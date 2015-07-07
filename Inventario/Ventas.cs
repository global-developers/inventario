using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Models;
using Inventario.Helpers;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace Inventario
{
    public partial class Ventas : MetroForm
    {

        private Form parent;
        private About about;
        private User user;
        private Connection cnn;
        private string query_search = "SELECT * FROM products WHERE id='{0}'";

        public Ventas()
        {
            InitializeComponent();
            cnn = new Connection();
        }

        public Ventas(Form parent, User user) : this()
        {
            this.parent = parent;
            this.user = user;

        }

        private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
            cnn.close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cnn.close();
            parent.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (int.TryParse(metroTextBox1.Text, out i))
            {
                MySqlCommand cmd = cnn.GetMysqlCommand(String.Format(query_search, metroTextBox1.Text.ToString()));
                var reader = cmd.ExecuteReader();
                Product product;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Price = reader.GetDouble(2);
                    }
                }
                else {
                    MetroMessageBox.Show(this, "No se encontro ningun producto con ese identificador", "Ventas - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();                
            }
            else
            {
                MetroMessageBox.Show(this, "La información proporcionada es invalida", "Ventas - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
