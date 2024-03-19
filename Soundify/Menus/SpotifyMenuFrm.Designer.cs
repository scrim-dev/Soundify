namespace Soundify.Menus
{
    partial class SpotifyMenuFrm
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
            this.SpotifyWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // SpotifyWebView
            // 
            this.SpotifyWebView.AllowExternalDrop = true;
            this.SpotifyWebView.CreationProperties = null;
            this.SpotifyWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.SpotifyWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotifyWebView.Location = new System.Drawing.Point(0, 0);
            this.SpotifyWebView.Name = "SpotifyWebView";
            this.SpotifyWebView.Size = new System.Drawing.Size(808, 661);
            this.SpotifyWebView.TabIndex = 0;
            this.SpotifyWebView.ZoomFactor = 1D;
            this.SpotifyWebView.Click += new System.EventHandler(this.SpotifyWebView_Click);
            // 
            // SpotifyMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(808, 661);
            this.Controls.Add(this.SpotifyWebView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpotifyMenuFrm";
            this.Text = "SpotifyMenuFrm";
            this.Load += new System.EventHandler(this.SpotifyMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpotifyWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 SpotifyWebView;
    }
}