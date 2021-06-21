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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString("hh:mm:ss");

        }


        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Value += 1;
            bunifuCircleProgress2.Value += 1;
            if (bunifuCircleProgress1.Value == 50 && bunifuCircleProgress2.Value == 50)
            {
                timer2.Stop();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 6;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 7;
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
