using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceDB
{
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        public MainForm()
        {
            InitializeComponent();
            ArrayList allClients = dal.GetAllClients();
            dgv_clientsList.DataSource = allClients;


        }
        void SettingsDGV_allClients()
        {
            dgv_clientsList.Columns[0].Visible = false;
            dgv_clientsList.Columns[2].Visible = false;
            dgv_clientsList.Columns[3].Visible = false;
            dgv_clientsList.Columns[4].Visible = false;
        }


        private void Dgv_clientsList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbx_clientName.Text = dgv_clientsList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbx_registrationDate.Text = dgv_clientsList.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbx_phoneNumber.Text = dgv_clientsList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbx_email.Text = dgv_clientsList.Rows[e.RowIndex].Cells[4].Value.ToString();
                dgv_services.DataSource = dal.GetAllSevicesForClients(dgv_clientsList.CurrentRow.Cells["ID клиента"].Value.ToString());
                SettingsDGV_services();
            }
            catch
            {

            }
        }

        void SettingsDGV_services()
        {
            dgv_services.Columns[0].Visible = false;
            dgv_services.Columns[3].HeaderText = "ФИО мастера";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_clientsList.CellEnter += new DataGridViewCellEventHandler(Dgv_clientsList_CellEnter);
            SettingsDGV_allClients();
        }

        private void РегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCall addNewCall = new AddNewCall();
            if (addNewCall.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый вызов успешно добавлен", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_services.DataSource = dal.GetAllSevicesForClients(dgv_clientsList.CurrentRow.Cells["ID клиента"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Вызов не добавлен!!!", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
               
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Вы действительное желаете закрыть приложение?", "Автосервис", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
                Application.Exit();
        }

        private void добавитьНовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient();
            addNewClient.ShowDialog();
            if (addNewClient.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Новый клиент успешно добавлен", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_clientsList.DataSource = dal.GetAllClients();
            }
            else
            {
                MessageBox.Show("Новый клиент не добавлен!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьНовуюУслугуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.ShowDialog();
            if (addNewService.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Новая услуга успешно добавлена", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Новую услугу не удалось добавить!!!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void открытьСписокПерсоналаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewWorker addNewWorker = new AddNewWorker();
            addNewWorker.ShowDialog();
            if (addNewWorker.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Новый работник успешно добавлен", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нового работника не удалось добавить!!!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        List<DataGridViewRow> searchedRows;
        int currentRow;
        private void btn_search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            string name = txbx_searchedClientName.Text.Trim();
            string phoneNumber = txbx_searchedPhoneNumber.Text.Trim();
            string registrationDate = txbx_searchedRegistrationDate.Text.Trim();

            foreach(DataGridViewRow row in dgv_clientsList.Rows)
            {
                if (
                    row.Cells["ФИО клиента"].FormattedValue.ToString().Contains(name) &&
                    row.Cells["Номер телефона клиента"].FormattedValue.ToString().Contains(phoneNumber) &&
                    row.Cells["Дата регистрации клиента"].FormattedValue.ToString().Contains(registrationDate)
                    )
                {
                    searchedRows.Add(row);
                }
            }
            if (searchedRows.Count == 0)
            {
                MessageBox.Show("По данному запросу не найдено записей");
                btn_next.Enabled = false;
                return;
            }
            MessageBox.Show("Найдено " + searchedRows.Count + " записей");
            btn_next.Enabled = true;
            currentRow = -1;
            btn_next_Click(null, null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txbx_searchedRegistrationDate.Text = dateTimePicker1.Value.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count - 1)
            {
                currentRow = 0;
            }
            else
            {
                currentRow++;
                dgv_clientsList.CurrentCell = searchedRows[currentRow].Cells[1];
            }
        }
    }
}
