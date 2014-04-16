using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class TestConcept
    {
        public int ID;

        public string name;
        public string productName;
        public string productRevision;
        public string productBOMVersion;
        public string version;
        public int versionNumber;
        public string description;
        public string remarks;
        public string author;
        public DateTime creationDate;
        public DateTime changeDate;

        public List<TestProcedureSet> testsets;

        public TestConcept()
        {
            ID = -1;

            name = "";
            productName = "";
            productRevision = "";
            productBOMVersion = "";

            version = "";
            versionNumber = 0;
            description = "";
            remarks = "";

            creationDate = DateTime.Now;
            changeDate = DateTime.Now;

            testsets = new List<TestProcedureSet>();
        }

        public TestConcept(string name) : this()
        {
            this.name = name;
        }

        public TestConcept(TestConcept original)
        {
            ID = original.ID;  // TODO: change

            name = String.Copy(original.name);
            productName = String.Copy(original.productName);
            productRevision = String.Copy(original.productRevision);
            productBOMVersion = String.Copy(original.productBOMVersion);
                        
            version = String.Copy(original.version);
            versionNumber = original.versionNumber;
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            creationDate = original.creationDate;
            changeDate = original.changeDate;

            testsets = new List<TestProcedureSet>(original.testsets.Count);
            foreach(TestProcedureSet tps in original.testsets)
            {
                testsets.Add(new TestProcedureSet(tps));
            }
        }

        public TestConcept deepCopy()
        {
            return new TestConcept(this);
        }

        public void clear()
        {
            testsets.Clear();
        }
    }
}
