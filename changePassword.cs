using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JCFracturationSystem
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            centraX(this, checks);
            centraX(this, PagesContainer);
        }

        bool findEmail(string email)
        {
            BLUser user_object = new BLUser();
            user_object.Email = email;
            var validation = user_object.findEmail();

            if (validation.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        private void PagesContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PagesContainer.PageIndex)
            {
                case 1:
                    stepOne.Checked = stepOne.Enabled = true;
                    StepOneLabel.ForeColor = Color.FromArgb(0, 31, 84);
                    break;
                case 2:
                    stepTwo.Checked = stepTwo.Enabled = true;
                    StepTwoLabel.ForeColor = Color.FromArgb(0, 31, 84);
                    break;
                case 3:
                    stepThree.Checked = stepThree.Enabled = true;
                    StepThreeLabel.ForeColor = Color.FromArgb(0, 31, 84);
                    break;

            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            PagesContainer.PageIndex = 0;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            PagesContainer.PageIndex = 1;

        }
        string code;
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            string userEmail = EmailTextBox.Text.Trim().ToLower();
            if (findEmail(userEmail))
            {
                code = generateCode();
                SendEmail(userEmail, code);

                PagesContainer.PageIndex = 1;
            }
            else
            {
                MessageBox.Show("Email invalido");
            }
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

        private void SendEmail(string email, string code)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("jcfacturationsytem@gmail.com", "7aeDlMYBaJ7P"),
                EnableSsl = true,
            };

            var messageBody = templateSendEmail();
            messageBody = messageBody.Replace("#code#", code);
            var mailMessage = new MailMessage
            {
                From = new MailAddress("jcfacturationsytem@gmail.com"),
                Subject = "Restablecer contraseña",
                Body = messageBody,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            smtpClient.Send(mailMessage);

            MessageBox.Show("Codigo enviado corretamente.");
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

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            string codeT = CodeTextBox.Text.Trim().ToLower();
            if (code.ToLower() == codeT) PagesContainer.PageIndex = 2;
            else
            {
                MessageBox.Show("Codigo incorrecto.");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            string newP = newPasswordTextBox.Text;
            string newPR = RepeatNewPasswordTextBox.Text;
            if (newP == newPR)
            {
                if (!isPassword(newP))
                {
                    MessageBox.Show("La contraseña no tiene el formato correcto.");
                    return;
                }

                BLUser user = new BLUser();
                user.Email = EmailTextBox.Text.Trim();
                user.Password = newP;
                user.UpdatePassword();
                PagesContainer.PageIndex = 3;

            }
        }

        private bool isPassword(string password)
        {
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            return passwordRegex.IsMatch(password);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Close();
        }
    }
}
