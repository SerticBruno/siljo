namespace Shutter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.background = new System.Windows.Forms.Panel();
            this.userPreferencesPanel = new System.Windows.Forms.Panel();
            this.musicLbl = new System.Windows.Forms.Label();
            this.musicCheckboxImage = new System.Windows.Forms.PictureBox();
            this.fullScrenCheckBoxLbl = new System.Windows.Forms.Label();
            this.fullscreenCheckboxImage = new System.Windows.Forms.PictureBox();
            this.startProcessBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lbl20H = new System.Windows.Forms.Label();
            this.lbl20HTxt = new System.Windows.Forms.Label();
            this.lbl10H = new System.Windows.Forms.Label();
            this.lbl10HTxt = new System.Windows.Forms.Label();
            this.lbl5H = new System.Windows.Forms.Label();
            this.lbl5HTxt = new System.Windows.Forms.Label();
            this.lbl45M = new System.Windows.Forms.Label();
            this.min45Lbl = new System.Windows.Forms.Label();
            this.lbl30M = new System.Windows.Forms.Label();
            this.min30Lbl = new System.Windows.Forms.Label();
            this.lbl15M = new System.Windows.Forms.Label();
            this.min15Lbl = new System.Windows.Forms.Label();
            this.lbl10M = new System.Windows.Forms.Label();
            this.min10Lbl = new System.Windows.Forms.Label();
            this.lbl5M = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.commandSetLbl = new System.Windows.Forms.Panel();
            this.shutDownLbl = new System.Windows.Forms.Label();
            this.restartLbl = new System.Windows.Forms.Label();
            this.sleepLbl = new System.Windows.Forms.Label();
            this.min5Lbl = new System.Windows.Forms.Label();
            this.minsDown = new System.Windows.Forms.PictureBox();
            this.minsUp = new System.Windows.Forms.PictureBox();
            this.hoursDown = new System.Windows.Forms.PictureBox();
            this.hoursUp = new System.Windows.Forms.PictureBox();
            this.cancelPanel = new System.Windows.Forms.Panel();
            this.toggleSoundBtn = new System.Windows.Forms.PictureBox();
            this.fullScreenLbl = new System.Windows.Forms.Label();
            this.cancelCountdownBtn = new System.Windows.Forms.Button();
            this.counterLbl = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.userPreferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicCheckboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenCheckboxImage)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUp)).BeginInit();
            this.cancelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSoundBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Cancel shutdown";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.userPreferencesPanel);
            this.background.Controls.Add(this.startProcessBtn);
            this.background.Controls.Add(this.mainPanel);
            this.background.Controls.Add(this.cancelPanel);
            this.background.Cursor = System.Windows.Forms.Cursors.Default;
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(308, 558);
            this.background.TabIndex = 1;
            // 
            // userPreferencesPanel
            // 
            this.userPreferencesPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPreferencesPanel.Controls.Add(this.musicLbl);
            this.userPreferencesPanel.Controls.Add(this.musicCheckboxImage);
            this.userPreferencesPanel.Controls.Add(this.fullScrenCheckBoxLbl);
            this.userPreferencesPanel.Controls.Add(this.fullscreenCheckboxImage);
            this.userPreferencesPanel.Location = new System.Drawing.Point(8, 359);
            this.userPreferencesPanel.Name = "userPreferencesPanel";
            this.userPreferencesPanel.Size = new System.Drawing.Size(291, 113);
            this.userPreferencesPanel.TabIndex = 34;
            // 
            // musicLbl
            // 
            this.musicLbl.AutoSize = true;
            this.musicLbl.BackColor = System.Drawing.Color.Transparent;
            this.musicLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLbl.ForeColor = System.Drawing.Color.White;
            this.musicLbl.Location = new System.Drawing.Point(56, 22);
            this.musicLbl.Name = "musicLbl";
            this.musicLbl.Size = new System.Drawing.Size(49, 16);
            this.musicLbl.TabIndex = 35;
            this.musicLbl.Text = "Music";
            this.musicLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicLbl_MouseUp_1);
            // 
            // musicCheckboxImage
            // 
            this.musicCheckboxImage.BackColor = System.Drawing.Color.Transparent;
            this.musicCheckboxImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicCheckboxImage.BackgroundImage")));
            this.musicCheckboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicCheckboxImage.Location = new System.Drawing.Point(38, 22);
            this.musicCheckboxImage.Name = "musicCheckboxImage";
            this.musicCheckboxImage.Size = new System.Drawing.Size(16, 16);
            this.musicCheckboxImage.TabIndex = 34;
            this.musicCheckboxImage.TabStop = false;
            this.musicCheckboxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicCheckboxImage_MouseUp);
            // 
            // fullScrenCheckBoxLbl
            // 
            this.fullScrenCheckBoxLbl.AutoSize = true;
            this.fullScrenCheckBoxLbl.BackColor = System.Drawing.Color.Transparent;
            this.fullScrenCheckBoxLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScrenCheckBoxLbl.ForeColor = System.Drawing.Color.White;
            this.fullScrenCheckBoxLbl.Location = new System.Drawing.Point(56, 0);
            this.fullScrenCheckBoxLbl.Name = "fullScrenCheckBoxLbl";
            this.fullScrenCheckBoxLbl.Size = new System.Drawing.Size(98, 16);
            this.fullScrenCheckBoxLbl.TabIndex = 33;
            this.fullScrenCheckBoxLbl.Text = "Fullscreen";
            this.fullScrenCheckBoxLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullScrenCheckBoxLbl_MouseUp);
            // 
            // fullscreenCheckboxImage
            // 
            this.fullscreenCheckboxImage.BackColor = System.Drawing.Color.Transparent;
            this.fullscreenCheckboxImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullscreenCheckboxImage.BackgroundImage")));
            this.fullscreenCheckboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullscreenCheckboxImage.Location = new System.Drawing.Point(38, 0);
            this.fullscreenCheckboxImage.Name = "fullscreenCheckboxImage";
            this.fullscreenCheckboxImage.Size = new System.Drawing.Size(16, 16);
            this.fullscreenCheckboxImage.TabIndex = 32;
            this.fullscreenCheckboxImage.TabStop = false;
            this.fullscreenCheckboxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FullscreenCheckboxImage_MouseUp);
            // 
            // startProcessBtn
            // 
            this.startProcessBtn.BackColor = System.Drawing.Color.Transparent;
            this.startProcessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startProcessBtn.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startProcessBtn.ForeColor = System.Drawing.Color.White;
            this.startProcessBtn.Location = new System.Drawing.Point(13, 485);
            this.startProcessBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startProcessBtn.Name = "startProcessBtn";
            this.startProcessBtn.Size = new System.Drawing.Size(288, 60);
            this.startProcessBtn.TabIndex = 0;
            this.startProcessBtn.Text = "Shut down";
            this.startProcessBtn.UseVisualStyleBackColor = false;
            this.startProcessBtn.Click += new System.EventHandler(this.ShutBtn_Click);
            this.startProcessBtn.MouseEnter += new System.EventHandler(this.StartProcessBtn_MouseEnter);
            this.startProcessBtn.MouseLeave += new System.EventHandler(this.StartProcessBtn_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.lbl20H);
            this.mainPanel.Controls.Add(this.lbl20HTxt);
            this.mainPanel.Controls.Add(this.lbl10H);
            this.mainPanel.Controls.Add(this.lbl10HTxt);
            this.mainPanel.Controls.Add(this.lbl5H);
            this.mainPanel.Controls.Add(this.lbl5HTxt);
            this.mainPanel.Controls.Add(this.lbl45M);
            this.mainPanel.Controls.Add(this.min45Lbl);
            this.mainPanel.Controls.Add(this.lbl30M);
            this.mainPanel.Controls.Add(this.min30Lbl);
            this.mainPanel.Controls.Add(this.lbl15M);
            this.mainPanel.Controls.Add(this.min15Lbl);
            this.mainPanel.Controls.Add(this.lbl10M);
            this.mainPanel.Controls.Add(this.min10Lbl);
            this.mainPanel.Controls.Add(this.lbl5M);
            this.mainPanel.Controls.Add(this.timeLbl);
            this.mainPanel.Controls.Add(this.commandSetLbl);
            this.mainPanel.Controls.Add(this.shutDownLbl);
            this.mainPanel.Controls.Add(this.restartLbl);
            this.mainPanel.Controls.Add(this.sleepLbl);
            this.mainPanel.Controls.Add(this.min5Lbl);
            this.mainPanel.Controls.Add(this.minsDown);
            this.mainPanel.Controls.Add(this.minsUp);
            this.mainPanel.Controls.Add(this.hoursDown);
            this.mainPanel.Controls.Add(this.hoursUp);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(288, 329);
            this.mainPanel.TabIndex = 0;
            // 
            // lbl20H
            // 
            this.lbl20H.AutoSize = true;
            this.lbl20H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl20H.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20H.ForeColor = System.Drawing.Color.White;
            this.lbl20H.Location = new System.Drawing.Point(5, 157);
            this.lbl20H.Name = "lbl20H";
            this.lbl20H.Size = new System.Drawing.Size(35, 19);
            this.lbl20H.TabIndex = 52;
            this.lbl20H.Text = "20";
            this.lbl20H.Click += new System.EventHandler(this.Lbl20H_Click);
            this.lbl20H.MouseEnter += new System.EventHandler(this.Hours20Lbl_MouseEnter);
            this.lbl20H.MouseLeave += new System.EventHandler(this.Hours20Lbl_MouseLeave);
            // 
            // lbl20HTxt
            // 
            this.lbl20HTxt.AutoSize = true;
            this.lbl20HTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl20HTxt.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20HTxt.ForeColor = System.Drawing.Color.White;
            this.lbl20HTxt.Location = new System.Drawing.Point(39, 152);
            this.lbl20HTxt.Name = "lbl20HTxt";
            this.lbl20HTxt.Size = new System.Drawing.Size(28, 29);
            this.lbl20HTxt.TabIndex = 51;
            this.lbl20HTxt.Text = "h";
            this.lbl20HTxt.Click += new System.EventHandler(this.Lbl20HTxt_Click);
            this.lbl20HTxt.MouseEnter += new System.EventHandler(this.Hours20Lbl_MouseEnter);
            this.lbl20HTxt.MouseLeave += new System.EventHandler(this.Hours20Lbl_MouseLeave);
            // 
            // lbl10H
            // 
            this.lbl10H.AutoSize = true;
            this.lbl10H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl10H.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10H.ForeColor = System.Drawing.Color.White;
            this.lbl10H.Location = new System.Drawing.Point(5, 128);
            this.lbl10H.Name = "lbl10H";
            this.lbl10H.Size = new System.Drawing.Size(35, 19);
            this.lbl10H.TabIndex = 50;
            this.lbl10H.Text = "10";
            this.lbl10H.Click += new System.EventHandler(this.Lbl10H_Click);
            this.lbl10H.MouseEnter += new System.EventHandler(this.Hours10Lbl_MouseEnter);
            this.lbl10H.MouseLeave += new System.EventHandler(this.Hours10Lbl_MouseLeave);
            // 
            // lbl10HTxt
            // 
            this.lbl10HTxt.AutoSize = true;
            this.lbl10HTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl10HTxt.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10HTxt.ForeColor = System.Drawing.Color.White;
            this.lbl10HTxt.Location = new System.Drawing.Point(39, 123);
            this.lbl10HTxt.Name = "lbl10HTxt";
            this.lbl10HTxt.Size = new System.Drawing.Size(28, 29);
            this.lbl10HTxt.TabIndex = 49;
            this.lbl10HTxt.Text = "h";
            this.lbl10HTxt.Click += new System.EventHandler(this.Lbl10HTxt_Click);
            this.lbl10HTxt.MouseEnter += new System.EventHandler(this.Hours10Lbl_MouseEnter);
            this.lbl10HTxt.MouseLeave += new System.EventHandler(this.Hours10Lbl_MouseLeave);
            // 
            // lbl5H
            // 
            this.lbl5H.AutoSize = true;
            this.lbl5H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5H.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5H.ForeColor = System.Drawing.Color.White;
            this.lbl5H.Location = new System.Drawing.Point(18, 99);
            this.lbl5H.Name = "lbl5H";
            this.lbl5H.Size = new System.Drawing.Size(22, 19);
            this.lbl5H.TabIndex = 48;
            this.lbl5H.Text = "5";
            this.lbl5H.Click += new System.EventHandler(this.Lbl5H_Click);
            this.lbl5H.MouseEnter += new System.EventHandler(this.Hours5Lbl_MouseEnter);
            this.lbl5H.MouseLeave += new System.EventHandler(this.Hours5Lbl_MouseLeave);
            // 
            // lbl5HTxt
            // 
            this.lbl5HTxt.AutoSize = true;
            this.lbl5HTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5HTxt.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5HTxt.ForeColor = System.Drawing.Color.White;
            this.lbl5HTxt.Location = new System.Drawing.Point(39, 94);
            this.lbl5HTxt.Name = "lbl5HTxt";
            this.lbl5HTxt.Size = new System.Drawing.Size(28, 29);
            this.lbl5HTxt.TabIndex = 47;
            this.lbl5HTxt.Text = "h";
            this.lbl5HTxt.Click += new System.EventHandler(this.Lbl5HTxt_Click);
            this.lbl5HTxt.MouseEnter += new System.EventHandler(this.Hours5Lbl_MouseEnter);
            this.lbl5HTxt.MouseLeave += new System.EventHandler(this.Hours5Lbl_MouseLeave);
            // 
            // lbl45M
            // 
            this.lbl45M.AutoSize = true;
            this.lbl45M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl45M.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl45M.ForeColor = System.Drawing.Color.White;
            this.lbl45M.Location = new System.Drawing.Point(196, 191);
            this.lbl45M.Name = "lbl45M";
            this.lbl45M.Size = new System.Drawing.Size(35, 19);
            this.lbl45M.TabIndex = 46;
            this.lbl45M.Text = "45";
            this.lbl45M.Click += new System.EventHandler(this.Lbl45M_Click);
            this.lbl45M.MouseEnter += new System.EventHandler(this.Min45Lbl_MouseEnter);
            this.lbl45M.MouseLeave += new System.EventHandler(this.Min45Lbl_MouseLeave);
            // 
            // min45Lbl
            // 
            this.min45Lbl.AutoSize = true;
            this.min45Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min45Lbl.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min45Lbl.ForeColor = System.Drawing.Color.White;
            this.min45Lbl.Location = new System.Drawing.Point(230, 186);
            this.min45Lbl.Name = "min45Lbl";
            this.min45Lbl.Size = new System.Drawing.Size(52, 29);
            this.min45Lbl.TabIndex = 45;
            this.min45Lbl.Text = "min";
            this.min45Lbl.Click += new System.EventHandler(this.Min45Lbl_Click_1);
            this.min45Lbl.MouseEnter += new System.EventHandler(this.Min45Lbl_MouseEnter);
            this.min45Lbl.MouseLeave += new System.EventHandler(this.Min45Lbl_MouseLeave);
            // 
            // lbl30M
            // 
            this.lbl30M.AutoSize = true;
            this.lbl30M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl30M.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30M.ForeColor = System.Drawing.Color.White;
            this.lbl30M.Location = new System.Drawing.Point(196, 162);
            this.lbl30M.Name = "lbl30M";
            this.lbl30M.Size = new System.Drawing.Size(35, 19);
            this.lbl30M.TabIndex = 44;
            this.lbl30M.Text = "30";
            this.lbl30M.Click += new System.EventHandler(this.Lbl30M_Click);
            this.lbl30M.MouseEnter += new System.EventHandler(this.Min30Lbl_MouseEnter);
            this.lbl30M.MouseLeave += new System.EventHandler(this.Min30Lbl_MouseLeave);
            // 
            // min30Lbl
            // 
            this.min30Lbl.AutoSize = true;
            this.min30Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min30Lbl.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min30Lbl.ForeColor = System.Drawing.Color.White;
            this.min30Lbl.Location = new System.Drawing.Point(230, 157);
            this.min30Lbl.Name = "min30Lbl";
            this.min30Lbl.Size = new System.Drawing.Size(52, 29);
            this.min30Lbl.TabIndex = 43;
            this.min30Lbl.Text = "min";
            this.min30Lbl.Click += new System.EventHandler(this.Min30Lbl_Click_1);
            this.min30Lbl.MouseEnter += new System.EventHandler(this.Min30Lbl_MouseEnter);
            this.min30Lbl.MouseLeave += new System.EventHandler(this.Min30Lbl_MouseLeave);
            // 
            // lbl15M
            // 
            this.lbl15M.AutoSize = true;
            this.lbl15M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl15M.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15M.ForeColor = System.Drawing.Color.White;
            this.lbl15M.Location = new System.Drawing.Point(196, 130);
            this.lbl15M.Name = "lbl15M";
            this.lbl15M.Size = new System.Drawing.Size(35, 19);
            this.lbl15M.TabIndex = 42;
            this.lbl15M.Text = "15";
            this.lbl15M.Click += new System.EventHandler(this.Lbl15M_Click);
            this.lbl15M.MouseEnter += new System.EventHandler(this.Min15Lbl_MouseEnter);
            this.lbl15M.MouseLeave += new System.EventHandler(this.Min15Lbl_MouseLeave);
            // 
            // min15Lbl
            // 
            this.min15Lbl.AutoSize = true;
            this.min15Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min15Lbl.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min15Lbl.ForeColor = System.Drawing.Color.White;
            this.min15Lbl.Location = new System.Drawing.Point(230, 128);
            this.min15Lbl.Name = "min15Lbl";
            this.min15Lbl.Size = new System.Drawing.Size(52, 29);
            this.min15Lbl.TabIndex = 41;
            this.min15Lbl.Text = "min";
            this.min15Lbl.Click += new System.EventHandler(this.Min15Lbl_Click_1);
            this.min15Lbl.MouseEnter += new System.EventHandler(this.Min15Lbl_MouseEnter);
            this.min15Lbl.MouseLeave += new System.EventHandler(this.Min15Lbl_MouseLeave);
            // 
            // lbl10M
            // 
            this.lbl10M.AutoSize = true;
            this.lbl10M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl10M.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10M.ForeColor = System.Drawing.Color.White;
            this.lbl10M.Location = new System.Drawing.Point(196, 104);
            this.lbl10M.Name = "lbl10M";
            this.lbl10M.Size = new System.Drawing.Size(35, 19);
            this.lbl10M.TabIndex = 40;
            this.lbl10M.Text = "10";
            this.lbl10M.Click += new System.EventHandler(this.Lbl10M_Click);
            this.lbl10M.MouseEnter += new System.EventHandler(this.Min10Lbl_MouseEnter);
            this.lbl10M.MouseLeave += new System.EventHandler(this.Min10Lbl_MouseLeave);
            // 
            // min10Lbl
            // 
            this.min10Lbl.AutoSize = true;
            this.min10Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min10Lbl.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min10Lbl.ForeColor = System.Drawing.Color.White;
            this.min10Lbl.Location = new System.Drawing.Point(230, 99);
            this.min10Lbl.Name = "min10Lbl";
            this.min10Lbl.Size = new System.Drawing.Size(52, 29);
            this.min10Lbl.TabIndex = 39;
            this.min10Lbl.Text = "min";
            this.min10Lbl.Click += new System.EventHandler(this.Min10Lbl_Click_1);
            this.min10Lbl.MouseEnter += new System.EventHandler(this.Min10Lbl_MouseEnter);
            this.min10Lbl.MouseLeave += new System.EventHandler(this.Min10Lbl_MouseLeave);
            // 
            // lbl5M
            // 
            this.lbl5M.AutoSize = true;
            this.lbl5M.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5M.Font = new System.Drawing.Font("Digital Display", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5M.ForeColor = System.Drawing.Color.White;
            this.lbl5M.Location = new System.Drawing.Point(209, 75);
            this.lbl5M.Name = "lbl5M";
            this.lbl5M.Size = new System.Drawing.Size(22, 19);
            this.lbl5M.TabIndex = 38;
            this.lbl5M.Text = "5";
            this.lbl5M.Click += new System.EventHandler(this.Lbl5M_Click);
            this.lbl5M.MouseEnter += new System.EventHandler(this.Min5Lbl_MouseEnter);
            this.lbl5M.MouseLeave += new System.EventHandler(this.Min5Lbl_MouseLeave);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Digital Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(74, 13);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(125, 32);
            this.timeLbl.TabIndex = 37;
            this.timeLbl.Text = "00:00";
            // 
            // commandSetLbl
            // 
            this.commandSetLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.commandSetLbl.Location = new System.Drawing.Point(36, 258);
            this.commandSetLbl.Name = "commandSetLbl";
            this.commandSetLbl.Size = new System.Drawing.Size(13, 1);
            this.commandSetLbl.TabIndex = 27;
            // 
            // shutDownLbl
            // 
            this.shutDownLbl.AutoSize = true;
            this.shutDownLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shutDownLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutDownLbl.ForeColor = System.Drawing.Color.White;
            this.shutDownLbl.Location = new System.Drawing.Point(51, 251);
            this.shutDownLbl.Name = "shutDownLbl";
            this.shutDownLbl.Size = new System.Drawing.Size(85, 16);
            this.shutDownLbl.TabIndex = 25;
            this.shutDownLbl.Text = "Shut Down";
            this.shutDownLbl.Click += new System.EventHandler(this.ShutDownLbl_Click);
            this.shutDownLbl.MouseEnter += new System.EventHandler(this.ShutDownLbl_MouseEnter);
            this.shutDownLbl.MouseLeave += new System.EventHandler(this.ShutDownLbl_MouseLeave);
            // 
            // restartLbl
            // 
            this.restartLbl.AutoSize = true;
            this.restartLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLbl.ForeColor = System.Drawing.Color.White;
            this.restartLbl.Location = new System.Drawing.Point(51, 279);
            this.restartLbl.Name = "restartLbl";
            this.restartLbl.Size = new System.Drawing.Size(71, 16);
            this.restartLbl.TabIndex = 24;
            this.restartLbl.Text = "Restart";
            this.restartLbl.Click += new System.EventHandler(this.RestartLbl_Click);
            this.restartLbl.MouseEnter += new System.EventHandler(this.RestartLbl_MouseEnter);
            this.restartLbl.MouseLeave += new System.EventHandler(this.RestartLbl_MouseLeave);
            // 
            // sleepLbl
            // 
            this.sleepLbl.AutoSize = true;
            this.sleepLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sleepLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepLbl.ForeColor = System.Drawing.Color.White;
            this.sleepLbl.Location = new System.Drawing.Point(51, 305);
            this.sleepLbl.Name = "sleepLbl";
            this.sleepLbl.Size = new System.Drawing.Size(53, 16);
            this.sleepLbl.TabIndex = 23;
            this.sleepLbl.Text = "Sleep";
            this.sleepLbl.Click += new System.EventHandler(this.SleepLbl_Click);
            this.sleepLbl.MouseEnter += new System.EventHandler(this.SleepLbl_MouseEnter);
            this.sleepLbl.MouseLeave += new System.EventHandler(this.SleepLbl_MouseLeave);
            // 
            // min5Lbl
            // 
            this.min5Lbl.AutoSize = true;
            this.min5Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min5Lbl.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min5Lbl.ForeColor = System.Drawing.Color.White;
            this.min5Lbl.Location = new System.Drawing.Point(230, 70);
            this.min5Lbl.Name = "min5Lbl";
            this.min5Lbl.Size = new System.Drawing.Size(52, 29);
            this.min5Lbl.TabIndex = 15;
            this.min5Lbl.Text = "min";
            this.min5Lbl.Click += new System.EventHandler(this.Min5Lbl_Click);
            this.min5Lbl.MouseEnter += new System.EventHandler(this.Min5Lbl_MouseEnter);
            this.min5Lbl.MouseLeave += new System.EventHandler(this.Min5Lbl_MouseLeave);
            // 
            // minsDown
            // 
            this.minsDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minsDown.BackgroundImage")));
            this.minsDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minsDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minsDown.Location = new System.Drawing.Point(143, 133);
            this.minsDown.Margin = new System.Windows.Forms.Padding(4);
            this.minsDown.Name = "minsDown";
            this.minsDown.Size = new System.Drawing.Size(56, 30);
            this.minsDown.TabIndex = 12;
            this.minsDown.TabStop = false;
            this.minsDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinsDown_MouseDown);
            this.minsDown.MouseEnter += new System.EventHandler(this.MinsDown_MouseEnter);
            this.minsDown.MouseLeave += new System.EventHandler(this.MinsDown_MouseLeave);
            this.minsDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinsDown_MouseUp);
            // 
            // minsUp
            // 
            this.minsUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minsUp.BackgroundImage")));
            this.minsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minsUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minsUp.Location = new System.Drawing.Point(143, 98);
            this.minsUp.Margin = new System.Windows.Forms.Padding(4);
            this.minsUp.Name = "minsUp";
            this.minsUp.Size = new System.Drawing.Size(56, 30);
            this.minsUp.TabIndex = 11;
            this.minsUp.TabStop = false;
            this.minsUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinsUp_MouseDown);
            this.minsUp.MouseEnter += new System.EventHandler(this.MinsUp_MouseEnter);
            this.minsUp.MouseLeave += new System.EventHandler(this.MinsUp_MouseLeave);
            this.minsUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinsUp_MouseUp);
            // 
            // hoursDown
            // 
            this.hoursDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hoursDown.BackgroundImage")));
            this.hoursDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hoursDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoursDown.Location = new System.Drawing.Point(74, 133);
            this.hoursDown.Margin = new System.Windows.Forms.Padding(4);
            this.hoursDown.Name = "hoursDown";
            this.hoursDown.Size = new System.Drawing.Size(56, 30);
            this.hoursDown.TabIndex = 8;
            this.hoursDown.TabStop = false;
            this.hoursDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HoursDown_MouseDown);
            this.hoursDown.MouseEnter += new System.EventHandler(this.HoursDown_MouseEnter);
            this.hoursDown.MouseLeave += new System.EventHandler(this.HoursDown_MouseLeave);
            this.hoursDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HoursDown_MouseUp);
            // 
            // hoursUp
            // 
            this.hoursUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hoursUp.BackgroundImage")));
            this.hoursUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hoursUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoursUp.Location = new System.Drawing.Point(74, 97);
            this.hoursUp.Margin = new System.Windows.Forms.Padding(4);
            this.hoursUp.Name = "hoursUp";
            this.hoursUp.Size = new System.Drawing.Size(56, 30);
            this.hoursUp.TabIndex = 2;
            this.hoursUp.TabStop = false;
            this.hoursUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HoursUp_MouseDown);
            this.hoursUp.MouseEnter += new System.EventHandler(this.HoursUp_MouseEnter);
            this.hoursUp.MouseLeave += new System.EventHandler(this.HoursUp_MouseLeave);
            this.hoursUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HoursUp_MouseUp);
            // 
            // cancelPanel
            // 
            this.cancelPanel.BackColor = System.Drawing.Color.Transparent;
            this.cancelPanel.Controls.Add(this.toggleSoundBtn);
            this.cancelPanel.Controls.Add(this.fullScreenLbl);
            this.cancelPanel.Controls.Add(this.cancelCountdownBtn);
            this.cancelPanel.Controls.Add(this.counterLbl);
            this.cancelPanel.Location = new System.Drawing.Point(8, 3);
            this.cancelPanel.Name = "cancelPanel";
            this.cancelPanel.Size = new System.Drawing.Size(290, 353);
            this.cancelPanel.TabIndex = 29;
            this.cancelPanel.Visible = false;
            // 
            // toggleSoundBtn
            // 
            this.toggleSoundBtn.BackgroundImage = global::Shutter.Properties.Resources.speaker;
            this.toggleSoundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleSoundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSoundBtn.Location = new System.Drawing.Point(9, 10);
            this.toggleSoundBtn.Name = "toggleSoundBtn";
            this.toggleSoundBtn.Size = new System.Drawing.Size(36, 36);
            this.toggleSoundBtn.TabIndex = 37;
            this.toggleSoundBtn.TabStop = false;
            this.toggleSoundBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToggleSoundBtn_MouseUp);
            // 
            // fullScreenLbl
            // 
            this.fullScreenLbl.AutoSize = true;
            this.fullScreenLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullScreenLbl.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenLbl.ForeColor = System.Drawing.Color.White;
            this.fullScreenLbl.Location = new System.Drawing.Point(98, 315);
            this.fullScreenLbl.Name = "fullScreenLbl";
            this.fullScreenLbl.Size = new System.Drawing.Size(98, 16);
            this.fullScreenLbl.TabIndex = 29;
            this.fullScreenLbl.Text = "Fullscreen";
            this.fullScreenLbl.Click += new System.EventHandler(this.FullScreenLbl_Click);
            this.fullScreenLbl.MouseEnter += new System.EventHandler(this.FullScreenLbl_MouseEnter);
            this.fullScreenLbl.MouseLeave += new System.EventHandler(this.FullScreenLbl_MouseLeave);
            // 
            // cancelCountdownBtn
            // 
            this.cancelCountdownBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelCountdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCountdownBtn.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCountdownBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCountdownBtn.Location = new System.Drawing.Point(0, 116);
            this.cancelCountdownBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelCountdownBtn.Name = "cancelCountdownBtn";
            this.cancelCountdownBtn.Size = new System.Drawing.Size(290, 60);
            this.cancelCountdownBtn.TabIndex = 28;
            this.cancelCountdownBtn.Text = "Cancel countdown";
            this.cancelCountdownBtn.UseVisualStyleBackColor = false;
            this.cancelCountdownBtn.Click += new System.EventHandler(this.CancelCountdownBtn_Click);
            this.cancelCountdownBtn.MouseEnter += new System.EventHandler(this.CancelCountdownBtn_MouseEnter);
            this.cancelCountdownBtn.MouseLeave += new System.EventHandler(this.CancelCountdownBtn_MouseLeave);
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Digital Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLbl.ForeColor = System.Drawing.Color.White;
            this.counterLbl.Location = new System.Drawing.Point(48, 55);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(191, 32);
            this.counterLbl.TabIndex = 36;
            this.counterLbl.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 558);
            this.Controls.Add(this.background);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Šiljo";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.background.ResumeLayout(false);
            this.userPreferencesPanel.ResumeLayout(false);
            this.userPreferencesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicCheckboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenCheckboxImage)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUp)).EndInit();
            this.cancelPanel.ResumeLayout(false);
            this.cancelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSoundBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button startProcessBtn;
        private System.Windows.Forms.PictureBox hoursUp;
        private System.Windows.Forms.PictureBox hoursDown;
        private System.Windows.Forms.Label min5Lbl;
        private System.Windows.Forms.PictureBox minsDown;
        private System.Windows.Forms.PictureBox minsUp;
        private System.Windows.Forms.Label shutDownLbl;
        private System.Windows.Forms.Label restartLbl;
        private System.Windows.Forms.Label sleepLbl;
        private System.Windows.Forms.Panel commandSetLbl;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button cancelCountdownBtn;
        private System.Windows.Forms.Panel cancelPanel;
        private System.Windows.Forms.Label fullScreenLbl;
        private System.Windows.Forms.Label musicCheckboxLbl;
        private System.Windows.Forms.Label fullScrenCheckBoxLbl;
        private System.Windows.Forms.PictureBox fullscreenCheckboxImage;
        private System.Windows.Forms.Panel userPreferencesPanel;
        private System.Windows.Forms.Label musicLbl;
        private System.Windows.Forms.PictureBox musicCheckboxImage;
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.PictureBox toggleSoundBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label lbl20H;
        private System.Windows.Forms.Label lbl20HTxt;
        private System.Windows.Forms.Label lbl10H;
        private System.Windows.Forms.Label lbl10HTxt;
        private System.Windows.Forms.Label lbl5H;
        private System.Windows.Forms.Label lbl5HTxt;
        private System.Windows.Forms.Label lbl45M;
        private System.Windows.Forms.Label min45Lbl;
        private System.Windows.Forms.Label lbl30M;
        private System.Windows.Forms.Label min30Lbl;
        private System.Windows.Forms.Label lbl15M;
        private System.Windows.Forms.Label min15Lbl;
        private System.Windows.Forms.Label lbl10M;
        private System.Windows.Forms.Label min10Lbl;
        private System.Windows.Forms.Label lbl5M;
    }
}

