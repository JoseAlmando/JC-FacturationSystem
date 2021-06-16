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

namespace JCFracturationSystem
{
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string userEmail = EmailTextBox.Text;
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

            BLUser userObject = new BLUser();
            userObject.Email = EmailTextBox.Text;
            userObject.Password = PasswordTextBox.Text;
            userObject.signUp();
            MessageBox.Show($"Usuario {userEmail} guardado exitosamente.", "Sign Up", MessageBoxButtons.OK);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
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

            BLUser userObject = new BLUser();
            userObject.Email = EmailTextBox.Text;
            userObject.Password = PasswordTextBox.Text;
            userObject.signUp();
            clearTextBox();
            MessageBox.Show("Usuario guardado exitosamente.", "Sign Up", MessageBoxButtons.OK);
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
        }

        void clearTextBox()
        {
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Hide();
        }
    }
}
