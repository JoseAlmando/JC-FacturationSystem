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
        BLLogIn loginObjet = new BLLogIn();

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            BLUser userObject = new BLUser();
            userObject.Email = EmailTextBox.Text;
            userObject.Password = PasswordTextBox.Text;
            userObject.signUp();
            MessageBox.Show("Usuario guardado exitosamente.", "Sign Up", MessageBoxButtons.OK);
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
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.PasswordChar = '●';
                PasswordTextBox.Focus();

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            BLUser userObject = new BLUser();
            userObject.Email = EmailTextBox.Text;
            userObject.Password = PasswordTextBox.Text;
            userObject.signUp();
            MessageBox.Show("Usuario guardado exitosamente.", "Sign Up", MessageBoxButtons.OK);
        }
    }
}
