namespace RykonServer
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxRootDir = new System.Windows.Forms.TextBox();
            this.btnBrowseRootDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbViewAppIntro = new System.Windows.Forms.CheckBox();
            this.tpgLanguages = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstbxExts = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNewLang = new System.Windows.Forms.Button();
            this.btnEditLang = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txbxLangArgs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbxLangPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbxLangVer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxLangName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbxLangs = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpgLanguages.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelMain.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Controls.Add(this.btnSaveSettings);
            this.panelMain.Controls.Add(this.btnResetDefaults);
            this.panelMain.Location = new System.Drawing.Point(3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(683, 497);
            this.panelMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tpgLanguages);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(671, 429);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.panel1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(663, 403);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbxRootDir);
            this.panel1.Controls.Add(this.btnBrowseRootDir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbViewAppIntro);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 396);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Root Directory";
            // 
            // txbxRootDir
            // 
            this.txbxRootDir.Location = new System.Drawing.Point(84, 11);
            this.txbxRootDir.Name = "txbxRootDir";
            this.txbxRootDir.Size = new System.Drawing.Size(434, 20);
            this.txbxRootDir.TabIndex = 3;
            this.txbxRootDir.TextChanged += new System.EventHandler(this.txbxRootDir_TextChanged);
            // 
            // btnBrowseRootDir
            // 
            this.btnBrowseRootDir.Location = new System.Drawing.Point(528, 9);
            this.btnBrowseRootDir.Name = "btnBrowseRootDir";
            this.btnBrowseRootDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRootDir.TabIndex = 5;
            this.btnBrowseRootDir.Text = "Browse";
            this.btnBrowseRootDir.UseVisualStyleBackColor = true;
            this.btnBrowseRootDir.Click += new System.EventHandler(this.btnBrowseRootDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "License";
            // 
            // cbViewAppIntro
            // 
            this.cbViewAppIntro.AutoSize = true;
            this.cbViewAppIntro.BackColor = System.Drawing.Color.Transparent;
            this.cbViewAppIntro.Location = new System.Drawing.Point(83, 57);
            this.cbViewAppIntro.Name = "cbViewAppIntro";
            this.cbViewAppIntro.Size = new System.Drawing.Size(73, 17);
            this.cbViewAppIntro.TabIndex = 1;
            this.cbViewAppIntro.Text = "View Intro";
            this.cbViewAppIntro.UseVisualStyleBackColor = false;
            this.cbViewAppIntro.CheckedChanged += new System.EventHandler(this.cbViewAppIntro_CheckedChanged);
            // 
            // tpgLanguages
            // 
            this.tpgLanguages.Controls.Add(this.panel3);
            this.tpgLanguages.Location = new System.Drawing.Point(4, 22);
            this.tpgLanguages.Name = "tpgLanguages";
            this.tpgLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLanguages.Size = new System.Drawing.Size(663, 403);
            this.tpgLanguages.TabIndex = 2;
            this.tpgLanguages.Text = "Languages";
            this.tpgLanguages.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel3.Controls.Add(this.lstbxExts);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnNewLang);
            this.panel3.Controls.Add(this.btnEditLang);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.txbxLangArgs);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txbxLangPath);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txbxLangVer);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txbxLangName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lstbxLangs);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 398);
            this.panel3.TabIndex = 0;
            // 
            // lstbxExts
            // 
            this.lstbxExts.FormattingEnabled = true;
            this.lstbxExts.Location = new System.Drawing.Point(295, 264);
            this.lstbxExts.Name = "lstbxExts";
            this.lstbxExts.Size = new System.Drawing.Size(300, 82);
            this.lstbxExts.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "File Exts";
            // 
            // btnNewLang
            // 
            this.btnNewLang.Location = new System.Drawing.Point(494, 361);
            this.btnNewLang.Name = "btnNewLang";
            this.btnNewLang.Size = new System.Drawing.Size(75, 23);
            this.btnNewLang.TabIndex = 12;
            this.btnNewLang.Text = "New";
            this.btnNewLang.UseVisualStyleBackColor = true;
            this.btnNewLang.Click += new System.EventHandler(this.btnNewLang_Click);
            // 
            // btnEditLang
            // 
            this.btnEditLang.Location = new System.Drawing.Point(575, 361);
            this.btnEditLang.Name = "btnEditLang";
            this.btnEditLang.Size = new System.Drawing.Size(75, 23);
            this.btnEditLang.TabIndex = 11;
            this.btnEditLang.Text = "Edit";
            this.btnEditLang.UseVisualStyleBackColor = true;
            this.btnEditLang.Visible = false;
            this.btnEditLang.Click += new System.EventHandler(this.btnEditLang_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(419, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txbxLangArgs
            // 
            this.txbxLangArgs.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangArgs.Location = new System.Drawing.Point(295, 174);
            this.txbxLangArgs.Name = "txbxLangArgs";
            this.txbxLangArgs.ReadOnly = true;
            this.txbxLangArgs.Size = new System.Drawing.Size(300, 13);
            this.txbxLangArgs.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Arguments";
            // 
            // txbxLangPath
            // 
            this.txbxLangPath.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangPath.Location = new System.Drawing.Point(295, 135);
            this.txbxLangPath.Name = "txbxLangPath";
            this.txbxLangPath.ReadOnly = true;
            this.txbxLangPath.Size = new System.Drawing.Size(300, 13);
            this.txbxLangPath.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Path";
            // 
            // txbxLangVer
            // 
            this.txbxLangVer.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangVer.Location = new System.Drawing.Point(295, 96);
            this.txbxLangVer.Name = "txbxLangVer";
            this.txbxLangVer.ReadOnly = true;
            this.txbxLangVer.Size = new System.Drawing.Size(300, 13);
            this.txbxLangVer.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Version";
            // 
            // txbxLangName
            // 
            this.txbxLangName.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangName.Location = new System.Drawing.Point(295, 57);
            this.txbxLangName.Name = "txbxLangName";
            this.txbxLangName.ReadOnly = true;
            this.txbxLangName.Size = new System.Drawing.Size(300, 13);
            this.txbxLangName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Languages";
            // 
            // lstbxLangs
            // 
            this.lstbxLangs.FormattingEnabled = true;
            this.lstbxLangs.Location = new System.Drawing.Point(47, 29);
            this.lstbxLangs.Name = "lstbxLangs";
            this.lstbxLangs.Size = new System.Drawing.Size(156, 355);
            this.lstbxLangs.TabIndex = 0;
            this.lstbxLangs.SelectedIndexChanged += new System.EventHandler(this.lstbxLangs_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(663, 403);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "General";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 170);
            this.panel4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(663, 403);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "General";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel5.Location = new System.Drawing.Point(4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(656, 396);
            this.panel5.TabIndex = 0;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(605, 441);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Save ";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.Location = new System.Drawing.Point(605, 470);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnResetDefaults.TabIndex = 5;
            this.btnResetDefaults.Text = "Reset";
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 506);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpgLanguages.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txbxRootDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseRootDir;
        private System.Windows.Forms.CheckBox cbViewAppIntro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetDefaults;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpgLanguages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lstbxLangs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxLangArgs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbxLangPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbxLangVer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbxLangName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEditLang;
        private System.Windows.Forms.Button btnNewLang;
        private System.Windows.Forms.ListBox lstbxExts;
        private System.Windows.Forms.Label label14;
    }
}