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
    public partial class DashBoard : Form
    {
        BLClient objectClient = new BLClient();

        private string idClient = null;
        private bool canEdit = false;
     
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            showClients();

        }

        private void showClients()
        {
            BLClient objectClient = new BLClient();
            dtgTable.DataSource = objectClient.showClients();
        }

        private void cleanForm()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dwGender.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString("yy:MM:dd hh:mm:ss");

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var button = MessageBox.Show("¿Estas seguro que deseas salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (button == DialogResult.OK)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (canEdit == false)
            {
                try
                {
                    objectClient.addClient(txtName.Text, txtLastName.Text, dwGender.Text, txtAge.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show($"El Cliente {txtName.Text} {txtLastName.Text} ha sido guardado exitosamente.");
                    showClients();
                    cleanForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error {ex}");
                }
            }
            if(canEdit == true)
            {
                try
                {
                    objectClient.editClient(idClient, txtName.Text, txtLastName.Text, dwGender.Text, txtAge.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show($"El Cliente {txtName.Text} {txtLastName.Text} ha sido editado exitosamente.");
                    showClients();
                    cleanForm();
                    canEdit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgTable.SelectedRows.Count > 0)
            {
                canEdit = true;
                txtName.Text = dtgTable.CurrentRow.Cells["NAME"].Value.ToString();
                txtLastName.Text = dtgTable.CurrentRow.Cells["LAST_NAME"].Value.ToString();
                dwGender.Text = dtgTable.CurrentRow.Cells["GENDER"].Value.ToString();
                txtAge.Text = dtgTable.CurrentRow.Cells["AGE"].Value.ToString();
                txtPhone.Text = dtgTable.CurrentRow.Cells["PHONE"].Value.ToString();
                txtAddress.Text = dtgTable.CurrentRow.Cells["ADDRESS"].Value.ToString();
                idClient = dtgTable.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgTable.SelectedRows.Count > 0)
            {
                idClient = dtgTable.CurrentRow.Cells["ID"].Value.ToString();
                objectClient.deleteClient(idClient);
                MessageBox.Show($"El Cliente ha sido eliminado exitosamente.");
                showClients();
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a eliminar.");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
