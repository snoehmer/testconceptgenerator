using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  a TestProcedureCategory is a category of test procedures found in a Test Procedure Catalog
 *  these can have subcategories and test procedures itself and hold references to the catalog
 */

namespace TestConceptGenerator
{
    public enum TestProcedureCategoryType
    {
        Procedures,
        SubCategories,
        ProceduresAndSubcategories
    }

    public class TestProcedureCategory
    {
        public int ID;

        public string name;
        public string number;
        public string description;
        public string remarks;

        public int index;
        
        public WordDocumentReference reference;
        public string wordDocumentPath;

        public TestProcedureCategoryType type;

        public List<TestProcedureCategory> subcategories;

        public List<TestProcedure> procedures;

        public TestProcedureCategory()
        {
            ID = -1;

            name = "";
            number = "";
            description = "";
            remarks = "";

            index = 0;

            reference = null;
            wordDocumentPath = "";

            type = TestProcedureCategoryType.Procedures;
            subcategories = new List<TestProcedureCategory>();
            procedures = new List<TestProcedure>();
        }

        public TestProcedureCategory(TestProcedureCategory original)
        {
            ID = original.ID;  // TODO: change

            name = String.Copy(original.name);
            number = String.Copy(original.number);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            index = original.index;

            reference = original.reference;
            wordDocumentPath = String.Copy(original.wordDocumentPath);

            type = original.type;

            subcategories = new List<TestProcedureCategory>(original.subcategories.Count);
            foreach(TestProcedureCategory category in original.subcategories)
            {
                subcategories.Add(new TestProcedureCategory(category));
            }

            procedures = new List<TestProcedure>(original.procedures.Count);
            foreach(TestProcedure procedure in original.procedures)
            {
                procedures.Add(new TestProcedure(procedure));
            }
        }

        public TestProcedureCategory deepCopy()
        {
            return new TestProcedureCategory(this);
        }

        public void clear()
        {
            subcategories.Clear();
            procedures.Clear();
        }
    }
}
