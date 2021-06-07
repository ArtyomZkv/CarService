using System;
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
    public partial class AddNewCall : Form
    {
        DAL dal = new DAL();
        string serviceID;
        string clientID;
        public AddNewCall()
        {
            InitializeComponent();
            
        }

        private void btn_chouseService_Click(object sender, EventArgs e)
        {
            lstbx_services.DataSource = dal.GetAllSevices();
        }

        private void btn_choseClient_Click(object sender, EventArgs e)
        {
            lstbx_clients.DataSource = dal.GetAllClients();
        }

        private void AddNewCall_Load(object sender, EventArgs e)
        {
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            if (dal.AddNewCalling(clientID, serviceID))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void lstbx_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceID = lstbx_services.SelectedValue.ToString();
            textBox1.Text = serviceID;
        }

        private void lstbx_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientID = lstbx_clients.SelectedValue.ToString();
            textBox3.Text = clientID;
        }

        private void btn_addNewService_Click(object sender, EventArgs e)
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

        private void btn_addNewClient_Click(object sender, EventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient();
            addNewClient.ShowDialog();
            if (addNewClient.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Новый клиент успешно добавлен", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Новый клиент не добавлен!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
