namespace TestConceptGenerator
{
    partial class AddTPForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditParams = new System.Windows.Forms.Button();
            this.buttonShowTP = new System.Windows.Forms.Button();
            this.groupBoxCatalog = new System.Windows.Forms.GroupBox();
            this.textBoxTPCatalog = new System.Windows.Forms.TextBox();
            this.groupBoxProcedures = new System.Windows.Forms.GroupBox();
            this.treeViewParams = new System.Windows.Forms.TreeView();
            this.labelParameters = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.treeViewTPs = new System.Windows.Forms.TreeView();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTestPoints = new System.Windows.Forms.Label();
            this.textBoxTestPoints = new System.Windows.Forms.TextBox();
            this.checkBoxFirmware = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.textBoxResponsible = new System.Windows.Forms.TextBox();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.labelDurationMin = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelFirmwareName = new System.Windows.Forms.Label();
            this.labelFirmwarePath = new System.Windows.Forms.Label();
            this.textBoxFirmwareName = new System.Windows.Forms.TextBox();
            this.textBoxFirmwarePath = new System.Windows.Forms.TextBox();
            this.buttonFirmwareBrowse = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.labelNrDUTs = new System.Windows.Forms.Label();
            this.numericUpDownNrDUTs = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCatalog.SuspendLayout();
            this.groupBoxProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrDUTs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(256, 667);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(360, 667);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEditParams
            // 
            this.buttonEditParams.Enabled = false;
            this.buttonEditParams.Location = new System.Drawing.Point(60, 564);
            this.buttonEditParams.Name = "buttonEditParams";
            this.buttonEditParams.Size = new System.Drawing.Size(201, 23);
            this.buttonEditParams.TabIndex = 2;
            this.buttonEditParams.Text = "Edit Parameter...";
            this.buttonEditParams.UseVisualStyleBackColor = true;
            this.buttonEditParams.Click += new System.EventHandler(this.buttonEditParams_Click);
            // 
            // buttonShowTP
            // 
            this.buttonShowTP.Location = new System.Drawing.Point(64, 564);
            this.buttonShowTP.Name = "buttonShowTP";
            this.buttonShowTP.Size = new System.Drawing.Size(194, 23);
            this.buttonShowTP.TabIndex = 3;
            this.buttonShowTP.Text = "Show Test Procedure in Word";
            this.buttonShowTP.UseVisualStyleBackColor = true;
            this.buttonShowTP.Click += new System.EventHandler(this.buttonShowTP_Click);
            // 
            // groupBoxCatalog
            // 
            this.groupBoxCatalog.Controls.Add(this.textBoxTPCatalog);
            this.groupBoxCatalog.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCatalog.Name = "groupBoxCatalog";
            this.groupBoxCatalog.Size = new System.Drawing.Size(664, 48);
            this.groupBoxCatalog.TabIndex = 5;
            this.groupBoxCatalog.TabStop = false;
            this.groupBoxCatalog.Text = "Test Procedures Catalog";
            // 
            // textBoxTPCatalog
            // 
            this.textBoxTPCatalog.Location = new System.Drawing.Point(7, 20);
            this.textBoxTPCatalog.Name = "textBoxTPCatalog";
            this.textBoxTPCatalog.ReadOnly = true;
            this.textBoxTPCatalog.Size = new System.Drawing.Size(651, 20);
            this.textBoxTPCatalog.TabIndex = 0;
            // 
            // groupBoxProcedures
            // 
            this.groupBoxProcedures.Controls.Add(this.buttonShowTP);
            this.groupBoxProcedures.Controls.Add(this.textBoxDescription);
            this.groupBoxProcedures.Controls.Add(this.labelDescription);
            this.groupBoxProcedures.Controls.Add(this.treeViewTPs);
            this.groupBoxProcedures.Location = new System.Drawing.Point(13, 68);
            this.groupBoxProcedures.Name = "groupBoxProcedures";
            this.groupBoxProcedures.Size = new System.Drawing.Size(327, 593);
            this.groupBoxProcedures.TabIndex = 6;
            this.groupBoxProcedures.TabStop = false;
            this.groupBoxProcedures.Text = "Select Test Procedure(s)";
            // 
            // treeViewParams
            // 
            this.treeViewParams.Enabled = false;
            this.treeViewParams.HideSelection = false;
            this.treeViewParams.Location = new System.Drawing.Point(9, 378);
            this.treeViewParams.Name = "treeViewParams";
            this.treeViewParams.ShowNodeToolTips = true;
            this.treeViewParams.Size = new System.Drawing.Size(308, 180);
            this.treeViewParams.TabIndex = 6;
            this.treeViewParams.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewParams_AfterSelect);
            this.treeViewParams.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewParams_MouseDoubleClick);
            // 
            // labelParameters
            // 
            this.labelParameters.AutoSize = true;
            this.labelParameters.Location = new System.Drawing.Point(6, 362);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(63, 13);
            this.labelParameters.TabIndex = 5;
            this.labelParameters.Text = "Parameters:";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Enabled = false;
            this.textBoxRemarks.Location = new System.Drawing.Point(9, 292);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(308, 58);
            this.textBoxRemarks.TabIndex = 4;
            this.textBoxRemarks.TextChanged += new System.EventHandler(this.textBoxRemarks_TextChanged);
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(6, 276);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(52, 13);
            this.labelRemarks.TabIndex = 3;
            this.labelRemarks.Text = "Remarks:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(7, 500);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(311, 58);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(4, 484);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description:";
            // 
            // treeViewTPs
            // 
            this.treeViewTPs.CheckBoxes = true;
            this.treeViewTPs.HideSelection = false;
            this.treeViewTPs.Location = new System.Drawing.Point(7, 20);
            this.treeViewTPs.Name = "treeViewTPs";
            this.treeViewTPs.ShowNodeToolTips = true;
            this.treeViewTPs.Size = new System.Drawing.Size(311, 447);
            this.treeViewTPs.TabIndex = 0;
            this.treeViewTPs.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewTPs_BeforeCheck);
            this.treeViewTPs.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTPs_AfterCheck);
            this.treeViewTPs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTPs_AfterSelect);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Enabled = false;
            this.labelPriority.Location = new System.Drawing.Point(6, 20);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(41, 13);
            this.labelPriority.TabIndex = 7;
            this.labelPriority.Text = "Priority:";
            // 
            // labelResponsible
            // 
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Enabled = false;
            this.labelResponsible.Location = new System.Drawing.Point(164, 20);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(68, 13);
            this.labelResponsible.TabIndex = 8;
            this.labelResponsible.Text = "Responsible:";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Enabled = false;
            this.labelDueDate.Location = new System.Drawing.Point(164, 46);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(56, 13);
            this.labelDueDate.TabIndex = 9;
            this.labelDueDate.Text = "Due Date:";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Enabled = false;
            this.labelDuration.Location = new System.Drawing.Point(6, 46);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 10;
            this.labelDuration.Text = "Duration:";
            // 
            // labelTestPoints
            // 
            this.labelTestPoints.AutoSize = true;
            this.labelTestPoints.Enabled = false;
            this.labelTestPoints.Location = new System.Drawing.Point(6, 193);
            this.labelTestPoints.Name = "labelTestPoints";
            this.labelTestPoints.Size = new System.Drawing.Size(140, 13);
            this.labelTestPoints.TabIndex = 11;
            this.labelTestPoints.Text = "Test Points and Description:";
            // 
            // textBoxTestPoints
            // 
            this.textBoxTestPoints.Enabled = false;
            this.textBoxTestPoints.Location = new System.Drawing.Point(9, 209);
            this.textBoxTestPoints.Multiline = true;
            this.textBoxTestPoints.Name = "textBoxTestPoints";
            this.textBoxTestPoints.Size = new System.Drawing.Size(308, 58);
            this.textBoxTestPoints.TabIndex = 12;
            this.textBoxTestPoints.TextChanged += new System.EventHandler(this.textBoxTestPoints_TextChanged);
            // 
            // checkBoxFirmware
            // 
            this.checkBoxFirmware.AutoSize = true;
            this.checkBoxFirmware.Enabled = false;
            this.checkBoxFirmware.Location = new System.Drawing.Point(9, 107);
            this.checkBoxFirmware.Name = "checkBoxFirmware";
            this.checkBoxFirmware.Size = new System.Drawing.Size(147, 17);
            this.checkBoxFirmware.TabIndex = 13;
            this.checkBoxFirmware.Text = "Special Firmware Needed";
            this.checkBoxFirmware.UseVisualStyleBackColor = true;
            this.checkBoxFirmware.CheckedChanged += new System.EventHandler(this.checkBoxFirmware_CheckedChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Enabled = false;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "very high",
            "high",
            "normal",
            "low",
            "very low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(62, 17);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(84, 21);
            this.comboBoxPriority.TabIndex = 14;
            this.comboBoxPriority.SelectedIndexChanged += new System.EventHandler(this.comboBoxPriority_SelectedIndexChanged);
            // 
            // textBoxResponsible
            // 
            this.textBoxResponsible.Enabled = false;
            this.textBoxResponsible.Location = new System.Drawing.Point(238, 17);
            this.textBoxResponsible.Name = "textBoxResponsible";
            this.textBoxResponsible.Size = new System.Drawing.Size(79, 20);
            this.textBoxResponsible.TabIndex = 15;
            this.textBoxResponsible.TextChanged += new System.EventHandler(this.textBoxResponsible_TextChanged);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Enabled = false;
            this.numericUpDownDuration.Location = new System.Drawing.Point(62, 44);
            this.numericUpDownDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDuration.TabIndex = 16;
            this.numericUpDownDuration.ValueChanged += new System.EventHandler(this.numericUpDownDuration_ValueChanged);
            // 
            // labelDurationMin
            // 
            this.labelDurationMin.AutoSize = true;
            this.labelDurationMin.Enabled = false;
            this.labelDurationMin.Location = new System.Drawing.Point(123, 46);
            this.labelDurationMin.Name = "labelDurationMin";
            this.labelDurationMin.Size = new System.Drawing.Size(23, 13);
            this.labelDurationMin.TabIndex = 17;
            this.labelDurationMin.Text = "min";
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Enabled = false;
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(238, 43);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerDueDate.TabIndex = 19;
            this.dateTimePickerDueDate.ValueChanged += new System.EventHandler(this.dateTimePickerDueDate_ValueChanged);
            // 
            // labelFirmwareName
            // 
            this.labelFirmwareName.AutoSize = true;
            this.labelFirmwareName.Enabled = false;
            this.labelFirmwareName.Location = new System.Drawing.Point(9, 131);
            this.labelFirmwareName.Name = "labelFirmwareName";
            this.labelFirmwareName.Size = new System.Drawing.Size(96, 13);
            this.labelFirmwareName.TabIndex = 20;
            this.labelFirmwareName.Text = "Name/Description:";
            // 
            // labelFirmwarePath
            // 
            this.labelFirmwarePath.AutoSize = true;
            this.labelFirmwarePath.Enabled = false;
            this.labelFirmwarePath.Location = new System.Drawing.Point(9, 158);
            this.labelFirmwarePath.Name = "labelFirmwarePath";
            this.labelFirmwarePath.Size = new System.Drawing.Size(79, 13);
            this.labelFirmwarePath.TabIndex = 21;
            this.labelFirmwarePath.Text = "Filename/Path:";
            // 
            // textBoxFirmwareName
            // 
            this.textBoxFirmwareName.Enabled = false;
            this.textBoxFirmwareName.Location = new System.Drawing.Point(111, 128);
            this.textBoxFirmwareName.Name = "textBoxFirmwareName";
            this.textBoxFirmwareName.Size = new System.Drawing.Size(206, 20);
            this.textBoxFirmwareName.TabIndex = 22;
            this.textBoxFirmwareName.TextChanged += new System.EventHandler(this.textBoxFirmwareName_TextChanged);
            // 
            // textBoxFirmwarePath
            // 
            this.textBoxFirmwarePath.Enabled = false;
            this.textBoxFirmwarePath.Location = new System.Drawing.Point(111, 155);
            this.textBoxFirmwarePath.Name = "textBoxFirmwarePath";
            this.textBoxFirmwarePath.Size = new System.Drawing.Size(149, 20);
            this.textBoxFirmwarePath.TabIndex = 23;
            this.textBoxFirmwarePath.TextChanged += new System.EventHandler(this.textBoxFirmwarePath_TextChanged);
            // 
            // buttonFirmwareBrowse
            // 
            this.buttonFirmwareBrowse.Enabled = false;
            this.buttonFirmwareBrowse.Location = new System.Drawing.Point(266, 153);
            this.buttonFirmwareBrowse.Name = "buttonFirmwareBrowse";
            this.buttonFirmwareBrowse.Size = new System.Drawing.Size(51, 23);
            this.buttonFirmwareBrowse.TabIndex = 24;
            this.buttonFirmwareBrowse.Text = "Browse";
            this.buttonFirmwareBrowse.UseVisualStyleBackColor = true;
            this.buttonFirmwareBrowse.Click += new System.EventHandler(this.buttonFirmwareBrowse_Click);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.numericUpDownNrDUTs);
            this.groupBoxControls.Controls.Add(this.labelNrDUTs);
            this.groupBoxControls.Controls.Add(this.buttonFirmwareBrowse);
            this.groupBoxControls.Controls.Add(this.labelPriority);
            this.groupBoxControls.Controls.Add(this.textBoxFirmwarePath);
            this.groupBoxControls.Controls.Add(this.labelRemarks);
            this.groupBoxControls.Controls.Add(this.textBoxFirmwareName);
            this.groupBoxControls.Controls.Add(this.textBoxRemarks);
            this.groupBoxControls.Controls.Add(this.labelFirmwarePath);
            this.groupBoxControls.Controls.Add(this.buttonEditParams);
            this.groupBoxControls.Controls.Add(this.labelFirmwareName);
            this.groupBoxControls.Controls.Add(this.labelParameters);
            this.groupBoxControls.Controls.Add(this.dateTimePickerDueDate);
            this.groupBoxControls.Controls.Add(this.treeViewParams);
            this.groupBoxControls.Controls.Add(this.labelDurationMin);
            this.groupBoxControls.Controls.Add(this.labelResponsible);
            this.groupBoxControls.Controls.Add(this.numericUpDownDuration);
            this.groupBoxControls.Controls.Add(this.labelDueDate);
            this.groupBoxControls.Controls.Add(this.textBoxResponsible);
            this.groupBoxControls.Controls.Add(this.labelDuration);
            this.groupBoxControls.Controls.Add(this.comboBoxPriority);
            this.groupBoxControls.Controls.Add(this.labelTestPoints);
            this.groupBoxControls.Controls.Add(this.checkBoxFirmware);
            this.groupBoxControls.Controls.Add(this.textBoxTestPoints);
            this.groupBoxControls.Location = new System.Drawing.Point(351, 68);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(326, 593);
            this.groupBoxControls.TabIndex = 7;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Test Procedure Settings";
            // 
            // labelNrDUTs
            // 
            this.labelNrDUTs.AutoSize = true;
            this.labelNrDUTs.Enabled = false;
            this.labelNrDUTs.Location = new System.Drawing.Point(6, 72);
            this.labelNrDUTs.Name = "labelNrDUTs";
            this.labelNrDUTs.Size = new System.Drawing.Size(45, 13);
            this.labelNrDUTs.TabIndex = 25;
            this.labelNrDUTs.Text = "#DUTs:";
            // 
            // numericUpDownNrDUTs
            // 
            this.numericUpDownNrDUTs.Location = new System.Drawing.Point(62, 70);
            this.numericUpDownNrDUTs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNrDUTs.Name = "numericUpDownNrDUTs";
            this.numericUpDownNrDUTs.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownNrDUTs.TabIndex = 26;
            this.numericUpDownNrDUTs.ValueChanged += new System.EventHandler(this.numericUpDownNrDUTs_ValueChanged);
            // 
            // AddTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 702);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxProcedures);
            this.Controls.Add(this.groupBoxCatalog);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTPForm";
            this.Text = "Add Test Procedure(s) to Test Concept";
            this.groupBoxCatalog.ResumeLayout(false);
            this.groupBoxCatalog.PerformLayout();
            this.groupBoxProcedures.ResumeLayout(false);
            this.groupBoxProcedures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrDUTs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditParams;
        private System.Windows.Forms.Button buttonShowTP;
        private System.Windows.Forms.GroupBox groupBoxCatalog;
        private System.Windows.Forms.TextBox textBoxTPCatalog;
        private System.Windows.Forms.GroupBox groupBoxProcedures;
        private System.Windows.Forms.TreeView treeViewParams;
        private System.Windows.Forms.Label labelParameters;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TreeView treeViewTPs;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label labelDurationMin;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.TextBox textBoxResponsible;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.CheckBox checkBoxFirmware;
        private System.Windows.Forms.TextBox textBoxTestPoints;
        private System.Windows.Forms.Label labelTestPoints;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelResponsible;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Button buttonFirmwareBrowse;
        private System.Windows.Forms.TextBox textBoxFirmwarePath;
        private System.Windows.Forms.TextBox textBoxFirmwareName;
        private System.Windows.Forms.Label labelFirmwarePath;
        private System.Windows.Forms.Label labelFirmwareName;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.NumericUpDown numericUpDownNrDUTs;
        private System.Windows.Forms.Label labelNrDUTs;
    }
}