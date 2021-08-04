using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;

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
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            Close();
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
    }
}
