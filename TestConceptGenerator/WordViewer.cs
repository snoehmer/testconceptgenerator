using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace TestConceptGenerator
{
    /**
     *  WordViewer can launch Word and show specific positions in Word files
     *  WordViewer is a singleton (so Word must be launched only once)
     */

    class WordViewer
    {
        private static WordViewer instance = null;

        private Word.Application wdApp;

        public WordViewer()
        {
            wdApp = new Word.Application();
        }


        public static WordViewer getInstance()
        {
            if(instance == null)
                instance = new WordViewer();

            return instance;
        }

        public void showReference(WordDocumentReference reference)
        {
            if(reference == null)
                return;

            if(reference.type != WordDocumentReferenceType.WordInterop)
                throw new Exception("WordViewer: got wrong WordDocumentReference type! (not WordInterop)");

            WordDocumentReference_WordInterop reference_interop = (WordDocumentReference_WordInterop) reference;

            Word.Document doc;

            object wFilename = reference_interop.path;

            doc = wdApp.Documents.Open(FileName: ref wFilename, ReadOnly: true);

            if(doc == null)
                throw new Exception("WordViewer: cannot open Word File '" + reference_interop.path + "'");

            Word.Paragraph refParagraph = reference_interop.paragraph;

            refParagraph.Range.Select();
        }
    }
}
