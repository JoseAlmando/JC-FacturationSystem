using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Net.Mail;

namespace JCFracturationSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            sigIn();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Focus();
                ShowPasswordLabel.Text = "Hide password";
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.PasswordChar = '●';
                PasswordTextBox.Focus();
                ShowPasswordLabel.Text = "Show password";

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp register = new SignUp();
            register.Show();
            Hide();
        }

        private bool isEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) sigIn();
        }

        private void sigIn()
        {
            string userEmail = EmailTextBox.Text.Trim().ToLower();
            string userPassword = PasswordTextBox.Text;

            if (userEmail == "" && userPassword == "")
            {
                MessageBox.Show("El email y contraseña son requeridos.");
                return;
            }


            if (!isEmail(userEmail))
            {
                MessageBox.Show("El email no tiene el formato correcto");
                return;
            }

            if (userEmail == "")
            {
                MessageBox.Show("El email es requerido.");
                return;
            }

            if (userPassword == "")
            {
                MessageBox.Show("La Contraseña es requerida.");
                return;
            }

            BLLogIn user_object = new BLLogIn();
            user_object.Email = EmailTextBox.Text;
            user_object.Password = PasswordTextBox.Text;
            var validation = user_object.sigIn();

            if (validation.HasRows)
            {
                MessageBox.Show($"Bienvenido {userEmail}.");
                Menu menu = new Menu(userEmail);
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas, Intente de nuevo.");
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            centraX(LeftPanel, pictureBox1);
            centraY(LeftPanel, pictureBox1);
        }


        public static void centraX(Control padre, Control hijo)
        {
            int x = 0;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            x = (padre.Width / 2) - (hijo.Width / 2);

            //asignamos la nueva ubicación
            hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
        }
        public static void centraY(Control padre, Control hijo)
        {
            int y = 0;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            y = (padre.Height / 2) - (hijo.Height / 2);

            //asignamos la nueva ubicación
            hijo.Location = new System.Drawing.Point(hijo.Location.X, y);
        }

    }

}
