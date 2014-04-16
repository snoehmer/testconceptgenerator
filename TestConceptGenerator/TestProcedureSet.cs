using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    /**
     *  a Test Procedure Set is a collection of test procedures which share
     *  common master parameters, and can have common remarks
     *  one Test Procedure Set can have multiple, nested subsets
     *  currently designed for future use ONLY!
     **/


    public enum TestProcedureSetType
    {
        Procedures,  // Set holds ONLY procedures
        SubSets,     // Set holds ONLY subsets
        ProceduresAndSubSets  // Set holds subsets AND procedures
    }

    public class TestProcedureSet
    {
        public int ID;

        public string name;
        public string description;
        public string remarks;

        public List<InputParameter> masterParameters;

        public TestProcedureSetType type;

        public List<TestProcedureSet> subsets;

        public List<TestProcedure> procedures;


        public TestProcedureSet()
        {
            ID = -1;

            name = "";
            description = "";
            remarks = "";

            type = TestProcedureSetType.Procedures;

            subsets = new List<TestProcedureSet>();
            procedures = new List<TestProcedure>();

            masterParameters = new List<InputParameter>();
        }

        public TestProcedureSet(TestProcedureSet original)
        {
            ID = original.ID;  // TODO: change

            name = String.Copy(original.name);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            masterParameters = new List<InputParameter>(original.masterParameters.Count);
            foreach(InputParameter ip in original.masterParameters)
            {
                masterParameters.Add(new InputParameter(ip));
            }

            type = original.type;

            subsets = new List<TestProcedureSet>(original.subsets.Count);
            foreach(TestProcedureSet tps in original.subsets)
            {
                subsets.Add(new TestProcedureSet(tps));
            }

            procedures = new List<TestProcedure>(original.procedures.Count);
            foreach(TestConceptProcedure tp in original.procedures)
            {
                procedures.Add(new TestConceptProcedure(tp));
            }
        }

        public TestProcedureSet deepCopy()
        {
            return new TestProcedureSet(this);
        }

        public void clear()
        {
            masterParameters.Clear();

            subsets.Clear();
            procedures.Clear();
        }
    }
}
