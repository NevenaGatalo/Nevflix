
namespace Nevflix
{
    partial class Logovanje
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogovanje = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(286, 139);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(163, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(286, 269);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(163, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Crimson;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(282, 102);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Crimson;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(282, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblLogovanje
            // 
            this.lblLogovanje.AutoSize = true;
            this.lblLogovanje.BackColor = System.Drawing.Color.Crimson;
            this.lblLogovanje.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogovanje.Location = new System.Drawing.Point(260, 23);
            this.lblLogovanje.Name = "lblLogovanje";
            this.lblLogovanje.Size = new System.Drawing.Size(247, 23);
            this.lblLogovanje.TabIndex = 4;
            this.lblLogovanje.Text = "Sign up or log in for Nevflix";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.IndianRed;
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(264, 341);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(61, 29);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(441, 341);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(61, 29);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblLogovanje);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "Logovanje";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogovanje;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogIn;
    }
}