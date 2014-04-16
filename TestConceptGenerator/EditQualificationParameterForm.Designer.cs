namespace TestConceptGenerator
{
    partial class EditQualificationParameterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDeviation = new System.Windows.Forms.Label();
            this.textBoxDeviation = new System.Windows.Forms.TextBox();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.labelRangeTo = new System.Windows.Forms.Label();
            this.textBoxRangeMax = new System.Windows.Forms.TextBox();
            this.textBoxRangeMin = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.radioButtonDeviation = new System.Windows.Forms.RadioButton();
            this.radioButtonMinMax = new System.Windows.Forms.RadioButton();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(122, 307);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 307);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRemarks);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Information";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(77, 100);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(292, 49);
            this.textBoxRemarks.TabIndex = 5;
            this.textBoxRemarks.TextChanged += new System.EventHandler(this.textBoxRemarks_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(77, 45);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(292, 49);
            this.textBoxDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remarks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(292, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDeviation);
            this.groupBox2.Controls.Add(this.textBoxDeviation);
            this.groupBox2.Controls.Add(this.textBoxMean);
            this.groupBox2.Controls.Add(this.textBoxMax);
            this.groupBox2.Controls.Add(this.radioButtonMax);
            this.groupBox2.Controls.Add(this.labelRangeTo);
            this.groupBox2.Controls.Add(this.textBoxRangeMax);
            this.groupBox2.Controls.Add(this.textBoxRangeMin);
            this.groupBox2.Controls.Add(this.textBoxMin);
            this.groupBox2.Controls.Add(this.radioButtonDeviation);
            this.groupBox2.Controls.Add(this.radioButtonMinMax);
            this.groupBox2.Controls.Add(this.radioButtonMin);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter Value";
            // 
            // labelDeviation
            // 
            this.labelDeviation.AutoSize = true;
            this.labelDeviation.Location = new System.Drawing.Point(231, 100);
            this.labelDeviation.Name = "labelDeviation";
            this.labelDeviation.Size = new System.Drawing.Size(13, 13);
            this.labelDeviation.TabIndex = 12;
            this.labelDeviation.Text = "±";
            // 
            // textBoxDeviation
            // 
            this.textBoxDeviation.Location = new System.Drawing.Point(250, 97);
            this.textBoxDeviation.Name = "textBoxDeviation";
            this.textBoxDeviation.Size = new System.Drawing.Size(119, 20);
            this.textBoxDeviation.TabIndex = 11;
            this.textBoxDeviation.TextChanged += new System.EventHandler(this.textBoxDeviation_TextChanged);
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(108, 97);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(114, 20);
            this.textBoxMean.TabIndex = 10;
            this.textBoxMean.TextChanged += new System.EventHandler(this.textBoxMean_TextChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(108, 45);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(261, 20);
            this.textBoxMax.TabIndex = 9;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(6, 46);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(72, 17);
            this.radioButtonMax.TabIndex = 8;
            this.radioButtonMax.Text = "Maximum:";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            this.radioButtonMax.CheckedChanged += new System.EventHandler(this.radioButtonMax_CheckedChanged);
            // 
            // labelRangeTo
            // 
            this.labelRangeTo.AutoSize = true;
            this.labelRangeTo.Enabled = false;
            this.labelRangeTo.Location = new System.Drawing.Point(228, 74);
            this.labelRangeTo.Name = "labelRangeTo";
            this.labelRangeTo.Size = new System.Drawing.Size(16, 13);
            this.labelRangeTo.TabIndex = 7;
            this.labelRangeTo.Text = "to";
            // 
            // textBoxRangeMax
            // 
            this.textBoxRangeMax.Enabled = false;
            this.textBoxRangeMax.Location = new System.Drawing.Point(250, 71);
            this.textBoxRangeMax.Name = "textBoxRangeMax";
            this.textBoxRangeMax.Size = new System.Drawing.Size(119, 20);
            this.textBoxRangeMax.TabIndex = 5;
            this.textBoxRangeMax.TextChanged += new System.EventHandler(this.textBoxRangeMax_TextChanged);
            // 
            // textBoxRangeMin
            // 
            this.textBoxRangeMin.Enabled = false;
            this.textBoxRangeMin.Location = new System.Drawing.Point(108, 71);
            this.textBoxRangeMin.Name = "textBoxRangeMin";
            this.textBoxRangeMin.Size = new System.Drawing.Size(114, 20);
            this.textBoxRangeMin.TabIndex = 4;
            this.textBoxRangeMin.TextChanged += new System.EventHandler(this.textBoxRangeMin_TextChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(108, 19);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(261, 20);
            this.textBoxMin.TabIndex = 3;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // radioButtonDeviation
            // 
            this.radioButtonDeviation.AutoSize = true;
            this.radioButtonDeviation.Location = new System.Drawing.Point(6, 97);
            this.radioButtonDeviation.Name = "radioButtonDeviation";
            this.radioButtonDeviation.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDeviation.TabIndex = 2;
            this.radioButtonDeviation.Text = "Deviation:";
            this.radioButtonDeviation.UseVisualStyleBackColor = true;
            this.radioButtonDeviation.CheckedChanged += new System.EventHandler(this.radioButtonDeviation_CheckedChanged);
            // 
            // radioButtonMinMax
            // 
            this.radioButtonMinMax.AutoSize = true;
            this.radioButtonMinMax.Location = new System.Drawing.Point(6, 72);
            this.radioButtonMinMax.Name = "radioButtonMinMax";
            this.radioButtonMinMax.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMinMax.TabIndex = 1;
            this.radioButtonMinMax.Text = "Range:";
            this.radioButtonMinMax.UseVisualStyleBackColor = true;
            this.radioButtonMinMax.CheckedChanged += new System.EventHandler(this.radioButtonMinMax_CheckedChanged);
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Checked = true;
            this.radioButtonMin.Location = new System.Drawing.Point(6, 20);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMin.TabIndex = 0;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "Minimum:";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            this.radioButtonMin.CheckedChanged += new System.EventHandler(this.radioButtonMin_CheckedChanged);
            // 
            // EditQualificationParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditQualificationParameterForm";
            this.Text = "Edit Qualification Parameter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRangeTo;
        private System.Windows.Forms.TextBox textBoxRangeMax;
        private System.Windows.Forms.TextBox textBoxRangeMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.RadioButton radioButtonDeviation;
        private System.Windows.Forms.RadioButton radioButtonMinMax;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.TextBox textBoxDeviation;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.Label labelDeviation;
    }
}