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
                MessageBox.Show("Cargando contenido de " + select_table);   
            }
        }

        private string select_table = "";
        private string query = "SELECT * FROM {0}";
    }
}
