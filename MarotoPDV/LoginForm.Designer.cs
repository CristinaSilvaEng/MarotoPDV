namespace MarotoPDV
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox_logoStore = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoStore)).BeginInit();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_logoStore
            // 
            this.pictureBox_logoStore.Image = global::MarotoPDV.Properties.Resources.logo_store;
            this.pictureBox_logoStore.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logoStore.Name = "pictureBox_logoStore";
            this.pictureBox_logoStore.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_logoStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_logoStore.TabIndex = 0;
            this.pictureBox_logoStore.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(8, 23);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(10, 60);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(72, 20);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(165, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(72, 57);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(165, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(234, 117);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(75, 23);
            this.button_signup.TabIndex = 4;
            this.button_signup.Text = "SignUp";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.textBox_password);
            this.groupBox_login.Controls.Add(this.textBox_username);
            this.groupBox_login.Controls.Add(this.label_password);
            this.groupBox_login.Controls.Add(this.label_username);
            this.groupBox_login.Location = new System.Drawing.Point(162, 12);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(243, 92);
            this.groupBox_login.TabIndex = 1;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Login";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(324, 117);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 156);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.pictureBox_logoStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarotoPDV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoStore)).EndInit();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logoStore;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.Button button_cancel;
    }
}

