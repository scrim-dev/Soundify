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
            this.WindowSidePanel = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.MenuHolderPanel = new System.Windows.Forms.Panel();
            this.GripIconBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WindowSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.MenuHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GripIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowSidePanel
            // 
            this.WindowSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.WindowSidePanel.Controls.Add(this.button1);
            this.WindowSidePanel.Controls.Add(this.LogoBox);
            this.WindowSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowSidePanel.Location = new System.Drawing.Point(0, 0);
            this.WindowSidePanel.Name = "WindowSidePanel";
            this.WindowSidePanel.Size = new System.Drawing.Size(176, 661);
            this.WindowSidePanel.TabIndex = 0;
            // 
            // LogoBox
            // 
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.MenuHolderPanel.Controls.Add(this.GripIconBox);
            this.MenuHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(13, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.WindowSidePanel.ResumeLayout(false);
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
        private Button button1;
    }
}

