using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public class Attachment
    {
        public int ID;

        public string name;
        public string description;

        public string path;
        public byte[] rawData;

        public int size;

        public Attachment()
        {
            ID = -1;

            name = "";
            description = "";

            path = "";
            rawData = null;

            size = 0;
        }

        public Attachment(Attachment original)
        {
            ID = original.ID;  // TODO: change

            name = String.Copy(original.name);
            description = String.Copy(original.description);

            path = String.Copy(original.path);
            original.rawData.CopyTo(rawData, 0);

            size = original.size;
        }

        public Attachment deepCopy()
        {
            return new Attachment(this);
        }
    }

}
