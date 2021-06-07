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
    public partial class AddNewService : Form
    {
        DAL dal = new DAL();
        Guid serviceID = Guid.NewGuid();
        string workerID;
        public AddNewService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dal.AddNewService(serviceID, txbx_serviceName.Text.Trim(), decimal.Parse(txbx_servicePrice.Text.Trim()), workerID))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void AddNewService_Load(object sender, EventArgs e)
        {
            lstbx_services.DataSource = dal.GetAllWorkers();
            workerID = lstbx_services.SelectedValue.ToString();
        }

        private void lstbx_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerID = lstbx_services.SelectedValue.ToString();
        }
    }
}
