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

namespace JCFracturationSystem
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
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

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) PasswordTextBox.Focus();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) signUp();
        }

        void signUp()
        {
            string userEmail = EmailTextBox.Text.Trim().ToLower();
            string userPassword = PasswordTextBox.Text;
            string userName = UsernameTextBox.Text.Trim();

            if (userName == "")
            {
                MessageBox.Show("El username es requerido.");
                return;
            }

            if (!isCorrectUsername(userName))
            {
                MessageBox.Show("El formato del username es incorrecto. No se permiten espacios en blanco.");
                return;
            }

            if (!isEmail(userEmail))
            {
                MessageBox.Show("El formato del email es incorrecto.");
                return;
            }

            if (!isPassword(userPassword))
            {
                MessageBox.Show("La contraseña no tiene el formato correcto.");
                return;
            }

            BLUser userObject = new BLUser();
            userObject.Email = userEmail;
            userObject.Password = userPassword;
            userObject.Username = userName;
            userObject.signUp();
            MessageBox.Show("Usuario guardado exitosamente.", "Sign Up", MessageBoxButtons.OK);
            clearTextBox();
        }

        void clearTextBox()
        {
            UsernameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
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

        private bool isPassword(string password)
        {
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            return passwordRegex.IsMatch(password);
        }

        private bool isCorrectUsername(string username)
        {
            var usernameRegex = new Regex(@"^[a-zA-Z0-9_]*$");
            return usernameRegex.IsMatch(username);
        }

        public static void centraX(Control padre, Control hijo)
        {
            int x = 0;

            x = (padre.Width / 2) - (hijo.Width / 2);

            hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
        }

        public static void centraY(Control padre, Control hijo)
        {
            int y = 0;

            y = (padre.Height / 2) - (hijo.Height / 2);

            hijo.Location = new Point(hijo.Location.X, y);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            centraX(LeftPanel, pictureBox1);
            centraY(LeftPanel, pictureBox1);
        }
    }
}
