using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCFracturationSystem
{
    public partial class Menu : Form
    {
        string person;
        public Menu(string person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text += " " + this.person.Trim();
            centraX(this, welcomeLabel);
            centraX(this, msgLabel);
            centraX(this, pictureBox1);

        }

        public static void centraX(Control padre, Control hijo)
        {
            int x = 0;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            x = (padre.Width / 2) - (hijo.Width / 2);

            //asignamos la nueva ubicación
            hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
        }
    }
}
