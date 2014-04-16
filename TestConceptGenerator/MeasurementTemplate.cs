using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class MeasurementTemplate
    {
        public string name;
        public string description;
        public string version;

        public string path;

        public Dictionary<string, string> keyCells;

        public MeasurementTemplate()
        {
            name = "";
            description = "";
            version = "";
            path = "";

            keyCells = new Dictionary<string, string>();
        }

        public MeasurementTemplate(MeasurementTemplate original)
        {
            name = String.Copy(original.name);
            description = String.Copy(original.description);
            version = String.Copy(original.version);
            path = String.Copy(original.path);

            keyCells = new Dictionary<string, string>(original.keyCells.Count);
            foreach(KeyValuePair<string, string> pair in original.keyCells)
            {
                keyCells.Add(String.Copy(pair.Key), String.Copy(pair.Value));
            }
        }

        public MeasurementTemplate deepCopy()
        {
            return new MeasurementTemplate(this);
        }
    }
}
