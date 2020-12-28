using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmEditRole : Form
    {
        BUS_Offices bus_office = new BUS_Offices();
        BUS_Users   bus_user   = new BUS_Users();
        public frmEditRole()
        {
            InitializeComponent();
        }

        private void frmEditRole_Load(object sender, EventArgs e)
        {
            bus_office.getOfficeNameToComboBox2(cbbOffice);
            RBAdmin.Checked=true;
            bus_user.getEmailToCombobox2(cbbEmail);
            txtFName.Text = bus_user.getFNameByEmail(cbbEmail.Text);
            txtLName.Text = bus_user.getLNameByEmail(cbbEmail.Text);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int i=0;
            if(RBAdmin.Checked)
                i=1;
            if(RBUser.Checked)
                i=2;
            try
            {
                bus_user.changRoleByEmail(cbbEmail.SelectedItem.ToString(), i);
                MessageBox.Show("Apply sucess");
            }
            catch (Exception)
            {

                MessageBox.Show("Please choose the Email in combobox");
            }           
        }

        private void cbbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFName.Text = bus_user.getFNameByEmail(cbbEmail.Text);
            txtLName.Text = bus_user.getLNameByEmail(cbbEmail.Text);
            cbbOffice.Text = bus_user.getOfficeNameByEmail(cbbEmail.Text).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
