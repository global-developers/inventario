﻿using MySql.Data.MySqlClient;
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

namespace Inventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cnn = new Connection();
            this.CenterToScreen();
        }

        public Login(Form parent) : this()
        {
            this.parent = parent;
            inventario = new Inventario(this);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            cnn.close();
            this.Close();
        }
        
        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackgroundImage = Properties.Resources.window_close_over;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackgroundImage = Properties.Resources.window_close;
        }

        private void CloseBtn_MouseUp(object sender, MouseEventArgs e)
        {
            CloseBtn.BackgroundImage = Properties.Resources.window_close_over;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinBtn_MouseHover(object sender, EventArgs e)
        {
            MinBtn.BackgroundImage = Properties.Resources.window_min_over;
        }

        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            MinBtn.BackgroundImage = Properties.Resources.window_min;
        }

        private void MinBtn_MouseUp(object sender, MouseEventArgs e)
        {
            MinBtn.BackgroundImage = Properties.Resources.window_min_over;
        }

        private Form parent;
        private int xR;
        private int yR;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            xR = e.X;
            yR = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Left + e.X - xR, this.Top + e.Y - yR);
            }
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
                User user = new User();

                if (reader.HasRows) 
                {
                    while(reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.FullName = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.CategoryId = reader.GetInt32(4);
                        user.Category = new Category(reader.GetInt32(7), reader.GetString(8));
                    }

                    MessageBox.Show("Bienvenido " + user.Category.Name + " " +  user.FullName);

                }

                reader.Close();

                if (user.CategoryId == 1 || user.CategoryId == 1)
                {
                    inventario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(String.Format("{0} ó {1} incorrectos", UsernameLbl.Text.ToString(), PasswordLbl.Text.ToString()));
                }

            }

        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                PasswordTXT.Clear();
            }
        }

        public static string email_pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public static string password_pattern = @"[0-9a-zA-ZñÑ]{6,12}";
        public static string query = "SELECT * FROM users, categories WHERE users.email='{0}' AND users.password='{1}' AND users.id=categories.id";
        private static Connection cnn = new Connection();
        private Inventario inventario;
    }
}