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
    public partial class AddNewClient : Form
    {
        //public string Mask { get; set; }
        
        DAL dal = new DAL();
        public AddNewClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dal.AddNewClient(txbx_clientName.Text.Trim(), txbx_date.Text.Trim(), txbx_phoneNumber.Text.Trim(), txbx_phoneNumber.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void txbx_phoneNumer_TextChanged(object sender, EventArgs e)
        {
            dal.InsertPhoneNumber(txbx_phoneNumber);
        }

        private void txbx_phoneNumber_Click(object sender, EventArgs e)
        {
            txbx_phoneNumber.SelectionStart = txbx_phoneNumber.Text.Length;
        }

        private void AddNewClient_Load(object sender, EventArgs e)
        {
            txbx_phoneNumber.Text = "+7(";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbx_phoneNumber.Text = "+7(";
        }

        private void dtp_registrationDate_ValueChanged(object sender, EventArgs e)
        {
            txbx_date.Text = dtp_registrationDate.Value.ToString();
        }
    }
}
