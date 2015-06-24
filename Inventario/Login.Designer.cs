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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ErrorUsernameLbl = new System.Windows.Forms.Label();
            this.ErrorPasswordLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventario.Properties.Resources.power;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MinBtn);
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Location = new System.Drawing.Point(297, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 26);
            this.panel2.TabIndex = 1;
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Black;
            this.MinBtn.BackgroundImage = global::Inventario.Properties.Resources.window_min;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(24, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(24, 24);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            this.MinBtn.MouseLeave += new System.EventHandler(this.MinBtn_MouseLeave);
            this.MinBtn.MouseHover += new System.EventHandler(this.MinBtn_MouseHover);
            this.MinBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinBtn_MouseUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Black;
            this.CloseBtn.BackgroundImage = global::Inventario.Properties.Resources.window_close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(0, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 24);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.CloseBtn.MouseHover += new System.EventHandler(this.CloseBtn_MouseHover);
            this.CloseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseUp);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleLbl.Location = new System.Drawing.Point(144, 4);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(66, 29);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Login";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(120, 232);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(115, 32);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTXT.Location = new System.Drawing.Point(13, 78);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(325, 31);
            this.UsernameTXT.TabIndex = 3;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTXT.Location = new System.Drawing.Point(12, 162);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.PasswordChar = '*';
            this.PasswordTXT.Size = new System.Drawing.Size(325, 31);
            this.PasswordTXT.TabIndex = 4;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLbl.Location = new System.Drawing.Point(12, 51);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(166, 24);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Correo electrónico";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLbl.Location = new System.Drawing.Point(12, 135);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(106, 24);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Contraseña";
            // 
            // ErrorUsernameLbl
            // 
            this.ErrorUsernameLbl.AutoSize = true;
            this.ErrorUsernameLbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorUsernameLbl.ForeColor = System.Drawing.Color.Orange;
            this.ErrorUsernameLbl.Location = new System.Drawing.Point(12, 114);
            this.ErrorUsernameLbl.Name = "ErrorUsernameLbl";
            this.ErrorUsernameLbl.Size = new System.Drawing.Size(140, 20);
            this.ErrorUsernameLbl.TabIndex = 8;
            this.ErrorUsernameLbl.Text = "Error correo electrónico";
            this.ErrorUsernameLbl.Visible = false;
            // 
            // ErrorPasswordLbl
            // 
            this.ErrorPasswordLbl.AutoSize = true;
            this.ErrorPasswordLbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPasswordLbl.ForeColor = System.Drawing.Color.Orange;
            this.ErrorPasswordLbl.Location = new System.Drawing.Point(12, 196);
            this.ErrorPasswordLbl.Name = "ErrorPasswordLbl";
            this.ErrorPasswordLbl.Size = new System.Drawing.Size(131, 20);
            this.ErrorPasswordLbl.TabIndex = 9;
            this.ErrorPasswordLbl.Text = "Error correo password";
            this.ErrorPasswordLbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(350, 278);
            this.Controls.Add(this.ErrorPasswordLbl);
            this.Controls.Add(this.ErrorUsernameLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.UsernameTXT);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorUsernameLbl;
        private System.Windows.Forms.Label ErrorPasswordLbl;

    }
}