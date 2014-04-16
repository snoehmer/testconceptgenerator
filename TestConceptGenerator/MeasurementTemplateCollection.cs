using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class MeasurementTemplateCollection
    {
        public string name;
        public string description;
        public string remarks;

        public List<MeasurementTemplate> templates;

        public MeasurementTemplateCollection()
        {
            name = "";
            description = "";
            remarks = "";

            templates = new List<MeasurementTemplate>();
        }

        public MeasurementTemplateCollection(MeasurementTemplateCollection original)
        {
            name = String.Copy(original.name);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            templates = new List<MeasurementTemplate>(original.templates.Count);
            foreach(MeasurementTemplate template in original.templates)
            {
                templates.Add(new MeasurementTemplate(template));
            }
        }

        public MeasurementTemplateCollection deepCopy()
        {
            return new MeasurementTemplateCollection(this);
        }

        public void clear()
        {
            templates.Clear();
        }
    }
}
