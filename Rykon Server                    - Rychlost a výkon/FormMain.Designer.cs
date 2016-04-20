namespace RykonServer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerWriter = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TpgMain = new System.Windows.Forms.TabPage();
            this.panelServer = new System.Windows.Forms.Panel();
            this.gpxStreamer = new System.Windows.Forms.GroupBox();
            this.lnk_copyStreamUrl = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTestStreamer = new System.Windows.Forms.Button();
            this.textBoxUrlStreamer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBoxDir = new System.Windows.Forms.GroupBox();
            this.linkLabelOpenRootDir = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxRootDir = new System.Windows.Forms.TextBox();
            this.GpxHead = new System.Windows.Forms.GroupBox();
            this.lnk_copyUrl = new System.Windows.Forms.LinkLabel();
            this.buttonTestSelfBrowser = new System.Windows.Forms.Button();
            this.txbxUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Prefixs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPort = new System.Windows.Forms.NumericUpDown();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelLogs = new System.Windows.Forms.Panel();
            this.lnkcloseLogs = new System.Windows.Forms.LinkLabel();
            this.txbxLogs = new System.Windows.Forms.RichTextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnk_close_settings = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage_streamer = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbswitch_streamerPreview = new System.Windows.Forms.CheckBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.tabpage_Controller = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPageDesigner = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelStatue = new System.Windows.Forms.Label();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panelMenustrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStream = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStreamOff = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStreamOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewStreamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler_off = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler_on = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRListenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadServerConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbxControlPasswd = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.TpgMain.SuspendLayout();
            this.panelServer.SuspendLayout();
            this.gpxStreamer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDir.SuspendLayout();
            this.GpxHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
            this.tabPageLogs.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelLogs.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_streamer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.tabpage_Controller.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageDesigner.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelcontainer.SuspendLayout();
            this.panelMenustrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Im Here";
            this.notifyIcon1.BalloonTipTitle = "Rykon !";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Rykon";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // timerWriter
            // 
            this.timerWriter.Interval = 6000;
            this.timerWriter.Tick += new System.EventHandler(this.timerWriter_Tick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.TpgMain);
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPage_streamer);
            this.tabControlMain.Controls.Add(this.tabpage_Controller);
            this.tabControlMain.Controls.Add(this.tabPageDesigner);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Location = new System.Drawing.Point(2, 23);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(567, 250);
            this.tabControlMain.TabIndex = 9;
            // 
            // TpgMain
            // 
            this.TpgMain.Controls.Add(this.panelServer);
            this.TpgMain.Location = new System.Drawing.Point(4, 22);
            this.TpgMain.Name = "TpgMain";
            this.TpgMain.Padding = new System.Windows.Forms.Padding(3);
            this.TpgMain.Size = new System.Drawing.Size(559, 224);
            this.TpgMain.TabIndex = 0;
            this.TpgMain.Tag = "Main";
            this.TpgMain.Text = "__Main __";
            this.TpgMain.UseVisualStyleBackColor = true;
            // 
            // panelServer
            // 
            this.panelServer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelServer.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panelServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelServer.Controls.Add(this.gpxStreamer);
            this.panelServer.Controls.Add(this.label5);
            this.panelServer.Controls.Add(this.pictureBox1);
            this.panelServer.Controls.Add(this.btnSettings);
            this.panelServer.Controls.Add(this.groupBoxDir);
            this.panelServer.Controls.Add(this.GpxHead);
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServer.Location = new System.Drawing.Point(3, 3);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(553, 218);
            this.panelServer.TabIndex = 2;
            // 
            // gpxStreamer
            // 
            this.gpxStreamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxStreamer.BackColor = System.Drawing.Color.Transparent;
            this.gpxStreamer.Controls.Add(this.lnk_copyStreamUrl);
            this.gpxStreamer.Controls.Add(this.label9);
            this.gpxStreamer.Controls.Add(this.btnTestStreamer);
            this.gpxStreamer.Controls.Add(this.textBoxUrlStreamer);
            this.gpxStreamer.Location = new System.Drawing.Point(6, 136);
            this.gpxStreamer.Name = "gpxStreamer";
            this.gpxStreamer.Size = new System.Drawing.Size(538, 40);
            this.gpxStreamer.TabIndex = 8;
            this.gpxStreamer.TabStop = false;
            this.gpxStreamer.Text = "Streamer";
            this.gpxStreamer.Enter += new System.EventHandler(this.gpxStreamer_Enter);
            // 
            // lnk_copyStreamUrl
            // 
            this.lnk_copyStreamUrl.AutoSize = true;
            this.lnk_copyStreamUrl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lnk_copyStreamUrl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnk_copyStreamUrl.Location = new System.Drawing.Point(421, 17);
            this.lnk_copyStreamUrl.Name = "lnk_copyStreamUrl";
            this.lnk_copyStreamUrl.Size = new System.Drawing.Size(39, 16);
            this.lnk_copyStreamUrl.TabIndex = 8;
            this.lnk_copyStreamUrl.TabStop = true;
            this.lnk_copyStreamUrl.Text = "Copy ";
            this.lnk_copyStreamUrl.Visible = false;
            this.lnk_copyStreamUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_copyStreamUrl_LinkClicked);
            this.lnk_copyStreamUrl.VisibleChanged += new System.EventHandler(this.lnk_copyStreamUrl_VisibleChanged);
            this.lnk_copyStreamUrl.Click += new System.EventHandler(this.lnk_copyStreamUrl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Streamer Url";
            // 
            // btnTestStreamer
            // 
            this.btnTestStreamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestStreamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(9)))));
            this.btnTestStreamer.Enabled = false;
            this.btnTestStreamer.Location = new System.Drawing.Point(424, 14);
            this.btnTestStreamer.Name = "btnTestStreamer";
            this.btnTestStreamer.Size = new System.Drawing.Size(94, 23);
            this.btnTestStreamer.TabIndex = 15;
            this.btnTestStreamer.Text = "Test";
            this.btnTestStreamer.UseVisualStyleBackColor = false;
            this.btnTestStreamer.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.btnTestStreamer.Click += new System.EventHandler(this.btnTestStreamer_Click);
            // 
            // textBoxUrlStreamer
            // 
            this.textBoxUrlStreamer.Enabled = false;
            this.textBoxUrlStreamer.Location = new System.Drawing.Point(94, 14);
            this.textBoxUrlStreamer.Name = "textBoxUrlStreamer";
            this.textBoxUrlStreamer.ReadOnly = true;
            this.textBoxUrlStreamer.Size = new System.Drawing.Size(321, 20);
            this.textBoxUrlStreamer.TabIndex = 13;
            this.textBoxUrlStreamer.TextChanged += new System.EventHandler(this.textBoxUrlStreamer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 36.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 56);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rykon Server";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RykonServer.Properties.Resources.Img;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::RykonServer.Properties.Resources.SettingsImg;
            this.btnSettings.Location = new System.Drawing.Point(424, -483);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(27, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = " ";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDir.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDir.Controls.Add(this.linkLabelOpenRootDir);
            this.groupBoxDir.Controls.Add(this.label2);
            this.groupBoxDir.Controls.Add(this.txbxRootDir);
            this.groupBoxDir.Location = new System.Drawing.Point(6, 179);
            this.groupBoxDir.Name = "groupBoxDir";
            this.groupBoxDir.Size = new System.Drawing.Size(538, 37);
            this.groupBoxDir.TabIndex = 4;
            this.groupBoxDir.TabStop = false;
            this.groupBoxDir.Text = "Directory";
            // 
            // linkLabelOpenRootDir
            // 
            this.linkLabelOpenRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelOpenRootDir.AutoSize = true;
            this.linkLabelOpenRootDir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelOpenRootDir.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelOpenRootDir.Location = new System.Drawing.Point(421, 15);
            this.linkLabelOpenRootDir.Name = "linkLabelOpenRootDir";
            this.linkLabelOpenRootDir.Size = new System.Drawing.Size(95, 16);
            this.linkLabelOpenRootDir.TabIndex = 7;
            this.linkLabelOpenRootDir.TabStop = true;
            this.linkLabelOpenRootDir.Text = "Open in explorer";
            this.linkLabelOpenRootDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenRootDir_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Main";
            // 
            // txbxRootDir
            // 
            this.txbxRootDir.Location = new System.Drawing.Point(95, 11);
            this.txbxRootDir.Name = "txbxRootDir";
            this.txbxRootDir.ReadOnly = true;
            this.txbxRootDir.Size = new System.Drawing.Size(320, 20);
            this.txbxRootDir.TabIndex = 4;
            // 
            // GpxHead
            // 
            this.GpxHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpxHead.BackColor = System.Drawing.Color.Transparent;
            this.GpxHead.Controls.Add(this.lnk_copyUrl);
            this.GpxHead.Controls.Add(this.buttonTestSelfBrowser);
            this.GpxHead.Controls.Add(this.txbxUrl);
            this.GpxHead.Controls.Add(this.label4);
            this.GpxHead.Controls.Add(this.cb_Prefixs);
            this.GpxHead.Controls.Add(this.label3);
            this.GpxHead.Controls.Add(this.label1);
            this.GpxHead.Controls.Add(this.NumPort);
            this.GpxHead.Controls.Add(this.btnSwitch);
            this.GpxHead.Location = new System.Drawing.Point(6, 66);
            this.GpxHead.Name = "GpxHead";
            this.GpxHead.Size = new System.Drawing.Size(538, 70);
            this.GpxHead.TabIndex = 2;
            this.GpxHead.TabStop = false;
            this.GpxHead.Text = "Server Control";
            // 
            // lnk_copyUrl
            // 
            this.lnk_copyUrl.AutoSize = true;
            this.lnk_copyUrl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_copyUrl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnk_copyUrl.Location = new System.Drawing.Point(421, 43);
            this.lnk_copyUrl.Name = "lnk_copyUrl";
            this.lnk_copyUrl.Size = new System.Drawing.Size(36, 16);
            this.lnk_copyUrl.TabIndex = 12;
            this.lnk_copyUrl.TabStop = true;
            this.lnk_copyUrl.Text = "Copy";
            this.lnk_copyUrl.Visible = false;
            this.lnk_copyUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_copyUrl_LinkClicked);
            this.lnk_copyUrl.VisibleChanged += new System.EventHandler(this.lnk_copyUrl_VisibleChanged);
            // 
            // buttonTestSelfBrowser
            // 
            this.buttonTestSelfBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestSelfBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(9)))));
            this.buttonTestSelfBrowser.Location = new System.Drawing.Point(424, 38);
            this.buttonTestSelfBrowser.Name = "buttonTestSelfBrowser";
            this.buttonTestSelfBrowser.Size = new System.Drawing.Size(94, 23);
            this.buttonTestSelfBrowser.TabIndex = 11;
            this.buttonTestSelfBrowser.Text = "Test";
            this.buttonTestSelfBrowser.UseVisualStyleBackColor = false;
            this.buttonTestSelfBrowser.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.buttonTestSelfBrowser.Click += new System.EventHandler(this.buttonTestSelfBrowser_Click);
            // 
            // txbxUrl
            // 
            this.txbxUrl.Enabled = false;
            this.txbxUrl.Location = new System.Drawing.Point(95, 41);
            this.txbxUrl.Name = "txbxUrl";
            this.txbxUrl.ReadOnly = true;
            this.txbxUrl.Size = new System.Drawing.Size(320, 20);
            this.txbxUrl.TabIndex = 9;
            this.txbxUrl.TextChanged += new System.EventHandler(this.txbxUrl_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Url";
            // 
            // cb_Prefixs
            // 
            this.cb_Prefixs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prefixs.FormattingEnabled = true;
            this.cb_Prefixs.Location = new System.Drawing.Point(95, 14);
            this.cb_Prefixs.Name = "cb_Prefixs";
            this.cb_Prefixs.Size = new System.Drawing.Size(206, 21);
            this.cb_Prefixs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prefix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // NumPort
            // 
            this.NumPort.Location = new System.Drawing.Point(339, 14);
            this.NumPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPort.Name = "NumPort";
            this.NumPort.Size = new System.Drawing.Size(76, 20);
            this.NumPort.TabIndex = 1;
            this.NumPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            this.NumPort.ValueChanged += new System.EventHandler(this.NumPort_ValueChanged);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.btnSwitch.Location = new System.Drawing.Point(424, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(96, 23);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Start";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageLogs.Controls.Add(this.panel2);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(559, 224);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Tag = "Logs";
            this.tabPageLogs.Text = "Logs";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel2.Controls.Add(this.PanelLogs);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 240);
            this.panel2.TabIndex = 0;
            // 
            // PanelLogs
            // 
            this.PanelLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogs.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogs.Controls.Add(this.lnkcloseLogs);
            this.PanelLogs.Controls.Add(this.txbxLogs);
            this.PanelLogs.Location = new System.Drawing.Point(3, -1);
            this.PanelLogs.Name = "PanelLogs";
            this.PanelLogs.Size = new System.Drawing.Size(546, 238);
            this.PanelLogs.TabIndex = 4;
            this.PanelLogs.Text = "Logs";
            // 
            // lnkcloseLogs
            // 
            this.lnkcloseLogs.AutoSize = true;
            this.lnkcloseLogs.LinkColor = System.Drawing.Color.Red;
            this.lnkcloseLogs.Location = new System.Drawing.Point(527, 7);
            this.lnkcloseLogs.Name = "lnkcloseLogs";
            this.lnkcloseLogs.Size = new System.Drawing.Size(14, 13);
            this.lnkcloseLogs.TabIndex = 1;
            this.lnkcloseLogs.TabStop = true;
            this.lnkcloseLogs.Text = "X";
            this.lnkcloseLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkcloseLogs_LinkClicked);
            // 
            // txbxLogs
            // 
            this.txbxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLogs.Location = new System.Drawing.Point(4, 19);
            this.txbxLogs.Name = "txbxLogs";
            this.txbxLogs.Size = new System.Drawing.Size(536, 213);
            this.txbxLogs.TabIndex = 0;
            this.txbxLogs.Text = "";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panel1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(559, 224);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel1.Controls.Add(this.lnk_close_settings);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 218);
            this.panel1.TabIndex = 0;
            // 
            // lnk_close_settings
            // 
            this.lnk_close_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_close_settings.AutoSize = true;
            this.lnk_close_settings.LinkColor = System.Drawing.Color.Red;
            this.lnk_close_settings.Location = new System.Drawing.Point(536, 4);
            this.lnk_close_settings.Name = "lnk_close_settings";
            this.lnk_close_settings.Size = new System.Drawing.Size(14, 13);
            this.lnk_close_settings.TabIndex = 2;
            this.lnk_close_settings.TabStop = true;
            this.lnk_close_settings.Text = "X";
            this.lnk_close_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_settings_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "label6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label8.Location = new System.Drawing.Point(81, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Not implemented";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // tabPage_streamer
            // 
            this.tabPage_streamer.Controls.Add(this.panel3);
            this.tabPage_streamer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_streamer.Name = "tabPage_streamer";
            this.tabPage_streamer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_streamer.Size = new System.Drawing.Size(559, 224);
            this.tabPage_streamer.TabIndex = 3;
            this.tabPage_streamer.Text = "streamer";
            this.tabPage_streamer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel3.Controls.Add(this.cbswitch_streamerPreview);
            this.panel3.Controls.Add(this.imgPreview);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 218);
            this.panel3.TabIndex = 1;
            // 
            // cbswitch_streamerPreview
            // 
            this.cbswitch_streamerPreview.AutoSize = true;
            this.cbswitch_streamerPreview.Location = new System.Drawing.Point(470, 49);
            this.cbswitch_streamerPreview.Name = "cbswitch_streamerPreview";
            this.cbswitch_streamerPreview.Size = new System.Drawing.Size(94, 17);
            this.cbswitch_streamerPreview.TabIndex = 4;
            this.cbswitch_streamerPreview.Text = "View Streamer";
            this.cbswitch_streamerPreview.UseVisualStyleBackColor = true;
            this.cbswitch_streamerPreview.CheckedChanged += new System.EventHandler(this.cbswitch_streamerPreview_CheckedChanged);
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(32, 60);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(421, 158);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(536, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_settings_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label14.Location = new System.Drawing.Point(114, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(349, 44);
            this.label14.TabIndex = 0;
            this.label14.Text = "Under constructing ";
            // 
            // tabpage_Controller
            // 
            this.tabpage_Controller.Controls.Add(this.panel4);
            this.tabpage_Controller.Location = new System.Drawing.Point(4, 22);
            this.tabpage_Controller.Name = "tabpage_Controller";
            this.tabpage_Controller.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_Controller.Size = new System.Drawing.Size(559, 224);
            this.tabpage_Controller.TabIndex = 4;
            this.tabpage_Controller.Text = "Controller";
            this.tabpage_Controller.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel4.Controls.Add(this.txbxControlPasswd);
            this.panel4.Controls.Add(this.linkLabel2);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 218);
            this.panel4.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(536, 4);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(14, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_settings_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "label6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "label6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label19.Location = new System.Drawing.Point(81, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(310, 44);
            this.label19.TabIndex = 0;
            this.label19.Text = "Not implemented";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "label6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(131, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Password";
            // 
            // tabPageDesigner
            // 
            this.tabPageDesigner.Controls.Add(this.panel5);
            this.tabPageDesigner.Location = new System.Drawing.Point(4, 22);
            this.tabPageDesigner.Name = "tabPageDesigner";
            this.tabPageDesigner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesigner.Size = new System.Drawing.Size(559, 224);
            this.tabPageDesigner.TabIndex = 5;
            this.tabPageDesigner.Text = "Design Editor";
            this.tabPageDesigner.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel5.Controls.Add(this.linkLabel3);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 218);
            this.panel5.TabIndex = 2;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(536, 4);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(14, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "X";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_settings_LinkClicked);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "label6";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "label6";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label24.Location = new System.Drawing.Point(81, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(310, 44);
            this.label24.TabIndex = 0;
            this.label24.Text = "Not implemented";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "label6";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "label26";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.panel6);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(559, 224);
            this.tabPageAbout.TabIndex = 6;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.linkLabel5);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.linkLabel4);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(553, 218);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RykonServer.Properties.Resources._17496578;
            this.pictureBox2.Location = new System.Drawing.Point(17, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel5.Location = new System.Drawing.Point(471, 225);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(54, 13);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Visit Page";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(132, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 163);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Location = new System.Drawing.Point(536, 4);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(14, 13);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "X";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_settings_LinkClicked);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label29.Location = new System.Drawing.Point(178, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(347, 44);
            this.label29.TabIndex = 0;
            this.label29.Text = "Under Construction";
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.panelBottom.Controls.Add(this.labelStatue);
            this.panelBottom.ForeColor = System.Drawing.Color.Black;
            this.panelBottom.Location = new System.Drawing.Point(2, 276);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(567, 17);
            this.panelBottom.TabIndex = 5;
            // 
            // labelStatue
            // 
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(9, 2);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(10, 13);
            this.labelStatue.TabIndex = 0;
            this.labelStatue.Text = ".";
            // 
            // panelcontainer
            // 
            this.panelcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelcontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcontainer.Controls.Add(this.panelBottom);
            this.panelcontainer.Controls.Add(this.panelMenustrip);
            this.panelcontainer.Controls.Add(this.tabControlMain);
            this.panelcontainer.Location = new System.Drawing.Point(1, 1);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(574, 297);
            this.panelcontainer.TabIndex = 10;
            // 
            // panelMenustrip
            // 
            this.panelMenustrip.Controls.Add(this.menuStrip1);
            this.panelMenustrip.Location = new System.Drawing.Point(2, -1);
            this.panelMenustrip.Name = "panelMenustrip";
            this.panelMenustrip.Size = new System.Drawing.Size(567, 22);
            this.panelMenustrip.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.designerToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serverToolStripMenuItem.BackgroundImage")));
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.reloadServerConfigurationToolStripMenuItem,
            this.logsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem,
            this.offlineToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            this.onlineToolStripMenuItem.Click += new System.EventHandler(this.onlineToolStripMenuItem_Click);
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.Checked = true;
            this.offlineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            this.offlineToolStripMenuItem.Click += new System.EventHandler(this.offlineToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            this.logsToolStripMenuItem1.Click += new System.EventHandler(this.logsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("designerToolStripMenuItem.BackgroundImage")));
            this.designerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolsToolStripMenuItem.BackgroundImage")));
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrpBtnStream,
            this.Tsrtrp_controler,
            this.soundPlayerToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.videoToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // tstrpBtnStream
            // 
            this.tstrpBtnStream.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrpBtnStreamOff,
            this.tstrpBtnStreamOn,
            this.toolStripSeparator2,
            this.viewStreamerToolStripMenuItem});
            this.tstrpBtnStream.Name = "tstrpBtnStream";
            this.tstrpBtnStream.Size = new System.Drawing.Size(152, 22);
            this.tstrpBtnStream.Text = "Streamer";
            // 
            // tstrpBtnStreamOff
            // 
            this.tstrpBtnStreamOff.Name = "tstrpBtnStreamOff";
            this.tstrpBtnStreamOff.Size = new System.Drawing.Size(149, 22);
            this.tstrpBtnStreamOff.Text = "Off";
            this.tstrpBtnStreamOff.Click += new System.EventHandler(this.tstrpBtnStreamOff_Click);
            // 
            // tstrpBtnStreamOn
            // 
            this.tstrpBtnStreamOn.Name = "tstrpBtnStreamOn";
            this.tstrpBtnStreamOn.Size = new System.Drawing.Size(149, 22);
            this.tstrpBtnStreamOn.Text = "On";
            this.tstrpBtnStreamOn.Click += new System.EventHandler(this.tstrpBtnStreamOn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // viewStreamerToolStripMenuItem
            // 
            this.viewStreamerToolStripMenuItem.Name = "viewStreamerToolStripMenuItem";
            this.viewStreamerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewStreamerToolStripMenuItem.Text = "View Streamer";
            this.viewStreamerToolStripMenuItem.Click += new System.EventHandler(this.viewStreamerToolStripMenuItem_Click);
            // 
            // Tsrtrp_controler
            // 
            this.Tsrtrp_controler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsrtrp_controler_off,
            this.Tsrtrp_controler_on,
            this.toolStripSeparator3,
            this.viewControllerToolStripMenuItem});
            this.Tsrtrp_controler.Name = "Tsrtrp_controler";
            this.Tsrtrp_controler.Size = new System.Drawing.Size(152, 22);
            this.Tsrtrp_controler.Text = "Controler";
            // 
            // Tsrtrp_controler_off
            // 
            this.Tsrtrp_controler_off.Name = "Tsrtrp_controler_off";
            this.Tsrtrp_controler_off.Size = new System.Drawing.Size(155, 22);
            this.Tsrtrp_controler_off.Text = "Off";
            this.Tsrtrp_controler_off.Click += new System.EventHandler(this.Tsrtrp_controler_off_Click);
            // 
            // Tsrtrp_controler_on
            // 
            this.Tsrtrp_controler_on.Name = "Tsrtrp_controler_on";
            this.Tsrtrp_controler_on.Size = new System.Drawing.Size(155, 22);
            this.Tsrtrp_controler_on.Text = "On";
            this.Tsrtrp_controler_on.Click += new System.EventHandler(this.Tsrtrp_controler_on_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // viewControllerToolStripMenuItem
            // 
            this.viewControllerToolStripMenuItem.Name = "viewControllerToolStripMenuItem";
            this.viewControllerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.viewControllerToolStripMenuItem.Text = "View Controller";
            this.viewControllerToolStripMenuItem.Click += new System.EventHandler(this.viewControllerToolStripMenuItem_Click);
            // 
            // soundPlayerToolStripMenuItem
            // 
            this.soundPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem,
            this.toolStripSeparator4,
            this.viewRListenToolStripMenuItem});
            this.soundPlayerToolStripMenuItem.Name = "soundPlayerToolStripMenuItem";
            this.soundPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soundPlayerToolStripMenuItem.Text = "Rykon Listen";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // viewRListenToolStripMenuItem
            // 
            this.viewRListenToolStripMenuItem.Name = "viewRListenToolStripMenuItem";
            this.viewRListenToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewRListenToolStripMenuItem.Text = "View RListen";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.BackgroundImage")));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.closeTabsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeTabsToolStripMenuItem
            // 
            this.closeTabsToolStripMenuItem.Name = "closeTabsToolStripMenuItem";
            this.closeTabsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeTabsToolStripMenuItem.Text = "Close Tabs";
            this.closeTabsToolStripMenuItem.Click += new System.EventHandler(this.closeTabsToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.videoToolStripMenuItem.Text = "Video player";
            // 
            // reloadServerConfigurationToolStripMenuItem
            // 
            this.reloadServerConfigurationToolStripMenuItem.Name = "reloadServerConfigurationToolStripMenuItem";
            this.reloadServerConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reloadServerConfigurationToolStripMenuItem.Text = "Reload Configuration";
            this.reloadServerConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadServerConfigurationToolStripMenuItem_Click);
            // 
            // txbxControlPasswd
            // 
            this.txbxControlPasswd.Location = new System.Drawing.Point(238, 18);
            this.txbxControlPasswd.Name = "txbxControlPasswd";
            this.txbxControlPasswd.Size = new System.Drawing.Size(100, 20);
            this.txbxControlPasswd.TabIndex = 3;
            this.txbxControlPasswd.Text = "1234";
            this.txbxControlPasswd.TextChanged += new System.EventHandler(this.txbxControlPasswd_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(577, 300);
            this.Controls.Add(this.panelcontainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Rykon Server    ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.TpgMain.ResumeLayout(false);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            this.gpxStreamer.ResumeLayout(false);
            this.gpxStreamer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.GpxHead.ResumeLayout(false);
            this.GpxHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
            this.tabPageLogs.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelLogs.ResumeLayout(false);
            this.PanelLogs.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_streamer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.tabpage_Controller.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageDesigner.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelcontainer.ResumeLayout(false);
            this.panelMenustrip.ResumeLayout(false);
            this.panelMenustrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerWriter;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TpgMain;
        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.GroupBox gpxStreamer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTestStreamer;
        private System.Windows.Forms.TextBox textBoxUrlStreamer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.LinkLabel linkLabelOpenRootDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxRootDir;
        private System.Windows.Forms.GroupBox GpxHead;
        private System.Windows.Forms.Button buttonTestSelfBrowser;
        private System.Windows.Forms.TextBox txbxUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Prefixs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumPort;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.LinkLabel lnk_copyUrl;
        private System.Windows.Forms.LinkLabel lnk_copyStreamUrl;
        private System.Windows.Forms.Panel panelMenustrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelLogs;
        private System.Windows.Forms.RichTextBox txbxLogs;
        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_off;
        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_on;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkcloseLogs;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.LinkLabel lnk_close_settings;
        private System.Windows.Forms.TabPage tabPage_streamer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabpage_Controller;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStream;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStreamOff;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStreamOn;
        private System.Windows.Forms.ToolStripMenuItem viewStreamerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPageDesigner;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.ToolStripMenuItem closeTabsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.CheckBox cbswitch_streamerPreview;
        private System.Windows.Forms.ToolStripMenuItem soundPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewRListenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadServerConfigurationToolStripMenuItem;
        private System.Windows.Forms.TextBox txbxControlPasswd;
    }
}

