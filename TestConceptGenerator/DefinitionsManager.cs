using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public enum PriorityDefinition
    {
        VeryHigh,
        High,
        Normal,
        Low,
        VeryLow,
        Undefined
    }

    public class DefinitionsManager
    {
        private static DefinitionsManager instance_;

        public static DefinitionsManager getInstance()
        {
            if(instance_ == null)
                instance_ = new DefinitionsManager();

            return instance_;
        }

        public DefinitionsManager()
        {
        }

        public static PriorityDefinition getPriority(int priority)
        {
            switch(priority)
            {
                case 2:
                    return PriorityDefinition.VeryHigh;

                case 1:
                    return PriorityDefinition.High;

                case 0:
                    return PriorityDefinition.Normal;

                case -1:
                    return PriorityDefinition.Low;

                case -2:
                    return PriorityDefinition.VeryLow;

                default:
                    return PriorityDefinition.Undefined;
            }
        }

        public static PriorityDefinition getPriority(string priority)
        {
            switch(priority)
            {
                case "very high":
                    return PriorityDefinition.VeryHigh;

                case "high":
                    return PriorityDefinition.High;

                case "normal":
                    return PriorityDefinition.Normal;

                case "low":
                    return PriorityDefinition.Low;

                case "very low":
                    return PriorityDefinition.VeryLow;

                default:
                    return PriorityDefinition.Undefined;
            }
        }

        public static int getPriorityAsInt(PriorityDefinition priority)
        {
            switch(priority)
            {
                case PriorityDefinition.VeryHigh:
                    return 2;

                case PriorityDefinition.High:
                    return 1;

                case PriorityDefinition.Normal:
                    return 0;

                case PriorityDefinition.Low:
                    return -1;

                case PriorityDefinition.VeryLow:
                    return -2;

                default:
                    return -5;
            }
        }

        public static string getPriorityAsString(PriorityDefinition priority)
        {
            switch(priority)
            {
                case PriorityDefinition.VeryHigh:
                    return "very high";

                case PriorityDefinition.High:
                    return "high";

                case PriorityDefinition.Normal:
                    return "normal";

                case PriorityDefinition.Low:
                    return "low";

                case PriorityDefinition.VeryLow:
                    return "very low";

                default:
                    return "undefined";
            }
        }

        public static string getPriorityAsExcelString(PriorityDefinition priority)
        {
            switch(priority)
            {
                case PriorityDefinition.VeryHigh:
                    return "++";

                case PriorityDefinition.High:
                    return "+";

                case PriorityDefinition.Normal:
                    return "o";

                case PriorityDefinition.Low:
                    return "-";

                case PriorityDefinition.VeryLow:
                    return "--";

                default:
                    return "?";
            }
        }
    }
}
