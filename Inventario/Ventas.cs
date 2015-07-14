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
        private string insert_register_ventas = "INSERT INTO register_ventas (venta_id, product_id, count) VALUES ";
        private string insert_vendedor = "INSERT INTO ventas (user_id,  created_at, updated_at) VALUES ('{0}', CURRENT_TIMESTAMP(), CURRENT_TIMESTAMP())";
        private double monto_venta = 0.00;
        
        public Ventas()
        {
            InitializeComponent();
            cnn = new Connection();
        }

        public Ventas(Form parent, User user) : this()
        {
            this.parent = parent;
            this.user = user;
            insert_vendedor = String.Format(insert_vendedor, user.Id);
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
                        product.Description = reader.GetString(2);
                        product.Price = reader.GetDouble(3);
                        product.Color = reader.GetString(4);
                        product.Barcode = reader.GetString(5);
                        product.Count = reader.GetInt32(6);

                        int row = SearchId(product.Id);

                        if (row != -1)
                        {
                            metroGrid1.Rows[row].Cells[4].Value = Convert.ToInt32(metroGrid1.Rows[row].Cells[4].Value) + 1;
                        }
                        else {
                            metroGrid1.Rows.Add();
                            int last = metroGrid1.Rows.Count - 1;

                            metroGrid1.Rows[last].Cells[0].Value = product.Id;
                            metroGrid1.Rows[last].Cells[1].Value = product.Name;
                            metroGrid1.Rows[last].Cells[2].Value = product.Description;
                            metroGrid1.Rows[last].Cells[3].Value = product.Price;
                            metroGrid1.Rows[last].Cells[4].Value = 1;
                        }

                        UpdateMontoVenta();
                                
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


        private int SearchId(int id)
        {
            int row = -1;
            
            for (int i = 0; i < metroGrid1.Rows.Count; i++ )
            {
                if (Convert.ToInt32(metroGrid1.Rows[i].Cells[0].Value) == id)
                {
                    row = i;
                    break;
                }

            }

            return row;
        }

        private void UpdateMontoVenta()
        { 
            monto_venta = 0;

            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                monto_venta += (Convert.ToDouble(metroGrid1.Rows[i].Cells[3].Value)  * Convert.ToInt32(metroGrid1.Rows[i].Cells[4].Value));
            }

            VentaMetroLabel.Text = "$ " + monto_venta;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroGrid1.Rows.Clear();
            UpdateMontoVenta();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if(metroGrid1.Rows.Count > 0)
            {
                int id = 0;
                var cmd = cnn.GetMysqlCommand(insert_vendedor);
                var reader = cmd.ExecuteReader();
                
                reader.Close();

                cmd = cnn.GetMysqlCommand("SELECT MAX(id) AS id FROM ventas");
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                        id = reader.GetInt32(0);
                }

                reader.Close();

                cmd = cnn.GetMysqlCommand(GenerateVenta(id));
                reader = cmd.ExecuteReader();

                metroTile2_Click(sender, e);
                reader.Close();
                MetroMessageBox.Show(this, "Venta " + id + " finalizada con exito!", "Ventas - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private string GenerateVenta(int id)
        {
            insert_register_ventas = "INSERT INTO register_ventas (venta_id, product_id, count, created_at, updated_at) VALUES ";

            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                insert_register_ventas += String.Format("('{0}', '{1}', '{2}', CURRENT_TIMESTAMP(), CURRENT_TIMESTAMP())", id, metroGrid1.Rows[i].Cells[0].Value, metroGrid1.Rows[i].Cells[4].Value);
                if ((i + 1) < metroGrid1.Rows.Count)
                    insert_register_ventas += ", ";
            }

            return insert_register_ventas;
        }


    }
}
