namespace Soundify
{
    partial class MainWindow
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
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.FormTabPages = new ReaLTaiizor.Controls.TabPage();
            this.SpotifyTabPage = new System.Windows.Forms.TabPage();
            this.SoundCldTabPage = new System.Windows.Forms.TabPage();
            this.MediaControlsTabPage = new System.Windows.Forms.TabPage();
            this.AddonsTabPage = new System.Windows.Forms.TabPage();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.CreditsTabPage = new System.Windows.Forms.TabPage();
            this.SpotifyWView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SoundCloudWView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.MainCredsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.OtherCredsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.DevelopTitleLabel = new System.Windows.Forms.Label();
            this.TkPicBox = new System.Windows.Forms.PictureBox();
            this.ScrimPicBox = new System.Windows.Forms.PictureBox();
            this.ScrimLabel = new System.Windows.Forms.Label();
            this.TkLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionIdent = new System.Windows.Forms.Label();
            this.JonasCredit = new System.Windows.Forms.LinkLabel();
            this.DubyaCredit = new System.Windows.Forms.LinkLabel();
            this.LacheeCredit = new System.Windows.Forms.LinkLabel();
            this.TaiizorCredit = new System.Windows.Forms.LinkLabel();
            this.ChanyaCredit = new System.Windows.Forms.LinkLabel();
            this.WebsiteLinksPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.FormTabPages.SuspendLayout();
            this.SpotifyTabPage.SuspendLayout();
            this.SoundCldTabPage.SuspendLayout();
            this.CreditsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWView)).BeginInit();
            this.MainCredsPanel.SuspendLayout();
            this.OtherCredsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrimPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Interval = 1100;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // FormTabPages
            // 
            this.FormTabPages.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormTabPages.ActiveLineTabColor = System.Drawing.Color.DarkSlateBlue;
            this.FormTabPages.ActiveTabColor = System.Drawing.Color.SlateBlue;
            this.FormTabPages.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.FormTabPages.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.FormTabPages.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.FormTabPages.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormTabPages.Controls.Add(this.SpotifyTabPage);
            this.FormTabPages.Controls.Add(this.SoundCldTabPage);
            this.FormTabPages.Controls.Add(this.MediaControlsTabPage);
            this.FormTabPages.Controls.Add(this.AddonsTabPage);
            this.FormTabPages.Controls.Add(this.SettingsTabPage);
            this.FormTabPages.Controls.Add(this.CreditsTabPage);
            this.FormTabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTabPages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.FormTabPages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTabPages.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormTabPages.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.FormTabPages.ItemSize = new System.Drawing.Size(44, 135);
            this.FormTabPages.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.FormTabPages.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.FormTabPages.Location = new System.Drawing.Point(0, 0);
            this.FormTabPages.Multiline = true;
            this.FormTabPages.Name = "FormTabPages";
            this.FormTabPages.NormalForeColor = System.Drawing.Color.White;
            this.FormTabPages.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FormTabPages.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.FormTabPages.SelectedIndex = 0;
            this.FormTabPages.ShowToolTips = true;
            this.FormTabPages.Size = new System.Drawing.Size(984, 661);
            this.FormTabPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.FormTabPages.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.FormTabPages.StringType = System.Drawing.StringAlignment.Near;
            this.FormTabPages.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormTabPages.TabIndex = 0;
            this.FormTabPages.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // SpotifyTabPage
            // 
            this.SpotifyTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SpotifyTabPage.Controls.Add(this.SpotifyWView);
            this.SpotifyTabPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotifyTabPage.ImageKey = "(none)";
            this.SpotifyTabPage.Location = new System.Drawing.Point(139, 4);
            this.SpotifyTabPage.Name = "SpotifyTabPage";
            this.SpotifyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SpotifyTabPage.Size = new System.Drawing.Size(841, 653);
            this.SpotifyTabPage.TabIndex = 0;
            this.SpotifyTabPage.Text = "Spotify";
            // 
            // SoundCldTabPage
            // 
            this.SoundCldTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SoundCldTabPage.Controls.Add(this.SoundCloudWView);
            this.SoundCldTabPage.Location = new System.Drawing.Point(139, 4);
            this.SoundCldTabPage.Name = "SoundCldTabPage";
            this.SoundCldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SoundCldTabPage.Size = new System.Drawing.Size(841, 653);
            this.SoundCldTabPage.TabIndex = 1;
            this.SoundCldTabPage.Text = "Soundcloud";
            // 
            // MediaControlsTabPage
            // 
            this.MediaControlsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MediaControlsTabPage.Location = new System.Drawing.Point(139, 4);
            this.MediaControlsTabPage.Name = "MediaControlsTabPage";
            this.MediaControlsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MediaControlsTabPage.Size = new System.Drawing.Size(841, 653);
            this.MediaControlsTabPage.TabIndex = 2;
            this.MediaControlsTabPage.Text = "Media Controls";
            // 
            // AddonsTabPage
            // 
            this.AddonsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.AddonsTabPage.Location = new System.Drawing.Point(139, 4);
            this.AddonsTabPage.Name = "AddonsTabPage";
            this.AddonsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddonsTabPage.Size = new System.Drawing.Size(841, 653);
            this.AddonsTabPage.TabIndex = 3;
            this.AddonsTabPage.Text = "Addons";
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SettingsTabPage.Location = new System.Drawing.Point(139, 4);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(841, 653);
            this.SettingsTabPage.TabIndex = 4;
            this.SettingsTabPage.Text = "Settings";
            // 
            // CreditsTabPage
            // 
            this.CreditsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CreditsTabPage.Controls.Add(this.WebsiteLinksPanel);
            this.CreditsTabPage.Controls.Add(this.OtherCredsPanel);
            this.CreditsTabPage.Controls.Add(this.MainCredsPanel);
            this.CreditsTabPage.Location = new System.Drawing.Point(139, 4);
            this.CreditsTabPage.Name = "CreditsTabPage";
            this.CreditsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreditsTabPage.Size = new System.Drawing.Size(841, 653);
            this.CreditsTabPage.TabIndex = 5;
            this.CreditsTabPage.Text = "Credits";
            // 
            // SpotifyWView
            // 
            this.SpotifyWView.AllowExternalDrop = true;
            this.SpotifyWView.CreationProperties = null;
            this.SpotifyWView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.SpotifyWView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotifyWView.Location = new System.Drawing.Point(3, 3);
            this.SpotifyWView.Name = "SpotifyWView";
            this.SpotifyWView.Size = new System.Drawing.Size(835, 647);
            this.SpotifyWView.TabIndex = 0;
            this.SpotifyWView.ZoomFactor = 1D;
            // 
            // SoundCloudWView
            // 
            this.SoundCloudWView.AllowExternalDrop = true;
            this.SoundCloudWView.CreationProperties = null;
            this.SoundCloudWView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.SoundCloudWView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoundCloudWView.Location = new System.Drawing.Point(3, 3);
            this.SoundCloudWView.Name = "SoundCloudWView";
            this.SoundCloudWView.Size = new System.Drawing.Size(835, 647);
            this.SoundCloudWView.TabIndex = 0;
            this.SoundCloudWView.ZoomFactor = 1D;
            // 
            // MainCredsPanel
            // 
            this.MainCredsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MainCredsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.MainCredsPanel.Controls.Add(this.VersionIdent);
            this.MainCredsPanel.Controls.Add(this.VersionLabel);
            this.MainCredsPanel.Controls.Add(this.TkLabel);
            this.MainCredsPanel.Controls.Add(this.ScrimLabel);
            this.MainCredsPanel.Controls.Add(this.ScrimPicBox);
            this.MainCredsPanel.Controls.Add(this.TkPicBox);
            this.MainCredsPanel.Controls.Add(this.DevelopTitleLabel);
            this.MainCredsPanel.Controls.Add(this.LogoPicBox);
            this.MainCredsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainCredsPanel.ForeColor = System.Drawing.Color.White;
            this.MainCredsPanel.Location = new System.Drawing.Point(6, 3);
            this.MainCredsPanel.Name = "MainCredsPanel";
            this.MainCredsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainCredsPanel.ShowText = true;
            this.MainCredsPanel.Size = new System.Drawing.Size(280, 310);
            this.MainCredsPanel.TabIndex = 0;
            this.MainCredsPanel.Text = "Main Credits";
            // 
            // OtherCredsPanel
            // 
            this.OtherCredsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OtherCredsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.OtherCredsPanel.Controls.Add(this.ChanyaCredit);
            this.OtherCredsPanel.Controls.Add(this.TaiizorCredit);
            this.OtherCredsPanel.Controls.Add(this.LacheeCredit);
            this.OtherCredsPanel.Controls.Add(this.DubyaCredit);
            this.OtherCredsPanel.Controls.Add(this.JonasCredit);
            this.OtherCredsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OtherCredsPanel.ForeColor = System.Drawing.Color.White;
            this.OtherCredsPanel.Location = new System.Drawing.Point(292, 3);
            this.OtherCredsPanel.Name = "OtherCredsPanel";
            this.OtherCredsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.OtherCredsPanel.ShowText = true;
            this.OtherCredsPanel.Size = new System.Drawing.Size(280, 310);
            this.OtherCredsPanel.TabIndex = 1;
            this.OtherCredsPanel.Text = "Other Credits";
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Soundify.Properties.Resources.Purple_Trans;
            this.LogoPicBox.Location = new System.Drawing.Point(4, 25);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(273, 160);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 0;
            this.LogoPicBox.TabStop = false;
            // 
            // DevelopTitleLabel
            // 
            this.DevelopTitleLabel.AutoSize = true;
            this.DevelopTitleLabel.Location = new System.Drawing.Point(3, 164);
            this.DevelopTitleLabel.Name = "DevelopTitleLabel";
            this.DevelopTitleLabel.Size = new System.Drawing.Size(163, 21);
            this.DevelopTitleLabel.TabIndex = 1;
            this.DevelopTitleLabel.Text = "Developed with <3 By";
            // 
            // TkPicBox
            // 
            this.TkPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TkPicBox.Image = global::Soundify.Properties.Resources.Terkoshi;
            this.TkPicBox.Location = new System.Drawing.Point(4, 188);
            this.TkPicBox.Name = "TkPicBox";
            this.TkPicBox.Size = new System.Drawing.Size(80, 93);
            this.TkPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TkPicBox.TabIndex = 2;
            this.TkPicBox.TabStop = false;
            this.TkPicBox.Click += new System.EventHandler(this.TkPicBox_Click);
            // 
            // ScrimPicBox
            // 
            this.ScrimPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScrimPicBox.Image = global::Soundify.Properties.Resources.ScrimGearGrad2;
            this.ScrimPicBox.Location = new System.Drawing.Point(90, 188);
            this.ScrimPicBox.Name = "ScrimPicBox";
            this.ScrimPicBox.Size = new System.Drawing.Size(80, 93);
            this.ScrimPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScrimPicBox.TabIndex = 3;
            this.ScrimPicBox.TabStop = false;
            this.ScrimPicBox.Click += new System.EventHandler(this.ScrimPicBox_Click);
            // 
            // ScrimLabel
            // 
            this.ScrimLabel.AutoSize = true;
            this.ScrimLabel.Location = new System.Drawing.Point(86, 284);
            this.ScrimLabel.Name = "ScrimLabel";
            this.ScrimLabel.Size = new System.Drawing.Size(89, 21);
            this.ScrimLabel.TabIndex = 4;
            this.ScrimLabel.Text = "Scrimmane";
            // 
            // TkLabel
            // 
            this.TkLabel.AutoSize = true;
            this.TkLabel.Location = new System.Drawing.Point(3, 284);
            this.TkLabel.Name = "TkLabel";
            this.TkLabel.Size = new System.Drawing.Size(67, 21);
            this.TkLabel.TabIndex = 5;
            this.TkLabel.Text = "Terkoshi";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.VersionLabel.Location = new System.Drawing.Point(241, 284);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(36, 21);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "null";
            // 
            // VersionIdent
            // 
            this.VersionIdent.AutoSize = true;
            this.VersionIdent.ForeColor = System.Drawing.Color.White;
            this.VersionIdent.Location = new System.Drawing.Point(223, 284);
            this.VersionIdent.Name = "VersionIdent";
            this.VersionIdent.Size = new System.Drawing.Size(23, 21);
            this.VersionIdent.TabIndex = 7;
            this.VersionIdent.Text = "V:";
            // 
            // JonasCredit
            // 
            this.JonasCredit.AutoSize = true;
            this.JonasCredit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.JonasCredit.Location = new System.Drawing.Point(3, 25);
            this.JonasCredit.Name = "JonasCredit";
            this.JonasCredit.Size = new System.Drawing.Size(84, 21);
            this.JonasCredit.TabIndex = 0;
            this.JonasCredit.TabStop = true;
            this.JonasCredit.Text = "Jonas Kohl";
            this.JonasCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JonasCredit_LinkClicked);
            // 
            // DubyaCredit
            // 
            this.DubyaCredit.AutoSize = true;
            this.DubyaCredit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.DubyaCredit.Location = new System.Drawing.Point(3, 46);
            this.DubyaCredit.Name = "DubyaCredit";
            this.DubyaCredit.Size = new System.Drawing.Size(92, 21);
            this.DubyaCredit.TabIndex = 1;
            this.DubyaCredit.TabStop = true;
            this.DubyaCredit.Text = "DubyaDude";
            this.DubyaCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DubyaCredit_LinkClicked);
            // 
            // LacheeCredit
            // 
            this.LacheeCredit.AutoSize = true;
            this.LacheeCredit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.LacheeCredit.Location = new System.Drawing.Point(3, 67);
            this.LacheeCredit.Name = "LacheeCredit";
            this.LacheeCredit.Size = new System.Drawing.Size(104, 21);
            this.LacheeCredit.TabIndex = 2;
            this.LacheeCredit.TabStop = true;
            this.LacheeCredit.Text = "Lachee (Lake)";
            this.LacheeCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LacheeCredit_LinkClicked);
            // 
            // TaiizorCredit
            // 
            this.TaiizorCredit.AutoSize = true;
            this.TaiizorCredit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.TaiizorCredit.Location = new System.Drawing.Point(3, 88);
            this.TaiizorCredit.Name = "TaiizorCredit";
            this.TaiizorCredit.Size = new System.Drawing.Size(54, 21);
            this.TaiizorCredit.TabIndex = 3;
            this.TaiizorCredit.TabStop = true;
            this.TaiizorCredit.Text = "Taiizor";
            this.TaiizorCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TaiizorCredit_LinkClicked);
            // 
            // ChanyaCredit
            // 
            this.ChanyaCredit.AutoSize = true;
            this.ChanyaCredit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.ChanyaCredit.Location = new System.Drawing.Point(3, 109);
            this.ChanyaCredit.Name = "ChanyaCredit";
            this.ChanyaCredit.Size = new System.Drawing.Size(92, 21);
            this.ChanyaCredit.TabIndex = 4;
            this.ChanyaCredit.TabStop = true;
            this.ChanyaCredit.Text = "ChanyaVRC";
            this.ChanyaCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChanyaCredit_LinkClicked);
            // 
            // WebsiteLinksPanel
            // 
            this.WebsiteLinksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WebsiteLinksPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.WebsiteLinksPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WebsiteLinksPanel.ForeColor = System.Drawing.Color.White;
            this.WebsiteLinksPanel.Location = new System.Drawing.Point(6, 319);
            this.WebsiteLinksPanel.Name = "WebsiteLinksPanel";
            this.WebsiteLinksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.WebsiteLinksPanel.ShowText = true;
            this.WebsiteLinksPanel.Size = new System.Drawing.Size(566, 141);
            this.WebsiteLinksPanel.TabIndex = 5;
            this.WebsiteLinksPanel.Text = "Links";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.FormTabPages);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FormTabPages.ResumeLayout(false);
            this.SpotifyTabPage.ResumeLayout(false);
            this.SoundCldTabPage.ResumeLayout(false);
            this.CreditsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWView)).EndInit();
            this.MainCredsPanel.ResumeLayout(false);
            this.MainCredsPanel.PerformLayout();
            this.OtherCredsPanel.ResumeLayout(false);
            this.OtherCredsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrimPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer MainFormTimer;
        private ReaLTaiizor.Controls.TabPage FormTabPages;
        private TabPage SpotifyTabPage;
        private TabPage SoundCldTabPage;
        private TabPage MediaControlsTabPage;
        private TabPage AddonsTabPage;
        private TabPage SettingsTabPage;
        private TabPage CreditsTabPage;
        private Microsoft.Web.WebView2.WinForms.WebView2 SpotifyWView;
        private Microsoft.Web.WebView2.WinForms.WebView2 SoundCloudWView;
        private ReaLTaiizor.Controls.LostBorderPanel MainCredsPanel;
        private ReaLTaiizor.Controls.LostBorderPanel OtherCredsPanel;
        private PictureBox LogoPicBox;
        private Label DevelopTitleLabel;
        private PictureBox ScrimPicBox;
        private PictureBox TkPicBox;
        private Label ScrimLabel;
        private Label TkLabel;
        private Label VersionLabel;
        private Label VersionIdent;
        private LinkLabel JonasCredit;
        private LinkLabel TaiizorCredit;
        private LinkLabel LacheeCredit;
        private LinkLabel DubyaCredit;
        private LinkLabel ChanyaCredit;
        private ReaLTaiizor.Controls.LostBorderPanel WebsiteLinksPanel;
    }
}

