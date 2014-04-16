using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public enum InputParameterType
    {
        None,
        SingleValue,
        ValueList,
        Range
    }

    public class InputParameter
    {
        public int ID;

        public string name;
        public string description;
        public string remarks;

        public InputParameterType type;
        public List<string> values;

        public bool isSet;

        public WordDocumentReference reference;

        public InputParameter()
        {
            ID = -1;

            type = InputParameterType.None;
            values = new List<string>();

            isSet = false;
        }

        public InputParameter(InputParameter original)
        {
            ID = original.ID;

            name = String.Copy(original.name);
            description = String.Copy(original.description);
            remarks = String.Copy(original.remarks);

            type = original.type;

            values = new List<string>(original.values.Count);
            foreach(string value in original.values)
            {
                values.Add(String.Copy(value));
            }

            isSet = original.isSet;

            reference = original.reference;
        }

        public InputParameter deepCopy()
        {
            return new InputParameter(this);
        }

        public bool isValueSet()
        {
            return isSet;
        }

        public void setSingleValue(string value)
        {
            type = InputParameterType.SingleValue;
            values.Clear();

            values.Add(String.Copy(value));

            isSet = true;
        }

        public void setValueList(List<string> values)
        {
            type = InputParameterType.ValueList;

            this.values = new List<string>(values.Count);
            foreach(string value in values)
            {
                this.values.Add(String.Copy(value));
            }

            isSet = true;
        }

        public void setValueList(string[] values)
        {
            type = InputParameterType.ValueList;

            this.values = new List<string>(values.Length);
            foreach(string value in values)
            {
                this.values.Add(String.Copy(value));
            }

            isSet = true;
        }

        public void initValueList(int count = -1)
        {
            if(count > 0)
                values = new List<string>(count);
            else
                values = new List<string>();
        }

        public void addElementToValueList(string value)
        {
            if(type == InputParameterType.None || type == InputParameterType.ValueList)
            {
                type = InputParameterType.ValueList;

                values.Add(String.Copy(value));

                isSet = true;
            }
            else
            {
                throw new Exception("tried to add a value to a wrong type instead of ValueList type!");
            }
        }

        public void clearValueList()
        {
            if(type == InputParameterType.ValueList)
            {
                values.Clear();

                isSet = false;
            }
            else
            {
                throw new Exception("tried to clear a value from a wrong type instead of ValueList type!");
            }
        }

        public void setValueRange(string min, string max, string step)
        {
            type = InputParameterType.Range;

            values = new List<string>(3);

            values.Add(String.Copy(min));
            values.Add(String.Copy(max));
            values.Add(String.Copy(step));

            if(min.Length > 0 && max.Length > 0 && step.Length > 0)
                isSet = true;
            else
                isSet = false;
        }

        public void disableValue(bool isSet = false)
        {
            type = InputParameterType.None;
            values.Clear();

            this.isSet = isSet;
        }

        public string getSingleValue()
        {
            if(type == InputParameterType.SingleValue && values.Count == 1)
            {
                return values[0];
            }
            else
            {
                throw new Exception("tried to read a SingleValue type, but type is different or value count does not match!");
            }
        }

        public List<string> getValueList()
        {
            if(type == InputParameterType.ValueList)
            {
                return values;
            }
            else
            {
                throw new Exception("tried to read a ValueList type, but type is different!");
            }
        }

        public string getValueRangeMin()
        {
            if(type == InputParameterType.Range && values.Count == 3)
            {
                return values[0];
            }
            else
            {
                throw new Exception("tried to read a Range type, but type is different or value count does not match!");
            }
        }

        public string getValueRangeMax()
        {
            if(type == InputParameterType.Range && values.Count == 3)
            {
                return values[1];
            }
            else
            {
                throw new Exception("tried to read a Range type, but type is different or value count does not match!");
            }
        }

        public string getValueRangeStep()
        {
            if(type == InputParameterType.Range && values.Count == 3)
            {
                return values[2];
            }
            else
            {
                throw new Exception("tried to read a Range type, but type is different or value count does not match!");
            }
        }

        public string getPrettyPrintSingleValue()
        {
            if(type != InputParameterType.SingleValue || values.Count != 1)
                throw new Exception("tried to print a SingleValue type, but type is different or value count does not match!");

            return values[0];
        }

        public string getPrettyPrintValueList()
        {
            string pretty = "{ ";
            bool first = true;

            if(type != InputParameterType.ValueList)
                throw new Exception("tried to print a ValueList type, but type is different!");

            foreach(string value in values)
            {
                if(first)
                {
                    pretty += value;
                    first = false;
                }
                else
                {
                    pretty += " , " + value;
                }
            }

            pretty += " }";

            return pretty;
        }

        public string getPrettyPrintValueRange()
        {
            if(type != InputParameterType.Range || values.Count != 3)
                throw new Exception("tried to print a Range type, but type is different or value count does not match!");

            return values[0] + " - " + values[1] + " (step size: " + values[2] + ")";
        }

        public string getInputParamValue()
        {
            if(isSet)
            {
                switch(type)
                {
                    case InputParameterType.None:
                        return "n.a.";

                    case InputParameterType.SingleValue:
                        return getPrettyPrintSingleValue();

                    case InputParameterType.ValueList:
                        return getPrettyPrintValueList();

                    case InputParameterType.Range:
                        return getPrettyPrintValueRange();

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
