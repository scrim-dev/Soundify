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
            this.WindowSidePanel = new System.Windows.Forms.Panel();
            this.FullscreenBtn = new System.Windows.Forms.PictureBox();
            this.DiscordPicBox = new System.Windows.Forms.PictureBox();
            this.WebsitePicBox = new System.Windows.Forms.PictureBox();
            this.YoutubePicBox = new System.Windows.Forms.PictureBox();
            this.GithubPicBox = new System.Windows.Forms.PictureBox();
            this.SettingsMenuBtn = new System.Windows.Forms.Button();
            this.MediaControlsMenuBtn = new System.Windows.Forms.Button();
            this.AddonsMenuBtn = new System.Windows.Forms.Button();
            this.SoundCMenuBtn = new System.Windows.Forms.Button();
            this.SpotifyMenuBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.MenuHolderPanel = new System.Windows.Forms.Panel();
            this.GripIconBox = new System.Windows.Forms.PictureBox();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.WindowSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullscreenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsitePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoutubePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.MenuHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GripIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowSidePanel
            // 
            this.WindowSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.WindowSidePanel.Controls.Add(this.FullscreenBtn);
            this.WindowSidePanel.Controls.Add(this.DiscordPicBox);
            this.WindowSidePanel.Controls.Add(this.WebsitePicBox);
            this.WindowSidePanel.Controls.Add(this.YoutubePicBox);
            this.WindowSidePanel.Controls.Add(this.GithubPicBox);
            this.WindowSidePanel.Controls.Add(this.SettingsMenuBtn);
            this.WindowSidePanel.Controls.Add(this.MediaControlsMenuBtn);
            this.WindowSidePanel.Controls.Add(this.AddonsMenuBtn);
            this.WindowSidePanel.Controls.Add(this.SoundCMenuBtn);
            this.WindowSidePanel.Controls.Add(this.SpotifyMenuBtn);
            this.WindowSidePanel.Controls.Add(this.LogoBox);
            this.WindowSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowSidePanel.Location = new System.Drawing.Point(0, 0);
            this.WindowSidePanel.Name = "WindowSidePanel";
            this.WindowSidePanel.Size = new System.Drawing.Size(176, 661);
            this.WindowSidePanel.TabIndex = 0;
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FullscreenBtn.Image = global::Soundify.Properties.Resources.expand_solid;
            this.FullscreenBtn.Location = new System.Drawing.Point(0, 636);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(25, 25);
            this.FullscreenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullscreenBtn.TabIndex = 9;
            this.FullscreenBtn.TabStop = false;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            // 
            // DiscordPicBox
            // 
            this.DiscordPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscordPicBox.Image = global::Soundify.Properties.Resources.discord;
            this.DiscordPicBox.Location = new System.Drawing.Point(126, 448);
            this.DiscordPicBox.Name = "DiscordPicBox";
            this.DiscordPicBox.Size = new System.Drawing.Size(47, 35);
            this.DiscordPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiscordPicBox.TabIndex = 8;
            this.DiscordPicBox.TabStop = false;
            this.DiscordPicBox.Click += new System.EventHandler(this.DiscordPicBox_Click);
            // 
            // WebsitePicBox
            // 
            this.WebsitePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WebsitePicBox.Image = global::Soundify.Properties.Resources.globe_solid;
            this.WebsitePicBox.Location = new System.Drawing.Point(85, 448);
            this.WebsitePicBox.Name = "WebsitePicBox";
            this.WebsitePicBox.Size = new System.Drawing.Size(35, 35);
            this.WebsitePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WebsitePicBox.TabIndex = 7;
            this.WebsitePicBox.TabStop = false;
            this.WebsitePicBox.Click += new System.EventHandler(this.WebsitePicBox_Click);
            // 
            // YoutubePicBox
            // 
            this.YoutubePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YoutubePicBox.Image = global::Soundify.Properties.Resources.youtube;
            this.YoutubePicBox.Location = new System.Drawing.Point(44, 448);
            this.YoutubePicBox.Name = "YoutubePicBox";
            this.YoutubePicBox.Size = new System.Drawing.Size(35, 35);
            this.YoutubePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YoutubePicBox.TabIndex = 6;
            this.YoutubePicBox.TabStop = false;
            this.YoutubePicBox.Click += new System.EventHandler(this.YoutubePicBox_Click);
            // 
            // GithubPicBox
            // 
            this.GithubPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GithubPicBox.Image = global::Soundify.Properties.Resources.github;
            this.GithubPicBox.Location = new System.Drawing.Point(3, 448);
            this.GithubPicBox.Name = "GithubPicBox";
            this.GithubPicBox.Size = new System.Drawing.Size(35, 35);
            this.GithubPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GithubPicBox.TabIndex = 1;
            this.GithubPicBox.TabStop = false;
            this.GithubPicBox.Click += new System.EventHandler(this.GithubPicBox_Click);
            // 
            // SettingsMenuBtn
            // 
            this.SettingsMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SettingsMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsMenuBtn.FlatAppearance.BorderSize = 0;
            this.SettingsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsMenuBtn.Location = new System.Drawing.Point(0, 387);
            this.SettingsMenuBtn.Name = "SettingsMenuBtn";
            this.SettingsMenuBtn.Size = new System.Drawing.Size(176, 55);
            this.SettingsMenuBtn.TabIndex = 5;
            this.SettingsMenuBtn.Text = "Settings";
            this.SettingsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsMenuBtn.UseVisualStyleBackColor = false;
            this.SettingsMenuBtn.Click += new System.EventHandler(this.SettingsMenuBtn_Click);
            // 
            // MediaControlsMenuBtn
            // 
            this.MediaControlsMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MediaControlsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MediaControlsMenuBtn.FlatAppearance.BorderSize = 0;
            this.MediaControlsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MediaControlsMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MediaControlsMenuBtn.Location = new System.Drawing.Point(0, 326);
            this.MediaControlsMenuBtn.Name = "MediaControlsMenuBtn";
            this.MediaControlsMenuBtn.Size = new System.Drawing.Size(176, 55);
            this.MediaControlsMenuBtn.TabIndex = 4;
            this.MediaControlsMenuBtn.Text = "Media Controls";
            this.MediaControlsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MediaControlsMenuBtn.UseVisualStyleBackColor = false;
            this.MediaControlsMenuBtn.Click += new System.EventHandler(this.MediaControlsMenuBtn_Click);
            // 
            // AddonsMenuBtn
            // 
            this.AddonsMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddonsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AddonsMenuBtn.FlatAppearance.BorderSize = 0;
            this.AddonsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddonsMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddonsMenuBtn.Location = new System.Drawing.Point(0, 265);
            this.AddonsMenuBtn.Name = "AddonsMenuBtn";
            this.AddonsMenuBtn.Size = new System.Drawing.Size(176, 55);
            this.AddonsMenuBtn.TabIndex = 3;
            this.AddonsMenuBtn.Text = "Addons";
            this.AddonsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddonsMenuBtn.UseVisualStyleBackColor = false;
            this.AddonsMenuBtn.Click += new System.EventHandler(this.AddonsMenuBtn_Click);
            // 
            // SoundCMenuBtn
            // 
            this.SoundCMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SoundCMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SoundCMenuBtn.FlatAppearance.BorderSize = 0;
            this.SoundCMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SoundCMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SoundCMenuBtn.Location = new System.Drawing.Point(0, 204);
            this.SoundCMenuBtn.Name = "SoundCMenuBtn";
            this.SoundCMenuBtn.Size = new System.Drawing.Size(176, 55);
            this.SoundCMenuBtn.TabIndex = 2;
            this.SoundCMenuBtn.Text = "SoundCloud";
            this.SoundCMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SoundCMenuBtn.UseVisualStyleBackColor = false;
            this.SoundCMenuBtn.Click += new System.EventHandler(this.SoundCMenuBtn_Click);
            // 
            // SpotifyMenuBtn
            // 
            this.SpotifyMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpotifyMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SpotifyMenuBtn.FlatAppearance.BorderSize = 0;
            this.SpotifyMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpotifyMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpotifyMenuBtn.Location = new System.Drawing.Point(0, 143);
            this.SpotifyMenuBtn.Name = "SpotifyMenuBtn";
            this.SpotifyMenuBtn.Size = new System.Drawing.Size(176, 55);
            this.SpotifyMenuBtn.TabIndex = 1;
            this.SpotifyMenuBtn.Text = "Spotify";
            this.SpotifyMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SpotifyMenuBtn.UseVisualStyleBackColor = false;
            this.SpotifyMenuBtn.Click += new System.EventHandler(this.SpotifyMenuBtn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoBox.Image = global::Soundify.Properties.Resources.Purple_Trans;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(176, 137);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click);
            // 
            // MenuHolderPanel
            // 
            this.MenuHolderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuHolderPanel.Controls.Add(this.GripIconBox);
            this.MenuHolderPanel.Location = new System.Drawing.Point(176, 0);
            this.MenuHolderPanel.Name = "MenuHolderPanel";
            this.MenuHolderPanel.Size = new System.Drawing.Size(808, 661);
            this.MenuHolderPanel.TabIndex = 1;
            // 
            // GripIconBox
            // 
            this.GripIconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GripIconBox.Image = global::Soundify.Properties.Resources.SideGripIcon;
            this.GripIconBox.Location = new System.Drawing.Point(795, 648);
            this.GripIconBox.Name = "GripIconBox";
            this.GripIconBox.Size = new System.Drawing.Size(10, 10);
            this.GripIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GripIconBox.TabIndex = 0;
            this.GripIconBox.TabStop = false;
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Interval = 1100;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.MenuHolderPanel);
            this.Controls.Add(this.WindowSidePanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.WindowSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FullscreenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsitePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoutubePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.MenuHolderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GripIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel WindowSidePanel;
        private PictureBox LogoBox;
        private Panel MenuHolderPanel;
        private PictureBox GripIconBox;
        private System.Windows.Forms.Button SpotifyMenuBtn;
        private System.Windows.Forms.Button SettingsMenuBtn;
        private System.Windows.Forms.Button MediaControlsMenuBtn;
        private System.Windows.Forms.Button AddonsMenuBtn;
        private System.Windows.Forms.Button SoundCMenuBtn;
        private PictureBox WebsitePicBox;
        private PictureBox YoutubePicBox;
        private PictureBox GithubPicBox;
        private PictureBox DiscordPicBox;
        private PictureBox FullscreenBtn;
        internal System.Windows.Forms.Timer MainFormTimer;
    }
}

