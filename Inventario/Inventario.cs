using Inventario.Helpers;
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

namespace Inventario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        public Inventario(Form parent) : this()
        {
            this.parent = parent;
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
            about.ShowDialog();
        }

        private Form parent;
        private About about = new About();
        private static Connection cnn = new Connection();

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
                if(control is TextBox)
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

                Label label = new Label();
                label.MaximumSize = new Size(232, 13);
                label.Text = select_table;
                label.Location = new Point(0, 0);
                FormPanel.Controls.Add(label);

                foreach (DataGridViewColumn column in TableDataGridView.Columns)
                {
                    label = new Label();
                    label.MaximumSize = new Size(232, 13); 
                    label.Text = column.Name;
                    label.Location = new Point(_x, 20 + (_y * _columns));
                    FormPanel.Controls.Add(label);
                    TextBox textbox = new TextBox();
                    textbox.Size = new Size(232, 20);
                    textbox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    textbox.Location = new Point(_x, 37 + (_y * _columns));
                    textbox.Enabled =  Array.Exists(noEdit, element => element == column.Name) ? false : true;
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
                if (control is TextBox)
                {
                    if (int.TryParse(control.Text.ToString(), out id))
                    {
                        id = Convert.ToInt32(control.Text.ToString());
                        var message = String.Format("Esta segudo de eliminar la fila \"{0}\"", id);

                        if (MessageBox.Show(message, "Confirmación de eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            var cmd = cnn.GetMysqlCommand(String.Format(query_delete, select_table, id));
                            var reader = cmd.ExecuteReader();
                            reader.Close();
                            UpdateDataGridView();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Elemento no selecionado");
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
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private string _cell = "";
        private string select_table = "";
        private string query_update = "";
        private string query_insert = "";
        private string query_delete = "DELETE FROM {0} WHERE id='{1}'";
        private string query = "SELECT * FROM {0}";
        private string[] noEdit = new string[3] {"id", "created_at", "updated_at"};

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

                if(control is Label)
                {
                    if (!Array.Exists(noEdit, element => element == control.Text) && select_table != control.Text)
                    {
                        key = control.Text;
                    }
                }

                if (control is TextBox)
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
                        MessageBox.Show("Elemento no selecionado");
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
                MessageBox.Show(query_update);
                var cmd = cnn.GetMysqlCommand(query_update);
                var reader = cmd.ExecuteReader();
                reader.Close();
                UpdateDataGridView();
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

                if (control is Label)
                {
                    if (!Array.Exists(noEdit, element => element == control.Text) && select_table != control.Text)
                    {
                        key = control.Text;
                    }
                }

                if (control is TextBox)
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
                MessageBox.Show("Existen campos vacios");
            }
        }

    }
}
