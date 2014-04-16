namespace TestConceptGenerator
{
    partial class EditInputParameterForm
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
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.listViewValues = new System.Windows.Forms.ListView();
            this.columnDummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelRangeTo = new System.Windows.Forms.Label();
            this.textBoxRangeMax = new System.Windows.Forms.TextBox();
            this.textBoxRangeMin = new System.Windows.Forms.TextBox();
            this.textBoxSingleValue = new System.Windows.Forms.TextBox();
            this.radioButtonValueList = new System.Windows.Forms.RadioButton();
            this.radioButtonValueRange = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleValue = new System.Windows.Forms.RadioButton();
            this.labelRangeStep = new System.Windows.Forms.Label();
            this.textBoxRangeStep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(122, 345);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 345);
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
            this.groupBox2.Controls.Add(this.textBoxRangeStep);
            this.groupBox2.Controls.Add(this.labelRangeStep);
            this.groupBox2.Controls.Add(this.buttonDown);
            this.groupBox2.Controls.Add(this.buttonUp);
            this.groupBox2.Controls.Add(this.listViewValues);
            this.groupBox2.Controls.Add(this.buttonRemove);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.labelRangeTo);
            this.groupBox2.Controls.Add(this.textBoxRangeMax);
            this.groupBox2.Controls.Add(this.textBoxRangeMin);
            this.groupBox2.Controls.Add(this.textBoxSingleValue);
            this.groupBox2.Controls.Add(this.radioButtonValueList);
            this.groupBox2.Controls.Add(this.radioButtonValueRange);
            this.groupBox2.Controls.Add(this.radioButtonSingleValue);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter Value";
            // 
            // buttonDown
            // 
            this.buttonDown.Enabled = false;
            this.buttonDown.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonDown.Location = new System.Drawing.Point(321, 100);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 23);
            this.buttonDown.TabIndex = 14;
            this.buttonDown.Text = "q";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Enabled = false;
            this.buttonUp.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonUp.Location = new System.Drawing.Point(285, 100);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 23);
            this.buttonUp.TabIndex = 13;
            this.buttonUp.Text = "p";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // listViewValues
            // 
            this.listViewValues.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDummy});
            this.listViewValues.Enabled = false;
            this.listViewValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewValues.HideSelection = false;
            this.listViewValues.LabelEdit = true;
            this.listViewValues.LabelWrap = false;
            this.listViewValues.Location = new System.Drawing.Point(108, 71);
            this.listViewValues.Name = "listViewValues";
            this.listViewValues.ShowGroups = false;
            this.listViewValues.Size = new System.Drawing.Size(154, 82);
            this.listViewValues.TabIndex = 12;
            this.listViewValues.UseCompatibleStateImageBehavior = false;
            this.listViewValues.View = System.Windows.Forms.View.Details;
            this.listViewValues.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewValues_AfterLabelEdit);
            this.listViewValues.ItemActivate += new System.EventHandler(this.listViewValues_ItemActivate);
            this.listViewValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewValues_MouseDown);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(269, 129);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove Element";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(269, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add Element";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelRangeTo
            // 
            this.labelRangeTo.AutoSize = true;
            this.labelRangeTo.Enabled = false;
            this.labelRangeTo.Location = new System.Drawing.Point(174, 48);
            this.labelRangeTo.Name = "labelRangeTo";
            this.labelRangeTo.Size = new System.Drawing.Size(16, 13);
            this.labelRangeTo.TabIndex = 7;
            this.labelRangeTo.Text = "to";
            // 
            // textBoxRangeMax
            // 
            this.textBoxRangeMax.Enabled = false;
            this.textBoxRangeMax.Location = new System.Drawing.Point(193, 45);
            this.textBoxRangeMax.Name = "textBoxRangeMax";
            this.textBoxRangeMax.Size = new System.Drawing.Size(60, 20);
            this.textBoxRangeMax.TabIndex = 5;
            this.textBoxRangeMax.TextChanged += new System.EventHandler(this.textBoxRangeMax_TextChanged);
            // 
            // textBoxRangeMin
            // 
            this.textBoxRangeMin.Enabled = false;
            this.textBoxRangeMin.Location = new System.Drawing.Point(108, 45);
            this.textBoxRangeMin.Name = "textBoxRangeMin";
            this.textBoxRangeMin.Size = new System.Drawing.Size(60, 20);
            this.textBoxRangeMin.TabIndex = 4;
            this.textBoxRangeMin.TextChanged += new System.EventHandler(this.textBoxRangeMin_TextChanged);
            // 
            // textBoxSingleValue
            // 
            this.textBoxSingleValue.Location = new System.Drawing.Point(108, 19);
            this.textBoxSingleValue.Name = "textBoxSingleValue";
            this.textBoxSingleValue.Size = new System.Drawing.Size(261, 20);
            this.textBoxSingleValue.TabIndex = 3;
            this.textBoxSingleValue.TextChanged += new System.EventHandler(this.textBoxSingleValue_TextChanged);
            // 
            // radioButtonValueList
            // 
            this.radioButtonValueList.AutoSize = true;
            this.radioButtonValueList.Location = new System.Drawing.Point(6, 71);
            this.radioButtonValueList.Name = "radioButtonValueList";
            this.radioButtonValueList.Size = new System.Drawing.Size(74, 17);
            this.radioButtonValueList.TabIndex = 2;
            this.radioButtonValueList.Text = "Value List:";
            this.radioButtonValueList.UseVisualStyleBackColor = true;
            this.radioButtonValueList.CheckedChanged += new System.EventHandler(this.radioButtonValueList_CheckedChanged);
            // 
            // radioButtonValueRange
            // 
            this.radioButtonValueRange.AutoSize = true;
            this.radioButtonValueRange.Location = new System.Drawing.Point(6, 46);
            this.radioButtonValueRange.Name = "radioButtonValueRange";
            this.radioButtonValueRange.Size = new System.Drawing.Size(90, 17);
            this.radioButtonValueRange.TabIndex = 1;
            this.radioButtonValueRange.Text = "Value Range:";
            this.radioButtonValueRange.UseVisualStyleBackColor = true;
            this.radioButtonValueRange.CheckedChanged += new System.EventHandler(this.radioButtonValueRange_CheckedChanged);
            // 
            // radioButtonSingleValue
            // 
            this.radioButtonSingleValue.AutoSize = true;
            this.radioButtonSingleValue.Checked = true;
            this.radioButtonSingleValue.Location = new System.Drawing.Point(6, 20);
            this.radioButtonSingleValue.Name = "radioButtonSingleValue";
            this.radioButtonSingleValue.Size = new System.Drawing.Size(87, 17);
            this.radioButtonSingleValue.TabIndex = 0;
            this.radioButtonSingleValue.TabStop = true;
            this.radioButtonSingleValue.Text = "Single Value:";
            this.radioButtonSingleValue.UseVisualStyleBackColor = true;
            this.radioButtonSingleValue.CheckedChanged += new System.EventHandler(this.radioButtonSingleValue_CheckedChanged);
            // 
            // labelRangeStep
            // 
            this.labelRangeStep.AutoSize = true;
            this.labelRangeStep.Enabled = false;
            this.labelRangeStep.Location = new System.Drawing.Point(267, 48);
            this.labelRangeStep.Name = "labelRangeStep";
            this.labelRangeStep.Size = new System.Drawing.Size(52, 13);
            this.labelRangeStep.TabIndex = 15;
            this.labelRangeStep.Text = "Step Size";
            // 
            // textBoxRangeStep
            // 
            this.textBoxRangeStep.Enabled = false;
            this.textBoxRangeStep.Location = new System.Drawing.Point(321, 45);
            this.textBoxRangeStep.Name = "textBoxRangeStep";
            this.textBoxRangeStep.Size = new System.Drawing.Size(48, 20);
            this.textBoxRangeStep.TabIndex = 16;
            this.textBoxRangeStep.TextChanged += new System.EventHandler(this.textBoxRangeStep_TextChanged);
            // 
            // EditInputParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditInputParameterForm";
            this.Text = "Edit Input Parameter";
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
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelRangeTo;
        private System.Windows.Forms.TextBox textBoxRangeMax;
        private System.Windows.Forms.TextBox textBoxRangeMin;
        private System.Windows.Forms.TextBox textBoxSingleValue;
        private System.Windows.Forms.RadioButton radioButtonValueList;
        private System.Windows.Forms.RadioButton radioButtonValueRange;
        private System.Windows.Forms.RadioButton radioButtonSingleValue;
        private System.Windows.Forms.ListView listViewValues;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ColumnHeader columnDummy;
        private System.Windows.Forms.TextBox textBoxRangeStep;
        private System.Windows.Forms.Label labelRangeStep;
    }
}