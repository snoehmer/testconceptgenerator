using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public enum QualificationParameterType
    {
        None,
        Min,
        Max,
        MinMax,
        ValueDev
    }

    public class QualificationParameter
    {
        public int ID;

        public string name;
        public string description;
        public string remarks;

        public QualificationParameterType type;

        public List<string> values;

        public bool isSet;

        public WordDocumentReference reference;

        public QualificationParameter()
        {
            ID = -1;

            name = "";
            description = "";
            remarks = "";

            values = new List<string>();

            isSet = false;

            type = QualificationParameterType.None;

            reference = null;
        }

        public QualificationParameter(QualificationParameter original)
        {
            ID = original.ID;

            name = String.Copy(original.name);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            type = original.type;
            isSet = original.isSet;

            reference = original.reference;

            values = new List<string>(original.values.Count);
            foreach(string value in original.values)
            {
                values.Add(String.Copy(value));
            }
        }

        public QualificationParameter deepCopy()
        {
            return new QualificationParameter(this);
        }

        public void disableValue(bool isSet = false)
        {
            type = QualificationParameterType.None;

            values.Clear();

            this.isSet = isSet;
        }

        public void setMinValue(string min)
        {
            type = QualificationParameterType.Min;

            values.Clear();

            values.Add(String.Copy(min));

            isSet = true;
        }

        public void setMaxValue(string max)
        {
            type = QualificationParameterType.Max;

            values.Clear();

            values.Add(String.Copy(max));

            isSet = true;
        }

        public void setMinMaxValue(string min, string max)
        {
            type = QualificationParameterType.MinMax;

            values.Clear();

            values.Add(String.Copy(min));
            values.Add(String.Copy(max));

            isSet = true;
        }

        public void setValueDevValue(string value, string deviation)
        {
            type = QualificationParameterType.ValueDev;

            values.Clear();

            values.Add(String.Copy(value));
            values.Add(String.Copy(deviation));

            isSet = true;
        }

        public string getMinValue()
        {
            if(type == QualificationParameterType.Min || type == QualificationParameterType.MinMax)
            {
                return values[0];
            }
            else
            {
                throw new Exception("tried to read minimum from a Min or MinMax type, but type is different!");
            }
        }

        public string getMaxValue()
        {
            if(type == QualificationParameterType.Max)
            {
                return values[0];
            }
            else if(type == QualificationParameterType.MinMax)
            {
                return values[1];
            }
            else
            {
                throw new Exception("tried to read maximum from a Max or MinMax type, but type is different!");
            }
        }

        public string getMeanValue()
        {
            if(type == QualificationParameterType.ValueDev)
            {
                return values[0];
            }
            else
            {
                throw new Exception("tried to read mean from a ValueDev type, but type is different!");
            }
        }

        public string getDeviationValue()
        {
            if(type == QualificationParameterType.ValueDev)
            {
                return values[1];
            }
            else
            {
                throw new Exception("tried to read deviation from a ValueDev type, but type is different!");
            }
        }

        public string getPrettyPrintMinType()
        {
            if(type != QualificationParameterType.Min || values.Count != 1)
                throw new Exception("tried to print a Min type, but type is different or value count does not match!");

            return ">= " + values[0];
        }

        public string getPrettyPrintMaxType()
        {
            if(type != QualificationParameterType.Max || values.Count != 1)
                throw new Exception("tried to print a Max type, but type is different or value count does not match!");

            return "<= " + values[0];
        }

        public string getPrettyPrintMinMaxType()
        {
            if(type != QualificationParameterType.MinMax || values.Count != 2)
                throw new Exception("tried to print a MinMax type, but type is different or value count does not match!");

            return values[0] + " <= X <= " + values[1];
        }

        public string getPrettyPrintValueDevType()
        {
            if(type != QualificationParameterType.ValueDev || values.Count != 2)
                throw new Exception("tried to print a ValueDev type, but type is different or value count does not match!");

            return values[0] + " +/- " + values[1] + "%";
        }

        public string getQualificationParamValue()
        {
            if(isSet)
            {
                switch(type)
                {
                    case QualificationParameterType.None:
                        return "n.a.";

                    case QualificationParameterType.Min:
                        return getPrettyPrintMinType();

                    case QualificationParameterType.Max:
                        return getPrettyPrintMaxType();

                    case QualificationParameterType.MinMax:
                        return getPrettyPrintMinMaxType();

                    case QualificationParameterType.ValueDev:
                        return getPrettyPrintValueDevType();

                    default:
                        return "[unknown type]";
                }
            }
            else
            {
                return "[ value not set ]";
            }
        }
    }
}
