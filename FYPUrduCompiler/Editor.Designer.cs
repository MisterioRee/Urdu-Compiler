namespace FYPUrduCompiler
{
    partial class Editor
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textUrdu = new System.Windows.Forms.RichTextBox();
            this.richTextOutput = new System.Windows.Forms.RichTextBox();
            this.textEnglish = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urduFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishCodeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urduCodeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishCodeFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bothFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothCodeInSameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urduEditorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishEditorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompileAndRun = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAndRunCtrl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.translateCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.textUrdu, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.richTextOutput, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textEnglish, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1317, 643);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // textUrdu
            // 
            this.textUrdu.AcceptsTab = true;
            this.textUrdu.BackColor = System.Drawing.Color.Gainsboro;
            this.textUrdu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUrdu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrdu.Location = new System.Drawing.Point(661, 3);
            this.textUrdu.Name = "textUrdu";
            this.textUrdu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textUrdu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textUrdu.Size = new System.Drawing.Size(653, 508);
            this.textUrdu.TabIndex = 1;
            this.textUrdu.Text = "";
            this.textUrdu.TextChanged += new System.EventHandler(this.textUrdu_TextChanged);
            this.textUrdu.Enter += new System.EventHandler(this.richTextBox2_Enter);
            this.textUrdu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textUrdu_KeyUp);
            this.textUrdu.Leave += new System.EventHandler(this.textUrdu_Leave);
            // 
            // richTextOutput
            // 
            this.richTextOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextOutput.Location = new System.Drawing.Point(3, 517);
            this.richTextOutput.Name = "richTextOutput";
            this.richTextOutput.Size = new System.Drawing.Size(652, 123);
            this.richTextOutput.TabIndex = 2;
            this.richTextOutput.Text = "";
            // 
            // textEnglish
            // 
            this.textEnglish.BackColor = System.Drawing.Color.Gainsboro;
            this.textEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textEnglish.Location = new System.Drawing.Point(3, 3);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.ReadOnly = true;
            this.textEnglish.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textEnglish.Size = new System.Drawing.Size(652, 508);
            this.textEnglish.TabIndex = 0;
            this.textEnglish.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(565, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 23);
            this.progressBar.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1285, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.ShowShortcutKeys = false;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urduFileToolStripMenuItem,
            this.englishCodeFileToolStripMenuItem});
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.ShowShortcutKeys = false;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // urduFileToolStripMenuItem
            // 
            this.urduFileToolStripMenuItem.Name = "urduFileToolStripMenuItem";
            this.urduFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.urduFileToolStripMenuItem.Text = "Urdu Code File";
            this.urduFileToolStripMenuItem.Click += new System.EventHandler(this.urduFileToolStripMenuItem_Click);
            // 
            // englishCodeFileToolStripMenuItem
            // 
            this.englishCodeFileToolStripMenuItem.Name = "englishCodeFileToolStripMenuItem";
            this.englishCodeFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.englishCodeFileToolStripMenuItem.Text = "English Code File";
            this.englishCodeFileToolStripMenuItem.Click += new System.EventHandler(this.englishCodeFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(140, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urduCodeFileToolStripMenuItem,
            this.englishCodeFileToolStripMenuItem1,
            this.bothFileToolStripMenuItem,
            this.bothCodeInSameFileToolStripMenuItem});
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // urduCodeFileToolStripMenuItem
            // 
            this.urduCodeFileToolStripMenuItem.Name = "urduCodeFileToolStripMenuItem";
            this.urduCodeFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.urduCodeFileToolStripMenuItem.Text = "Urdu Code File";
            // 
            // englishCodeFileToolStripMenuItem1
            // 
            this.englishCodeFileToolStripMenuItem1.Name = "englishCodeFileToolStripMenuItem1";
            this.englishCodeFileToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.englishCodeFileToolStripMenuItem1.Text = "English Code File";
            // 
            // bothFileToolStripMenuItem
            // 
            this.bothFileToolStripMenuItem.Name = "bothFileToolStripMenuItem";
            this.bothFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.bothFileToolStripMenuItem.Text = "Both Codes In Seperate Files";
            // 
            // bothCodeInSameFileToolStripMenuItem
            // 
            this.bothCodeInSameFileToolStripMenuItem.Name = "bothCodeInSameFileToolStripMenuItem";
            this.bothCodeInSameFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.bothCodeInSameFileToolStripMenuItem.Text = "Both Code In Same File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urduEditorColorToolStripMenuItem,
            this.englishEditorColorToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // urduEditorColorToolStripMenuItem
            // 
            this.urduEditorColorToolStripMenuItem.Name = "urduEditorColorToolStripMenuItem";
            this.urduEditorColorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.urduEditorColorToolStripMenuItem.Text = "Urdu Editor Color";
            this.urduEditorColorToolStripMenuItem.Click += new System.EventHandler(this.urduEditorColorToolStripMenuItem_Click);
            // 
            // englishEditorColorToolStripMenuItem
            // 
            this.englishEditorColorToolStripMenuItem.Name = "englishEditorColorToolStripMenuItem";
            this.englishEditorColorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.englishEditorColorToolStripMenuItem.Text = "English Editor Color";
            this.englishEditorColorToolStripMenuItem.Click += new System.EventHandler(this.englishEditorColorToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // btnCompile
            // 
            this.btnCompile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem});
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(64, 20);
            this.btnCompile.Text = "Compile";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.compileToolStripMenuItem.Text = "Compile         Ctrl+F6";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // btnCompileAndRun
            // 
            this.btnCompileAndRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileAndRunCtrl2ToolStripMenuItem});
            this.btnCompileAndRun.Name = "btnCompileAndRun";
            this.btnCompileAndRun.Size = new System.Drawing.Size(113, 20);
            this.btnCompileAndRun.Text = "Compile And Run";
            // 
            // compileAndRunCtrl2ToolStripMenuItem
            // 
            this.compileAndRunCtrl2ToolStripMenuItem.Name = "compileAndRunCtrl2ToolStripMenuItem";
            this.compileAndRunCtrl2ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.compileAndRunCtrl2ToolStripMenuItem.Text = "Compile And Run        Ctrl+F5";
            this.compileAndRunCtrl2ToolStripMenuItem.Click += new System.EventHandler(this.compileAndRunCtrl2ToolStripMenuItem_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateCtrlTToolStripMenuItem});
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(67, 20);
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // translateCtrlTToolStripMenuItem
            // 
            this.translateCtrlTToolStripMenuItem.Name = "translateCtrlTToolStripMenuItem";
            this.translateCtrlTToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.translateCtrlTToolStripMenuItem.Text = "Translate       Ctrl+T";
            this.translateCtrlTToolStripMenuItem.Click += new System.EventHandler(this.translateCtrlTToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.btnCompile,
            this.btnCompileAndRun,
            this.btnTranslate});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1317, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 683);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RichTextBox textUrdu;
        private System.Windows.Forms.RichTextBox textEnglish;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextOutput;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urduFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishCodeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urduCodeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishCodeFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bothFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothCodeInSameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urduEditorColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishEditorColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCompile;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCompileAndRun;
        private System.Windows.Forms.ToolStripMenuItem compileAndRunCtrl2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTranslate;
        private System.Windows.Forms.ToolStripMenuItem translateCtrlTToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

