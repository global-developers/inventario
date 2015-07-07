namespace Inventario
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(147, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.Style = MetroFramework.MetroColorStyle.Black;
            this.label1.TabIndex = 1;
            this.label1.Text = "PowerDev";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 242);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 10);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventario.Properties.Resources._1436249533_power_blue;
            this.pictureBox1.Location = new System.Drawing.Point(133, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Resizable = false;
            this.Text = "Start";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            this.Load += new System.EventHandler(this.Start_Load);
            this.Shown += new System.EventHandler(this.Start_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}