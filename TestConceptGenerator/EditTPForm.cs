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
    public partial class EditTPForm : Form
    {
        private MainForm mainForm;
        
        private Font markedNodeFont;
        private Color markedNodeColor;
        private Font completedNodeFont;
        private Color completedNodeColor;

        private TestConceptProcedure originalTP;
        private TestConceptProcedure tempTP;

        private bool tpChanged;

        public EditTPForm(MainForm mainForm, TestConceptProcedure tp)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            markedNodeFont = new Font(treeViewParams.Font, FontStyle.Bold);
            markedNodeColor = Color.DarkRed;
            completedNodeFont = markedNodeFont;
            completedNodeColor = Color.Green;

            originalTP = tp;

            tempTP = (TestConceptProcedure) tp.deepCopy();

            updateTPControls(tempTP);

            tpChanged = false;
        }


        // ========================== CONTROL ELEMENTS METHODS =========================================================================

        private void updateTPControls(TestConceptProcedure tp, bool updateParams = true)
        {
            labelTPnr.Text = tp.testProcedureDescription.number;
            labelTPname.Text = tp.testProcedureDescription.name;

            textBoxDescription.Text = tp.testProcedureDescription.description;
            textBoxSetup.Text = tp.testProcedureDescription.setup;

            comboBoxPriority.Text = DefinitionsManager.getPriorityAsString(DefinitionsManager.getPriority(tp.priority));
            textBoxResponsible.Text = tp.responsible;
            numericUpDownDuration.Value = tp.customDuration;
            dateTimePickerDueDate.Value = tp.dueDate;
            checkBoxFirmware.Checked = tp.firmwareNeeded;
            numericUpDownNrDUTs.Value = tp.nrDUTs;

            if(tp.firmwareNeeded)
            {
                textBoxFirmwareName.Enabled = true;
                textBoxFirmwareName.Text = tp.firmwareName;

                textBoxFirmwarePath.Enabled = true;
                textBoxFirmwarePath.Text = tp.firmwarePath;
            }

            textBoxTestPoints.Text = tp.testpoints;
            textBoxRemarks.Text = tp.customRemarks;

            if(updateParams)
                updateParamsTree(tp);
        }

        private void clearTPControls(bool clearParams = true)
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


        
        // =========================== PARAMETERS TREE METHODS =========================================================================

        public void updateParamsTree(TestProcedure tp)
        {
            treeViewParams.BeginUpdate();
            clearParamsTree();
            setParamsTree(treeViewParams.Nodes, tp);
            updateParamsTreeFormat();
            treeViewParams.EndUpdate();

            treeViewParams.ExpandAll();

            //treeViewParams.Refresh();
            //treeViewParams.Update();
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

                nodeValue = inputParam.name + " = " + inputParam.getInputParamValue();

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

                nodeValue = qualParam.name + " = " + qualParam.getQualificationParamValue();

                currentSubNode = currentNode.Nodes.Add(qualParam.name);
                currentSubNode.ToolTipText = qualParam.description;
                currentSubNode.Tag = qualParam;
            }

            //treeViewParams.Refresh();
        }

        public void clearParamsTree()
        {
            treeViewParams.BeginUpdate();
            treeViewParams.Nodes.Clear();
            treeViewParams.EndUpdate();

            //treeViewParams.Refresh();
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

            //treeViewParams.Refresh();
        }

        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            originalTP.overwriteFrom(tempTP);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(tpChanged)
            {
                if(MessageBox.Show("Test Procedure has been changed, but not saved. If you proceed, all changes will be lost. Proceed?", "Test Procedure not saved!", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            this.Close();
        }

        

        // =================================== PARAMETER TREE VIEW METHODS ===============================================================

        private void treeViewParams_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0)  // parameter type selected
            {
                buttonEditParams.Enabled = false;
            }
            else if(e.Node.Level == 1)  // input or qualification parameter selected
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

            updateParamsTree(tempTP);
            updateParamsTreeFormat();
        }

        private void editParameter(QualificationParameter qp)
        {
            EditQualificationParameterForm form = new EditQualificationParameterForm();
            form.setQualificationParameter(qp);
            form.ShowDialog();
            form.Dispose();

            updateParamsTree(tempTP);
            updateParamsTreeFormat();
        }

        private void buttonEditParams_Click(object sender, EventArgs e)
        {
            if(treeViewParams.SelectedNode.Level == 1)
            {
                editParameter(treeViewParams.SelectedNode);
            }
        }

        private void treeViewParams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeViewParams.SelectedNode;

            if(node != null && node.Level == 1)  // parameter node
            {
                editParameter(node);
            }
        }


        // =============================== TEXTBOX CHANGE EVENTS ================================================================

        private void comboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempTP.priority = DefinitionsManager.getPriorityAsInt(DefinitionsManager.getPriority(comboBoxPriority.Text));

            tpChanged = true;
        }

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {
            tempTP.customRemarks = textBoxRemarks.Text;

            tpChanged = true;
        }

        private void textBoxResponsible_TextChanged(object sender, EventArgs e)
        {
            tempTP.responsible = textBoxResponsible.Text;

            tpChanged = true;
        }

        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            tempTP.customDuration = (int)numericUpDownDuration.Value;

            tpChanged = true;
        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {
            tempTP.dueDate = dateTimePickerDueDate.Value;

            tpChanged = true;

        }

        private void numericUpDownNrDUTs_ValueChanged(object sender, EventArgs e)
        {
            tempTP.nrDUTs = (int)numericUpDownNrDUTs.Value;

            tpChanged = true;
        }

        private void checkBoxFirmware_CheckedChanged(object sender, EventArgs e)
        {
            labelFirmwareName.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwareName.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwareName.Text = "";

            labelFirmwarePath.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwarePath.Enabled = checkBoxFirmware.Checked;
            textBoxFirmwarePath.Text = "";

            tempTP.firmwareNeeded = checkBoxFirmware.Checked;
            tempTP.firmwareName = textBoxFirmwareName.Text;
            tempTP.firmwarePath = textBoxFirmwarePath.Text;
            tempTP.firmwareFile = null;  // TODO: firmware file handling

            tpChanged = true;
        }

        private void textBoxFirmwareName_TextChanged(object sender, EventArgs e)
        {
            if(checkBoxFirmware.Checked)
            {
                tempTP.firmwareName = textBoxFirmwareName.Text;

                tpChanged = true;
            }
        }

        private void textBoxFirmwarePath_TextChanged(object sender, EventArgs e)
        {
            if(checkBoxFirmware.Checked)
            {
                tempTP.firmwarePath = textBoxFirmwarePath.Text;

                tpChanged = true;
            }
        }

        private void buttonFirmwareBrowse_Click(object sender, EventArgs e)
        {
            // TODO: implement
            MessageBox.Show("Not yet implemented");
        }

        private void textBoxTestPoints_TextChanged(object sender, EventArgs e)
        {
            tempTP.testpoints = textBoxTestPoints.Text;

            tpChanged = true;
        }

    }
}
