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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.InicioTabPage = new MetroFramework.Controls.MetroTabPage();
            this.FormPanel = new MetroFramework.Controls.MetroPanel();
            this.SearchLbl = new MetroFramework.Controls.MetroLabel();
            this.ColumnLbl = new MetroFramework.Controls.MetroLabel();
            this.ColumnsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SearchTXT = new MetroFramework.Controls.MetroTextBox();
            this.TablesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TableDataGridView = new MetroFramework.Controls.MetroGrid();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ClearBtn = new MetroFramework.Controls.MetroButton();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.CreateBtn = new MetroFramework.Controls.MetroButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.CreateExcelBtn = new MetroFramework.Controls.MetroButton();
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
            this.tabControl1.Location = new System.Drawing.Point(20, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 290);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.UseSelectable = true;
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
            this.InicioTabPage.HorizontalScrollbarBarColor = true;
            this.InicioTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.InicioTabPage.HorizontalScrollbarSize = 10;
            this.InicioTabPage.Location = new System.Drawing.Point(4, 38);
            this.InicioTabPage.Name = "InicioTabPage";
            this.InicioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InicioTabPage.Size = new System.Drawing.Size(952, 248);
            this.InicioTabPage.TabIndex = 0;
            this.InicioTabPage.Text = "Base de Datos";
            this.InicioTabPage.UseVisualStyleBackColor = true;
            this.InicioTabPage.VerticalScrollbarBarColor = true;
            this.InicioTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.InicioTabPage.VerticalScrollbarSize = 10;
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormPanel.HorizontalScrollbarBarColor = true;
            this.FormPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.FormPanel.HorizontalScrollbarSize = 10;
            this.FormPanel.Location = new System.Drawing.Point(683, 44);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(263, 198);
            this.FormPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.FormPanel.TabIndex = 15;
            this.FormPanel.VerticalScrollbar = true;
            this.FormPanel.VerticalScrollbarBarColor = true;
            this.FormPanel.VerticalScrollbarHighlightOnWheel = true;
            this.FormPanel.VerticalScrollbarSize = 10;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(292, 15);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(38, 19);
            this.SearchLbl.TabIndex = 8;
            this.SearchLbl.Text = "texto";
            // 
            // ColumnLbl
            // 
            this.ColumnLbl.AutoSize = true;
            this.ColumnLbl.Location = new System.Drawing.Point(8, 17);
            this.ColumnLbl.Name = "ColumnLbl";
            this.ColumnLbl.Size = new System.Drawing.Size(76, 19);
            this.ColumnLbl.TabIndex = 7;
            this.ColumnLbl.Text = "Buscar por ";
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.ItemHeight = 23;
            this.ColumnsComboBox.Location = new System.Drawing.Point(90, 9);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(192, 29);
            this.ColumnsComboBox.TabIndex = 6;
            this.ColumnsComboBox.UseSelectable = true;
            // 
            // SearchTXT
            // 
            this.SearchTXT.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SearchTXT.Lines = new string[0];
            this.SearchTXT.Location = new System.Drawing.Point(336, 9);
            this.SearchTXT.MaxLength = 32767;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.PasswordChar = '\0';
            this.SearchTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTXT.SelectedText = "";
            this.SearchTXT.Size = new System.Drawing.Size(215, 29);
            this.SearchTXT.TabIndex = 5;
            this.SearchTXT.UseSelectable = true;
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesComboBox.ItemHeight = 23;
            this.TablesComboBox.Location = new System.Drawing.Point(755, 9);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(192, 29);
            this.TablesComboBox.TabIndex = 1;
            this.TablesComboBox.UseSelectable = true;
            this.TablesComboBox.SelectedValueChanged += new System.EventHandler(this.TablesComboBox_SelectedValueChanged);
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.AllowUserToOrderColumns = true;
            this.TableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.TableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TableDataGridView.EnableHeadersVisualStyles = false;
            this.TableDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TableDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableDataGridView.Location = new System.Drawing.Point(6, 44);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableDataGridView.Size = new System.Drawing.Size(674, 198);
            this.TableDataGridView.Style = MetroFramework.MetroColorStyle.Blue;
            this.TableDataGridView.TabIndex = 0;
            this.TableDataGridView.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.ProductMenuStrip.Location = new System.Drawing.Point(20, 60);
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(960, 24);
            this.ProductMenuStrip.TabIndex = 3;
            this.ProductMenuStrip.Text = "ProductMenuStrip";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackgroundImage = global::Inventario.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.Location = new System.Drawing.Point(557, 9);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(29, 29);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.UseSelectable = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackgroundImage = global::Inventario.Properties.Resources.save;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(587, 9);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(29, 29);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackgroundImage = global::Inventario.Properties.Resources.delete;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Location = new System.Drawing.Point(619, 9);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(29, 29);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.UseSelectable = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBtn.BackgroundImage = global::Inventario.Properties.Resources.create;
            this.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateBtn.Location = new System.Drawing.Point(651, 9);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(29, 29);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.UseSelectable = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Inventario.Properties.Resources.update;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(683, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 9;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateExcelBtn
            // 
            this.CreateExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateExcelBtn.BackgroundImage = global::Inventario.Properties.Resources.excel;
            this.CreateExcelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateExcelBtn.Location = new System.Drawing.Point(715, 9);
            this.CreateExcelBtn.Name = "CreateExcelBtn";
            this.CreateExcelBtn.Size = new System.Drawing.Size(29, 29);
            this.CreateExcelBtn.TabIndex = 3;
            this.CreateExcelBtn.UseSelectable = true;
            this.CreateExcelBtn.Click += new System.EventHandler(this.CreateExcelBtn_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProductMenuStrip);
            this.MainMenuStrip = this.ProductMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Inventario";
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

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage InicioTabPage;
        private MetroFramework.Controls.MetroGrid TableDataGridView;
        private MetroFramework.Controls.MetroComboBox TablesComboBox;
        private MetroFramework.Controls.MetroButton CreateExcelBtn;
        private MetroFramework.Controls.MetroComboBox ColumnsComboBox;
        private MetroFramework.Controls.MetroTextBox SearchTXT;
        private MetroFramework.Controls.MetroLabel SearchLbl;
        private MetroFramework.Controls.MetroLabel ColumnLbl;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton CreateBtn;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroPanel FormPanel;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ProductMenuStrip;
        private MetroFramework.Controls.MetroButton ClearBtn;

    }
}

