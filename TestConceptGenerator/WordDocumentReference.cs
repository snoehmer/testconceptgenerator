using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace TestConceptGenerator
{
    public enum WordDocumentReferenceType
    {
        WordInterop
    }

    public class WordDocumentReference
    {
        public WordDocumentReferenceType type;
    }

    public class WordDocumentReference_WordInterop : WordDocumentReference
    {
        public Word.Paragraph paragraph;
        public string path;

        public WordDocumentReference_WordInterop()
        {
            type = WordDocumentReferenceType.WordInterop;
        }

        public WordDocumentReference_WordInterop(Word.Paragraph paragraph, string path)
        {
            type = WordDocumentReferenceType.WordInterop;
            this.paragraph = paragraph;
            this.path = path;
        }
    }
}
