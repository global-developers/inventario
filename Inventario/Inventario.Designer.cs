namespace Inventario
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InicioTabPage = new System.Windows.Forms.TabPage();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.ColumnsComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnLbl = new System.Windows.Forms.Label();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.InicioTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.ProductMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.InicioTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 309);
            this.tabControl1.TabIndex = 2;
            // 
            // InicioTabPage
            // 
            this.InicioTabPage.Controls.Add(this.SearchLbl);
            this.InicioTabPage.Controls.Add(this.ColumnLbl);
            this.InicioTabPage.Controls.Add(this.ColumnsComboBox);
            this.InicioTabPage.Controls.Add(this.SearchTXT);
            this.InicioTabPage.Controls.Add(this.EditBtn);
            this.InicioTabPage.Controls.Add(this.CreateBtn);
            this.InicioTabPage.Controls.Add(this.DeleteBtn);
            this.InicioTabPage.Controls.Add(this.TablesComboBox);
            this.InicioTabPage.Controls.Add(this.TableDataGridView);
            this.InicioTabPage.Location = new System.Drawing.Point(4, 22);
            this.InicioTabPage.Name = "InicioTabPage";
            this.InicioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InicioTabPage.Size = new System.Drawing.Size(792, 283);
            this.InicioTabPage.TabIndex = 0;
            this.InicioTabPage.Text = "Base de Datos";
            this.InicioTabPage.UseVisualStyleBackColor = true;
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesComboBox.Location = new System.Drawing.Point(594, 14);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(192, 21);
            this.TablesComboBox.TabIndex = 1;
            this.TablesComboBox.SelectedValueChanged += new System.EventHandler(this.TablesComboBox_SelectedValueChanged);
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableDataGridView.Location = new System.Drawing.Point(6, 44);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.Size = new System.Drawing.Size(780, 233);
            this.TableDataGridView.TabIndex = 0;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AboutToolStripMenuItem.Text = "Acerca de PowerDev";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.acercaDeToolStripMenuItem.Text = "Salir";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ProductMenuStrip
            // 
            this.ProductMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.ProductMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(824, 24);
            this.ProductMenuStrip.TabIndex = 3;
            this.ProductMenuStrip.Text = "ProductMenuStrip";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBtn.BackgroundImage = global::Inventario.Properties.Resources.create;
            this.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateBtn.Location = new System.Drawing.Point(513, 14);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(21, 21);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.BackgroundImage = global::Inventario.Properties.Resources.edit;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditBtn.Location = new System.Drawing.Point(540, 14);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(21, 21);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackgroundImage = global::Inventario.Properties.Resources.delete;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Location = new System.Drawing.Point(567, 14);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(21, 21);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTXT
            // 
            this.SearchTXT.Location = new System.Drawing.Point(309, 14);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(180, 20);
            this.SearchTXT.TabIndex = 5;
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.Location = new System.Drawing.Point(75, 12);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(192, 21);
            this.ColumnsComboBox.TabIndex = 6;
            // 
            // ColumnLbl
            // 
            this.ColumnLbl.AutoSize = true;
            this.ColumnLbl.Location = new System.Drawing.Point(8, 17);
            this.ColumnLbl.Name = "ColumnLbl";
            this.ColumnLbl.Size = new System.Drawing.Size(61, 13);
            this.ColumnLbl.TabIndex = 7;
            this.ColumnLbl.Text = "Buscar por ";
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(273, 17);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(30, 13);
            this.SearchLbl.TabIndex = 8;
            this.SearchLbl.Text = "texto";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 362);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProductMenuStrip);
            this.MainMenuStrip = this.ProductMenuStrip;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventario_FormClosed);
            this.Shown += new System.EventHandler(this.Inventario_Shown);
            this.tabControl1.ResumeLayout(false);
            this.InicioTabPage.ResumeLayout(false);
            this.InicioTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ProductMenuStrip.ResumeLayout(false);
            this.ProductMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InicioTabPage;
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ProductMenuStrip;
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ComboBox ColumnsComboBox;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label ColumnLbl;

    }
}

