using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    public interface ICallbackForm
    {
        void reportProgress(int value, int min = -1, int max = -1);
        void reportFinished();
        void reportFailed(string message);
    }
}
