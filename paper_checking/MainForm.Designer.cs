﻿namespace paper_checking
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCheckingProgress = new System.Windows.Forms.ProgressBar();
            this.btnToCheckPaperPath = new System.Windows.Forms.Button();
            this.txtToCheckPaperPath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkStatisTable = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnForceStop = new System.Windows.Forms.Button();
            this.cmbCheckWay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinalReportPath = new System.Windows.Forms.Button();
            this.txtFinalReportPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRecover = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheckThreshold = new System.Windows.Forms.TextBox();
            this.btnStartChecking = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBlocklist = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnManageLibrary = new System.Windows.Forms.Button();
            this.txtPaperSourcePath = new System.Windows.Forms.TextBox();
            this.btnPaperSourcePath = new System.Windows.Forms.Button();
            this.btnAddLibrary = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnShowReportList = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRestoreDefault2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinBytes = new System.Windows.Forms.TextBox();
            this.txtMinWords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSuportTxt = new System.Windows.Forms.CheckBox();
            this.chkSuportDocx = new System.Windows.Forms.CheckBox();
            this.chkSuportPdf = new System.Windows.Forms.CheckBox();
            this.chkSuportDoc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestoreDefault1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConvertThreadCnt = new System.Windows.Forms.TextBox();
            this.txtCheckThreadCnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnShowLicence = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(17, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pbCheckingProgress);
            this.tabPage1.Controls.Add(this.btnToCheckPaperPath);
            this.tabPage1.Controls.Add(this.txtToCheckPaperPath);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.chkStatisTable);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnForceStop);
            this.tabPage1.Controls.Add(this.cmbCheckWay);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnFinalReportPath);
            this.tabPage1.Controls.Add(this.txtFinalReportPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chkRecover);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtCheckThreshold);
            this.tabPage1.Controls.Add(this.btnStartChecking);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(601, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查重";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(261, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "查重进度";
            // 
            // pbCheckingProgress
            // 
            this.pbCheckingProgress.Location = new System.Drawing.Point(65, 239);
            this.pbCheckingProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pbCheckingProgress.Name = "pbCheckingProgress";
            this.pbCheckingProgress.Size = new System.Drawing.Size(464, 29);
            this.pbCheckingProgress.TabIndex = 36;
            // 
            // btnToCheckPaperPath
            // 
            this.btnToCheckPaperPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToCheckPaperPath.Location = new System.Drawing.Point(427, 126);
            this.btnToCheckPaperPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnToCheckPaperPath.Name = "btnToCheckPaperPath";
            this.btnToCheckPaperPath.Size = new System.Drawing.Size(56, 31);
            this.btnToCheckPaperPath.TabIndex = 33;
            this.btnToCheckPaperPath.Text = "...";
            this.btnToCheckPaperPath.UseVisualStyleBackColor = true;
            this.btnToCheckPaperPath.Click += new System.EventHandler(this.ButtonSelectToCheckPaperPath);
            // 
            // txtToCheckPaperPath
            // 
            this.txtToCheckPaperPath.Location = new System.Drawing.Point(285, 129);
            this.txtToCheckPaperPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtToCheckPaperPath.Name = "txtToCheckPaperPath";
            this.txtToCheckPaperPath.ReadOnly = true;
            this.txtToCheckPaperPath.Size = new System.Drawing.Size(132, 25);
            this.txtToCheckPaperPath.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(97, 132);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 15);
            this.label20.TabIndex = 34;
            this.label20.Text = "待查文件所在的文件夹";
            // 
            // chkStatisTable
            // 
            this.chkStatisTable.AutoSize = true;
            this.chkStatisTable.Location = new System.Drawing.Point(195, 378);
            this.chkStatisTable.Margin = new System.Windows.Forms.Padding(4);
            this.chkStatisTable.Name = "chkStatisTable";
            this.chkStatisTable.Size = new System.Drawing.Size(104, 19);
            this.chkStatisTable.TabIndex = 32;
            this.chkStatisTable.Text = "生成统计表";
            this.chkStatisTable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(443, 344);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "（不推荐）";
            // 
            // btnForceStop
            // 
            this.btnForceStop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForceStop.Location = new System.Drawing.Point(435, 306);
            this.btnForceStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnForceStop.Name = "btnForceStop";
            this.btnForceStop.Size = new System.Drawing.Size(99, 34);
            this.btnForceStop.TabIndex = 30;
            this.btnForceStop.Text = "强制退出";
            this.btnForceStop.UseVisualStyleBackColor = true;
            this.btnForceStop.Click += new System.EventHandler(this.ButtonForceStop);
            // 
            // cmbCheckWay
            // 
            this.cmbCheckWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckWay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCheckWay.FormattingEnabled = true;
            this.cmbCheckWay.Items.AddRange(new object[] {
            "纵向查重",
            "横向查重"});
            this.cmbCheckWay.Location = new System.Drawing.Point(285, 34);
            this.cmbCheckWay.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCheckWay.Name = "cmbCheckWay";
            this.cmbCheckWay.Size = new System.Drawing.Size(132, 28);
            this.cmbCheckWay.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(201, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "查重方式";
            // 
            // btnFinalReportPath
            // 
            this.btnFinalReportPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinalReportPath.Location = new System.Drawing.Point(427, 170);
            this.btnFinalReportPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalReportPath.Name = "btnFinalReportPath";
            this.btnFinalReportPath.Size = new System.Drawing.Size(56, 31);
            this.btnFinalReportPath.TabIndex = 4;
            this.btnFinalReportPath.Text = "...";
            this.btnFinalReportPath.UseVisualStyleBackColor = true;
            this.btnFinalReportPath.Click += new System.EventHandler(this.ButtonSelectFinalReportPath);
            // 
            // txtFinalReportPath
            // 
            this.txtFinalReportPath.Location = new System.Drawing.Point(285, 172);
            this.txtFinalReportPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalReportPath.Name = "txtFinalReportPath";
            this.txtFinalReportPath.ReadOnly = true;
            this.txtFinalReportPath.Size = new System.Drawing.Size(132, 25);
            this.txtFinalReportPath.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(97, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "保存查重报告的文件夹";
            // 
            // chkRecover
            // 
            this.chkRecover.AutoSize = true;
            this.chkRecover.Location = new System.Drawing.Point(311, 378);
            this.chkRecover.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecover.Name = "chkRecover";
            this.chkRecover.Size = new System.Drawing.Size(89, 19);
            this.chkRecover.TabIndex = 6;
            this.chkRecover.Text = "中断恢复";
            this.chkRecover.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(201, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "查重阈值";
            // 
            // txtCheckThreshold
            // 
            this.txtCheckThreshold.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheckThreshold.Location = new System.Drawing.Point(285, 82);
            this.txtCheckThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckThreshold.MaxLength = 2;
            this.txtCheckThreshold.Name = "txtCheckThreshold";
            this.txtCheckThreshold.Size = new System.Drawing.Size(132, 27);
            this.txtCheckThreshold.TabIndex = 1;
            this.txtCheckThreshold.Text = "10";
            this.txtCheckThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilterKeyPress);
            // 
            // btnStartChecking
            // 
            this.btnStartChecking.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartChecking.Location = new System.Drawing.Point(157, 288);
            this.btnStartChecking.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartChecking.Name = "btnStartChecking";
            this.btnStartChecking.Size = new System.Drawing.Size(269, 82);
            this.btnStartChecking.TabIndex = 5;
            this.btnStartChecking.Text = "开始查重";
            this.btnStartChecking.UseVisualStyleBackColor = true;
            this.btnStartChecking.Click += new System.EventHandler(this.ButtonStartChecking);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(601, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "比对库管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.txtBlocklist);
            this.groupBox8.Location = new System.Drawing.Point(8, 218);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(583, 184);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "自定义关键词过滤";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "注：关键词之间通过空格分隔";
            // 
            // txtBlocklist
            // 
            this.txtBlocklist.Location = new System.Drawing.Point(15, 29);
            this.txtBlocklist.Margin = new System.Windows.Forms.Padding(4);
            this.txtBlocklist.Multiline = true;
            this.txtBlocklist.Name = "txtBlocklist";
            this.txtBlocklist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBlocklist.Size = new System.Drawing.Size(551, 120);
            this.txtBlocklist.TabIndex = 0;
            this.txtBlocklist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBlocklist_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnManageLibrary);
            this.groupBox7.Controls.Add(this.txtPaperSourcePath);
            this.groupBox7.Controls.Add(this.btnPaperSourcePath);
            this.groupBox7.Controls.Add(this.btnAddLibrary);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(8, 14);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(583, 180);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "添加比对库";
            // 
            // btnManageLibrary
            // 
            this.btnManageLibrary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnManageLibrary.Location = new System.Drawing.Point(291, 85);
            this.btnManageLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageLibrary.Name = "btnManageLibrary";
            this.btnManageLibrary.Size = new System.Drawing.Size(180, 66);
            this.btnManageLibrary.TabIndex = 39;
            this.btnManageLibrary.Text = "管理比对库";
            this.btnManageLibrary.UseVisualStyleBackColor = true;
            this.btnManageLibrary.Click += new System.EventHandler(this.BtnManageLibrary_Click);
            // 
            // txtPaperSourcePath
            // 
            this.txtPaperSourcePath.Location = new System.Drawing.Point(291, 40);
            this.txtPaperSourcePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaperSourcePath.Name = "txtPaperSourcePath";
            this.txtPaperSourcePath.ReadOnly = true;
            this.txtPaperSourcePath.Size = new System.Drawing.Size(132, 25);
            this.txtPaperSourcePath.TabIndex = 38;
            // 
            // btnPaperSourcePath
            // 
            this.btnPaperSourcePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPaperSourcePath.Location = new System.Drawing.Point(432, 38);
            this.btnPaperSourcePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaperSourcePath.Name = "btnPaperSourcePath";
            this.btnPaperSourcePath.Size = new System.Drawing.Size(56, 31);
            this.btnPaperSourcePath.TabIndex = 36;
            this.btnPaperSourcePath.Text = "...";
            this.btnPaperSourcePath.UseVisualStyleBackColor = true;
            this.btnPaperSourcePath.Click += new System.EventHandler(this.ButtonSelectPaperSourcePath);
            // 
            // btnAddLibrary
            // 
            this.btnAddLibrary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddLibrary.Location = new System.Drawing.Point(103, 85);
            this.btnAddLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLibrary.Name = "btnAddLibrary";
            this.btnAddLibrary.Size = new System.Drawing.Size(180, 66);
            this.btnAddLibrary.TabIndex = 0;
            this.btnAddLibrary.Text = "添加到比对库";
            this.btnAddLibrary.UseVisualStyleBackColor = true;
            this.btnAddLibrary.Click += new System.EventHandler(this.ButtonAddLibrary);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(85, 45);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "待添加文件所在的文件夹";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExportReport);
            this.tabPage3.Controls.Add(this.btnShowReportList);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(601, 426);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "历史查重结果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExportReport
            // 
            this.btnExportReport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportReport.Location = new System.Drawing.Point(161, 54);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(279, 134);
            this.btnExportReport.TabIndex = 1;
            this.btnExportReport.Text = "导出上一次查重报告";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.ButtonExportReport);
            // 
            // btnShowReportList
            // 
            this.btnShowReportList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowReportList.Location = new System.Drawing.Point(161, 226);
            this.btnShowReportList.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowReportList.Name = "btnShowReportList";
            this.btnShowReportList.Size = new System.Drawing.Size(279, 134);
            this.btnShowReportList.TabIndex = 2;
            this.btnShowReportList.Text = "查看上一次查重报告";
            this.btnShowReportList.UseVisualStyleBackColor = true;
            this.btnShowReportList.Click += new System.EventHandler(this.ButtonShowReportList);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(601, 426);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "高级设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRestoreDefault2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtMinBytes);
            this.groupBox4.Controls.Add(this.txtMinWords);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(43, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(505, 95);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文件限制";
            // 
            // btnRestoreDefault2
            // 
            this.btnRestoreDefault2.Location = new System.Drawing.Point(343, 19);
            this.btnRestoreDefault2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestoreDefault2.Name = "btnRestoreDefault2";
            this.btnRestoreDefault2.Size = new System.Drawing.Size(116, 65);
            this.btnRestoreDefault2.TabIndex = 28;
            this.btnRestoreDefault2.Text = "恢复默认";
            this.btnRestoreDefault2.UseVisualStyleBackColor = true;
            this.btnRestoreDefault2.Click += new System.EventHandler(this.ButtonRestoreDefault2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "文件最低字数";
            // 
            // txtMinBytes
            // 
            this.txtMinBytes.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMinBytes.Location = new System.Drawing.Point(184, 55);
            this.txtMinBytes.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinBytes.MaxLength = 5;
            this.txtMinBytes.Name = "txtMinBytes";
            this.txtMinBytes.Size = new System.Drawing.Size(132, 27);
            this.txtMinBytes.TabIndex = 25;
            this.txtMinBytes.Text = "0";
            this.txtMinBytes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilterKeyPress);
            // 
            // txtMinWords
            // 
            this.txtMinWords.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMinWords.Location = new System.Drawing.Point(184, 19);
            this.txtMinWords.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinWords.MaxLength = 5;
            this.txtMinWords.Name = "txtMinWords";
            this.txtMinWords.Size = new System.Drawing.Size(132, 27);
            this.txtMinWords.TabIndex = 24;
            this.txtMinWords.Text = "0";
            this.txtMinWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilterKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "转换后文件最小字节";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Location = new System.Drawing.Point(43, 332);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(505, 71);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其它设置";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 21);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 36);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "重置系统";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ButtonReset);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSuportTxt);
            this.groupBox2.Controls.Add(this.chkSuportDocx);
            this.groupBox2.Controls.Add(this.chkSuportPdf);
            this.groupBox2.Controls.Add(this.chkSuportDoc);
            this.groupBox2.Location = new System.Drawing.Point(43, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(505, 64);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支持的文件格式";
            // 
            // chkSuportTxt
            // 
            this.chkSuportTxt.AutoSize = true;
            this.chkSuportTxt.Checked = true;
            this.chkSuportTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuportTxt.Location = new System.Drawing.Point(173, 30);
            this.chkSuportTxt.Margin = new System.Windows.Forms.Padding(4);
            this.chkSuportTxt.Name = "chkSuportTxt";
            this.chkSuportTxt.Size = new System.Drawing.Size(53, 19);
            this.chkSuportTxt.TabIndex = 33;
            this.chkSuportTxt.Text = "TXT";
            this.chkSuportTxt.UseVisualStyleBackColor = true;
            // 
            // chkSuportDocx
            // 
            this.chkSuportDocx.AutoSize = true;
            this.chkSuportDocx.Checked = true;
            this.chkSuportDocx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuportDocx.Location = new System.Drawing.Point(387, 30);
            this.chkSuportDocx.Margin = new System.Windows.Forms.Padding(4);
            this.chkSuportDocx.Name = "chkSuportDocx";
            this.chkSuportDocx.Size = new System.Drawing.Size(61, 19);
            this.chkSuportDocx.TabIndex = 32;
            this.chkSuportDocx.Text = "DOCX";
            this.chkSuportDocx.UseVisualStyleBackColor = true;
            // 
            // chkSuportPdf
            // 
            this.chkSuportPdf.AutoSize = true;
            this.chkSuportPdf.Checked = true;
            this.chkSuportPdf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuportPdf.Location = new System.Drawing.Point(65, 30);
            this.chkSuportPdf.Margin = new System.Windows.Forms.Padding(4);
            this.chkSuportPdf.Name = "chkSuportPdf";
            this.chkSuportPdf.Size = new System.Drawing.Size(53, 19);
            this.chkSuportPdf.TabIndex = 30;
            this.chkSuportPdf.Text = "PDF";
            this.chkSuportPdf.UseVisualStyleBackColor = true;
            // 
            // chkSuportDoc
            // 
            this.chkSuportDoc.AutoSize = true;
            this.chkSuportDoc.Checked = true;
            this.chkSuportDoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuportDoc.Location = new System.Drawing.Point(279, 30);
            this.chkSuportDoc.Margin = new System.Windows.Forms.Padding(4);
            this.chkSuportDoc.Name = "chkSuportDoc";
            this.chkSuportDoc.Size = new System.Drawing.Size(53, 19);
            this.chkSuportDoc.TabIndex = 31;
            this.chkSuportDoc.Text = "DOC";
            this.chkSuportDoc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestoreDefault1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtConvertThreadCnt);
            this.groupBox1.Controls.Add(this.txtCheckThreadCnt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(505, 95);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "线程数设置";
            // 
            // btnRestoreDefault1
            // 
            this.btnRestoreDefault1.Location = new System.Drawing.Point(343, 19);
            this.btnRestoreDefault1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestoreDefault1.Name = "btnRestoreDefault1";
            this.btnRestoreDefault1.Size = new System.Drawing.Size(116, 65);
            this.btnRestoreDefault1.TabIndex = 28;
            this.btnRestoreDefault1.Text = "恢复默认";
            this.btnRestoreDefault1.UseVisualStyleBackColor = true;
            this.btnRestoreDefault1.Click += new System.EventHandler(this.ButtonRestoreDefault1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "查重线程数";
            // 
            // txtConvertThreadCnt
            // 
            this.txtConvertThreadCnt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConvertThreadCnt.Location = new System.Drawing.Point(184, 55);
            this.txtConvertThreadCnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtConvertThreadCnt.MaxLength = 2;
            this.txtConvertThreadCnt.Name = "txtConvertThreadCnt";
            this.txtConvertThreadCnt.Size = new System.Drawing.Size(132, 27);
            this.txtConvertThreadCnt.TabIndex = 25;
            this.txtConvertThreadCnt.Text = "2";
            this.txtConvertThreadCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilterKeyPress);
            // 
            // txtCheckThreadCnt
            // 
            this.txtCheckThreadCnt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheckThreadCnt.Location = new System.Drawing.Point(184, 19);
            this.txtCheckThreadCnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckThreadCnt.MaxLength = 2;
            this.txtCheckThreadCnt.Name = "txtCheckThreadCnt";
            this.txtCheckThreadCnt.Size = new System.Drawing.Size(132, 27);
            this.txtCheckThreadCnt.TabIndex = 24;
            this.txtCheckThreadCnt.Text = "3";
            this.txtCheckThreadCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitFilterKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "格式转换线程数";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(601, 426);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "关于";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblVersion);
            this.groupBox6.Controls.Add(this.btnShowLicence);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Location = new System.Drawing.Point(43, 25);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(505, 66);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "版本信息";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(228, 29);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(15, 15);
            this.lblVersion.TabIndex = 27;
            this.lblVersion.Text = "0";
            // 
            // btnShowLicence
            // 
            this.btnShowLicence.Location = new System.Drawing.Point(308, 22);
            this.btnShowLicence.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLicence.Name = "btnShowLicence";
            this.btnShowLicence.Size = new System.Drawing.Size(100, 29);
            this.btnShowLicence.TabIndex = 1;
            this.btnShowLicence.Text = "开源协议";
            this.btnShowLicence.UseVisualStyleBackColor = true;
            this.btnShowLicence.Click += new System.EventHandler(this.ButtonShowLicence);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(133, 29);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 15);
            this.label23.TabIndex = 26;
            this.label23.Text = "当前版本：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Location = new System.Drawing.Point(43, 99);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(505, 295);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "使用说明";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(8, 25);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(489, 260);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 485);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "简体中文查重系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddLibrary;
        private System.Windows.Forms.Button btnStartChecking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckThreshold;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnShowReportList;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.CheckBox chkRecover;
        private System.Windows.Forms.Button btnFinalReportPath;
        private System.Windows.Forms.TextBox txtFinalReportPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCheckWay;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtConvertThreadCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCheckThreadCnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestoreDefault1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSuportTxt;
        private System.Windows.Forms.CheckBox chkSuportDocx;
        private System.Windows.Forms.CheckBox chkSuportPdf;
        private System.Windows.Forms.CheckBox chkSuportDoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnForceStop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkStatisTable;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnShowLicence;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnToCheckPaperPath;
        private System.Windows.Forms.TextBox txtToCheckPaperPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPaperSourcePath;
        private System.Windows.Forms.TextBox txtPaperSourcePath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRestoreDefault2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinBytes;
        private System.Windows.Forms.TextBox txtMinWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar pbCheckingProgress;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBlocklist;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnManageLibrary;
    }
}

