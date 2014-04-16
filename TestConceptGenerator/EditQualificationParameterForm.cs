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
    public partial class EditQualificationParameterForm : Form
    {
        private QualificationParameter qp;

        private bool qpChanged;

        public EditQualificationParameterForm()
        {
            InitializeComponent();

            qpChanged = false;
        }

        public void setQualificationParameter(QualificationParameter qp)
        {
            this.qp = qp;

            textBoxName.Text = qp.name;
            textBoxDescription.Text = qp.description;
            textBoxRemarks.Text = qp.remarks;

            switch(qp.type)
            {
                case QualificationParameterType.None:
                    break;

                case QualificationParameterType.Min:
                    radioButtonMin.Checked = true;
                    textBoxMin.Text = qp.getMinValue();
                    break;

                case QualificationParameterType.Max:
                    radioButtonMax.Checked = true;
                    textBoxRangeMax.Text = qp.getMaxValue();
                    break;

                case QualificationParameterType.MinMax:
                    radioButtonMinMax.Checked = true;
                    textBoxRangeMin.Text = qp.getMinValue();
                    textBoxRangeMax.Text = qp.getMaxValue();
                    break;

                case QualificationParameterType.ValueDev:
                    radioButtonDeviation.Checked = true;
                    textBoxMean.Text = qp.getMeanValue();
                    textBoxDeviation.Text = qp.getDeviationValue();
                    break;
            }

            qpChanged = false;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(qpChanged)
            {
                if(MessageBox.Show("Parameter has changed. If you process, these changes will be lost! Proceed?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            qp.isSet = false;

            if(radioButtonMin.Checked)
            {
                qp.type = QualificationParameterType.Min;
                qp.setMinValue(textBoxMin.Text);

                if(textBoxMin.Text.Length > 0)
                    qp.isSet = true;
            }
            else if(radioButtonMax.Checked)
            {
                qp.type = QualificationParameterType.Max;
                qp.setMaxValue(textBoxMax.Text);

                if(textBoxMax.Text.Length > 0)
                    qp.isSet = true;
            }
            else if(radioButtonMinMax.Checked)
            {
                qp.type = QualificationParameterType.MinMax;
                qp.setMinMaxValue(textBoxRangeMin.Text, textBoxRangeMax.Text);

                if(textBoxRangeMin.Text.Length > 0 || textBoxRangeMax.Text.Length > 0)
                    qp.isSet = true;
            }
            else if(radioButtonDeviation.Checked)
            {
                qp.type = QualificationParameterType.ValueDev;
                qp.setValueDevValue(textBoxMean.Text, textBoxDeviation.Text);

                if(textBoxMean.Text.Length > 0 || textBoxDeviation.Text.Length > 0)
                    qp.isSet = true;
            }

            qp.remarks = textBoxRemarks.Text;

            qpChanged = false;

            this.Close();
        }

        private void textBoxRangeMin_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void textBoxRangeMax_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void radioButtonMin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMin.Checked)
            {
                textBoxMin.Enabled = true;
            }
            else
            {
                textBoxMin.Enabled = false;
            }

            qpChanged = true;
        }

        private void radioButtonMax_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMax.Checked)
            {
                textBoxMax.Enabled = true;
            }
            else
            {
                textBoxMax.Enabled = false;
            }

            qpChanged = true;
        }

        private void radioButtonDeviation_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMinMax.Checked)
            {
                labelRangeTo.Enabled = true;
                textBoxRangeMin.Enabled = true;
                textBoxRangeMax.Enabled = true;
            }
            else
            {
                labelRangeTo.Enabled = false;
                textBoxRangeMin.Enabled = false;
                textBoxRangeMax.Enabled = false;
            }

            qpChanged = true;
        }

        private void radioButtonMinMax_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDeviation.Checked)
            {
                labelDeviation.Enabled = true;
                textBoxMean.Enabled = true;
                textBoxDeviation.Enabled = true;
            }
            else
            {
                labelDeviation.Enabled = false;
                textBoxMean.Enabled = false;
                textBoxDeviation.Enabled = false;
            }

            qpChanged = true;
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void textBoxMean_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void textBoxDeviation_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {
            qpChanged = true;
        }
    }
}
