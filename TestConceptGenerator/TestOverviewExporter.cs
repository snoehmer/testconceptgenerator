using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConceptGenerator
{
    abstract public class TestOverviewExporter
    {
        protected TestConcept tc;

        public TestOverviewExporter(TestConcept tc)
        {
            this.tc = tc;
        }

        public abstract void exportTestOverview(string path, bool showResults = false);
    }
}
