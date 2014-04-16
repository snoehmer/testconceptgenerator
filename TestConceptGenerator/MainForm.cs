using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConceptGenerator
{
    public partial class MainForm : Form, ISimpleCallbackForm
    {
        // sub-forms
        private TPCatalogChooserForm catalogChooser;

        private TestConcept currentTC;
        private bool tcChanged;

        private TestProcedureCatalog tpCatalog;

        private ConfigurationManager confMan;
        private DefinitionsManager defMan;
        private TestprocedureCategoryManager tpCatMan;

        public MainForm()
        {
            InitializeComponent();

            confMan = ConfigurationManager.getInstance();
            defMan = DefinitionsManager.getInstance();
            tpCatMan = TestprocedureCategoryManager.getInstance();


            catalogChooser = new TPCatalogChooserForm(this);

            currentTC = new TestConcept("New Test Concept");
            currentTC.testsets.Add(new TestProcedureSet());

            tcChanged = false;
            tpCatalog = null;
        }

        public bool confirmIgnoreTCUnsavedChanges()
        {
            if(tcChanged)
                return MessageBox.Show("The current Test Concept has been changed. If you proceed, the changes will be lost. Proceed?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes;
            else
                return true;
        }

        public void showTestConcept(TestConcept tc)
        {
            textBoxTCName.Text = tc.name;
            textBoxTCDut.Text = tc.productName;
            textBoxTCProductRevision.Text = tc.productRevision;
            textBoxProductBOMVersion.Text = tc.productBOMVersion;
            textBoxTCVersion.Text = tc.version;
            textBoxTCDescription.Text = tc.description;
            textBoxTCRemarks.Text = tc.remarks;

            updateTPTree(tc.testsets[0]);
        }

        public void setCurrentTestConcept(TestConcept tc)
        {
            currentTC = tc;

            showTestConcept(currentTC);
        }

        private void addProcedureToTestConcept(TestConcept tc, TestConceptProcedure tp)
        {
            tc.testsets[0].procedures.Add(tp);
        }

        private void addProceduresToTestConcept(TestConcept tc, List<TestConceptProcedure> tps)
        {
            foreach(TestConceptProcedure tp in tps)
            {
                addProcedureToTestConcept(tc, tp);
            }
        }

        public void addProcedureToCurrentTestConcept(TestConceptProcedure tp, bool updateTree = true)
        {
            addProcedureToTestConcept(currentTC, tp);

            if(updateTree)
                updateTPTree(currentTC.testsets[0]);
        }

        public void addProceduresToCurrentTestConcept(List<TestConceptProcedure> tps, bool updateTree = true)
        {
            addProceduresToTestConcept(currentTC, tps);

            if(updateTree)
                updateTPTree(currentTC.testsets[0]);
        }

        private void removeProcedureFromTestConcept(TestConcept tc, TestConceptProcedure tp)
        {
            tc.testsets[0].procedures.Remove(tp);
        }

        private void removeProceduresFromTestConcept(TestConcept tc, List<TestConceptProcedure> tps)
        {
            foreach(TestConceptProcedure tp in tps)
            {
                removeProcedureFromTestConcept(tc, tp);
            }
        }

        public void removeProcedureFromCurrentTestConcept(TestConceptProcedure tp, bool updateTree = true)
        {
            removeProcedureFromTestConcept(currentTC, tp);

            if(updateTree)
                updateTPTree(currentTC.testsets[0]);
        }

        public void removeProceduresFromCurrentTestConcept(List<TestConceptProcedure> tps, bool updateTree = true)
        {
            removeProceduresFromTestConcept(currentTC, tps);

            if(updateTree)
                updateTPTree(currentTC.testsets[0]);
        }

        private void clearProceduresFromTestConcept(TestConcept tc)
        {
            tc.testsets[0].clear();
        }

        public void clearProceduresFromCurrentTestConcept(bool updateTree = true)
        {
            clearProceduresFromTestConcept(currentTC);

            if(updateTree)
                updateTPTree(currentTC.testsets[0]);
        }


        private void setTPTree(TreeNodeCollection tnc, TestProcedureSet testset)
        {
            if(testset != null)
            {
                TreeNode currentNode;

                foreach(TestConceptProcedure procedure in testset.procedures)
                {
                    currentNode = tnc.Add("(" + procedure.getNumber() + ") " + procedure.getName());
                    currentNode.Tag = procedure;
                }
            }
        }

        private void updateTPTree(TestProcedureSet testset)
        {
            treeViewTPs.BeginUpdate();
            clearTPTree();
            setTPTree(treeViewTPs.Nodes, testset);
            treeViewTPs.EndUpdate();
        }

        private void clearTPTree()
        {
            treeViewTPs.BeginUpdate();
            treeViewTPs.Nodes.Clear();
            treeViewTPs.EndUpdate();
        }

        public void setTestProcedureCatalog(TestProcedureCatalog tpCatalog)
        {
            this.tpCatalog = tpCatalog;
        }

        public TestProcedureCatalog getTestProcedureCatalog()
        {
            return this.tpCatalog;
        }

        private void sandboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm sandbox = new TestForm();
            sandbox.Show();
            sandbox.Focus();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(confirmIgnoreTCUnsavedChanges())
                Application.Exit();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //groupBoxTP.SetBounds(13, 276, MainForm.ActiveForm.Size.Width - 2 * 13, 176);
        }

        private void chooseTestProceduresCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalogChooser.ShowDialog();
        }


        public void reportSimpleFinished(Form source)
        {
            if(source == catalogChooser)  // catalog chooser form finished, update main catalog
            {
                toolStripStatusLabel.Text = "imported new Test Procedures catalog";
            }
        }

        private void buttonAddTP_Click(object sender, EventArgs e)
        {
            if(tpCatalog == null)
            {
                MessageBox.Show("You must first choose a Test Procedures Catalog! Go to 'Test Procedures', 'Choose Test Procedures Catalog'.", "No Catalog selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AddTPForm addTPForm = new AddTPForm(this);
            addTPForm.ShowDialog();
        }

        private void clearParamsTree()
        {
            treeViewTPParams.BeginUpdate();
            treeViewTPParams.Nodes.Clear();
            treeViewTPParams.EndUpdate();
        }

        private void updateParamsTree(TestConceptProcedure selectedTP)
        {
            clearParamsTree();

            if(selectedTP == null)
            {
                return;
            }

            TreeNode parentNode;
            //TreeNode currentNode;

            treeViewTPParams.BeginUpdate();

            parentNode = treeViewTPParams.Nodes.Add("Information");

            parentNode.Nodes.Add(selectedTP.getNumber());
            parentNode.Nodes.Add(selectedTP.getName());
            parentNode.Nodes.Add(selectedTP.getDescription());

            parentNode = treeViewTPParams.Nodes.Add("Concept Specific");

            parentNode.Nodes.Add("#DUTs: " + selectedTP.nrDUTs);
            parentNode.Nodes.Add("Priority: " + selectedTP.priority);
            parentNode.Nodes.Add("Resposible: " + selectedTP.responsible);

            parentNode = treeViewTPParams.Nodes.Add("Input Parameters");

            foreach(InputParameter ip in selectedTP.getInputParameters())
            {
                parentNode.Nodes.Add(ip.name + " = " + ip.getInputParamValue());
            }

            parentNode = treeViewTPParams.Nodes.Add("Qualification Parameters");

            foreach(QualificationParameter qp in selectedTP.getQualificationParameters())
            {
                parentNode.Nodes.Add(qp.name + " = " + qp.getQualificationParamValue());
            }

            treeViewTPParams.ExpandAll();

            treeViewTPParams.EndUpdate();
        }

        private void treeViewTPs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeViewTPs.SelectedNode != null)
            {
                updateParamsTree((TestConceptProcedure)treeViewTPs.SelectedNode.Tag);
            }
        }

        private void exportTestOverviewExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TestOverviewExporter toExporter = new TestOverviewExporter_Excel(currentTC);

            //toExporter.exportTestOverview(@"C:\tmp\TestOverviewOutput\");

            ExportTestOverviewForm exportForm = new ExportTestOverviewForm(currentTC);

            exportForm.ShowDialog();
        }

        private void textBoxTCDut_TextChanged(object sender, EventArgs e)
        {
            currentTC.productName = textBoxTCDut.Text;
            tcChanged = true;
        }

        private void textBoxTCProductRevision_TextChanged(object sender, EventArgs e)
        {
            currentTC.productRevision = textBoxTCProductRevision.Text;
            tcChanged = true;
        }

        private void textBoxProductBOMVersion_TextChanged(object sender, EventArgs e)
        {
            currentTC.productBOMVersion = textBoxProductBOMVersion.Text;
            tcChanged = true;
        }

        private void buttonRemoveTP_Click(object sender, EventArgs e)
        {
            if(treeViewTPs.SelectedNode == null)
                return;

            TestProcedure selectedTP = (TestProcedure) treeViewTPs.SelectedNode.Tag;

            currentTC.testsets[0].procedures.Remove(selectedTP);
            selectedTP = null;

            updateTPTree(currentTC.testsets[0]);

            tcChanged = true;
        }

        private void buttonEditTP_Click(object sender, EventArgs e)
        {
            if(treeViewTPs.SelectedNode != null && treeViewTPs.SelectedNode.Level == 0)
            {
                TestConceptProcedure tp = (TestConceptProcedure)treeViewTPs.SelectedNode.Tag;

                EditTPForm editForm = new EditTPForm(this, tp);
                editForm.ShowDialog();

                updateParamsTree(tp);
            }
            else
            {
                MessageBox.Show("You must select a Test Procedure before you can edit it!", "No Test Procedure Selected", MessageBoxButtons.OK);
            }
        }

        private void buttonTPUp_Click(object sender, EventArgs e)
        {
            List<TestProcedure> tps = currentTC.testsets[0].procedures;
            TestConceptProcedure selectedTP = (TestConceptProcedure)treeViewTPs.SelectedNode.Tag;

            if(tps.Count > 0 && selectedTP != tps[0])
            {
                int oldIndex = treeViewTPs.SelectedNode.Index;

                if(oldIndex > 0)
                {
                    tps.RemoveAt(oldIndex);
                    tps.Insert(oldIndex - 1, selectedTP);
                }

                tcChanged = true;
            }
        }

        private void buttonTPDown_Click(object sender, EventArgs e)
        {
            List<TestProcedure> tps = currentTC.testsets[0].procedures;
            TestConceptProcedure selectedTP = (TestConceptProcedure)treeViewTPs.SelectedNode.Tag;

            if(tps.Count > 0 && selectedTP != tps[tps.Count - 1])
            {
                int oldIndex = treeViewTPs.SelectedNode.Index;

                if(oldIndex < tps.Count - 1)
                {
                    tps.RemoveAt(oldIndex);
                    tps.Insert(oldIndex + 1, selectedTP);
                }

                tcChanged = true;
            }
        }

        private void buttonEditTPParams_Click(object sender, EventArgs e)
        {
            // TODO: implement
            MessageBox.Show("not yet implemented");
        }


        public void saveTestConcept(TestConcept tc, string path)
        {
            // TODO: implement
        }

        public TestConcept loadTestConcept(string path)
        {
            // TODO: implement

            return null;
        }


    }
}