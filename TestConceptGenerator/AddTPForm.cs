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
    public partial class AddTPForm : Form
    {
        private MainForm mainForm;
        private TestProcedureCatalog tpCatalog;

        private List<TestConceptProcedure> newProcedures;

        private bool paramsTreeEditable;

        private Font markedNodeFont;
        private Color markedNodeColor;
        private Font completedNodeFont;
        private Color completedNodeColor;

        public AddTPForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            markedNodeFont = new Font(treeViewTPs.Font, FontStyle.Bold);
            markedNodeColor = Color.DarkRed;
            completedNodeFont = markedNodeFont;
            completedNodeColor = Color.Green;

            newProcedures = new List<TestConceptProcedure>();

            tpCatalog = mainForm.getTestProcedureCatalog();

            textBoxTPCatalog.Text = tpCatalog.path;

            
            updateTPTree(tpCatalog);
            clearParamsTree();
            treeViewParams.Enabled = false;

            enableTPControls(false, false);

            paramsTreeEditable = false;
        }

        private void enableTPControls(bool enabled, bool parametersEnabled)
        {
            labelPriority.Enabled = enabled;
            comboBoxPriority.Enabled = enabled;
            
            labelResponsible.Enabled = enabled;
            textBoxResponsible.Enabled = enabled;

            labelDuration.Enabled = enabled;
            labelDurationMin.Enabled = enabled;
            numericUpDownDuration.Enabled = enabled;

            labelDueDate.Enabled = enabled;
            dateTimePickerDueDate.Enabled = enabled;

            labelNrDUTs.Enabled = enabled;
            numericUpDownNrDUTs.Enabled = enabled;

            checkBoxFirmware.Enabled = enabled;

            if(!enabled)  // only disable automatically, must be enabled manually!
            {
                checkBoxFirmware.Checked = false;

                labelFirmwareName.Enabled = enabled;
                textBoxFirmwareName.Enabled = enabled;
                textBoxFirmwareName.Text = "";

                labelFirmwarePath.Enabled = enabled;
                textBoxFirmwarePath.Enabled = enabled;
                textBoxFirmwarePath.Text = "";

                buttonFirmwareBrowse.Enabled = enabled;
            }

            labelTestPoints.Enabled = enabled;
            textBoxTestPoints.Enabled = enabled;

            labelRemarks.Enabled = enabled;
            textBoxRemarks.Enabled = enabled;

            labelParameters.Enabled = parametersEnabled;
            treeViewParams.Enabled = parametersEnabled;

            buttonEditParams.Enabled = enabled;
        }

        private void updateTPControls(TestConceptProcedure tp, bool updateParams = false)
        {
            comboBoxPriority.Text = DefinitionsManager.getPriorityAsString(DefinitionsManager.getPriority(tp.priority));
            textBoxResponsible.Text = tp.responsible;
            numericUpDownDuration.Value = tp.customDuration;
            dateTimePickerDueDate.Value = tp.dueDate;
            checkBoxFirmware.Checked = tp.firmwareNeeded;
            numericUpDownNrDUTs.Value = tp.nrDUTs;

            if(tp.firmwareNeeded)
            {
                textBoxFirmwareName.Text = tp.firmwareName;
                textBoxFirmwarePath.Text = tp.firmwarePath;
            }

            textBoxTestPoints.Text = tp.testpoints;
            textBoxRemarks.Text = tp.customRemarks;

            if(updateParams)
                updateParamsTree(tp);
        }

        private void updateTPControls(TestProcedureDescription tp, bool updateParams = false)
        {
            comboBoxPriority.Text = "";
            textBoxResponsible.Text = "";
            numericUpDownDuration.Value = tp.defaultDuration;
            dateTimePickerDueDate.Value = DateTime.Today;
            numericUpDownNrDUTs.Value = tp.defaultNrDUTs;

            checkBoxFirmware.Checked = false;
            textBoxFirmwareName.Text = "";
            textBoxFirmwarePath.Text = "";
            

            textBoxTestPoints.Text = "";
            textBoxRemarks.Text = tp.remarks;

            if(updateParams)
                updateParamsTree(tp);
        }

        private void clearTPControls(bool clearParams = false)
        {
            comboBoxPriority.Text = "";
            textBoxResponsible.Text = "";
            numericUpDownDuration.Value = 0;
            dateTimePickerDueDate.Value = DateTime.Today;
            checkBoxFirmware.Checked = false;
            numericUpDownNrDUTs.Value = 0;

            textBoxFirmwareName.Text = "";
            textBoxFirmwarePath.Text = "";

            textBoxTestPoints.Text = "";
            textBoxRemarks.Text = "";

            if(clearParams)
                clearParamsTree();
        }

        // check if all important TP-specific controls are set
        public bool allTPControlsSet()
        {
            if(comboBoxPriority.Text.Equals(""))
                return false;

            if(textBoxResponsible.Text.Equals(""))
                return false;

            if(numericUpDownNrDUTs.Value <= 0)
                return false;

            // TODO: add more?

            return true;
        }

        public void updateTPTree(TestProcedureCatalog tpCatalog)
        {
            treeViewTPs.BeginUpdate();
            clearTPTree();
            setTPTree(treeViewTPs.Nodes, tpCatalog);
            treeViewTPs.EndUpdate();
        }

        public void setTPTree(TreeNodeCollection tnc, TestProcedureCatalog tpCatalog)
        {
            foreach(TestProcedureCategory category in tpCatalog.categories)
            {
                TreeNode currentNode;

                currentNode = tnc.Add(category.name);
                currentNode.Tag = category;

                foreach(TestProcedure procedure in category.procedures)
                {
                    TreeNode currentSubNode;

                    currentSubNode = currentNode.Nodes.Add("(" + procedure.getNumber() + ") " + procedure.getName());
                    currentSubNode.Tag = procedure;
                }
            }
        }

        public void clearTPTree()
        {
            treeViewTPs.BeginUpdate();
            treeViewTPs.Nodes.Clear();
            treeViewTPs.EndUpdate();
        }

        public void updateParamsTree(TestProcedure tp)
        {
            treeViewParams.BeginUpdate();
            clearParamsTree();
            setParamsTree(treeViewParams.Nodes, tp);
            updateParamsTreeFormat(treeViewTPs.SelectedNode.Checked);
            updateTPTreeFormat();
            treeViewParams.EndUpdate();

            treeViewParams.ExpandAll();
        }

        public void setParamsTree(TreeNodeCollection tnc, TestProcedure tp)
        {
            TreeNode currentNode;

            currentNode = tnc.Add("Input Parameters");
            currentNode.Tag = null;

            foreach(InputParameter inputParam in tp.getInputParameters())
            {
                TreeNode currentSubNode;
                string nodeValue;

                if(paramsTreeEditable)  // displaying a procedure from the test concept
                {
                    nodeValue = inputParam.name + " = " + inputParam.getInputParamValue();
                }
                else
                {
                    nodeValue = inputParam.name;
                }

                currentSubNode = currentNode.Nodes.Add(nodeValue);
                currentSubNode.ToolTipText = inputParam.description;
                currentSubNode.Tag = inputParam;
            }

            currentNode = tnc.Add("Qualification Parameters");
            currentNode.Tag = null;

            foreach(QualificationParameter qualParam in tp.getQualificationParameters())
            {
                TreeNode currentSubNode;
                string nodeValue;

                if(paramsTreeEditable)  // displaying a procedure from the test concept
                {
                    nodeValue = qualParam.name + " = " + qualParam.getQualificationParamValue();
                }
                else
                {
                    nodeValue = qualParam.name;
                }

                currentSubNode = currentNode.Nodes.Add(qualParam.name);
                currentSubNode.ToolTipText = qualParam.description;
                currentSubNode.Tag = qualParam;
            }
        }

        public void clearParamsTree()
        {
            treeViewParams.BeginUpdate();
            treeViewParams.Nodes.Clear();
            treeViewParams.EndUpdate();
        }

        public void updateParamsTreeFormat(bool paramsTreeEditable = true)
        {
            treeViewParams.BeginUpdate();

            foreach(TreeNode node in treeViewParams.Nodes)
            {
                if(paramsTreeEditable)
                {
                    node.NodeFont = completedNodeFont;
                    node.ForeColor = completedNodeColor;
                }

                foreach(TreeNode subnode in node.Nodes)
                {
                    subnode.NodeFont = treeViewParams.Font;
                    subnode.ForeColor = Color.FromKnownColor(KnownColor.WindowText);

                    if(paramsTreeEditable)
                    {
                        if(node.Index == 0)  // input parameters
                        {
                            InputParameter currentParam = (InputParameter)subnode.Tag;

                            if(!currentParam.isSet)
                            {
                                subnode.NodeFont = markedNodeFont;
                                subnode.ForeColor = markedNodeColor;

                                node.NodeFont = markedNodeFont;
                                node.ForeColor = markedNodeColor;
                            }
                            else
                            {
                                subnode.NodeFont = completedNodeFont;
                                subnode.ForeColor = completedNodeColor;
                            }
                        }

                        else if(node.Index == 1)  // qualification parameters
                        {
                            QualificationParameter currentParam = (QualificationParameter)subnode.Tag;

                            if(!currentParam.isSet)
                            {
                                subnode.NodeFont = markedNodeFont;
                                subnode.ForeColor = markedNodeColor;

                                node.NodeFont = markedNodeFont;
                                node.ForeColor = markedNodeColor;
                            }
                            else
                            {
                                subnode.NodeFont = completedNodeFont;
                                subnode.ForeColor = completedNodeColor;
                            }
                        }
                    }
                }
            }

            treeViewParams.EndUpdate();
        }

        public void updateTPTreeFormat()
        {
            treeViewTPs.BeginUpdate();

            foreach(TreeNode node in treeViewTPs.Nodes)
            {
                node.NodeFont = treeViewTPs.Font;
                node.ForeColor = Color.FromKnownColor(KnownColor.WindowText);

                bool nodeContainsConceptProcedures = false;
                bool allSubnodesSet = true;

                foreach(TreeNode subnode in node.Nodes)
                {
                    subnode.NodeFont = treeViewTPs.Font;
                    subnode.ForeColor = Color.FromKnownColor(KnownColor.WindowText);

                    if(subnode.Checked)  // procedure is in test concept
                    {
                        nodeContainsConceptProcedures = true;

                        TestProcedure tp = (TestProcedure)subnode.Tag;
                        bool allParamsSet = true;

                        foreach(InputParameter ip in tp.getInputParameters())
                        {
                            if(!ip.isSet)
                            {
                                allParamsSet = false;
                                break;
                            }
                        }

                        foreach(QualificationParameter qp in tp.getQualificationParameters())
                        {
                            if(!qp.isSet)
                            {
                                allParamsSet = false;
                                break;
                            }
                        }

                        if(!allTPControlsSet())
                            allParamsSet = false;

                        if(!allParamsSet)
                        {
                            subnode.ForeColor = markedNodeColor;
                            subnode.NodeFont = markedNodeFont;

                            allSubnodesSet = false;
                        }
                        else
                        {
                            subnode.ForeColor = completedNodeColor;
                            subnode.NodeFont = completedNodeFont;
                        }
                    }
                }

                if(nodeContainsConceptProcedures && !allSubnodesSet)
                {
                    node.NodeFont = markedNodeFont;
                    node.ForeColor = markedNodeColor;
                }
                else if(nodeContainsConceptProcedures && allSubnodesSet)
                {
                    node.NodeFont = completedNodeFont;
                    node.ForeColor = completedNodeColor;
                }
            }

            treeViewTPs.EndUpdate();
        }

        private void treeViewTPs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewTPs.BeginUpdate();

            if(e.Node.Level == 1)  // a procedure was selected
            {
                TestProcedure tp = (TestProcedure)e.Node.Tag;

                textBoxDescription.Text = tp.getDescription();
                                
                if(e.Node.Checked)  // procedure is in the test concept
                {
                    updateTPControls((TestConceptProcedure)tp);
                    enableTPControls(true, true);

                    paramsTreeEditable = true;
                }
                else  // procedure from catalog (not editable)
                {
                    updateTPControls((TestProcedureDescription)tp);
                    enableTPControls(false, true);

                    paramsTreeEditable = false;
                }

                updateParamsTree(tp);
                updateParamsTreeFormat(treeViewTPs.SelectedNode.Checked);
                updateTPTreeFormat();
                treeViewParams.ExpandAll();
            }
            else  // a category was selected
            {
                TestProcedureCategory cat = (TestProcedureCategory)e.Node.Tag;

                clearTPControls(true);
                enableTPControls(false, false);

                textBoxDescription.Text = cat.description;

                paramsTreeEditable = false;
            }

            treeViewTPs.EndUpdate();
        }

        private void treeViewTPs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            treeViewTPs.BeginUpdate();

            if(node.Level == 1)  // procedure node
            {
                if(node.Checked)  // node added to the new procedures collection
                {
                    TestProcedureDescription catalogTP = (TestProcedureDescription)node.Tag;
                    TestConceptProcedure newTP = new TestConceptProcedure(catalogTP);

                    newProcedures.Add(newTP);

                    node.Tag = newTP;

                    updateTPControls(newTP);
                    enableTPControls(true, true);

                    paramsTreeEditable = true;
                    updateParamsTree(newTP);
                }
                else  // node removed from new procedures collection
                {
                    TestConceptProcedure removeTP = (TestConceptProcedure)node.Tag;
                    TestProcedureDescription catalogTP = removeTP.testProcedureDescription;

                    newProcedures.Remove(removeTP);

                    node.Tag = catalogTP;

                    updateTPControls(catalogTP);
                    enableTPControls(false, true);

                    treeViewParams.Enabled = true;
                    paramsTreeEditable = false;
                    updateParamsTree(catalogTP);
                }

                treeViewParams.ExpandAll();
                updateParamsTreeFormat(node.Checked);
                updateTPTreeFormat();
            }
            else if(e.Node.Level == 0) // category node
            {
                if(node.Checked) // enable all procedures in category
                {
                    node.Expand();

                    foreach(TreeNode subnode in e.Node.Nodes)
                    {
                        if(!subnode.Checked)  // ignore already checked subnodes
                        {
                            subnode.Checked = true;
                        }
                    }
                }
                else  // disable all procedures in category
                {
                    foreach(TreeNode subnode in e.Node.Nodes)
                    {
                        if(subnode.Checked)  // ignore already unchecked subnodes
                        {
                            subnode.Checked = false;
                        }
                    }
                }

                clearTPControls();
                enableTPControls(false, false);

                treeViewParams.Enabled = false;
                paramsTreeEditable = false;

                clearParamsTree();

                updateTPTreeFormat();
            }
            else  // other node
            {
                clearTPControls();
                enableTPControls(false, false);

                treeViewParams.Enabled = false;
                paramsTreeEditable = false;

                clearParamsTree(); 
            }

            treeViewTPs.EndUpdate();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(newProcedures.Count > 0)
            {
                mainForm.addProceduresToCurrentTestConcept(newProcedures);
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeViewTPs_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            treeViewTPs.SelectedNode = e.Node;
        }

        private void treeViewParams_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(paramsTreeEditable & e.Node.Level == 0)  // parameter type selected
            {
                buttonEditParams.Enabled = false;
            }
            else if(paramsTreeEditable & e.Node.Level == 1)  // input or qualification parameter selected
            {
                buttonEditParams.Enabled = true;
            }
        }

        private void editParameter(TreeNode node)
        {
            if(node.Level == 1)
            {
                if(node.Parent.Index == 0)  // input parameter
                {
                    editParameter((InputParameter)node.Tag);
                }
                else if(node.Parent.Index == 1)  // qualification parameter
                {
                    editParameter((QualificationParameter)node.Tag);
                }
            }
        }

        private void editParameter(InputParameter ip)
        {
            EditInputParameterForm form = new EditInputParameterForm();
            form.setInputParameter(ip);
            form.ShowDialog();
            form.Dispose();

            updateParamsTree((TestProcedure)treeViewTPs.SelectedNode.Tag);
            updateParamsTreeFormat();
            updateTPTreeFormat();
        }

        private void editParameter(QualificationParameter qp)
        {
            EditQualificationParameterForm form = new EditQualificationParameterForm();
            form.setQualificationParameter(qp);
            form.ShowDialog();
            form.Dispose();

            updateParamsTree((TestProcedure)treeViewTPs.SelectedNode.Tag);
            updateParamsTreeFormat();
            updateTPTreeFormat();
        }

        private void buttonEditParams_Click(object sender, EventArgs e)
        {
            if(paramsTreeEditable && treeViewParams.SelectedNode.Level == 1)
            {
                editParameter(treeViewParams.SelectedNode);
            }
        }

        private void treeViewParams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeViewParams.SelectedNode;

            if(node != null && paramsTreeEditable && node.Level == 1)  // parameter node
            {
                editParameter(node);
            }
        }

        private void buttonShowTP_Click(object sender, EventArgs e)
        {
            WordDocumentReference reference = null;

            if(treeViewTPs.SelectedNode != null)
            {
                if(treeViewTPs.SelectedNode.Level == 0)  // category selected
                {
                    TestProcedureCategory category = (TestProcedureCategory)treeViewTPs.SelectedNode.Tag;
                    reference = category.reference;
                }
                else if(treeViewTPs.SelectedNode.Level == 1)  // procedure selected
                {
                    if(treeViewTPs.SelectedNode.Checked)  // TestConceptProcedure type
                    {
                        TestConceptProcedure tp = (TestConceptProcedure)treeViewTPs.SelectedNode.Tag;
                        reference = tp.testProcedureDescription.reference;
                    }
                    else  // TestProcedureDescription type
                    {
                        TestProcedureDescription tp = (TestProcedureDescription)treeViewTPs.SelectedNode.Tag;
                        reference = tp.reference;
                    }
                }

                // show in Word
                WordViewer wViewer = WordViewer.getInstance();

                wViewer.showReference(reference);
            }
        }

        // ====================== TEXT BOX CHANGE EVENTS ==========================================================================================

        private void comboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.priority = DefinitionsManager.getPriorityAsInt(DefinitionsManager.getPriority(comboBoxPriority.Text));
                }
            }
        }

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.customRemarks = textBoxRemarks.Text;
                }
            }
        }

        private void textBoxResponsible_TextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.responsible = textBoxResponsible.Text;
                }
            }
        }

        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.customDuration = (int) numericUpDownDuration.Value;
                }
            }
        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.dueDate = dateTimePickerDueDate.Value;
                }
            }
        }

        private void numericUpDownNrDUTs_ValueChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.nrDUTs = (int) numericUpDownNrDUTs.Value;
                }
            }
        }

        private void checkBoxFirmware_CheckedChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            labelFirmwareName.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwareName.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwareName.Text = "";

            labelFirmwarePath.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwarePath.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwarePath.Text = "";

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.firmwareNeeded = checkBoxFirmware.Checked;
                    selectedTP.firmwareName = textBoxFirmwareName.Text;
                    selectedTP.firmwarePath = textBoxFirmwarePath.Text;
                    selectedTP.firmwareFile = null;  // TODO: firmware file handling
                }
            }
        }

        private void textBoxFirmwareName_TextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    if(checkBoxFirmware.Checked)
                        selectedTP.firmwareName = textBoxFirmwareName.Text;
                }
            }
        }

        private void textBoxFirmwarePath_TextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    if(checkBoxFirmware.Checked)
                        selectedTP.firmwarePath = textBoxFirmwarePath.Text;
                }
            }
        }

        private void buttonFirmwareBrowse_Click(object sender, EventArgs e)
        {
            // TODO: implement
            MessageBox.Show("Not yet implemented");
        }

        private void textBoxTestPoints_TextChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewTPs.SelectedNode;
            TestConceptProcedure selectedTP;

            if(selectedNode != null)
            {
                if(selectedNode.Level == 1 && selectedNode.Checked == true)
                {
                    selectedTP = (TestConceptProcedure)selectedNode.Tag;

                    selectedTP.testpoints = textBoxTestPoints.Text;
                }
            }
        }
    }
}
