using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Helpers;
using MetroFramework.Forms;

namespace Inventario
{
    public partial class Start : MetroForm
    {
        public Start()
        {
            InitializeComponent();

        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private void Start_Shown(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            InitializeMyTimer();

            if (cnn.Version == null)
                this.Close();
        }

        // Call this method from the constructor of the form.
        private void InitializeMyTimer()
        {
            // Set the interval for the timer.
            time.Interval = 10;
            // Connect the Tick event of the timer to its event handler.
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar a value of one each time.
            progressBar1.Increment(1);
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            // statusBarPanel1.Text = progressBar1.Value.ToString() + "% Completed";
            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (progressBar1.Value == progressBar1.Maximum)
            {
                // Stop the timer.
                time.Stop();
                Login login = new Login(this); 
                login.Show();
                this.Hide();
            }
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.close();
        }

        private static Connection cnn = new Connection();

    }

}
