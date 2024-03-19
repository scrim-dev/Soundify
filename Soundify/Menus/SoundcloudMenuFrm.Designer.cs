namespace Soundify.Menus
{
    partial class SoundcloudMenuFrm
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
            this.SoundCloudWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundCloudWebView
            // 
            this.SoundCloudWebView.AllowExternalDrop = true;
            this.SoundCloudWebView.CreationProperties = null;
            this.SoundCloudWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.SoundCloudWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoundCloudWebView.Location = new System.Drawing.Point(0, 0);
            this.SoundCloudWebView.Name = "SoundCloudWebView";
            this.SoundCloudWebView.Size = new System.Drawing.Size(808, 661);
            this.SoundCloudWebView.TabIndex = 0;
            this.SoundCloudWebView.ZoomFactor = 1D;
            this.SoundCloudWebView.Click += new System.EventHandler(this.SoundCloudWebView_Click);
            // 
            // SoundcloudMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(808, 661);
            this.Controls.Add(this.SoundCloudWebView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SoundcloudMenuFrm";
            this.Text = "SoundcloudMenuFrm";
            this.Load += new System.EventHandler(this.SoundcloudMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundCloudWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 SoundCloudWebView;
    }
}