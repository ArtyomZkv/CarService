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
    public partial class AddNewWorker : Form
    {
        DAL dal = new DAL();
        string workerID;
        public AddNewWorker()
        {
            InitializeComponent();
        }

        private void btn_addNewWorker_Click(object sender, EventArgs e)
        {
            if (dal.AddNewWorker(txbx_workerName.Text.Trim(), txbx_phoneNumber.Text.Trim(), workerID))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerID = listBox1.SelectedValue.ToString();
        }

        private void AddNewWorker_Load(object sender, EventArgs e)
        {
            txbx_phoneNumber.Text = "+7(";
            listBox1.DataSource = dal.GetAllSevices();
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void txbx_phoneNumber_TextChanged(object sender, EventArgs e)
        {
            dal.InsertPhoneNumber(txbx_phoneNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbx_phoneNumber.Text = "+7(";
        }
    }
}
