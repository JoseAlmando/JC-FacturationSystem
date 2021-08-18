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

            btnBuscarToolTip.SetToolTip(this.BuscarButton, "Boton para buscar.");
            btnEditarToolTip.SetToolTip(this.btnSave, "Boton para guardar.");
            btnEditarToolTip.SetToolTip(this.btnEdit, "Boton para editar.");
            btnEliminarToolTip.SetToolTip(this.btnDelete, "Boton para eliminar");
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
            txtAdress.Clear();
            txtIdentificationCard.Clear();
            dwGender.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString("yy:MM:dd hh:mm:ss");

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void ExitApp()
        {
            var button = MessageBox.Show("¿Estas seguro que deseas salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (button == DialogResult.OK)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCLient();
        }

        private bool areEmpty()
        {
            if (txtName.Text.Trim() == string.Empty || txtLastName.Text.Trim() == string.Empty || txtAdress.Text.Trim() == string.Empty || txtIdentificationCard.Text.Trim() == string.Empty || txtLastName.Text.Trim() == string.Empty || txtAge.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty) return true;
            return false;
        }
        private void saveCLient()
        {
            if (areEmpty()) MessageBox.Show("Debe llenar todoso los campos.");
            else
            {
                if (canEdit == false)
                {
                    try
                    {
                        objectClient.addClient(txtName.Text, txtLastName.Text, dwGender.Text, txtAge.Text, txtPhone.Text, txtAdress.Text, txtIdentificationCard.Text);
                        MessageBox.Show($"El Cliente {txtName.Text} {txtLastName.Text} ha sido guardado exitosamente.");
                        showClients();
                        cleanForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Cliente existente.");
                    }
                }
                if (canEdit == true)
                {
                    try
                    {
                        objectClient.editClient(idClient, txtName.Text, txtLastName.Text, dwGender.Text, txtAge.Text, txtPhone.Text, txtAdress.Text, txtIdentificationCard.Text);
                        MessageBox.Show($"El Cliente {txtName.Text} {txtLastName.Text} ha sido editado exitosamente.");
                        showClients();
                        cleanForm();
                        canEdit = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Cliente no existente.");
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgTable.SelectedRows.Count > 0)
            {
                canEdit = true;
                txtName.Text = dtgTable.CurrentRow.Cells["Nombre"].Value.ToString();
                txtLastName.Text = dtgTable.CurrentRow.Cells["Apellido"].Value.ToString();
                dwGender.Text = dtgTable.CurrentRow.Cells["Sexo"].Value.ToString();
                txtAge.Text = dtgTable.CurrentRow.Cells["Edad"].Value.ToString();
                txtPhone.Text = dtgTable.CurrentRow.Cells["Telefono"].Value.ToString();
                txtAdress.Text = dtgTable.CurrentRow.Cells["Direccion"].Value.ToString();
                txtIdentificationCard.Text = dtgTable.CurrentRow.Cells["Cedula"].Value.ToString();
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
                idClient = dtgTable.CurrentRow.Cells["Cedula"].Value.ToString();
                objectClient.deleteClient(idClient);
                MessageBox.Show($"El Cliente ha sido eliminado exitosamente.");
                showClients();
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a eliminar.");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            showClientOrClients();
        }

        void showClientOrClients()
        {
            BLClient objectClient = new BLClient();
            dtgTable.DataSource = objectClient.showClientOrClients(BuscarTextBox.Text.Trim());

        }

        private void BuscarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) showClientOrClients();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtLastName.Focus();
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) dwGender.Focus();
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void dwGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAge.Focus();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtPhone.Focus();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtIdentificationCard.Focus();
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtIdentificationCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtAdress.Focus();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) saveCLient();
        }

        private void DashBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F10) ExitApp();

        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        int wait = 0;
        private void WaitingTimer_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 100;

            int tp;

            tp = wait;
            tp += 1;
            wait = tp;

            if (tp == 500)
            {
                MessageBox.Show("Tiempo de Espera Agotado");
                Application.ExitThread();
                Application.Exit();

            }
        }

        private void DashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            wait = 0;
        }

        private void tabPage6_MouseMove(object sender, MouseEventArgs e)
        {
            wait = 0;

        }

        private void BuscarTextBox_TextChange(object sender, EventArgs e)
        {
            showClientOrClients();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
