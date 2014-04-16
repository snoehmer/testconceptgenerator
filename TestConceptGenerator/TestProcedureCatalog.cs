using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{

    /**
     *  a TestProcedureCatalog is a collection of test procedures (TestProcedure)
     *  either from a Word document or from a database
     *  the contained test procedures are arranged in categories
     */

    public class TestProcedureCatalog
    {
        public int ID;

        public string name;
        public string version;
        public string remarks;

        public string path;
        
        public List<TestProcedureCategory> categories;

        public TestProcedureCatalog(string path)
        {
            ID = -1;

            this.path = path;

            categories = new List<TestProcedureCategory>();
        }

        public TestProcedureCatalog(TestProcedureCatalog original)
        {
            ID = original.ID;  // TODO: change

            name = String.Copy(original.name);
            version = String.Copy(original.version);
            remarks = String.Copy(original.remarks);

            path = String.Copy(original.path);

            categories = new List<TestProcedureCategory>(original.categories.Count);
            foreach(TestProcedureCategory category in original.categories)
            {
                categories.Add(new TestProcedureCategory(category));
            }
        }

        public TestProcedureCatalog deepCopy()
        {
            return new TestProcedureCatalog(this);
        }

        public string getPath()
        {
            return path;
        }

        public void addCategory(TestProcedureCategory category)
        {
            categories.Add(category);
        }

        public void clear()
        {
            categories.Clear();
        }
    }
}
