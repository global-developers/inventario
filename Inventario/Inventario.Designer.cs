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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InicioTabPage = new System.Windows.Forms.TabPage();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.ColumnLbl = new System.Windows.Forms.Label();
            this.ColumnsComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.CreateExcelBtn = new System.Windows.Forms.Button();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuStrip = new System.Windows.Forms.MenuStrip();
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
            this.tabControl1.Size = new System.Drawing.Size(860, 309);
            this.tabControl1.TabIndex = 2;
            // 
            // InicioTabPage
            // 
            this.InicioTabPage.Controls.Add(this.ClearBtn);
            this.InicioTabPage.Controls.Add(this.FormPanel);
            this.InicioTabPage.Controls.Add(this.SaveBtn);
            this.InicioTabPage.Controls.Add(this.DeleteBtn);
            this.InicioTabPage.Controls.Add(this.CreateBtn);
            this.InicioTabPage.Controls.Add(this.button1);
            this.InicioTabPage.Controls.Add(this.SearchLbl);
            this.InicioTabPage.Controls.Add(this.ColumnLbl);
            this.InicioTabPage.Controls.Add(this.ColumnsComboBox);
            this.InicioTabPage.Controls.Add(this.SearchTXT);
            this.InicioTabPage.Controls.Add(this.CreateExcelBtn);
            this.InicioTabPage.Controls.Add(this.TablesComboBox);
            this.InicioTabPage.Controls.Add(this.TableDataGridView);
            this.InicioTabPage.Location = new System.Drawing.Point(4, 22);
            this.InicioTabPage.Name = "InicioTabPage";
            this.InicioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InicioTabPage.Size = new System.Drawing.Size(852, 283);
            this.InicioTabPage.TabIndex = 0;
            this.InicioTabPage.Text = "Base de Datos";
            this.InicioTabPage.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackgroundImage = global::Inventario.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.Location = new System.Drawing.Point(495, 14);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(21, 21);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.Location = new System.Drawing.Point(607, 44);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(239, 233);
            this.FormPanel.TabIndex = 15;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackgroundImage = global::Inventario.Properties.Resources.save;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(520, 14);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(21, 21);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackgroundImage = global::Inventario.Properties.Resources.delete;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(547, 14);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(21, 21);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBtn.BackgroundImage = global::Inventario.Properties.Resources.create;
            this.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateBtn.Location = new System.Drawing.Point(574, 14);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(21, 21);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Inventario.Properties.Resources.update;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(601, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // ColumnLbl
            // 
            this.ColumnLbl.AutoSize = true;
            this.ColumnLbl.Location = new System.Drawing.Point(8, 17);
            this.ColumnLbl.Name = "ColumnLbl";
            this.ColumnLbl.Size = new System.Drawing.Size(61, 13);
            this.ColumnLbl.TabIndex = 7;
            this.ColumnLbl.Text = "Buscar por ";
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.Location = new System.Drawing.Point(75, 12);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(192, 21);
            this.ColumnsComboBox.TabIndex = 6;
            // 
            // SearchTXT
            // 
            this.SearchTXT.Location = new System.Drawing.Point(309, 14);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(180, 20);
            this.SearchTXT.TabIndex = 5;
            // 
            // CreateExcelBtn
            // 
            this.CreateExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateExcelBtn.BackgroundImage = global::Inventario.Properties.Resources.excel;
            this.CreateExcelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateExcelBtn.Location = new System.Drawing.Point(628, 14);
            this.CreateExcelBtn.Name = "CreateExcelBtn";
            this.CreateExcelBtn.Size = new System.Drawing.Size(21, 21);
            this.CreateExcelBtn.TabIndex = 3;
            this.CreateExcelBtn.UseVisualStyleBackColor = true;
            this.CreateExcelBtn.Click += new System.EventHandler(this.CreateExcelBtn_Click);
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesComboBox.Location = new System.Drawing.Point(655, 14);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(192, 21);
            this.TablesComboBox.TabIndex = 1;
            this.TablesComboBox.SelectedValueChanged += new System.EventHandler(this.TablesComboBox_SelectedValueChanged);
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TableDataGridView.Location = new System.Drawing.Point(6, 44);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TableDataGridView.Size = new System.Drawing.Size(595, 233);
            this.TableDataGridView.TabIndex = 0;
            this.TableDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDataGridView_CellDoubleClick);
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
            this.acercaDeToolStripMenuItem.Text = "Cerrar sesión";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ProductMenuStrip
            // 
            this.ProductMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.ProductMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.ProductMenuStrip.TabIndex = 3;
            this.ProductMenuStrip.Text = "ProductMenuStrip";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProductMenuStrip);
            this.MainMenuStrip = this.ProductMenuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 400);
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
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Button CreateExcelBtn;
        private System.Windows.Forms.ComboBox ColumnsComboBox;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label ColumnLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ProductMenuStrip;
        private System.Windows.Forms.Button ClearBtn;

    }
}

