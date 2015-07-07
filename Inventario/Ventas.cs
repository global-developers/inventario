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

namespace Inventario
{
    public partial class Ventas : MetroForm
    {

        private Form parent;
        private About about;

        public Ventas()
        {
            InitializeComponent();
        }

        public Ventas(Form parent) : this()
        {
            this.parent = parent;
        }

        private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.ShowDialog();
        }
    }
}
