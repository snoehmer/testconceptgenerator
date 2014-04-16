using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace TestConceptGenerator
{
    public class TPCatalogReader_WordInterop : TPCatalogReader
    {
        protected override void parseWordDocument(object parameters)
        {
            Word.Application word = new Word.Application();

            object wFilename = ((object[]) parameters)[0];
            ICallbackForm callbackForm = (ICallbackForm) ((object[])parameters)[1];

			Word.Document doc;

            doc = word.Documents.Open(FileName: ref wFilename, ReadOnly: true);

			if(doc == null)
				throw new Exception("can not open word document: " + path);

			tpCatalog = parseTestprocedureDocument(word, doc, path, callbackForm);

            word.Quit(SaveChanges: Word.WdSaveOptions.wdDoNotSaveChanges);

            callbackForm.reportFinished();
        }
	

        private static TestProcedureCatalog parseTestprocedureDocument(Word.Application word, Word.Document doc, string path, ICallbackForm callbackForm)
        {
            TestProcedureCatalog parsedCatalog = new TestProcedureCatalog(path);
            parsedCatalog.categories = new List<TestProcedureCategory>();
            
            string fileName = Path.GetFileNameWithoutExtension(path);
            string[] fileNameParts = fileName.Split(new string[] {"_V"}, 2, StringSplitOptions.None);

            if(fileNameParts.Length == 1)
            {
                parsedCatalog.name = fileNameParts[0];
                parsedCatalog.version = "unknown";
            }
            else
            {
                parsedCatalog.name = fileNameParts[0];
                parsedCatalog.version = fileNameParts[1];
            }

            parsedCatalog.remarks = "";


			if(doc == null)
				throw new Exception("no Word document opened for parsing!");

			// find 1st category and ignore everything before, read testprocedures
			int nListParagraphs = doc.ListParagraphs.Count;

			callbackForm.reportProgress(0, 0, nListParagraphs);
			
			for(int iListParagraphs = 1; iListParagraphs <= nListParagraphs; iListParagraphs++)
			{
				Word.Paragraph listParagraph = doc.ListParagraphs[iListParagraphs];

				Word.WdListType paragraphType = listParagraph.Range.ListFormat.ListType;
				int paragraphLevel = listParagraph.Range.ListFormat.ListLevelNumber;

				if(paragraphType == Word.WdListType.wdListOutlineNumbering)  // list item with numbering
				{
					if(paragraphLevel == 1)  // level 1 means category
					{
						TestProcedureCategory newCategory = new TestProcedureCategory();
						newCategory.index = listParagraph.Range.ListFormat.ListValue;
						newCategory.name = listParagraph.Range.Text.Trim();
						newCategory.number = listParagraph.Range.ListFormat.ListString;
                        newCategory.description = "";
                        newCategory.remarks = "";
						newCategory.reference = new WordDocumentReference_WordInterop(listParagraph, path);
                        newCategory.wordDocumentPath = String.Copy(path);

						parsedCatalog.categories.Add(newCategory);
					}

					else if(paragraphLevel == 2)  // level 2 means test procedure
					{
						if(parsedCatalog.categories.Count > 0)  // already in a category (ignore dummy procedures otherwise)
						{
							TestProcedureDescription newTP = new TestProcedureDescription();
							newTP.procedureIndex = listParagraph.Range.ListFormat.ListValue;
							newTP.name = listParagraph.Range.Text.Trim();
							newTP.number = listParagraph.Range.ListFormat.ListString;
							newTP.reference = new WordDocumentReference_WordInterop(listParagraph, path);
                            newTP.wordDocumentPath = String.Copy(path);
                            newTP.categoryIndex = parsedCatalog.categories.Last<TestProcedureCategory>().index;
                            newTP.description = "";
                            newTP.remarks = "";
                            newTP.parentCategory = parsedCatalog.categories.Last<TestProcedureCategory>();
							
							parsedCatalog.categories.Last<TestProcedureCategory>().procedures.Add(newTP);
						}
					}

					else  // deeper level of item list, ignore
					{
					}
				}

				else if(paragraphType == Word.WdListType.wdListBullet)  // list item with bullets
				{
					if(parsedCatalog.categories.Count > 0 && parsedCatalog.categories.Last<TestProcedureCategory>().procedures.Count > 0)  // ignore sections that are not part of a test procedure
					{
						if(paragraphLevel == 1 && listParagraph.Range.Font.Size >= 12.0f)  // this is a description section (e.g., Input Parameters)
						{
                            TestProcedureDescription tp = (TestProcedureDescription)parsedCatalog.categories.Last<TestProcedureCategory>().procedures.Last<TestProcedure>();

                            if(listParagraph.Range.Text.Trim().Equals("Test setup"))  // get the description for a test procedure
                            {
                                Word.Range setupRange;
                                int setupRangeEnd;

								if(iListParagraphs == nListParagraphs)  // special treatment for last numbered paragraph (should never happen, only for security)
									setupRangeEnd = doc.Range().End;
								else
									setupRangeEnd = doc.ListParagraphs[iListParagraphs + 1].Range.Start;

                                setupRange = doc.Range(listParagraph.Range.End, setupRangeEnd);

                                foreach(Word.Paragraph p in setupRange.Paragraphs)
                                {
                                    String setupString = p.Range.Text.Trim();

                                    if(setupString.Length == 0)  // discard empty lines
                                        continue;

                                    if(setupString.Contains(':'))
                                    {
                                        string header = setupString.Substring(0, setupString.IndexOf(':')).Trim();
                                        string description = setupString.Substring(setupString.IndexOf(':') + 1).Trim();

                                        if(header.Equals("Description"))  // found description section
                                        {
                                            tp.description = description;
                                        }

                                        if(header.Equals("Set up"))  // found setup section
                                        {
                                            tp.setup = description;
                                        }
                                    }
                                }
                            }
							if(listParagraph.Range.Text.Trim().Equals("Input parameter"))  // found the input parameters section
							{
								Word.Range parametersRange;
								int parameterRangeEnd;

								if(iListParagraphs == nListParagraphs)  // special treatment for last numbered paragraph (should never happen, only for security)
									parameterRangeEnd = doc.Range().End;
								else
									parameterRangeEnd = doc.ListParagraphs[iListParagraphs + 1].Range.Start;

								parametersRange = doc.Range(listParagraph.Range.End, parameterRangeEnd);

								foreach(Word.Paragraph p in parametersRange.Paragraphs)  // interpret all following paragraphs as input parameters
								{
									InputParameter newIP = new InputParameter();

									String parameterString = p.Range.Text.Trim();

									if(parameterString.Length == 0)  // discard empty lines
										continue;

                                    if(parameterString.Equals("None") || parameterString.Equals("none"))  // ignore 'none' parameter
                                        continue;

									if(parameterString.Contains(':'))  // split into parameter name and description
									{
										newIP.name = parameterString.Substring(0, parameterString.IndexOf(':')).Trim();
										newIP.description = parameterString.Substring(parameterString.IndexOf(':') + 1).Trim();
									}
									else
									{
										newIP.name = parameterString;
										newIP.description = "";
									}

                                    newIP.disableValue();
                                    newIP.remarks = "";
									newIP.reference = new WordDocumentReference_WordInterop(p, path);

									parsedCatalog.categories.Last<TestProcedureCategory>().procedures.Last<TestProcedure>().getInputParameters().Add(newIP);
								}
							}
                            if(listParagraph.Range.Text.Trim().Equals("Qualification parameter"))  // found the qualification parameters section
                            {
                                Word.Range parametersRange;
                                int parameterRangeEnd;

                                if(iListParagraphs == nListParagraphs)  // special treatment for last numbered paragraph (should never happen, only for security)
                                    parameterRangeEnd = doc.Range().End;
                                else
                                    parameterRangeEnd = doc.ListParagraphs[iListParagraphs + 1].Range.Start;

                                parametersRange = doc.Range(listParagraph.Range.End, parameterRangeEnd);

                                foreach(Word.Paragraph p in parametersRange.Paragraphs)  // interpret all following paragraphs as qualification parameters
                                {
                                    QualificationParameter newQP = new QualificationParameter();

                                    String parameterString = p.Range.Text.Trim();

                                    if(parameterString.Length == 0)  // discard empty lines
                                        continue;

                                    if(parameterString.Equals("None") || parameterString.Equals("none"))  // ignore 'none' parameter
                                        continue;

                                    if(parameterString.Contains(':'))  // split into parameter name and description
                                    {
                                        newQP.name = parameterString.Substring(0, parameterString.IndexOf(':')).Trim();
                                        newQP.description = parameterString.Substring(parameterString.IndexOf(':') + 1).Trim();
                                    }
                                    else
                                    {
                                        newQP.name = parameterString;
                                        newQP.description = "";
                                    }

                                    newQP.disableValue();
                                    newQP.remarks = "";
                                    newQP.reference = new WordDocumentReference_WordInterop(p, path);

                                    parsedCatalog.categories.Last<TestProcedureCategory>().procedures.Last<TestProcedure>().getQualificationParameters().Add(newQP);
                                }
                            }
						}
					}
				}

				callbackForm.reportProgress(iListParagraphs);
			}

			return parsedCatalog;
        }
    }
}
