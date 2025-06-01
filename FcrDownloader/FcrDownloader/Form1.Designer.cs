namespace FcrDownloader
{
    partial class Form1
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
            this.FcrGrid = new System.Windows.Forms.DataGridView();
            this.PasteButton = new System.Windows.Forms.Button();
            this.BrowserButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.UnzipButton = new System.Windows.Forms.Button();
            this.GetFcrNoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FcrGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FcrGrid
            // 
            this.FcrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FcrGrid.Location = new System.Drawing.Point(12, 22);
            this.FcrGrid.Name = "FcrGrid";
            this.FcrGrid.RowHeadersWidth = 51;
            this.FcrGrid.RowTemplate.Height = 24;
            this.FcrGrid.Size = new System.Drawing.Size(447, 416);
            this.FcrGrid.TabIndex = 0;
            // 
            // PasteButton
            // 
            this.PasteButton.BackColor = System.Drawing.Color.YellowGreen;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Location = new System.Drawing.Point(494, 41);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(140, 35);
            this.PasteButton.TabIndex = 1;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // BrowserButton
            // 
            this.BrowserButton.BackColor = System.Drawing.Color.YellowGreen;
            this.BrowserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserButton.Location = new System.Drawing.Point(494, 94);
            this.BrowserButton.Name = "BrowserButton";
            this.BrowserButton.Size = new System.Drawing.Size(140, 35);
            this.BrowserButton.TabIndex = 2;
            this.BrowserButton.Text = "Open Browser";
            this.BrowserButton.UseVisualStyleBackColor = false;
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.YellowGreen;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Location = new System.Drawing.Point(494, 161);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(140, 35);
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = false;
            // 
            // UnzipButton
            // 
            this.UnzipButton.BackColor = System.Drawing.Color.YellowGreen;
            this.UnzipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnzipButton.Location = new System.Drawing.Point(494, 223);
            this.UnzipButton.Name = "UnzipButton";
            this.UnzipButton.Size = new System.Drawing.Size(140, 35);
            this.UnzipButton.TabIndex = 4;
            this.UnzipButton.Text = "Unzip";
            this.UnzipButton.UseVisualStyleBackColor = false;
            this.UnzipButton.Click += new System.EventHandler(this.UnzipButton_Click);
            // 
            // GetFcrNoButton
            // 
            this.GetFcrNoButton.BackColor = System.Drawing.Color.YellowGreen;
            this.GetFcrNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetFcrNoButton.Location = new System.Drawing.Point(494, 285);
            this.GetFcrNoButton.Name = "GetFcrNoButton";
            this.GetFcrNoButton.Size = new System.Drawing.Size(140, 35);
            this.GetFcrNoButton.TabIndex = 5;
            this.GetFcrNoButton.Text = "GetFcrNo";
            this.GetFcrNoButton.UseVisualStyleBackColor = false;
            this.GetFcrNoButton.Click += new System.EventHandler(this.GetFcrNoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetFcrNoButton);
            this.Controls.Add(this.UnzipButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.BrowserButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.FcrGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FcrGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FcrGrid;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button BrowserButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button UnzipButton;
        private System.Windows.Forms.Button GetFcrNoButton;
    }
}

