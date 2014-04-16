using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestConceptGenerator
{
    public class TestOverviewConfigurationManager : GenericConfigurationManager
    {
        // names for configuration file values
        public const string NrOfMainCategories = "NrOfMainCategories";

        public const string TestsStartRow = "TestsStartRow";

        public const string PRevisionCol = "PRevisionCol";
        public const string BOMVersionCol = "BOMVersionCol";
        public const string CategoryCol = "CategoryCol";
        public const string PriorityCol = "PriorityCol";
        public const string TPNrCol = "TPNrCol";
        public const string TPNameCol = "TPNameCol";
        public const string TestDoneCol = "TestDoneCol";
        public const string TestTesterCol = "TestTesterCol";
        public const string TestDateCol = "TestDateCol";
        public const string TestRefIDCol = "TestRefIDCol";
        public const string TestRemarksCol = "TestRemarksCol";
        public const string TestCompletedCol = "TestCompletedCol";
        public const string GeneralRemarksCol = "GeneralRemarksCol";
        public const string ProtocolFileCol = "ProtocolFileCol";
        public const string ProtocolBrowseFileCol = "ProtocolBrowseFileCol";
        public const string ProtocolBrowseDirCol = "ProtocolBrowseDirCol";
        public const string ProtocolLocationCol = "ProtocolLocationCol";
        public const string ProtocolLocationBrowseCol = "ProtocolLocationBrowseCol";
        public const string ReviewCompletedCol = "ReviewCompletedCol";
        public const string ReviewReviewerCol = "ReviewReviewerCol";
        public const string ReviewDateCol = "ReviewDateCol";
        public const string ReviewRemarksCol = "ReviewRemarksCol";
        public const string AdditionalRemarksCol = "AdditionalRemarksCol";

        public const string ExcelOverviewTemplateFilename = "ExcelOverviewTemplateFilename";


        // default values for configuration file values
        private const int NrOfMainCategories_ = 12;

        private const int TestsStartRow_ = 95;

        private const int PRevisionCol_ = 2;
        private const int BOMVersionCol_ = 3;
        private const int CategoryCol_ = 4;
        private const int PriorityCol_ = 5;
        private const int TPNrCol_ = 6;
        private const int TPNameCol_ = 7;
        private const int TestDoneCol_ = 10;
        private const int TestTesterCol_ = 11;
        private const int TestDateCol_ = 12;
        private const int TestRefIDCol_ = 13;
        private const int TestRemarksCol_ = 14;
        private const int TestCompletedCol_ = 15;
        private const int GeneralRemarksCol_ = 16;
        private const int ProtocolFileCol_ = 18;
        private const int ProtocolBrowseFileCol_ = 19;
        private const int ProtocolBrowseDirCol_ = 20;
        private const int ProtocolLocationCol_ = 21;
        private const int ProtocolLocationBrowseCol_ = 22;
        private const int ReviewCompletedCol_ = 23;
        private const int ReviewReviewerCol_ = 24;
        private const int ReviewDateCol_ = 25;
        private const int ReviewRemarksCol_ = 26;
        private const int AdditionalRemarksCol_ = 27;

        private const string ExcelOverviewTemplateFilename_ = @"testing_overview_v1.2_template.xltm";


        private static TestOverviewConfigurationManager instance_ = null;

        public static TestOverviewConfigurationManager getInstance()
        {
            if(instance_ == null)
            {
                ConfigurationManager confMan = ConfigurationManager.getInstance();

                string configPath = confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateSubDir) + confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateConfig);
                
                instance_ = new TestOverviewConfigurationManager(configPath);
            }

            return instance_;
        }

        public TestOverviewConfigurationManager(string configPath)
            : base(configPath)
        {
        }


        protected override void generateDefaultConfig()
        {
            configurationSet = new Dictionary<string, ConfigurationValue>();

            configurationSet.Add(NrOfMainCategories, new ConfigurationValue(NrOfMainCategories_, "number of main categories (tabs) in the Excel template"));
            
            configurationSet.Add(TestsStartRow, new ConfigurationValue(TestsStartRow_, "the first row used to enter tests in the Excel template"));

            configurationSet.Add(PRevisionCol, new ConfigurationValue(PRevisionCol_, "the column for the Product Revision field"));
            configurationSet.Add(BOMVersionCol, new ConfigurationValue(BOMVersionCol_, "the column for the BOM Version field"));
            configurationSet.Add(CategoryCol, new ConfigurationValue(CategoryCol_, "the column for the Test Category field"));
            configurationSet.Add(PriorityCol, new ConfigurationValue(PriorityCol_, "the column for the Priority field"));
            configurationSet.Add(TPNrCol, new ConfigurationValue(TPNrCol_, "the column for the Product TP Number field"));
            configurationSet.Add(TPNameCol, new ConfigurationValue(TPNameCol_, "the column for the TP Name field"));
            configurationSet.Add(TestDoneCol, new ConfigurationValue(TestDoneCol_, "the column for the Test Done field"));
            configurationSet.Add(TestTesterCol, new ConfigurationValue(TestTesterCol_, "the column for the Tester field"));
            configurationSet.Add(TestDateCol, new ConfigurationValue(TestDateCol_, "the column for the Test Date field"));
            configurationSet.Add(TestRefIDCol, new ConfigurationValue(TestRefIDCol_, "the column for the Test Reference ID field"));
            configurationSet.Add(TestRemarksCol, new ConfigurationValue(TestRemarksCol_, "the column for the Test Remarks field"));
            configurationSet.Add(TestCompletedCol, new ConfigurationValue(TestCompletedCol_, "the column for the Test Completed field"));
            configurationSet.Add(GeneralRemarksCol, new ConfigurationValue(GeneralRemarksCol_, "the column for the General Remarks field"));
            configurationSet.Add(ProtocolFileCol, new ConfigurationValue(ProtocolFileCol_, "the column for the Protocol File/Directory field"));
            configurationSet.Add(ProtocolBrowseFileCol, new ConfigurationValue(ProtocolBrowseFileCol_, "the column for the Protocol File Browse Button field"));
            configurationSet.Add(ProtocolBrowseDirCol, new ConfigurationValue(ProtocolBrowseDirCol_, "the column for the Protocol Directory Browse Button field"));
            configurationSet.Add(ProtocolLocationCol, new ConfigurationValue(ProtocolLocationCol_, "the column for the Protocol Location field"));
            configurationSet.Add(ProtocolLocationBrowseCol, new ConfigurationValue(ProtocolLocationBrowseCol_, "the column for the Protocol Location Browse Button field"));
            configurationSet.Add(ReviewCompletedCol, new ConfigurationValue(ReviewCompletedCol_, "the column for the Review Completed field"));
            configurationSet.Add(ReviewReviewerCol, new ConfigurationValue(ReviewReviewerCol_, "the column for the Reviewer field"));
            configurationSet.Add(ReviewDateCol, new ConfigurationValue(ReviewDateCol_, "the column for the Review Date field"));
            configurationSet.Add(ReviewRemarksCol, new ConfigurationValue(ReviewRemarksCol_, "the column for the Review Remarks field"));
            configurationSet.Add(AdditionalRemarksCol, new ConfigurationValue(AdditionalRemarksCol_, "the column for the Additional Remarks field"));

            configurationSet.Add(ExcelOverviewTemplateFilename, new ConfigurationValue(ExcelOverviewTemplateFilename_, "file name of the corresponding Excel template"));

        }
    }



    public class TestOverviewExporter_Excel : TestOverviewExporter
    {
        private string templatePath;

        private ConfigurationManager confMan;
        private TestOverviewConfigurationManager toConfMan;
        private TestprocedureCategoryManager tpCatMan;

        public TestOverviewExporter_Excel(TestConcept tc) : base(tc)
        {
            confMan = ConfigurationManager.getInstance();
            toConfMan = TestOverviewConfigurationManager.getInstance();
            tpCatMan = TestprocedureCategoryManager.getInstance();

            string tmpPath = ConfigurationManager.getProgramDir() + confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateSubDir) + confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateFilename);


            templatePath = String.Copy(tmpPath);
        }

        public void setTemplate(string templatePath)
        {
            this.templatePath = String.Copy(templatePath);
        }

        public override void exportTestOverview(string path, bool showExcel = false)
        {
            if(tc.testsets.Count <= 0 && tc.testsets[0].procedures.Count <= 0)
            {
                return;
            }

            exportOverviewToNewFile(path, showExcel); 
        }

        public void appendTestOverview(string inputPath, string outputPath, bool showExcel = false)
        {
            if(tc.testsets.Count <= 0 && tc.testsets[0].procedures.Count <= 0)
            {
                return;
            }

            exportOverviewAppendToFile(inputPath, outputPath, showExcel);
        }

        private void exportOverviewToNewFile(string path, bool showExcel = false)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlBook;
            Excel.Worksheet xlSheet;

            //string filename = path + fileSubdirectory + @"\" + fileNamePrefix + DateTime.Now.ToString("yyyy-mm-dd_hh:mm") + ".xlsm";
            //string filename = @"C:\tmp\ExcelOutput\TestOverview.xlsm";

            string filename = path;

            if(xlApp == null)
            {
                throw new Exception("TestOverviewExporter_Excel: exportOverviewToNewFile: could not initialize Excel!");
            }

            object xlTemplate = (object)templatePath;
            xlBook = xlApp.Workbooks.Add(Template: xlTemplate);

            //xlBook = xlApp.ActiveWorkbook;

            if(xlBook == null)
            {
                throw new Exception("TestOverviewExporter_Excel: exportOverviewToNewFile: could not open Template!");
            }

            int nrOfMainCategories = toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.NrOfMainCategories);

            int testsStartRow = toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestsStartRow);

            List<int> currentRows = new List<int>(nrOfMainCategories);
            for(int i = 0; i < nrOfMainCategories; i++)
            {
                currentRows.Add(testsStartRow);
            }

            TestProcedureSet testset = tc.testsets[0];
            //TestProcedureCategory category;
            TestConceptProcedure tp;

            for(int i = 0; i < testset.procedures.Count; i++)
            {
                if(testset.procedures[i].type != TestProcedureType.TestConceptProcedure)
                {
                    throw new Exception("TestOverviewExporter_Excel: exportOverviewToNewFile: tried to export test procedure with incorrect type!");
                }

                tp = (TestConceptProcedure)testset.procedures[i];

                string mainCategoryName = "Electrical";  // TODO
                xlSheet = xlBook.Worksheets[mainCategoryName];

                int categoryIndex = tpCatMan.getIndexOfMainCategoryByName(mainCategoryName);

                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.PRevisionCol)] = tc.productRevision;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.BOMVersionCol)] = tc.productBOMVersion;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.CategoryCol)] = tp.testProcedureDescription.parentCategory.name;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.PriorityCol)] = DefinitionsManager.getPriorityAsExcelString(DefinitionsManager.getPriority(tp.priority));
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNrCol)] = tp.getNumber();
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNameCol)] = tp.getName();
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestTesterCol)] = tp.responsible;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestDateCol)] = tp.dueDate.ToString("yyyy-MM-dd");
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestRemarksCol)] = tp.customRemarks;

                currentRows[categoryIndex]++;

            }

            xlBook.SaveAs(Filename: filename, FileFormat: Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled);

            if(showExcel)
                xlApp.Visible = true;
            else
                xlApp.Quit();
        }

        private void exportOverviewAppendToFile(string inputPath, string outputPath, bool showExcel = false)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlBook;
            Excel.Worksheet xlSheet;

            //string filename = path + fileSubdirectory + @"\" + fileNamePrefix + DateTime.Now.ToString("yyyy-mm-dd_hh:mm") + ".xlsm";
            //string filename = @"C:\tmp\ExcelOutput\TestOverview.xlsm";

            string filename = inputPath;

            if(xlApp == null)
            {
                throw new Exception("TestOverviewExporter_Excel: exportOverviewAppendToFile: could not initialize Excel!");
            }

            //object xlFilename = (object)path;
            xlBook = xlApp.Workbooks.Open(inputPath, UpdateLinks: (object)0);

            //xlBook = xlApp.ActiveWorkbook;

            if(xlBook == null)
            {
                throw new Exception("TestOverviewExporter_Excel: exportOverviewAppendToFile: could not open file!");
            }

            int nrOfMainCategories = tpCatMan.getNrOfMainCategories();

            if(nrOfMainCategories != toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.NrOfMainCategories))
            {
                throw new Exception("TestOverviewExporter_Excel: exportOverviewAppendToFile: number of main categories (" + nrOfMainCategories + ") does not match number of tabs in the Excel Sheet!");
            }

            int testsStartRow = toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestsStartRow);

            List<int> currentRows = new List<int>(tpCatMan.mainCategories.Count);
            for(int i = 0; i < tpCatMan.mainCategories.Count; i++)
            {
                int firstEmptyRow = testsStartRow;

                xlSheet = xlBook.Worksheets[tpCatMan.mainCategories[i].name];

                while(true)
                {
                    int cellValueLength = 0;

                    Excel.Range range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.PRevisionCol)];
                    string cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.CategoryCol)];
                    cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNrCol)];
                    cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNameCol)];
                    cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestDoneCol)];
                    cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    range = xlSheet.Cells[firstEmptyRow, toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.GeneralRemarksCol)];
                    cellValue = range.get_Value();
                    if(cellValue != null)
                        cellValueLength += cellValue.Length;

                    if(cellValueLength > 0)
                        firstEmptyRow++;
                    else
                        break;
                }

                currentRows.Add(firstEmptyRow);
            }

            xlSheet = null;

            TestProcedureSet testset = tc.testsets[0];
            //TestProcedureCategory category;
            TestConceptProcedure tp;

            for(int i = 0; i < testset.procedures.Count; i++)
            {
                if(testset.procedures[i].type != TestProcedureType.TestConceptProcedure)
                {
                    throw new Exception("TestOverviewExporter_Excel: exportOverviewAppendToFile: tried to export test procedure with incorrect type!");
                }

                tp = (TestConceptProcedure)testset.procedures[i];

                string mainCategoryName = "Electrical";  // TODO
                xlSheet = xlBook.Worksheets[mainCategoryName];

                int categoryIndex = tpCatMan.getIndexOfMainCategoryByName(mainCategoryName);

                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.PRevisionCol)] = tc.productRevision;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.BOMVersionCol)] = tc.productBOMVersion;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.CategoryCol)] = tp.testProcedureDescription.parentCategory.name;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.PriorityCol)] = DefinitionsManager.getPriorityAsExcelString(DefinitionsManager.getPriority(tp.priority));
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNrCol)] = tp.getNumber();
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TPNameCol)] = tp.getName();
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestTesterCol)] = tp.responsible;
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestDateCol)] = tp.dueDate.ToString("yyyy-MM-dd");
                xlSheet.Cells[currentRows[categoryIndex], toConfMan.getNumericConfigurationValue(TestOverviewConfigurationManager.TestRemarksCol)] = tp.customRemarks;

                currentRows[categoryIndex]++;

            }

            if(inputPath.Equals(outputPath))
            {
                xlBook.Save();
            }
            else
            {
                xlBook.SaveAs(Filename: outputPath, FileFormat: Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled);
            }


            if(showExcel)
                xlApp.Visible = true;
            else
                xlApp.Quit();
        }
    }
}
