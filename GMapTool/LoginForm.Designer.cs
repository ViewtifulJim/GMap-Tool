namespace GMapTool
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHelpLogin = new System.Windows.Forms.Button();
            this.btnRequestLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(23, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(94, 37);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(30, 113);
            this.txtBoxUsername.MaximumSize = new System.Drawing.Size(427, 41);
            this.txtBoxUsername.MinimumSize = new System.Drawing.Size(427, 41);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(427, 41);
            this.txtBoxUsername.TabIndex = 1;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(25, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(132, 29);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(30, 206);
            this.txtBoxPassword.MaximumSize = new System.Drawing.Size(427, 41);
            this.txtBoxPassword.MinimumSize = new System.Drawing.Size(427, 41);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(427, 41);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.BackColor = System.Drawing.Color.White;
            this.btnClearLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogin.Location = new System.Drawing.Point(136, 266);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(105, 37);
            this.btnClearLogin.TabIndex = 5;
            this.btnClearLogin.Text = "Clear";
            this.btnClearLogin.UseVisualStyleBackColor = false;
            this.btnClearLogin.Click += new System.EventHandler(this.btnClearLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(247, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHelpLogin
            // 
            this.btnHelpLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelpLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpLogin.Location = new System.Drawing.Point(419, 20);
            this.btnHelpLogin.Name = "btnHelpLogin";
            this.btnHelpLogin.Size = new System.Drawing.Size(38, 38);
            this.btnHelpLogin.TabIndex = 7;
            this.btnHelpLogin.Text = "?";
            this.btnHelpLogin.UseVisualStyleBackColor = false;
            this.btnHelpLogin.Click += new System.EventHandler(this.btnHelpLogin_Click);
            // 
            // btnRequestLogin
            // 
            this.btnRequestLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRequestLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLogin.Location = new System.Drawing.Point(163, 321);
            this.btnRequestLogin.Name = "btnRequestLogin";
            this.btnRequestLogin.Size = new System.Drawing.Size(162, 37);
            this.btnRequestLogin.TabIndex = 8;
            this.btnRequestLogin.Text = "Request Login";
            this.btnRequestLogin.UseVisualStyleBackColor = false;
            this.btnRequestLogin.Click += new System.EventHandler(this.btnRequestLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(487, 370);
            this.Controls.Add(this.btnRequestLogin);
            this.Controls.Add(this.btnHelpLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClearLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(505, 417);
            this.MinimumSize = new System.Drawing.Size(505, 417);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHelpLogin;
        private System.Windows.Forms.Button btnRequestLogin;
    }
}