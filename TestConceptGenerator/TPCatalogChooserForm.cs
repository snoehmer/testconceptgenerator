using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TestConceptGenerator
{
    public partial class TPCatalogChooserForm : Form, ICallbackForm
    {
        private TPCatalogReader catalogReader;
        private TestProcedureCatalog tpCatalog;
        private MainForm mainForm;

        public TPCatalogChooserForm(MainForm parent)
        {
            InitializeComponent();

            mainForm = parent;

            catalogReader = new TPCatalogReader_WordInterop();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if(openTPCatalogDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxTPPath.Text = openTPCatalogDialog.FileName;
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            if(File.Exists(textBoxTPPath.Text))
            {
                if(tpCatalog != null)
                    tpCatalog.clear();

                clearTPTree();

                catalogReader.startParserThread(textBoxTPPath.Text, this);
            }
            else
            {
                MessageBox.Show("No or illegal path to test procedure catalog file!", "Illegal Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setTPTree(TreeNodeCollection tnc, TestProcedureCatalog catalog)
        {
            TreeNode currentNode;

            foreach(TestProcedureCategory category in catalog.categories)  // build TP tree with same indices as TP catalog
            {
                currentNode = tnc.Add("(" + category.number + ") " + category.name);

                foreach(TestProcedureDescription procedure in category.procedures)
                {
                    currentNode.Nodes.Add("(" + procedure.number + ") " + procedure.name);
                }
            }
        }

        private void updateTPTree(TestProcedureCatalog catalog)
        {
            treeViewTPs.BeginUpdate();
            clearTPTree();
            setTPTree(treeViewTPs.Nodes, catalog);            
            treeViewTPs.EndUpdate();
        }

        private void clearTPTree()
        {
            treeViewTPs.BeginUpdate();
            treeViewTPs.Nodes.Clear();
            treeViewTPs.EndUpdate();
        }

        private delegate void reportProgressDelegate(int value, int min, int max);
        private void reportProgressMethod(int value, int min, int max)
        {
            if(min >= 0)
                progressBar.Minimum = min;

            if(max >= 0 && max >= progressBar.Minimum)
                progressBar.Maximum = max;

            if(value >= progressBar.Minimum && value <= progressBar.Maximum)
                progressBar.Value = value;
        }

        public void reportProgress(int value, int min = -1, int max = -1)
        {
            Invoke(new reportProgressDelegate(reportProgressMethod), new object[] { value, min, max });
        }


        private delegate void reportFinishedDelegate();
        private void reportFinishedMethod()
        {
            progressBar.Value = progressBar.Maximum;

            tpCatalog = catalogReader.getCatalog();

            updateTPTree(tpCatalog);
        }

        public void reportFinished()
        {
            Invoke(new reportFinishedDelegate(reportFinishedMethod));
        }


        private delegate void reportFailedDelegate(string message);
        private void reportFailedMethod(string message)
        {
            progressBar.Value = progressBar.Minimum;

            tpCatalog.clear();

            clearTPTree();

            MessageBox.Show("Failed to parse test procedures catalog! Reason: " + message, "Failed to parse", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void reportFailed(string message)
        {
            Invoke(new reportFailedDelegate(reportFailedMethod), new object[] { message });
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            mainForm.setTestProcedureCatalog(tpCatalog);
            mainForm.reportSimpleFinished(this);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
