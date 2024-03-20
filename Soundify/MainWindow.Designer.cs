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
            this.SpotifyWView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SoundCldTabPage = new System.Windows.Forms.TabPage();
            this.SoundCloudWView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.MediaControlsTabPage = new System.Windows.Forms.TabPage();
            this.ConsolePanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.RTBConsole = new System.Windows.Forms.RichTextBox();
            this.MediaControlsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.VisualizerWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PausePlayBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.StopBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.NextBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.PreviousBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.AddonsTabPage = new System.Windows.Forms.TabPage();
            this.DiscordRPCPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.VRCOscPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.AppSetsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.AppConfigsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.CreditsTabPage = new System.Windows.Forms.TabPage();
            this.WebsiteLinksPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.OtherCredsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.ChanyaCredit = new System.Windows.Forms.LinkLabel();
            this.TaiizorCredit = new System.Windows.Forms.LinkLabel();
            this.LacheeCredit = new System.Windows.Forms.LinkLabel();
            this.DubyaCredit = new System.Windows.Forms.LinkLabel();
            this.JonasCredit = new System.Windows.Forms.LinkLabel();
            this.MainCredsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.VersionIdent = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TkLabel = new System.Windows.Forms.Label();
            this.ScrimLabel = new System.Windows.Forms.Label();
            this.DevelopTitleLabel = new System.Windows.Forms.Label();
            this.AppUpdateCheck = new System.Windows.Forms.Timer(this.components);
            this.GhPicBoxBtn = new System.Windows.Forms.PictureBox();
            this.YTPicBoxBtn = new System.Windows.Forms.PictureBox();
            this.WebsitePicBoxBtn = new System.Windows.Forms.PictureBox();
            this.ScrimPicBox = new System.Windows.Forms.PictureBox();
            this.TkPicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.FormTabPages.SuspendLayout();
            this.SpotifyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWView)).BeginInit();
            this.SoundCldTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWView)).BeginInit();
            this.MediaControlsTabPage.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.MediaControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizerWebView)).BeginInit();
            this.AddonsTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.CreditsTabPage.SuspendLayout();
            this.WebsiteLinksPanel.SuspendLayout();
            this.OtherCredsPanel.SuspendLayout();
            this.MainCredsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GhPicBoxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTPicBoxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsitePicBoxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrimPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
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
            // MediaControlsTabPage
            // 
            this.MediaControlsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MediaControlsTabPage.Controls.Add(this.ConsolePanel);
            this.MediaControlsTabPage.Controls.Add(this.MediaControlsPanel);
            this.MediaControlsTabPage.Location = new System.Drawing.Point(139, 4);
            this.MediaControlsTabPage.Name = "MediaControlsTabPage";
            this.MediaControlsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MediaControlsTabPage.Size = new System.Drawing.Size(841, 653);
            this.MediaControlsTabPage.TabIndex = 2;
            this.MediaControlsTabPage.Text = "Media Controls";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ConsolePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.ConsolePanel.Controls.Add(this.RTBConsole);
            this.ConsolePanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ConsolePanel.ForeColor = System.Drawing.Color.White;
            this.ConsolePanel.Location = new System.Drawing.Point(6, 319);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Padding = new System.Windows.Forms.Padding(5);
            this.ConsolePanel.ShowText = true;
            this.ConsolePanel.Size = new System.Drawing.Size(826, 326);
            this.ConsolePanel.TabIndex = 6;
            this.ConsolePanel.Text = "Console";
            // 
            // RTBConsole
            // 
            this.RTBConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBConsole.BackColor = System.Drawing.Color.Black;
            this.RTBConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTBConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBConsole.ForeColor = System.Drawing.Color.Cyan;
            this.RTBConsole.Location = new System.Drawing.Point(4, 25);
            this.RTBConsole.Name = "RTBConsole";
            this.RTBConsole.ReadOnly = true;
            this.RTBConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBConsole.Size = new System.Drawing.Size(819, 298);
            this.RTBConsole.TabIndex = 0;
            this.RTBConsole.Text = "";
            // 
            // MediaControlsPanel
            // 
            this.MediaControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MediaControlsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.MediaControlsPanel.Controls.Add(this.VisualizerWebView);
            this.MediaControlsPanel.Controls.Add(this.PausePlayBtn);
            this.MediaControlsPanel.Controls.Add(this.StopBtn);
            this.MediaControlsPanel.Controls.Add(this.NextBtn);
            this.MediaControlsPanel.Controls.Add(this.PreviousBtn);
            this.MediaControlsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MediaControlsPanel.ForeColor = System.Drawing.Color.White;
            this.MediaControlsPanel.Location = new System.Drawing.Point(6, 3);
            this.MediaControlsPanel.Name = "MediaControlsPanel";
            this.MediaControlsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MediaControlsPanel.ShowText = true;
            this.MediaControlsPanel.Size = new System.Drawing.Size(829, 310);
            this.MediaControlsPanel.TabIndex = 2;
            this.MediaControlsPanel.Text = "Controls";
            // 
            // VisualizerWebView
            // 
            this.VisualizerWebView.AllowExternalDrop = true;
            this.VisualizerWebView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizerWebView.CreationProperties = null;
            this.VisualizerWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.VisualizerWebView.Location = new System.Drawing.Point(4, 25);
            this.VisualizerWebView.Name = "VisualizerWebView";
            this.VisualizerWebView.Size = new System.Drawing.Size(822, 236);
            this.VisualizerWebView.TabIndex = 4;
            this.VisualizerWebView.ZoomFactor = 1D;
            // 
            // PausePlayBtn
            // 
            this.PausePlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PausePlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PausePlayBtn.BaseColor = System.Drawing.Color.LimeGreen;
            this.PausePlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PausePlayBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PausePlayBtn.Location = new System.Drawing.Point(109, 267);
            this.PausePlayBtn.Name = "PausePlayBtn";
            this.PausePlayBtn.Rounded = false;
            this.PausePlayBtn.Size = new System.Drawing.Size(443, 40);
            this.PausePlayBtn.TabIndex = 3;
            this.PausePlayBtn.Text = "Play/Pause";
            this.PausePlayBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PausePlayBtn.Click += new System.EventHandler(this.PausePlayBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.BaseColor = System.Drawing.Color.Firebrick;
            this.StopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StopBtn.Location = new System.Drawing.Point(558, 267);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Rounded = false;
            this.StopBtn.Size = new System.Drawing.Size(162, 40);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextBtn.Location = new System.Drawing.Point(726, 267);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Rounded = false;
            this.NextBtn.Size = new System.Drawing.Size(100, 40);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "=>";
            this.NextBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.PreviousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PreviousBtn.Location = new System.Drawing.Point(3, 267);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Rounded = false;
            this.PreviousBtn.Size = new System.Drawing.Size(100, 40);
            this.PreviousBtn.TabIndex = 0;
            this.PreviousBtn.Text = "<=";
            this.PreviousBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // AddonsTabPage
            // 
            this.AddonsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.AddonsTabPage.Controls.Add(this.DiscordRPCPanel);
            this.AddonsTabPage.Controls.Add(this.VRCOscPanel);
            this.AddonsTabPage.Location = new System.Drawing.Point(139, 4);
            this.AddonsTabPage.Name = "AddonsTabPage";
            this.AddonsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddonsTabPage.Size = new System.Drawing.Size(841, 653);
            this.AddonsTabPage.TabIndex = 3;
            this.AddonsTabPage.Text = "Addons";
            // 
            // DiscordRPCPanel
            // 
            this.DiscordRPCPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DiscordRPCPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.DiscordRPCPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscordRPCPanel.ForeColor = System.Drawing.Color.White;
            this.DiscordRPCPanel.Location = new System.Drawing.Point(292, 3);
            this.DiscordRPCPanel.Name = "DiscordRPCPanel";
            this.DiscordRPCPanel.Padding = new System.Windows.Forms.Padding(5);
            this.DiscordRPCPanel.ShowText = true;
            this.DiscordRPCPanel.Size = new System.Drawing.Size(280, 310);
            this.DiscordRPCPanel.TabIndex = 3;
            this.DiscordRPCPanel.Text = "Discord RPC";
            // 
            // VRCOscPanel
            // 
            this.VRCOscPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VRCOscPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.VRCOscPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VRCOscPanel.ForeColor = System.Drawing.Color.White;
            this.VRCOscPanel.Location = new System.Drawing.Point(6, 3);
            this.VRCOscPanel.Name = "VRCOscPanel";
            this.VRCOscPanel.Padding = new System.Windows.Forms.Padding(5);
            this.VRCOscPanel.ShowText = true;
            this.VRCOscPanel.Size = new System.Drawing.Size(280, 310);
            this.VRCOscPanel.TabIndex = 2;
            this.VRCOscPanel.Text = "VRChat OSC";
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SettingsTabPage.Controls.Add(this.AppSetsPanel);
            this.SettingsTabPage.Controls.Add(this.AppConfigsPanel);
            this.SettingsTabPage.Location = new System.Drawing.Point(139, 4);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(841, 653);
            this.SettingsTabPage.TabIndex = 4;
            this.SettingsTabPage.Text = "Settings";
            // 
            // AppSetsPanel
            // 
            this.AppSetsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AppSetsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.AppSetsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AppSetsPanel.ForeColor = System.Drawing.Color.White;
            this.AppSetsPanel.Location = new System.Drawing.Point(292, 3);
            this.AppSetsPanel.Name = "AppSetsPanel";
            this.AppSetsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.AppSetsPanel.ShowText = true;
            this.AppSetsPanel.Size = new System.Drawing.Size(280, 310);
            this.AppSetsPanel.TabIndex = 4;
            this.AppSetsPanel.Text = "App";
            // 
            // AppConfigsPanel
            // 
            this.AppConfigsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AppConfigsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.AppConfigsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AppConfigsPanel.ForeColor = System.Drawing.Color.White;
            this.AppConfigsPanel.Location = new System.Drawing.Point(6, 3);
            this.AppConfigsPanel.Name = "AppConfigsPanel";
            this.AppConfigsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.AppConfigsPanel.ShowText = true;
            this.AppConfigsPanel.Size = new System.Drawing.Size(280, 310);
            this.AppConfigsPanel.TabIndex = 3;
            this.AppConfigsPanel.Text = "Config";
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
            // WebsiteLinksPanel
            // 
            this.WebsiteLinksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WebsiteLinksPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(209)))));
            this.WebsiteLinksPanel.Controls.Add(this.GhPicBoxBtn);
            this.WebsiteLinksPanel.Controls.Add(this.YTPicBoxBtn);
            this.WebsiteLinksPanel.Controls.Add(this.WebsitePicBoxBtn);
            this.WebsiteLinksPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WebsiteLinksPanel.ForeColor = System.Drawing.Color.White;
            this.WebsiteLinksPanel.Location = new System.Drawing.Point(6, 319);
            this.WebsiteLinksPanel.Name = "WebsiteLinksPanel";
            this.WebsiteLinksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.WebsiteLinksPanel.ShowText = true;
            this.WebsiteLinksPanel.Size = new System.Drawing.Size(280, 67);
            this.WebsiteLinksPanel.TabIndex = 5;
            this.WebsiteLinksPanel.Text = "Links";
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
            // TkLabel
            // 
            this.TkLabel.AutoSize = true;
            this.TkLabel.Location = new System.Drawing.Point(3, 284);
            this.TkLabel.Name = "TkLabel";
            this.TkLabel.Size = new System.Drawing.Size(67, 21);
            this.TkLabel.TabIndex = 5;
            this.TkLabel.Text = "Terkoshi";
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
            // DevelopTitleLabel
            // 
            this.DevelopTitleLabel.AutoSize = true;
            this.DevelopTitleLabel.Location = new System.Drawing.Point(3, 164);
            this.DevelopTitleLabel.Name = "DevelopTitleLabel";
            this.DevelopTitleLabel.Size = new System.Drawing.Size(163, 21);
            this.DevelopTitleLabel.TabIndex = 1;
            this.DevelopTitleLabel.Text = "Developed with <3 By";
            // 
            // AppUpdateCheck
            // 
            this.AppUpdateCheck.Enabled = true;
            this.AppUpdateCheck.Interval = 19900;
            this.AppUpdateCheck.Tick += new System.EventHandler(this.AppUpdateCheck_Tick);
            // 
            // GhPicBoxBtn
            // 
            this.GhPicBoxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GhPicBoxBtn.Image = global::Soundify.Properties.Resources.github;
            this.GhPicBoxBtn.Location = new System.Drawing.Point(86, 25);
            this.GhPicBoxBtn.Name = "GhPicBoxBtn";
            this.GhPicBoxBtn.Size = new System.Drawing.Size(35, 35);
            this.GhPicBoxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GhPicBoxBtn.TabIndex = 10;
            this.GhPicBoxBtn.TabStop = false;
            this.GhPicBoxBtn.Click += new System.EventHandler(this.GhPicBoxBtn_Click);
            // 
            // YTPicBoxBtn
            // 
            this.YTPicBoxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YTPicBoxBtn.Image = global::Soundify.Properties.Resources.youtube;
            this.YTPicBoxBtn.Location = new System.Drawing.Point(45, 25);
            this.YTPicBoxBtn.Name = "YTPicBoxBtn";
            this.YTPicBoxBtn.Size = new System.Drawing.Size(35, 35);
            this.YTPicBoxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YTPicBoxBtn.TabIndex = 9;
            this.YTPicBoxBtn.TabStop = false;
            this.YTPicBoxBtn.Click += new System.EventHandler(this.YTPicBoxBtn_Click);
            // 
            // WebsitePicBoxBtn
            // 
            this.WebsitePicBoxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsitePicBoxBtn.Image = global::Soundify.Properties.Resources.globe_solid;
            this.WebsitePicBoxBtn.Location = new System.Drawing.Point(4, 25);
            this.WebsitePicBoxBtn.Name = "WebsitePicBoxBtn";
            this.WebsitePicBoxBtn.Size = new System.Drawing.Size(35, 35);
            this.WebsitePicBoxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WebsitePicBoxBtn.TabIndex = 8;
            this.WebsitePicBoxBtn.TabStop = false;
            this.WebsitePicBoxBtn.Click += new System.EventHandler(this.WebsitePicBoxBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWView)).EndInit();
            this.SoundCldTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWView)).EndInit();
            this.MediaControlsTabPage.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.MediaControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizerWebView)).EndInit();
            this.AddonsTabPage.ResumeLayout(false);
            this.SettingsTabPage.ResumeLayout(false);
            this.CreditsTabPage.ResumeLayout(false);
            this.WebsiteLinksPanel.ResumeLayout(false);
            this.OtherCredsPanel.ResumeLayout(false);
            this.OtherCredsPanel.PerformLayout();
            this.MainCredsPanel.ResumeLayout(false);
            this.MainCredsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GhPicBoxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTPicBoxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsitePicBoxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrimPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
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
        private PictureBox GhPicBoxBtn;
        private PictureBox YTPicBoxBtn;
        private PictureBox WebsitePicBoxBtn;
        private ReaLTaiizor.Controls.LostBorderPanel MediaControlsPanel;
        private ReaLTaiizor.Controls.ForeverButton PreviousBtn;
        private ReaLTaiizor.Controls.ForeverButton NextBtn;
        private ReaLTaiizor.Controls.ForeverButton StopBtn;
        private ReaLTaiizor.Controls.ForeverButton PausePlayBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 VisualizerWebView;
        private ReaLTaiizor.Controls.LostBorderPanel ConsolePanel;
        private RichTextBox RTBConsole;
        private ReaLTaiizor.Controls.LostBorderPanel VRCOscPanel;
        private ReaLTaiizor.Controls.LostBorderPanel DiscordRPCPanel;
        private ReaLTaiizor.Controls.LostBorderPanel AppConfigsPanel;
        private ReaLTaiizor.Controls.LostBorderPanel AppSetsPanel;
        internal System.Windows.Forms.Timer AppUpdateCheck;
    }
}

