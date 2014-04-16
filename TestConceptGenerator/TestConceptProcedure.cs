using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class TestConceptProcedure : TestProcedure
    {
        public TestProcedureDescription testProcedureDescription;
        public int testProcedureID;

        public string customDescription;
        public int nrDUTs;
        public int customDuration;

        public string customRemarks;

        public bool firmwareNeeded;
        public string firmwareName;
        public string firmwarePath;
        public Attachment firmwareFile;

        public string testpoints;

        public string responsible;
        public DateTime dueDate;

        public int priority;

        public int orderIndex;

        public List<InputParameter> inputParameters;
        public List<QualificationParameter> qualificationParameters;


        public TestConceptProcedure()
        {
            ID = -1;
            type = TestProcedureType.TestConceptProcedure;

            customDescription = "";
            customRemarks = "";

            testProcedureDescription = null;
            testProcedureID = -1;

            customDuration = 0;
            nrDUTs = 0;

            firmwareNeeded = false;
            firmwareName = "";
            firmwarePath = "";
            firmwareFile = null;

            testpoints = "";

            responsible = "";
            dueDate = DateTime.Today;

            priority = 0;

            orderIndex = -1;

            inputParameters = new List<InputParameter>();
            qualificationParameters = new List<QualificationParameter>();
        }

        public TestConceptProcedure(TestProcedureDescription tp) : this()
        {
            testProcedureDescription = tp;
            testProcedureID = tp.ID;

            nrDUTs = tp.defaultNrDUTs;
            customDuration = tp.defaultDuration;

            inputParameters = new List<InputParameter>(tp.inputParameters.Count);
            foreach(InputParameter ip in tp.inputParameters)
            {
                inputParameters.Add(new InputParameter(ip));
            }

            qualificationParameters = new List<QualificationParameter>(tp.qualificationParameters.Count);
            foreach(QualificationParameter qp in tp.qualificationParameters)
            {
                qualificationParameters.Add(new QualificationParameter(qp));
            }
        }

        public TestConceptProcedure(TestConceptProcedure original)
        {
            ID = original.ID;  // TODO: change
            type = original.type;

            customDescription = String.Copy(original.customDescription);
            customRemarks = String.Copy(original.customRemarks);

            testProcedureDescription = original.testProcedureDescription;

            customDuration = original.customDuration;
            nrDUTs = original.nrDUTs;

            firmwareName = String.Copy(original.firmwareName);
            firmwarePath = String.Copy(original.firmwarePath);

            if(original.firmwareFile == null)
            {
                firmwareFile = null;
            }
            else
            {
                firmwareFile = original.firmwareFile.deepCopy();
            }

            testpoints = String.Copy(original.testpoints);

            responsible = String.Copy(original.responsible);
            dueDate = original.dueDate;

            priority = original.priority;

            orderIndex = original.orderIndex;

            inputParameters = new List<InputParameter>(original.inputParameters.Count);
            foreach(InputParameter ip in original.inputParameters)
            {
                inputParameters.Add(new InputParameter(ip));
            }

            qualificationParameters = new List<QualificationParameter>(original.qualificationParameters.Count);
            foreach(QualificationParameter qp in original.qualificationParameters)
            {
                qualificationParameters.Add(new QualificationParameter(qp));
            }
        }

        public override TestProcedure deepCopy()
        {
            return new TestConceptProcedure(this);
        }

        public override void overwriteFrom(TestProcedure original_)
        {
            if(original_.type != TestProcedureType.TestConceptProcedure)
                throw new Exception("TestConceptProcedure::overwriteFrom: called with different type than TestConceptProcedure!");

            base.overwriteFrom(original_);

            TestConceptProcedure original = (TestConceptProcedure)original_;

            ID = original.ID;  // TODO: change
            type = original.type;

            customDescription = String.Copy(original.customDescription);
            customRemarks = String.Copy(original.customRemarks);

            testProcedureDescription = original.testProcedureDescription;

            customDuration = original.customDuration;
            nrDUTs = original.nrDUTs;

            firmwareName = String.Copy(original.firmwareName);
            firmwarePath = String.Copy(original.firmwarePath);

            if(original.firmwareFile == null)
            {
                firmwareFile = null;
            }
            else
            {
                firmwareFile = original.firmwareFile.deepCopy();
            }

            testpoints = String.Copy(original.testpoints);

            responsible = String.Copy(original.responsible);
            dueDate = original.dueDate;

            priority = original.priority;

            orderIndex = original.orderIndex;

            inputParameters = new List<InputParameter>(original.inputParameters.Count);
            foreach(InputParameter ip in original.inputParameters)
            {
                inputParameters.Add(new InputParameter(ip));
            }

            qualificationParameters = new List<QualificationParameter>(original.qualificationParameters.Count);
            foreach(QualificationParameter qp in original.qualificationParameters)
            {
                qualificationParameters.Add(new QualificationParameter(qp));
            }
        }

        public override string getName()
        {
            return testProcedureDescription.getName();
        }

        public override string getNumber()
        {
            return testProcedureDescription.getNumber();
        }

        public override string getDescription()
        {
            return testProcedureDescription.getDescription();
        }

        public override string getRemarks()
        {
            return testProcedureDescription.getRemarks();
        }

        public override List<InputParameter> getInputParameters()
        {
            return inputParameters;
        }

        public override List<QualificationParameter> getQualificationParameters()
        {
            return qualificationParameters;
        }
    }
}
