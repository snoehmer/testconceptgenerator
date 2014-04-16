using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public enum TestProcedureType
    {
        None,
        TestProcedureDescription,
        TestConceptProcedure
    }


    public class TestProcedure
    {
        public int ID;

        public TestProcedureType type;

        
        public TestProcedure()
        {
            ID = -1;

            type = TestProcedureType.None;
        }

        public TestProcedure(TestProcedure original)
        {
            ID = original.ID;  // TODO: change

            type = original.type;
        }

        public virtual TestProcedure deepCopy()
        {
            return new TestProcedure(this);
        }

        public virtual void overwriteFrom(TestProcedure original)
        {
            this.ID = original.ID;
            this.type = original.type;
        }

        public virtual string getName()
        {
            return "";
        }

        public virtual string getNumber()
        {
            return "";
        }

        public virtual string getDescription()
        {
            return "";
        }

        public virtual string getRemarks()
        {
            return "";
        }

        public virtual List<InputParameter> getInputParameters()
        {
            return null;
        }

        public virtual List<QualificationParameter> getQualificationParameters()
        {
            return null;
        }
    }
}
