namespace Inventario
{
    partial class Login
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
            this.SignInBtn = new MetroFramework.Controls.MetroButton();
            this.UsernameTXT = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTXT = new MetroFramework.Controls.MetroTextBox();
            this.UsernameLbl = new MetroFramework.Controls.MetroLabel();
            this.PasswordLbl = new MetroFramework.Controls.MetroLabel();
            this.ErrorUsernameLbl = new MetroFramework.Controls.MetroLabel();
            this.ErrorPasswordLbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // SignInBtn
            // 
            this.SignInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(120, 232);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(157, 32);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SignInBtn.UseSelectable = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UsernameTXT.Lines = new string[0];
            this.UsernameTXT.Location = new System.Drawing.Point(23, 78);
            this.UsernameTXT.MaxLength = 32767;
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.PasswordChar = '\0';
            this.UsernameTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTXT.SelectedText = "";
            this.UsernameTXT.Size = new System.Drawing.Size(346, 31);
            this.UsernameTXT.TabIndex = 3;
            this.UsernameTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UsernameTXT.UseSelectable = true;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordTXT.Lines = new string[0];
            this.PasswordTXT.Location = new System.Drawing.Point(23, 162);
            this.PasswordTXT.MaxLength = 32767;
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.PasswordChar = '*';
            this.PasswordTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTXT.SelectedText = "";
            this.PasswordTXT.Size = new System.Drawing.Size(346, 31);
            this.PasswordTXT.TabIndex = 4;
            this.PasswordTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PasswordTXT.UseSelectable = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLbl.Location = new System.Drawing.Point(23, 56);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(119, 19);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Correo electrónico";
            this.UsernameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLbl.Location = new System.Drawing.Point(23, 140);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(75, 19);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Contraseña";
            this.PasswordLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ErrorUsernameLbl
            // 
            this.ErrorUsernameLbl.AutoSize = true;
            this.ErrorUsernameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ErrorUsernameLbl.ForeColor = System.Drawing.Color.Orange;
            this.ErrorUsernameLbl.Location = new System.Drawing.Point(23, 112);
            this.ErrorUsernameLbl.Name = "ErrorUsernameLbl";
            this.ErrorUsernameLbl.Size = new System.Drawing.Size(150, 19);
            this.ErrorUsernameLbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.ErrorUsernameLbl.TabIndex = 8;
            this.ErrorUsernameLbl.Text = "Error correo electrónico";
            this.ErrorUsernameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ErrorUsernameLbl.UseStyleColors = true;
            this.ErrorUsernameLbl.Visible = false;
            // 
            // ErrorPasswordLbl
            // 
            this.ErrorPasswordLbl.AutoSize = true;
            this.ErrorPasswordLbl.ForeColor = System.Drawing.Color.Orange;
            this.ErrorPasswordLbl.Location = new System.Drawing.Point(23, 196);
            this.ErrorPasswordLbl.Name = "ErrorPasswordLbl";
            this.ErrorPasswordLbl.Size = new System.Drawing.Size(141, 19);
            this.ErrorPasswordLbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.ErrorPasswordLbl.TabIndex = 9;
            this.ErrorPasswordLbl.Text = "Error correo password";
            this.ErrorPasswordLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ErrorPasswordLbl.UseStyleColors = true;
            this.ErrorPasswordLbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.ErrorPasswordLbl);
            this.Controls.Add(this.ErrorUsernameLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.UsernameTXT);
            this.Controls.Add(this.SignInBtn);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SignInBtn;
        private MetroFramework.Controls.MetroTextBox UsernameTXT;
        private MetroFramework.Controls.MetroTextBox PasswordTXT;
        private MetroFramework.Controls.MetroLabel UsernameLbl;
        private MetroFramework.Controls.MetroLabel PasswordLbl;
        private MetroFramework.Controls.MetroLabel ErrorUsernameLbl;
        private MetroFramework.Controls.MetroLabel ErrorPasswordLbl;

    }
}