using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Helpers;
using Inventario.Models;
using MetroFramework.Forms;
using MetroFramework;

namespace Inventario
{
    public partial class Login : MetroForm
    {

        private Form parent;
        public static string email_pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public static string password_pattern = @"[0-9a-zA-ZñÑ]{6,12}";
        public static string query = "SELECT * FROM users, categories WHERE users.email='{0}' AND users.password='{1}' AND users.category_id=categories.id";
        private static Connection cnn;
        private Inventario inventario;
        private Ventas ventas;
        private User user;


        public Login()
        {
            InitializeComponent();
            cnn = new Connection();
            this.CenterToScreen();
        }

        public Login(Form parent) : this()
        {
            this.parent = parent;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {

            bool success = true;
            
            string email = UsernameTXT.Text.ToString();
            string email_message = null;
            string password = PasswordTXT.Text.ToString();
            string password_message = null;

            // Ocultamos los mensajes de error
            ErrorUsernameLbl.Visible = false;
            ErrorPasswordLbl.Visible = false;


            Regex regex = new Regex(email_pattern);

            if (email.Length < 5) {
                email_message = "El campo " + UsernameLbl.Text.ToString() + " tener almenos 5 caracteres.";
            } else if (email.Length > 320) {
                email_message = "El campo " + UsernameLbl.Text.ToString() + " tener máximo 320 caracteres.";
            } else if (!regex.IsMatch(email)) {
                email_message = "El campo " + UsernameLbl.Text.ToString() + " debe ser valido."; ;
            }

            // Validación de password
            regex = new Regex(password_pattern);

            if (password.Length < 6) {
                password_message = "El campo " + PasswordLbl.Text.ToString() + " tener almenos 6 caracteres.";
            } else if (password.Length > 60) {
                password_message = "El campo " + PasswordLbl.Text.ToString() + " tener máximo 60 caracteres.";
            } else if (!regex.IsMatch(password)) {
                password_message = "El campo " + PasswordLbl.Text.ToString() + " solo acepta números y letras."; ;
            }

            if (email_message != null)
            {
                success = false;
                ErrorUsernameLbl.Visible = true;
                ErrorUsernameLbl.Text = email_message;
            }

            if (password_message != null)
            {
                success = false;
                ErrorPasswordLbl.Visible = true;
                ErrorPasswordLbl.Text = password_message;
            }

            if (success) 
            {
                MySqlCommand cmd = cnn.GetMysqlCommand(String.Format(query, email, password));
                var reader = cmd.ExecuteReader();

                if (reader.HasRows) 
                {
                    while(reader.Read())
                    {
                        user = new User();
                        user.Id = reader.GetInt32(0);
                        user.FullName = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.CategoryId = reader.GetInt32(4);
                        user.Category = new Category(reader.GetInt32(7), reader.GetString(8));
                    }

                    MetroMessageBox.Show(this, "Bienvenido " + user.Category.Name + " " + user.FullName, "Login - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                    if (user.CategoryId == 1 || user.Category.Name.Equals("Administrador"))
                    {
                        inventario = new Inventario(this, user);
                        inventario.Show();
                        this.Hide();
                    }
                    else if (user.CategoryId == 2 || user.Category.Name.Equals("Vendedor"))
                    {
                        ventas = new Ventas(this, user);
                        ventas.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MetroMessageBox.Show(this, "Usted no cuenta con permiso para accesar!!!", "Login - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    user = null;
                    MetroMessageBox.Show(this, String.Format("{0} ó {1} incorrectos", UsernameLbl.Text.ToString(), PasswordLbl.Text.ToString()), "Login - PowerDev", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();

            }

        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                PasswordTXT.Clear();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.close();
            parent.Close();
        }
    }
}
