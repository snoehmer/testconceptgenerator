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
    public partial class EditInputParameterForm : Form
    {
        private InputParameter ip;

        private bool ipChanged;

        public EditInputParameterForm()
        {
            InitializeComponent();

            columnDummy.Width = listViewValues.Width - SystemInformation.VerticalScrollBarWidth - listViewValues.Margin.Horizontal;

            ipChanged = false;
        }

        public void setInputParameter(InputParameter ip)
        {
            this.ip = ip;

            textBoxName.Text = ip.name;
            textBoxDescription.Text = ip.description;
            textBoxRemarks.Text = ip.remarks;

            switch(ip.type)
            {
                case InputParameterType.None:
                    break;

                case InputParameterType.SingleValue:
                    radioButtonSingleValue.Checked = true;
                    textBoxSingleValue.Text = ip.getSingleValue();
                    break;

                case InputParameterType.Range:
                    radioButtonValueRange.Checked = true;
                    textBoxRangeMin.Text = ip.getValueRangeMin();
                    textBoxRangeMax.Text = ip.getValueRangeMax();
                    break;

                case InputParameterType.ValueList:
                    radioButtonValueList.Checked = true;
                    foreach(string value in ip.values)
                    {
                        listViewValues.Items.Add(value);
                    }
                    break;
            }

            ipChanged = false;
        }

        private void radioButtonSingleValue_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSingleValue.Checked)
            {
                textBoxSingleValue.Enabled = true;
            }
            else
            {
                textBoxSingleValue.Enabled = false;
            }

            ipChanged = true;
        }

        private void radioButtonValueRange_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonValueRange.Checked)
            {
                labelRangeTo.Enabled = true;
                labelRangeStep.Enabled = true;
                textBoxRangeMin.Enabled = true;
                textBoxRangeMax.Enabled = true;
                textBoxRangeStep.Enabled = true;
            }
            else
            {
                labelRangeTo.Enabled = false;
                labelRangeStep.Enabled = false;
                textBoxRangeMin.Enabled = false;
                textBoxRangeMax.Enabled = false;
                textBoxRangeStep.Enabled = false;
            }

            ipChanged = true;
        }

        private void radioButtonValueList_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonValueList.Checked)
            {
                listViewValues.Enabled = true;
                buttonAdd.Enabled = true;
                buttonRemove.Enabled = true;
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
            else
            {
                listViewValues.Enabled = false;
                buttonAdd.Enabled = false;
                buttonRemove.Enabled = false;
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
            }

            ipChanged = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(ipChanged)
            {
                if(MessageBox.Show("Parameter has changed. If you proceed, these changes will be lost! Proceed?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ip.isSet = false;

            if(radioButtonSingleValue.Checked)
            {
                ip.type = InputParameterType.SingleValue;
                ip.setSingleValue(textBoxSingleValue.Text);

                if(textBoxSingleValue.Text.Length > 0)
                    ip.isSet = true;
            }
            else if(radioButtonValueRange.Checked)
            {
                ip.type = InputParameterType.Range;
                ip.setValueRange(textBoxRangeMin.Text, textBoxRangeMax.Text, textBoxRangeStep.Text);

                if(textBoxRangeMin.Text.Length > 0 || textBoxRangeMax.Text.Length > 0 || textBoxRangeStep.Text.Length > 0)
                    ip.isSet = true;
            }
            else if(radioButtonValueList.Checked)
            {
                ip.type = InputParameterType.ValueList;
                ip.initValueList(listViewValues.Items.Count);

                foreach(ListViewItem item in listViewValues.Items)
                {
                    if(item.Text.Length > 0)
                    {
                        ip.addElementToValueList(item.Text);
                        ip.isSet = true;
                    }
                }
            }

            ip.remarks = textBoxRemarks.Text;

            ipChanged = false;

            this.Close();
        }

        private void textBoxSingleValue_TextChanged(object sender, EventArgs e)
        {
            ipChanged = true;
        }

        private void textBoxRangeMin_TextChanged(object sender, EventArgs e)
        {
            ipChanged = true;
        }

        private void textBoxRangeMax_TextChanged(object sender, EventArgs e)
        {
            ipChanged = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewValues.SelectedItems)
            {
                listViewValues.Items.Remove(item);
            }

            ipChanged = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewValues.SelectedItems)
            {
                item.Selected = false;
            }

            ListViewItem newItem = listViewValues.Items.Add("<new value>");

            newItem.Selected = true;
            newItem.BeginEdit();

            ipChanged = true;
        }

        private void listViewValues_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ipChanged = true;
        }

        private void listViewValues_ItemActivate(object sender, EventArgs e)
        {
            if(listViewValues.SelectedItems.Count > 0)
            {
                listViewValues.SelectedItems[0].BeginEdit();
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if(listViewValues.Items.Count > 0 && !listViewValues.SelectedItems.Contains(listViewValues.Items[0]))
            {
                foreach(ListViewItem item in listViewValues.SelectedItems)
                {
                    int oldIndex = item.Index;

                    if(oldIndex > 0)
                    {
                        listViewValues.Items.RemoveAt(oldIndex);
                        listViewValues.Items.Insert(oldIndex - 1, item);
                    }
                }

                ipChanged = true;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if(listViewValues.Items.Count > 0 && !listViewValues.SelectedItems.Contains(listViewValues.Items[listViewValues.Items.Count - 1]))
            {
                for(int i = listViewValues.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = listViewValues.SelectedItems[i];

                    int oldIndex = item.Index;

                    if(oldIndex < listViewValues.Items.Count - 1)
                    {
                        listViewValues.Items.RemoveAt(oldIndex);
                        listViewValues.Items.Insert(oldIndex + 1, item);
                    }
                }

                ipChanged = true;
            }
        }

        private void listViewValues_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Clicks == 2 && radioButtonValueList.Checked && listViewValues.SelectedItems.Count == 0)  // doubleclick in empty space
            {
                foreach(ListViewItem item in listViewValues.SelectedItems)
                {
                    item.Selected = false;
                }

                ListViewItem newItem = listViewValues.Items.Add("<new value>");

                listViewValues.Update();

                newItem.Selected = true;
                newItem.BeginEdit();

                ipChanged = true;
            }
        }

        private void textBoxRangeStep_TextChanged(object sender, EventArgs e)
        {
            ipChanged = true;
        }
    }
}
