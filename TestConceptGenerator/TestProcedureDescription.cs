using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class TestProcedureDescription : TestProcedure
    {
        // test procedure description specific data
        public string name;
        public string number;
        public string description;
        public string setup;
        public string addInfo;
        public string remarks;
        public bool active;
        public int defaultDuration;
        public int defaultNrDUTs;

        // IDs for main category and category to find parent category
        public int mainCategoryID;
        public int categoryID;

        // used to number the procedure: TP<categoryIndex>.<procedureIndex>
        public int categoryIndex;
        public int procedureIndex;

        // index used for sorting
        public int orderIndex;

        // test procedure description versioning information
        public string author;
        public int versionNumber;
        public DateTime creationDate;
        public DateTime changeDate;

        // reference to the corresponding section in the Test Procedures Word document
        public WordDocumentReference reference;
        public string wordDocumentPath;

        // parameters definition (holds only descriptions, no values!)
        public List<InputParameter> inputParameters;
        public List<QualificationParameter> qualificationParameters;

        // templates for this test procedure for Excel measurement protocol generation
        public List<MeasurementTemplate> templates;

        //public TestProcedure catalogReference;

        // test category containing this test procedure
        public TestProcedureCategory parentCategory;


        // generates an empty test procedure description
        public TestProcedureDescription()
        {
            ID = -1;
            type = TestProcedureType.TestProcedureDescription;

            name = "";
            number = "";
            description = "";
            remarks = "";

            mainCategoryID = -1;
            categoryID = -1;

            categoryIndex = 0;
            procedureIndex = 0;

            orderIndex = -1;

            author = "";
            versionNumber = 0;
            creationDate = DateTime.Now;
            changeDate = DateTime.Now;

            reference = null;
            wordDocumentPath = "";

            inputParameters = new List<InputParameter>();
            qualificationParameters = new List<QualificationParameter>();

            templates = new List<MeasurementTemplate>();

            parentCategory = null;

            //catalogReference = null;
        }

        // copy constructor
        public TestProcedureDescription(TestProcedureDescription original)
        {
            ID = original.ID;  // TODO: change
            type = original.type;

            name = String.Copy(original.name);
            number = String.Copy(original.number);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            orderIndex = original.orderIndex;

            categoryIndex = original.categoryIndex;
            procedureIndex = original.procedureIndex;

            author = String.Copy(original.author);
            versionNumber = original.versionNumber;
            creationDate = original.creationDate;
            changeDate = original.changeDate;

            reference = original.reference;
            wordDocumentPath = String.Copy(original.wordDocumentPath);

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

            templates = new List<MeasurementTemplate>(original.templates.Count);
            foreach(MeasurementTemplate template in original.templates)
            {
                templates.Add(new MeasurementTemplate(template));
            }

            parentCategory = original.parentCategory;

            //catalogReference = original.catalogReference;
        }

        public override TestProcedure deepCopy()
        {
            return new TestProcedureDescription(this);
        }

        public override void overwriteFrom(TestProcedure original_)
        {
            if(original_.type != TestProcedureType.TestProcedureDescription)
                throw new Exception("TestProcedureDescription::overwriteFrom: called with different type than TestProcedureDescription!");

            base.overwriteFrom(original_);

            TestProcedureDescription original = (TestProcedureDescription)original_;

            ID = original.ID;  // TODO: change
            type = original.type;

            name = String.Copy(original.name);
            number = String.Copy(original.number);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            orderIndex = original.orderIndex;

            categoryIndex = original.categoryIndex;
            procedureIndex = original.procedureIndex;

            author = String.Copy(original.author);
            versionNumber = original.versionNumber;
            creationDate = original.creationDate;
            changeDate = original.changeDate;

            reference = original.reference;
            wordDocumentPath = String.Copy(original.wordDocumentPath);

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

            templates = new List<MeasurementTemplate>(original.templates.Count);
            foreach(MeasurementTemplate template in original.templates)
            {
                templates.Add(new MeasurementTemplate(template));
            }

            parentCategory = original.parentCategory;

            //catalogReference = original.catalogReference;
        }

        public override string getName()
        {
            return name;
        }

        public override string getNumber()
        {
            return number;
        }

        public override string getDescription()
        {
            return description;
        }

        public override string getRemarks()
        {
            return remarks;
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
