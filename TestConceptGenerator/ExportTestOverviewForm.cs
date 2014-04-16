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
using System.Text.RegularExpressions;


namespace TestConceptGenerator
{
    public partial class ExportTestOverviewForm : Form
    {
        private ConfigurationManager confMan;
        private TestOverviewExporter_Excel exporter;

        private TestConcept tc;

        public ExportTestOverviewForm(TestConcept tc)
        {
            InitializeComponent();

            confMan = ConfigurationManager.getInstance();

            this.tc = tc;

            textBoxTemplatePath.Text = ConfigurationManager.getProgramDir() + confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateSubDir) + confMan.getConfigurationValue(ConfigurationManager.ExcelOverviewTemplateFilename);

            exporter = new TestOverviewExporter_Excel(this.tc);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonNewFile_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNewFile.Checked)
            {
                labelNewPath.Enabled = true;
                textBoxNewPath.Enabled = true;
                buttonNewBrowse.Enabled = true;
                buttonNewExport.Enabled = true;
            }
            else
            {
                labelNewPath.Enabled = false;
                textBoxNewPath.Enabled = false;
                buttonNewBrowse.Enabled = false;
                buttonNewExport.Enabled = false;
            }
        }

        private void radioButtonAppendFile_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAppendFile.Checked)
            {
                labelAppendPath.Enabled = true;
                textBoxAppendPath.Enabled = true;
                buttonAppendBrowse.Enabled = true;
                buttonAppendExport.Enabled = true;
                checkBoxNewFileVersion.Enabled = true;
            }
            else
            {
                labelAppendPath.Enabled = false;
                textBoxAppendPath.Enabled = false;
                buttonAppendBrowse.Enabled = false;
                buttonAppendExport.Enabled = false;
                checkBoxNewFileVersion.Enabled = false;
            }
        }

        private void buttonNewBrowse_Click(object sender, EventArgs e)
        {
            if(saveNewFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxNewPath.Text = saveNewFileDialog.FileName;
            }
        }

        private void buttonNewExport_Click(object sender, EventArgs e)
        {
            if(File.Exists(textBoxNewPath.Text))
            {
                if(MessageBox.Show("The file \"" + textBoxNewPath.Text + "\" already exists. If you proceed, the file will be overwritten and the old contents will be lost. Proceed?", "File already exists", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    File.Delete(textBoxNewPath.Text);
                }
            }

            exporter.exportTestOverview(textBoxNewPath.Text, checkBoxShowAfterExport.Checked);
        }

        private void buttonAppendBrowse_Click(object sender, EventArgs e)
        {
            if(openAppendFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAppendPath.Text = openAppendFileDialog.FileName;
            }
        }

        private void buttonAppendExport_Click(object sender, EventArgs e)
        {
            if(!File.Exists(textBoxAppendPath.Text))
            {
                MessageBox.Show("The file \"" + textBoxAppendPath.Text + "\" does not exist. Please select a file that exists.", "File does not exist", MessageBoxButtons.OK);
                return;
            }

            string outputFilename;

            if(checkBoxNewFileVersion.Checked)
            {
                outputFilename = calculateNextVersionFilename(textBoxAppendPath.Text);
            }
            else
            {
                outputFilename = textBoxAppendPath.Text;
            }

            exporter.appendTestOverview(textBoxAppendPath.Text, outputFilename, checkBoxShowAfterExport.Checked);
        }

        private string calculateNextVersionFilename(string path)
        {
            string newPath;

            string directory = Path.GetDirectoryName(path);
            string oldFilename = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);

            string[] filenameParts = oldFilename.Split(new char[] { '_' });

            string oldVersionPart = null;

            foreach(string filenamePart in filenameParts)
            {
                if(Regex.IsMatch(filenamePart, @"^[v]\d{1,2}[.]\d{1,3}$", RegexOptions.IgnoreCase))
                {
                    oldVersionPart = filenamePart;
                }
            }

            string newFilename;

            if(oldVersionPart != null)
            {
                string oldVersionMajorPart = oldVersionPart.Substring(0, oldVersionPart.LastIndexOf('.') + 1);
                string oldVersionMinorPart = oldVersionPart.Substring(oldVersionPart.LastIndexOf('.') + 1);

                int minorVersion = int.Parse(oldVersionMinorPart) + 1;

                string newVersionPart = oldVersionMajorPart + minorVersion.ToString();

                newFilename = oldFilename.Replace(oldVersionPart, newVersionPart);
            }
            else
            {
                newFilename = oldFilename + "_v1.0";
            }

            newPath = directory + @"\" + newFilename + extension;

            return newPath;
        }
    }
}
