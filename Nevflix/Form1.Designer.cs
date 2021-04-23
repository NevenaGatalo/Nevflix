
namespace Nevflix
{
    partial class forma
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
            this.Nevflix = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbZanrovi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nevflix)).BeginInit();
            this.SuspendLayout();
            // 
            // Nevflix
            // 
            this.Nevflix.BackColor = System.Drawing.SystemColors.Control;
            this.Nevflix.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nevflix.Image = global::Nevflix.Properties.Resources.nevflix;
            this.Nevflix.Location = new System.Drawing.Point(0, 0);
            this.Nevflix.Name = "Nevflix";
            this.Nevflix.Size = new System.Drawing.Size(800, 154);
            this.Nevflix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nevflix.TabIndex = 1;
            this.Nevflix.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbSearch.Location = new System.Drawing.Point(612, 154);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(188, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(367, 160);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "refresh/back";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbZanrovi
            // 
            this.cbZanrovi.AccessibleName = "";
            this.cbZanrovi.BackColor = System.Drawing.SystemColors.Window;
            this.cbZanrovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZanrovi.FormattingEnabled = true;
            this.cbZanrovi.Location = new System.Drawing.Point(460, 160);
            this.cbZanrovi.Name = "cbZanrovi";
            this.cbZanrovi.Size = new System.Drawing.Size(146, 21);
            this.cbZanrovi.TabIndex = 4;
            this.cbZanrovi.SelectedIndexChanged += new System.EventHandler(this.cbZanrovi_SelectedIndexChanged);
            // 
            // forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbZanrovi);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.Nevflix);
            this.KeyPreview = true;
            this.Name = "forma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nevflix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Nevflix;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbZanrovi;
    }
}

