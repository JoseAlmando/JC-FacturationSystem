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
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

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
            ShowPassword();
        }

        private void ShowPassword()
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
            //SignUp register = new SignUp();
            //register.Show();
            //Hide();

            SendEmail("20211093@itla.edu.do");
        }

        private void SendEmail(string email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("josea.dominique01@gmail.com", "8095203242"),
                EnableSsl = true,
            };

            var messageBody = templateSendEmail();
            messageBody = messageBody.Replace("#code#", "159-753");
            var mailMessage = new MailMessage
            {
                From = new MailAddress("josea.dominique01@gmail.com"),
                Subject = "Restablecer contraseña",
                Body = messageBody,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            smtpClient.Send(mailMessage);

            MessageBox.Show("Succes");
        }

        private string templateSendEmail()
        {
            string startupPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            string result = "";

            StreamReader reader = new StreamReader($"{startupPath}\\HTMLtemplate\\emailTemplate.html");

            result = reader.ReadToEnd();

            reader.Close();

            return result;
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

            if (validation.Rows.Count > 0)
            {
                var userName = validation.Rows[0]["username"].ToString();
                var userLevel = validation.Rows[0]["leveln"].ToString();
                var userLastName = validation.Rows[0]["user_last_name"].ToString();
                DashBoard menu = new DashBoard();
                MessageBox.Show($"Bienvenido {userLastName}.");
                menu.userLabel.Text += " " + userLastName + " - " + userLevel;
                if (userLevel == "normal")
                {

                    menu.userLabel.ForeColor = Color.Red;
                }
                if (userLevel == "admin")
                {
                    menu.userLabel.ForeColor = Color.White;

                }
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

            x = (padre.Width / 2) - (hijo.Width / 2);

            hijo.Location = new Point(x, hijo.Location.Y);
        }

        public static void centraY(Control padre, Control hijo)
        {
            int y = 0;

            y = (padre.Height / 2) - (hijo.Height / 2);

            hijo.Location = new Point(hijo.Location.X, y);
        }

        static string generateCode()
        {
            Random random = new Random();
            string resultado = "";

            Dictionary<string, string> Configuration = new Dictionary<string, string>()
            {
                { "minusculas", "abcdefghijklmnopqrstuvwxyz" },
                { "numeros", "0123456789" }
            };
            string[] keys = { "minusculas", "numeros" };


            for (int i = 0; i < 8; i++)
            {
                string key = keys[random.Next(keys.Length)];
                string cadena = Configuration[key];
                char character = cadena[random.Next(cadena.Length)];

                resultado += character.ToString();
            }

            return resultado;
        }

    }
}
