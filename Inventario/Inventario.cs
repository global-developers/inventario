﻿using Inventario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using Inventario.Models;
using System.Diagnostics;

namespace Inventario
{
    public partial class Inventario : MetroForm
    {

        private Form parent;
        private About about;
        private User user;
        private static Connection cnn;
        private string _cell = "";
        private string select_table = "";
        private string query_update = "";
        private string query_insert = "";
        private string query_delete = "DELETE FROM {0} WHERE id='{1}'";
        private string query = "SELECT * FROM {0}";
        private string[] noEdit = new string[3] { "id", "created_at", "updated_at" };

        public Inventario()
        {
            InitializeComponent();
            cnn = new Connection();
        }

        public Inventario(Form parent, User user) : this()
        {
            this.parent = parent;
            this.user = user;
        }

        private void Inventario_Shown(object sender, EventArgs e)
        {
            MySqlCommand cmd = cnn.GetMysqlCommand("SHOW TABLES");
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TablesComboBox.Items.Add(reader.GetString(0));
                }
            }

            reader.Close();
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.close();
            parent.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void TablesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            select_table = TablesComboBox.SelectedItem.ToString();
            UpdateDataGridView();
        }

        private void CreateExcelBtn_Click(object sender, EventArgs e)
        {
            exportExcel(TableDataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        public void exportExcel(DataGridView table)
        {
            if (table.Columns.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Application.Workbooks.Add(true);

                int _columns = 0;
                int _rows = 1;
                
                foreach (DataGridViewColumn column in table.Columns)
                {
                    excel.Cells[1, ++_columns] = column.Name;
                }

                foreach (DataGridViewRow row in table.Rows)
                {
                    _columns = 0;
                    _rows++;
                    foreach (DataGridViewColumn column in table.Columns)
                    {
                        excel.Cells[_rows, ++_columns] = row.Cells[column.Name].Value;
                    }
                }

                excel.Visible = true;

            }
        }

        private void TableDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _cell = TableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void TableDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = 0;
            DeleteBtn.Enabled = true;
            SaveBtn.Enabled = true;
            CreateBtn.Enabled = false;
            foreach(Control control in FormPanel.Controls)
            {
                if(control is MetroTextBox)
                {
                    control.Text = TableDataGridView.Rows[row].Cells[column].Value.ToString();
                    column++;
                }
            }
        }

        private void UpdateDataGridView()
        {
            if (select_table != "")
            {
                cnn.DataAdapter(String.Format(query, select_table));

                var data_adapter = cnn.GetDataAdapter();

                DataSet ds = new DataSet();

                data_adapter.Fill(ds, select_table);

                ColumnsComboBox.Items.Clear();

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    ColumnsComboBox.Items.Add(ds.Tables[0].Columns[i].ColumnName);// .Add(ds.Tables[0].Columns[i].ColumnName);
                }

                TableDataGridView.DataSource = ds;
                TableDataGridView.DataMember = select_table;

                int _x = 3;
                int _y = 41;

                int _columns = 0;
                FormPanel.AutoScroll = true;
                FormPanel.Controls.Clear();

                MetroLabel label = new MetroLabel();
                label.Location = new Point(0, 0);
                label.Size = new Size(232, 19);
                label.MaximumSize = new Size(232, 19);
                label.Text = select_table;
                FormPanel.Controls.Add(label);

                foreach (DataGridViewColumn column in TableDataGridView.Columns)
                {
                    label = new MetroLabel();
                    label.Location = new Point(_x, 30 + (_y * _columns));
                    label.Size = new Size(232, 19);
                    label.MaximumSize = new Size(232, 19); 
                    label.Text = column.Name;
                    FormPanel.Controls.Add(label);
                    MetroTextBox textbox = new MetroTextBox();
                    textbox.Location = new Point(_x, 50 + (_y * _columns));
                    textbox.Size = new Size(255, 23);
                    textbox.MaximumSize = new Size(255, 23);
                    textbox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    textbox.Enabled =  Array.Exists(noEdit, element => element == column.Name) ? false : true;
                    textbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
                    FormPanel.Controls.Add(textbox);
                    _columns++;
                }   
            
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id = 0;

            foreach (Control control in FormPanel.Controls)
            {
                if (control is MetroTextBox)
                {
                    if (int.TryParse(control.Text.ToString(), out id))
                    {
                        id = Convert.ToInt32(control.Text.ToString());
                        var message = String.Format("Esta realmente seguro de eliminar la fila \"{0}\"", id);

                        if (MetroMessageBox.Show(this, message, "Eliminación de registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                        {

                            var cmd = cnn.GetMysqlCommand(String.Format(query_delete, select_table, id));
                            var reader = cmd.ExecuteReader();
                            reader.Close();
                            UpdateDataGridView();

                        }

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Elemento no selecionado", "Eliminación de registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            DeleteBtn.Enabled = false;
            SaveBtn.Enabled = false;
            CreateBtn.Enabled = true;

            foreach (Control control in FormPanel.Controls)
            {
                if (control is MetroTextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            int id = 0;
            int count = ((FormPanel.Controls.Count) - 7) / 2;
            bool valid = false;

            query_update = String.Format("UPDATE {0} SET updated_at=CURRENT_TIMESTAMP(), ", select_table);

            string key = null;
            string value = null;

            foreach (Control control in FormPanel.Controls)
            {

                if(control is MetroLabel)
                {
                    if (!Array.Exists(noEdit, element => element == control.Text) && select_table != control.Text)
                    {
                        key = control.Text;
                    }
                }

                if (control is MetroTextBox)
                {
                    if (int.TryParse(control.Text.ToString(), out i) && id == 0)
                    {
                        id = Convert.ToInt32(control.Text.ToString());
                        valid = true;
                    }

                    if(control.Enabled) 
                    {
                        value = control.Text;
                    }
                    
                    if(!valid)
                    {
                        MetroMessageBox.Show(this, "Elemento no selecionado", "Creación de registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

                if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    query_update += String.Format("{0}='{1}'", key, value);
                    key = null;
                    value = null;
                    if (count > 1)
                    {
                        query_update += ", ";
                        count--;
                    }
                }
                 
            }

            if(valid)
            {
                query_update += String.Format("  WHERE id='{0}'", id);

                var message = String.Format("Esta realmente seguro de eliminar la fila \"{0}\"", id);

                if (MetroMessageBox.Show(this, message, "Actualización de registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    // MessageBox.Show(query_update);
                    var cmd = cnn.GetMysqlCommand(query_update);
                    var reader = cmd.ExecuteReader();
                    reader.Close();
                    UpdateDataGridView();
                }
            }


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int count = ((FormPanel.Controls.Count) - 7) / 2;

            query_insert = String.Format("INSERT INTO {0} ", select_table);
            
            string columns = "(";
            string values = "(";
           
            string key = null;
            string value = null;

            foreach (Control control in FormPanel.Controls)
            {

                if (control is MetroLabel)
                {
                    if (!Array.Exists(noEdit, element => element == control.Text) && select_table != control.Text)
                    {
                        key = control.Text;
                    }
                }

                if (control is MetroTextBox)
                {
                    if (control.Enabled)
                    {
                        value = control.Text;
                    }
                }

                if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    columns += String.Format("{0}", key);
                    values += String.Format("'{0}'", value);
                    
                    key = null;
                    value = null;
                    
                    if (count > 1)
                    {
                        columns += ", ";
                        values += ", ";
                        count--;
                    }
                }

            }

            if (count == 1)
            {
                query_insert += columns + ", created_at, updated_at) VALUES " + values + ", CURRENT_TIMESTAMP(), CURRENT_TIMESTAMP())";
                var cmd = cnn.GetMysqlCommand(query_insert);
                var reader = cmd.ExecuteReader();

                reader.Close();
                UpdateDataGridView();
            }
            else {
                MetroMessageBox.Show(this, "Existen campos vacios", "Actualización de registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            if(TableDataGridView.RowCount > 0)
                To_pdf();
            else
                MetroMessageBox.Show(this, "No existe contenido.", "Generación de reportes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region crearPDF
        private void To_pdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = select_table + "-report.pdf";
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "Autorizo: " + user.FullName.ToUpper();
                string envio = "Fecha: " + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte de General de " + select_table.ToUpper(), FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("PowerDev - IPN"));
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc, TableDataGridView);
                doc.AddCreationDate();
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }

        }
        public void GenerarDocumento(Document document, DataGridView dataGridViewContent)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridViewContent.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridViewContent);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridViewContent.ColumnCount; i++)
            {
                datatable.AddCell(dataGridViewContent.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridViewContent.Rows.Count; i++)
            {
                for (j = 0; j < dataGridViewContent.Columns.Count; j++)
                {
                    if (dataGridViewContent[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridViewContent[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }
        #endregion

    }
}
