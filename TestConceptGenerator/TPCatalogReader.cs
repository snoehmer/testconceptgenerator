using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TestConceptGenerator
{
    abstract public class TPCatalogReader
    {
        protected string path;
        protected ICallbackForm callbackForm;

        protected TestProcedureCatalog tpCatalog;

        public void startParserThread(string path, ICallbackForm callbackForm)
        {
            this.path = path;
            this.callbackForm = callbackForm;

            object[] parameters = new object[] { path, callbackForm };
            
            ParameterizedThreadStart threadStarter = new ParameterizedThreadStart(parseWordDocument);
            Thread workerThread = new Thread(threadStarter);

            workerThread.Start((object)parameters);
        }

        protected virtual void parseWordDocument(object parameters)
        {
            MessageBox.Show("Abstract Method parseWordDocument is not implemented!", "Method not implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public TestProcedureCatalog getCatalog()
        {
            return tpCatalog;
        }
    }
}
