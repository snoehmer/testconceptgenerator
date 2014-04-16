namespace TestConceptGenerator
{
    partial class ExportTestOverviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.radioButtonNewFile = new System.Windows.Forms.RadioButton();
            this.radioButtonAppendFile = new System.Windows.Forms.RadioButton();
            this.groupBoxTemplate = new System.Windows.Forms.GroupBox();
            this.labelTemplatePath = new System.Windows.Forms.Label();
            this.textBoxTemplatePath = new System.Windows.Forms.TextBox();
            this.buttonConfigureTemplate = new System.Windows.Forms.Button();
            this.buttonBrowseTemplate = new System.Windows.Forms.Button();
            this.labelNewPath = new System.Windows.Forms.Label();
            this.textBoxNewPath = new System.Windows.Forms.TextBox();
            this.buttonNewBrowse = new System.Windows.Forms.Button();
            this.buttonNewExport = new System.Windows.Forms.Button();
            this.labelAppendPath = new System.Windows.Forms.Label();
            this.textBoxAppendPath = new System.Windows.Forms.TextBox();
            this.buttonAppendBrowse = new System.Windows.Forms.Button();
            this.buttonAppendExport = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxShowAfterExport = new System.Windows.Forms.CheckBox();
            this.openAppendFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveNewFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxNewFileVersion = new System.Windows.Forms.CheckBox();
            this.groupBoxExport.SuspendLayout();
            this.groupBoxTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.checkBoxNewFileVersion);
            this.groupBoxExport.Controls.Add(this.checkBoxShowAfterExport);
            this.groupBoxExport.Controls.Add(this.buttonAppendExport);
            this.groupBoxExport.Controls.Add(this.buttonAppendBrowse);
            this.groupBoxExport.Controls.Add(this.textBoxAppendPath);
            this.groupBoxExport.Controls.Add(this.labelAppendPath);
            this.groupBoxExport.Controls.Add(this.buttonNewExport);
            this.groupBoxExport.Controls.Add(this.buttonNewBrowse);
            this.groupBoxExport.Controls.Add(this.textBoxNewPath);
            this.groupBoxExport.Controls.Add(this.labelNewPath);
            this.groupBoxExport.Controls.Add(this.radioButtonAppendFile);
            this.groupBoxExport.Controls.Add(this.radioButtonNewFile);
            this.groupBoxExport.Location = new System.Drawing.Point(13, 115);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(576, 224);
            this.groupBoxExport.TabIndex = 0;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export Options";
            // 
            // radioButtonNewFile
            // 
            this.radioButtonNewFile.AutoSize = true;
            this.radioButtonNewFile.Checked = true;
            this.radioButtonNewFile.Location = new System.Drawing.Point(6, 53);
            this.radioButtonNewFile.Name = "radioButtonNewFile";
            this.radioButtonNewFile.Size = new System.Drawing.Size(166, 17);
            this.radioButtonNewFile.TabIndex = 0;
            this.radioButtonNewFile.TabStop = true;
            this.radioButtonNewFile.Text = "Generate New Test Overview";
            this.radioButtonNewFile.UseVisualStyleBackColor = true;
            this.radioButtonNewFile.CheckedChanged += new System.EventHandler(this.radioButtonNewFile_CheckedChanged);
            // 
            // radioButtonAppendFile
            // 
            this.radioButtonAppendFile.AutoSize = true;
            this.radioButtonAppendFile.Location = new System.Drawing.Point(6, 139);
            this.radioButtonAppendFile.Name = "radioButtonAppendFile";
            this.radioButtonAppendFile.Size = new System.Drawing.Size(185, 17);
            this.radioButtonAppendFile.TabIndex = 1;
            this.radioButtonAppendFile.Text = "Append to Existing Test Overview";
            this.radioButtonAppendFile.UseVisualStyleBackColor = true;
            this.radioButtonAppendFile.CheckedChanged += new System.EventHandler(this.radioButtonAppendFile_CheckedChanged);
            // 
            // groupBoxTemplate
            // 
            this.groupBoxTemplate.Controls.Add(this.buttonBrowseTemplate);
            this.groupBoxTemplate.Controls.Add(this.buttonConfigureTemplate);
            this.groupBoxTemplate.Controls.Add(this.textBoxTemplatePath);
            this.groupBoxTemplate.Controls.Add(this.labelTemplatePath);
            this.groupBoxTemplate.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTemplate.Name = "groupBoxTemplate";
            this.groupBoxTemplate.Size = new System.Drawing.Size(576, 96);
            this.groupBoxTemplate.TabIndex = 1;
            this.groupBoxTemplate.TabStop = false;
            this.groupBoxTemplate.Text = "Excel Template";
            // 
            // labelTemplatePath
            // 
            this.labelTemplatePath.AutoSize = true;
            this.labelTemplatePath.Location = new System.Drawing.Point(7, 20);
            this.labelTemplatePath.Name = "labelTemplatePath";
            this.labelTemplatePath.Size = new System.Drawing.Size(218, 13);
            this.labelTemplatePath.TabIndex = 0;
            this.labelTemplatePath.Text = "Path to used Test Overview Excel Template:";
            // 
            // textBoxTemplatePath
            // 
            this.textBoxTemplatePath.Location = new System.Drawing.Point(10, 38);
            this.textBoxTemplatePath.Name = "textBoxTemplatePath";
            this.textBoxTemplatePath.ReadOnly = true;
            this.textBoxTemplatePath.Size = new System.Drawing.Size(559, 20);
            this.textBoxTemplatePath.TabIndex = 1;
            // 
            // buttonConfigureTemplate
            // 
            this.buttonConfigureTemplate.Enabled = false;
            this.buttonConfigureTemplate.Location = new System.Drawing.Point(494, 64);
            this.buttonConfigureTemplate.Name = "buttonConfigureTemplate";
            this.buttonConfigureTemplate.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigureTemplate.TabIndex = 2;
            this.buttonConfigureTemplate.Text = "Configure";
            this.buttonConfigureTemplate.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseTemplate
            // 
            this.buttonBrowseTemplate.Enabled = false;
            this.buttonBrowseTemplate.Location = new System.Drawing.Point(413, 64);
            this.buttonBrowseTemplate.Name = "buttonBrowseTemplate";
            this.buttonBrowseTemplate.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseTemplate.TabIndex = 3;
            this.buttonBrowseTemplate.Text = "Browse";
            this.buttonBrowseTemplate.UseVisualStyleBackColor = true;
            // 
            // labelNewPath
            // 
            this.labelNewPath.AutoSize = true;
            this.labelNewPath.Location = new System.Drawing.Point(10, 80);
            this.labelNewPath.Name = "labelNewPath";
            this.labelNewPath.Size = new System.Drawing.Size(32, 13);
            this.labelNewPath.TabIndex = 2;
            this.labelNewPath.Text = "Path:";
            // 
            // textBoxNewPath
            // 
            this.textBoxNewPath.Location = new System.Drawing.Point(48, 77);
            this.textBoxNewPath.Name = "textBoxNewPath";
            this.textBoxNewPath.Size = new System.Drawing.Size(440, 20);
            this.textBoxNewPath.TabIndex = 3;
            // 
            // buttonNewBrowse
            // 
            this.buttonNewBrowse.Location = new System.Drawing.Point(494, 75);
            this.buttonNewBrowse.Name = "buttonNewBrowse";
            this.buttonNewBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonNewBrowse.TabIndex = 4;
            this.buttonNewBrowse.Text = "Browse";
            this.buttonNewBrowse.UseVisualStyleBackColor = true;
            this.buttonNewBrowse.Click += new System.EventHandler(this.buttonNewBrowse_Click);
            // 
            // buttonNewExport
            // 
            this.buttonNewExport.Location = new System.Drawing.Point(412, 104);
            this.buttonNewExport.Name = "buttonNewExport";
            this.buttonNewExport.Size = new System.Drawing.Size(157, 23);
            this.buttonNewExport.TabIndex = 5;
            this.buttonNewExport.Text = "Generate Test Overview";
            this.buttonNewExport.UseVisualStyleBackColor = true;
            this.buttonNewExport.Click += new System.EventHandler(this.buttonNewExport_Click);
            // 
            // labelAppendPath
            // 
            this.labelAppendPath.AutoSize = true;
            this.labelAppendPath.Enabled = false;
            this.labelAppendPath.Location = new System.Drawing.Point(11, 166);
            this.labelAppendPath.Name = "labelAppendPath";
            this.labelAppendPath.Size = new System.Drawing.Size(32, 13);
            this.labelAppendPath.TabIndex = 6;
            this.labelAppendPath.Text = "Path:";
            // 
            // textBoxAppendPath
            // 
            this.textBoxAppendPath.Enabled = false;
            this.textBoxAppendPath.Location = new System.Drawing.Point(49, 163);
            this.textBoxAppendPath.Name = "textBoxAppendPath";
            this.textBoxAppendPath.Size = new System.Drawing.Size(440, 20);
            this.textBoxAppendPath.TabIndex = 7;
            // 
            // buttonAppendBrowse
            // 
            this.buttonAppendBrowse.Enabled = false;
            this.buttonAppendBrowse.Location = new System.Drawing.Point(495, 161);
            this.buttonAppendBrowse.Name = "buttonAppendBrowse";
            this.buttonAppendBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonAppendBrowse.TabIndex = 8;
            this.buttonAppendBrowse.Text = "Browse";
            this.buttonAppendBrowse.UseVisualStyleBackColor = true;
            this.buttonAppendBrowse.Click += new System.EventHandler(this.buttonAppendBrowse_Click);
            // 
            // buttonAppendExport
            // 
            this.buttonAppendExport.Enabled = false;
            this.buttonAppendExport.Location = new System.Drawing.Point(413, 190);
            this.buttonAppendExport.Name = "buttonAppendExport";
            this.buttonAppendExport.Size = new System.Drawing.Size(157, 23);
            this.buttonAppendExport.TabIndex = 9;
            this.buttonAppendExport.Text = "Append to Test Overview";
            this.buttonAppendExport.UseVisualStyleBackColor = true;
            this.buttonAppendExport.Click += new System.EventHandler(this.buttonAppendExport_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(514, 345);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxShowAfterExport
            // 
            this.checkBoxShowAfterExport.AutoSize = true;
            this.checkBoxShowAfterExport.Checked = true;
            this.checkBoxShowAfterExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowAfterExport.Location = new System.Drawing.Point(6, 20);
            this.checkBoxShowAfterExport.Name = "checkBoxShowAfterExport";
            this.checkBoxShowAfterExport.Size = new System.Drawing.Size(202, 17);
            this.checkBoxShowAfterExport.TabIndex = 10;
            this.checkBoxShowAfterExport.Text = "Show Test Overview File After Export";
            this.checkBoxShowAfterExport.UseVisualStyleBackColor = true;
            // 
            // openAppendFileDialog
            // 
            this.openAppendFileDialog.Filter = "Test Overview Excel File (*.xlsm)|*.xlsm";
            this.openAppendFileDialog.Title = "Select Test Overview Excel File to Append";
            // 
            // saveNewFileDialog
            // 
            this.saveNewFileDialog.DefaultExt = "xlsm";
            this.saveNewFileDialog.FileName = "Test_Overview_RFRTx00x_v1.0.xlsm";
            this.saveNewFileDialog.Filter = "Test Overview Excel Files|*.xlsm";
            this.saveNewFileDialog.Title = "Select Test Overview Excel File Name and Location";
            // 
            // checkBoxNewFileVersion
            // 
            this.checkBoxNewFileVersion.AutoSize = true;
            this.checkBoxNewFileVersion.Enabled = false;
            this.checkBoxNewFileVersion.Location = new System.Drawing.Point(14, 194);
            this.checkBoxNewFileVersion.Name = "checkBoxNewFileVersion";
            this.checkBoxNewFileVersion.Size = new System.Drawing.Size(251, 17);
            this.checkBoxNewFileVersion.TabIndex = 11;
            this.checkBoxNewFileVersion.Text = "Create New File with Increased Version Number";
            this.checkBoxNewFileVersion.UseVisualStyleBackColor = true;
            // 
            // ExportTestOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 377);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxTemplate);
            this.Controls.Add(this.groupBoxExport);
            this.Name = "ExportTestOverviewForm";
            this.Text = "Export Test Overview To Excel";
            this.groupBoxExport.ResumeLayout(false);
            this.groupBoxExport.PerformLayout();
            this.groupBoxTemplate.ResumeLayout(false);
            this.groupBoxTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.Button buttonAppendExport;
        private System.Windows.Forms.Button buttonAppendBrowse;
        private System.Windows.Forms.TextBox textBoxAppendPath;
        private System.Windows.Forms.Label labelAppendPath;
        private System.Windows.Forms.Button buttonNewExport;
        private System.Windows.Forms.Button buttonNewBrowse;
        private System.Windows.Forms.TextBox textBoxNewPath;
        private System.Windows.Forms.Label labelNewPath;
        private System.Windows.Forms.RadioButton radioButtonAppendFile;
        private System.Windows.Forms.RadioButton radioButtonNewFile;
        private System.Windows.Forms.GroupBox groupBoxTemplate;
        private System.Windows.Forms.Button buttonBrowseTemplate;
        private System.Windows.Forms.Button buttonConfigureTemplate;
        private System.Windows.Forms.TextBox textBoxTemplatePath;
        private System.Windows.Forms.Label labelTemplatePath;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxShowAfterExport;
        private System.Windows.Forms.CheckBox checkBoxNewFileVersion;
        private System.Windows.Forms.OpenFileDialog openAppendFileDialog;
        private System.Windows.Forms.SaveFileDialog saveNewFileDialog;
    }
}