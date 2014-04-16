namespace TestConceptGenerator
{
    partial class EditTPForm
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.treeViewParams = new System.Windows.Forms.TreeView();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.numericUpDownNrDUTs = new System.Windows.Forms.NumericUpDown();
            this.labelNrDUTs = new System.Windows.Forms.Label();
            this.buttonFirmwareBrowse = new System.Windows.Forms.Button();
            this.labelPriority = new System.Windows.Forms.Label();
            this.textBoxFirmwarePath = new System.Windows.Forms.TextBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxFirmwareName = new System.Windows.Forms.TextBox();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelFirmwarePath = new System.Windows.Forms.Label();
            this.labelFirmwareName = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDurationMin = new System.Windows.Forms.Label();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBoxResponsible = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelTestPoints = new System.Windows.Forms.Label();
            this.checkBoxFirmware = new System.Windows.Forms.CheckBox();
            this.textBoxTestPoints = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelSetup = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxSetup = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelTPname = new System.Windows.Forms.Label();
            this.labelTPnr = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrDUTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(630, 608);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(711, 608);
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
            this.buttonEditParams.Location = new System.Drawing.Point(293, 328);
            this.buttonEditParams.Name = "buttonEditParams";
            this.buttonEditParams.Size = new System.Drawing.Size(141, 23);
            this.buttonEditParams.TabIndex = 2;
            this.buttonEditParams.Text = "Edit Parameter...";
            this.buttonEditParams.UseVisualStyleBackColor = true;
            this.buttonEditParams.Click += new System.EventHandler(this.buttonEditParams_Click);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.treeViewParams);
            this.groupBoxParameters.Controls.Add(this.buttonEditParams);
            this.groupBoxParameters.Location = new System.Drawing.Point(344, 245);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(442, 357);
            this.groupBoxParameters.TabIndex = 6;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Test Procedure Parameters";
            // 
            // treeViewParams
            // 
            this.treeViewParams.HideSelection = false;
            this.treeViewParams.Location = new System.Drawing.Point(6, 19);
            this.treeViewParams.Name = "treeViewParams";
            this.treeViewParams.ShowNodeToolTips = true;
            this.treeViewParams.Size = new System.Drawing.Size(428, 303);
            this.treeViewParams.TabIndex = 6;
            this.treeViewParams.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewParams_AfterSelect);
            this.treeViewParams.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewParams_MouseDoubleClick);
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
            this.groupBoxControls.Controls.Add(this.labelFirmwareName);
            this.groupBoxControls.Controls.Add(this.dateTimePickerDueDate);
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
            this.groupBoxControls.Location = new System.Drawing.Point(12, 245);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(326, 357);
            this.groupBoxControls.TabIndex = 8;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Test Procedure Settings";
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
            // labelNrDUTs
            // 
            this.labelNrDUTs.AutoSize = true;
            this.labelNrDUTs.Location = new System.Drawing.Point(6, 72);
            this.labelNrDUTs.Name = "labelNrDUTs";
            this.labelNrDUTs.Size = new System.Drawing.Size(45, 13);
            this.labelNrDUTs.TabIndex = 25;
            this.labelNrDUTs.Text = "#DUTs:";
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
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(6, 20);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(41, 13);
            this.labelPriority.TabIndex = 7;
            this.labelPriority.Text = "Priority:";
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
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(6, 276);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(52, 13);
            this.labelRemarks.TabIndex = 3;
            this.labelRemarks.Text = "Remarks:";
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
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(9, 292);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(308, 58);
            this.textBoxRemarks.TabIndex = 4;
            this.textBoxRemarks.TextChanged += new System.EventHandler(this.textBoxRemarks_TextChanged);
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
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(238, 43);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerDueDate.TabIndex = 19;
            this.dateTimePickerDueDate.ValueChanged += new System.EventHandler(this.dateTimePickerDueDate_ValueChanged);
            // 
            // labelDurationMin
            // 
            this.labelDurationMin.AutoSize = true;
            this.labelDurationMin.Location = new System.Drawing.Point(123, 46);
            this.labelDurationMin.Name = "labelDurationMin";
            this.labelDurationMin.Size = new System.Drawing.Size(23, 13);
            this.labelDurationMin.TabIndex = 17;
            this.labelDurationMin.Text = "min";
            // 
            // labelResponsible
            // 
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Location = new System.Drawing.Point(164, 20);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(68, 13);
            this.labelResponsible.TabIndex = 8;
            this.labelResponsible.Text = "Responsible:";
            // 
            // numericUpDownDuration
            // 
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
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(164, 46);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(56, 13);
            this.labelDueDate.TabIndex = 9;
            this.labelDueDate.Text = "Due Date:";
            // 
            // textBoxResponsible
            // 
            this.textBoxResponsible.Location = new System.Drawing.Point(238, 17);
            this.textBoxResponsible.Name = "textBoxResponsible";
            this.textBoxResponsible.Size = new System.Drawing.Size(79, 20);
            this.textBoxResponsible.TabIndex = 15;
            this.textBoxResponsible.TextChanged += new System.EventHandler(this.textBoxResponsible_TextChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(6, 46);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 10;
            this.labelDuration.Text = "Duration:";
            // 
            // comboBoxPriority
            // 
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
            // labelTestPoints
            // 
            this.labelTestPoints.AutoSize = true;
            this.labelTestPoints.Location = new System.Drawing.Point(6, 193);
            this.labelTestPoints.Name = "labelTestPoints";
            this.labelTestPoints.Size = new System.Drawing.Size(140, 13);
            this.labelTestPoints.TabIndex = 11;
            this.labelTestPoints.Text = "Test Points and Description:";
            // 
            // checkBoxFirmware
            // 
            this.checkBoxFirmware.AutoSize = true;
            this.checkBoxFirmware.Location = new System.Drawing.Point(9, 107);
            this.checkBoxFirmware.Name = "checkBoxFirmware";
            this.checkBoxFirmware.Size = new System.Drawing.Size(147, 17);
            this.checkBoxFirmware.TabIndex = 13;
            this.checkBoxFirmware.Text = "Special Firmware Needed";
            this.checkBoxFirmware.UseVisualStyleBackColor = true;
            this.checkBoxFirmware.CheckedChanged += new System.EventHandler(this.checkBoxFirmware_CheckedChanged);
            // 
            // textBoxTestPoints
            // 
            this.textBoxTestPoints.Location = new System.Drawing.Point(9, 209);
            this.textBoxTestPoints.Multiline = true;
            this.textBoxTestPoints.Name = "textBoxTestPoints";
            this.textBoxTestPoints.Size = new System.Drawing.Size(308, 58);
            this.textBoxTestPoints.TabIndex = 12;
            this.textBoxTestPoints.TextChanged += new System.EventHandler(this.textBoxTestPoints_TextChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelSetup);
            this.groupBoxInfo.Controls.Add(this.labelDescription);
            this.groupBoxInfo.Controls.Add(this.textBoxSetup);
            this.groupBoxInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxInfo.Controls.Add(this.labelTPname);
            this.groupBoxInfo.Controls.Add(this.labelTPnr);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(773, 226);
            this.groupBoxInfo.TabIndex = 9;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Test Procedure Information";
            // 
            // labelSetup
            // 
            this.labelSetup.AutoSize = true;
            this.labelSetup.Location = new System.Drawing.Point(8, 141);
            this.labelSetup.Name = "labelSetup";
            this.labelSetup.Size = new System.Drawing.Size(38, 13);
            this.labelSetup.TabIndex = 5;
            this.labelSetup.Text = "Setup:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 56);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxSetup
            // 
            this.textBoxSetup.Location = new System.Drawing.Point(11, 157);
            this.textBoxSetup.Multiline = true;
            this.textBoxSetup.Name = "textBoxSetup";
            this.textBoxSetup.ReadOnly = true;
            this.textBoxSetup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSetup.Size = new System.Drawing.Size(754, 56);
            this.textBoxSetup.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(11, 72);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(754, 56);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelTPname
            // 
            this.labelTPname.AutoSize = true;
            this.labelTPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPname.Location = new System.Drawing.Point(125, 20);
            this.labelTPname.MaximumSize = new System.Drawing.Size(600, 24);
            this.labelTPname.MinimumSize = new System.Drawing.Size(600, 24);
            this.labelTPname.Name = "labelTPname";
            this.labelTPname.Size = new System.Drawing.Size(600, 24);
            this.labelTPname.TabIndex = 1;
            this.labelTPname.Text = "Procedure Name";
            // 
            // labelTPnr
            // 
            this.labelTPnr.AutoSize = true;
            this.labelTPnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPnr.Location = new System.Drawing.Point(7, 20);
            this.labelTPnr.MaximumSize = new System.Drawing.Size(120, 24);
            this.labelTPnr.MinimumSize = new System.Drawing.Size(100, 24);
            this.labelTPnr.Name = "labelTPnr";
            this.labelTPnr.Size = new System.Drawing.Size(100, 24);
            this.labelTPnr.TabIndex = 0;
            this.labelTPnr.Text = "TPX.X";
            // 
            // EditTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 643);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditTPForm";
            this.Text = "Edit Test Procedure";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrDUTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditParams;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TreeView treeViewParams;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.NumericUpDown numericUpDownNrDUTs;
        private System.Windows.Forms.Label labelNrDUTs;
        private System.Windows.Forms.Button buttonFirmwareBrowse;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.TextBox textBoxFirmwarePath;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TextBox textBoxFirmwareName;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label labelFirmwarePath;
        private System.Windows.Forms.Label labelFirmwareName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label labelDurationMin;
        private System.Windows.Forms.Label labelResponsible;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.TextBox textBoxResponsible;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelTestPoints;
        private System.Windows.Forms.CheckBox checkBoxFirmware;
        private System.Windows.Forms.TextBox textBoxTestPoints;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelSetup;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxSetup;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelTPname;
        private System.Windows.Forms.Label labelTPnr;
    }
}