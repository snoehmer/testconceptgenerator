namespace TestConceptGenerator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestConceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestConceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestConceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestConceptAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTestProceduresCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestProceduresCatalogInWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testProtocolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTestProtocolTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageTestProtocolTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTestConceptOverviewWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMeasurementProtocolExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTestOverviewExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBoxTC = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProductBOMVersion = new System.Windows.Forms.TextBox();
            this.textBoxTCProductRevision = new System.Windows.Forms.TextBox();
            this.buttonEditMasterParams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTCDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeViewMasterParams = new System.Windows.Forms.TreeView();
            this.textBoxTCVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTCDut = new System.Windows.Forms.TextBox();
            this.textBoxTCRemarks = new System.Windows.Forms.TextBox();
            this.textBoxTCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTP = new System.Windows.Forms.GroupBox();
            this.buttonTPDown = new System.Windows.Forms.Button();
            this.buttonTPUp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEditTPParams = new System.Windows.Forms.Button();
            this.buttonShowTP = new System.Windows.Forms.Button();
            this.buttonRemoveTP = new System.Windows.Forms.Button();
            this.buttonEditTP = new System.Windows.Forms.Button();
            this.buttonAddTP = new System.Windows.Forms.Button();
            this.treeViewTPParams = new System.Windows.Forms.TreeView();
            this.treeViewTPs = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxTC.SuspendLayout();
            this.groupBoxTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.testConceptToolStripMenuItem,
            this.testProceduresToolStripMenuItem,
            this.testProtocolToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sandboxToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // sandboxToolStripMenuItem
            // 
            this.sandboxToolStripMenuItem.Name = "sandboxToolStripMenuItem";
            this.sandboxToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sandboxToolStripMenuItem.Text = "Sandbox";
            this.sandboxToolStripMenuItem.Click += new System.EventHandler(this.sandboxToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // testConceptToolStripMenuItem
            // 
            this.testConceptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestConceptToolStripMenuItem,
            this.openTestConceptToolStripMenuItem,
            this.saveTestConceptToolStripMenuItem,
            this.saveTestConceptAsToolStripMenuItem});
            this.testConceptToolStripMenuItem.Name = "testConceptToolStripMenuItem";
            this.testConceptToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.testConceptToolStripMenuItem.Text = "Test Concept";
            // 
            // newTestConceptToolStripMenuItem
            // 
            this.newTestConceptToolStripMenuItem.Name = "newTestConceptToolStripMenuItem";
            this.newTestConceptToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newTestConceptToolStripMenuItem.Text = "New Test Concept";
            // 
            // openTestConceptToolStripMenuItem
            // 
            this.openTestConceptToolStripMenuItem.Name = "openTestConceptToolStripMenuItem";
            this.openTestConceptToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openTestConceptToolStripMenuItem.Text = "Open Test Concept";
            // 
            // saveTestConceptToolStripMenuItem
            // 
            this.saveTestConceptToolStripMenuItem.Name = "saveTestConceptToolStripMenuItem";
            this.saveTestConceptToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveTestConceptToolStripMenuItem.Text = "Save Test Concept";
            // 
            // saveTestConceptAsToolStripMenuItem
            // 
            this.saveTestConceptAsToolStripMenuItem.Name = "saveTestConceptAsToolStripMenuItem";
            this.saveTestConceptAsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveTestConceptAsToolStripMenuItem.Text = "Save Test Concept as...";
            // 
            // testProceduresToolStripMenuItem
            // 
            this.testProceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseTestProceduresCatalogToolStripMenuItem,
            this.openTestProceduresCatalogInWordToolStripMenuItem});
            this.testProceduresToolStripMenuItem.Name = "testProceduresToolStripMenuItem";
            this.testProceduresToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.testProceduresToolStripMenuItem.Text = "Test Procedures";
            // 
            // chooseTestProceduresCatalogToolStripMenuItem
            // 
            this.chooseTestProceduresCatalogToolStripMenuItem.Name = "chooseTestProceduresCatalogToolStripMenuItem";
            this.chooseTestProceduresCatalogToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.chooseTestProceduresCatalogToolStripMenuItem.Text = "Choose Test Procedures Catalog";
            this.chooseTestProceduresCatalogToolStripMenuItem.Click += new System.EventHandler(this.chooseTestProceduresCatalogToolStripMenuItem_Click);
            // 
            // openTestProceduresCatalogInWordToolStripMenuItem
            // 
            this.openTestProceduresCatalogInWordToolStripMenuItem.Name = "openTestProceduresCatalogInWordToolStripMenuItem";
            this.openTestProceduresCatalogInWordToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.openTestProceduresCatalogInWordToolStripMenuItem.Text = "Open Test Procedures Catalog in Word";
            // 
            // testProtocolToolStripMenuItem
            // 
            this.testProtocolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTestProtocolTemplatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.manageTestProtocolTemplatesToolStripMenuItem});
            this.testProtocolToolStripMenuItem.Name = "testProtocolToolStripMenuItem";
            this.testProtocolToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.testProtocolToolStripMenuItem.Text = "Test Protocol";
            // 
            // selectTestProtocolTemplatesToolStripMenuItem
            // 
            this.selectTestProtocolTemplatesToolStripMenuItem.Name = "selectTestProtocolTemplatesToolStripMenuItem";
            this.selectTestProtocolTemplatesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.selectTestProtocolTemplatesToolStripMenuItem.Text = "Select Test Protocol Templates";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // manageTestProtocolTemplatesToolStripMenuItem
            // 
            this.manageTestProtocolTemplatesToolStripMenuItem.Name = "manageTestProtocolTemplatesToolStripMenuItem";
            this.manageTestProtocolTemplatesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.manageTestProtocolTemplatesToolStripMenuItem.Text = "Manage Test Protocol Templates";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTestConceptOverviewWordToolStripMenuItem,
            this.exportMeasurementProtocolExcelToolStripMenuItem,
            this.exportTestOverviewExcelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // exportTestConceptOverviewWordToolStripMenuItem
            // 
            this.exportTestConceptOverviewWordToolStripMenuItem.Name = "exportTestConceptOverviewWordToolStripMenuItem";
            this.exportTestConceptOverviewWordToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exportTestConceptOverviewWordToolStripMenuItem.Text = "Export Test Concept Overview (Word)";
            // 
            // exportMeasurementProtocolExcelToolStripMenuItem
            // 
            this.exportMeasurementProtocolExcelToolStripMenuItem.Name = "exportMeasurementProtocolExcelToolStripMenuItem";
            this.exportMeasurementProtocolExcelToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exportMeasurementProtocolExcelToolStripMenuItem.Text = "Export Measurement Protocol (Excel)";
            // 
            // exportTestOverviewExcelToolStripMenuItem
            // 
            this.exportTestOverviewExcelToolStripMenuItem.Name = "exportTestOverviewExcelToolStripMenuItem";
            this.exportTestOverviewExcelToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.exportTestOverviewExcelToolStripMenuItem.Text = "Export Test Overview (Excel)";
            this.exportTestOverviewExcelToolStripMenuItem.Click += new System.EventHandler(this.exportTestOverviewExcelToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 25);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabel.Text = "ready";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 19);
            // 
            // groupBoxTC
            // 
            this.groupBoxTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTC.Controls.Add(this.label9);
            this.groupBoxTC.Controls.Add(this.label8);
            this.groupBoxTC.Controls.Add(this.textBoxProductBOMVersion);
            this.groupBoxTC.Controls.Add(this.textBoxTCProductRevision);
            this.groupBoxTC.Controls.Add(this.buttonEditMasterParams);
            this.groupBoxTC.Controls.Add(this.label1);
            this.groupBoxTC.Controls.Add(this.label6);
            this.groupBoxTC.Controls.Add(this.textBoxTCDescription);
            this.groupBoxTC.Controls.Add(this.label5);
            this.groupBoxTC.Controls.Add(this.treeViewMasterParams);
            this.groupBoxTC.Controls.Add(this.textBoxTCVersion);
            this.groupBoxTC.Controls.Add(this.label2);
            this.groupBoxTC.Controls.Add(this.label4);
            this.groupBoxTC.Controls.Add(this.textBoxTCDut);
            this.groupBoxTC.Controls.Add(this.textBoxTCRemarks);
            this.groupBoxTC.Controls.Add(this.textBoxTCName);
            this.groupBoxTC.Controls.Add(this.label3);
            this.groupBoxTC.Location = new System.Drawing.Point(13, 28);
            this.groupBoxTC.Name = "groupBoxTC";
            this.groupBoxTC.Size = new System.Drawing.Size(719, 201);
            this.groupBoxTC.TabIndex = 2;
            this.groupBoxTC.TabStop = false;
            this.groupBoxTC.Text = "Test Concept Overview";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "BOM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Revision:";
            // 
            // textBoxProductBOMVersion
            // 
            this.textBoxProductBOMVersion.Location = new System.Drawing.Point(407, 45);
            this.textBoxProductBOMVersion.Name = "textBoxProductBOMVersion";
            this.textBoxProductBOMVersion.Size = new System.Drawing.Size(73, 20);
            this.textBoxProductBOMVersion.TabIndex = 14;
            this.textBoxProductBOMVersion.TextChanged += new System.EventHandler(this.textBoxProductBOMVersion_TextChanged);
            // 
            // textBoxTCProductRevision
            // 
            this.textBoxTCProductRevision.Location = new System.Drawing.Point(268, 45);
            this.textBoxTCProductRevision.Name = "textBoxTCProductRevision";
            this.textBoxTCProductRevision.Size = new System.Drawing.Size(73, 20);
            this.textBoxTCProductRevision.TabIndex = 13;
            this.textBoxTCProductRevision.TextChanged += new System.EventHandler(this.textBoxTCProductRevision_TextChanged);
            // 
            // buttonEditMasterParams
            // 
            this.buttonEditMasterParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditMasterParams.Location = new System.Drawing.Point(638, 17);
            this.buttonEditMasterParams.Name = "buttonEditMasterParams";
            this.buttonEditMasterParams.Size = new System.Drawing.Size(75, 23);
            this.buttonEditMasterParams.TabIndex = 12;
            this.buttonEditMasterParams.Text = "Edit";
            this.buttonEditMasterParams.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concept Name:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Master Parameters:";
            // 
            // textBoxTCDescription
            // 
            this.textBoxTCDescription.Location = new System.Drawing.Point(93, 97);
            this.textBoxTCDescription.Multiline = true;
            this.textBoxTCDescription.Name = "textBoxTCDescription";
            this.textBoxTCDescription.Size = new System.Drawing.Size(387, 43);
            this.textBoxTCDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks:";
            // 
            // treeViewMasterParams
            // 
            this.treeViewMasterParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewMasterParams.Location = new System.Drawing.Point(514, 48);
            this.treeViewMasterParams.Name = "treeViewMasterParams";
            this.treeViewMasterParams.Size = new System.Drawing.Size(199, 143);
            this.treeViewMasterParams.TabIndex = 11;
            // 
            // textBoxTCVersion
            // 
            this.textBoxTCVersion.Location = new System.Drawing.Point(124, 71);
            this.textBoxTCVersion.Name = "textBoxTCVersion";
            this.textBoxTCVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxTCVersion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Concept Version:";
            // 
            // textBoxTCDut
            // 
            this.textBoxTCDut.Location = new System.Drawing.Point(93, 45);
            this.textBoxTCDut.Name = "textBoxTCDut";
            this.textBoxTCDut.Size = new System.Drawing.Size(92, 20);
            this.textBoxTCDut.TabIndex = 9;
            this.textBoxTCDut.TextChanged += new System.EventHandler(this.textBoxTCDut_TextChanged);
            // 
            // textBoxTCRemarks
            // 
            this.textBoxTCRemarks.Location = new System.Drawing.Point(93, 146);
            this.textBoxTCRemarks.Multiline = true;
            this.textBoxTCRemarks.Name = "textBoxTCRemarks";
            this.textBoxTCRemarks.Size = new System.Drawing.Size(387, 45);
            this.textBoxTCRemarks.TabIndex = 6;
            // 
            // textBoxTCName
            // 
            this.textBoxTCName.Location = new System.Drawing.Point(93, 19);
            this.textBoxTCName.Name = "textBoxTCName";
            this.textBoxTCName.Size = new System.Drawing.Size(387, 20);
            this.textBoxTCName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // groupBoxTP
            // 
            this.groupBoxTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTP.Controls.Add(this.buttonTPDown);
            this.groupBoxTP.Controls.Add(this.buttonTPUp);
            this.groupBoxTP.Controls.Add(this.label7);
            this.groupBoxTP.Controls.Add(this.buttonEditTPParams);
            this.groupBoxTP.Controls.Add(this.buttonShowTP);
            this.groupBoxTP.Controls.Add(this.buttonRemoveTP);
            this.groupBoxTP.Controls.Add(this.buttonEditTP);
            this.groupBoxTP.Controls.Add(this.buttonAddTP);
            this.groupBoxTP.Controls.Add(this.treeViewTPParams);
            this.groupBoxTP.Controls.Add(this.treeViewTPs);
            this.groupBoxTP.Location = new System.Drawing.Point(12, 235);
            this.groupBoxTP.Name = "groupBoxTP";
            this.groupBoxTP.Size = new System.Drawing.Size(720, 326);
            this.groupBoxTP.TabIndex = 3;
            this.groupBoxTP.TabStop = false;
            this.groupBoxTP.Text = "Test Procedures in the Test Concept";
            // 
            // buttonTPDown
            // 
            this.buttonTPDown.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonTPDown.Location = new System.Drawing.Point(43, 298);
            this.buttonTPDown.Name = "buttonTPDown";
            this.buttonTPDown.Size = new System.Drawing.Size(30, 23);
            this.buttonTPDown.TabIndex = 9;
            this.buttonTPDown.Text = "q";
            this.buttonTPDown.UseVisualStyleBackColor = true;
            this.buttonTPDown.Click += new System.EventHandler(this.buttonTPDown_Click);
            // 
            // buttonTPUp
            // 
            this.buttonTPUp.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonTPUp.Location = new System.Drawing.Point(7, 298);
            this.buttonTPUp.Name = "buttonTPUp";
            this.buttonTPUp.Size = new System.Drawing.Size(30, 23);
            this.buttonTPUp.TabIndex = 8;
            this.buttonTPUp.Text = "p";
            this.buttonTPUp.UseVisualStyleBackColor = true;
            this.buttonTPUp.Click += new System.EventHandler(this.buttonTPUp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Test Procedure Information:";
            // 
            // buttonEditTPParams
            // 
            this.buttonEditTPParams.Location = new System.Drawing.Point(550, 297);
            this.buttonEditTPParams.Name = "buttonEditTPParams";
            this.buttonEditTPParams.Size = new System.Drawing.Size(164, 23);
            this.buttonEditTPParams.TabIndex = 6;
            this.buttonEditTPParams.Text = "Edit Selected Parameter";
            this.buttonEditTPParams.UseVisualStyleBackColor = true;
            this.buttonEditTPParams.Click += new System.EventHandler(this.buttonEditTPParams_Click);
            // 
            // buttonShowTP
            // 
            this.buttonShowTP.Location = new System.Drawing.Point(379, 297);
            this.buttonShowTP.Name = "buttonShowTP";
            this.buttonShowTP.Size = new System.Drawing.Size(164, 23);
            this.buttonShowTP.TabIndex = 5;
            this.buttonShowTP.Text = "Show Testprocedure in Word";
            this.buttonShowTP.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTP
            // 
            this.buttonRemoveTP.Location = new System.Drawing.Point(265, 297);
            this.buttonRemoveTP.Name = "buttonRemoveTP";
            this.buttonRemoveTP.Size = new System.Drawing.Size(77, 23);
            this.buttonRemoveTP.TabIndex = 4;
            this.buttonRemoveTP.Text = "Remove...";
            this.buttonRemoveTP.UseVisualStyleBackColor = true;
            this.buttonRemoveTP.Click += new System.EventHandler(this.buttonRemoveTP_Click);
            // 
            // buttonEditTP
            // 
            this.buttonEditTP.Location = new System.Drawing.Point(182, 297);
            this.buttonEditTP.Name = "buttonEditTP";
            this.buttonEditTP.Size = new System.Drawing.Size(77, 23);
            this.buttonEditTP.TabIndex = 3;
            this.buttonEditTP.Text = "Edit...";
            this.buttonEditTP.UseVisualStyleBackColor = true;
            this.buttonEditTP.Click += new System.EventHandler(this.buttonEditTP_Click);
            // 
            // buttonAddTP
            // 
            this.buttonAddTP.Location = new System.Drawing.Point(99, 297);
            this.buttonAddTP.Name = "buttonAddTP";
            this.buttonAddTP.Size = new System.Drawing.Size(77, 23);
            this.buttonAddTP.TabIndex = 2;
            this.buttonAddTP.Text = "Add...";
            this.buttonAddTP.UseVisualStyleBackColor = true;
            this.buttonAddTP.Click += new System.EventHandler(this.buttonAddTP_Click);
            // 
            // treeViewTPParams
            // 
            this.treeViewTPParams.Location = new System.Drawing.Point(379, 36);
            this.treeViewTPParams.Name = "treeViewTPParams";
            this.treeViewTPParams.Size = new System.Drawing.Size(335, 254);
            this.treeViewTPParams.TabIndex = 1;
            // 
            // treeViewTPs
            // 
            this.treeViewTPs.FullRowSelect = true;
            this.treeViewTPs.HideSelection = false;
            this.treeViewTPs.Location = new System.Drawing.Point(7, 20);
            this.treeViewTPs.Name = "treeViewTPs";
            this.treeViewTPs.Size = new System.Drawing.Size(335, 271);
            this.treeViewTPs.TabIndex = 0;
            this.treeViewTPs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTPs_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 586);
            this.Controls.Add(this.groupBoxTP);
            this.Controls.Add(this.groupBoxTC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 625);
            this.Name = "MainForm";
            this.Text = "Test Concept Generator";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxTC.ResumeLayout(false);
            this.groupBoxTC.PerformLayout();
            this.groupBoxTP.ResumeLayout(false);
            this.groupBoxTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestConceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestConceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestConceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestConceptAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTestProceduresCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestProceduresCatalogInWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem testProtocolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTestProtocolTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manageTestProtocolTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTestConceptOverviewWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMeasurementProtocolExcelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditMasterParams;
        private System.Windows.Forms.TreeView treeViewMasterParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTCDut;
        private System.Windows.Forms.TextBox textBoxTCVersion;
        private System.Windows.Forms.TextBox textBoxTCDescription;
        private System.Windows.Forms.TextBox textBoxTCRemarks;
        private System.Windows.Forms.TextBox textBoxTCName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem sandboxToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTP;
        private System.Windows.Forms.TreeView treeViewTPParams;
        private System.Windows.Forms.TreeView treeViewTPs;
        private System.Windows.Forms.Button buttonEditTPParams;
        private System.Windows.Forms.Button buttonShowTP;
        private System.Windows.Forms.Button buttonRemoveTP;
        private System.Windows.Forms.Button buttonEditTP;
        private System.Windows.Forms.Button buttonAddTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button buttonTPDown;
        private System.Windows.Forms.Button buttonTPUp;
        private System.Windows.Forms.ToolStripMenuItem exportTestOverviewExcelToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProductBOMVersion;
        private System.Windows.Forms.TextBox textBoxTCProductRevision;
    }
}