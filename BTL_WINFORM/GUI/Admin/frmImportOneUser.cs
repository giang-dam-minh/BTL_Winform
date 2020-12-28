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
    public partial class frmAddUser : Form 
    {
        BUS_Offices bus_office = new BUS_Offices();
        BUS_Users bus_user = new BUS_Users();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            bus_office.getOfficeNameToComboBox2(cbbOffice);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkValid = true;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please enter email address!");
                checkValid=false;
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                errorProvider1.SetError(txtFName, "Please enter First Name!");
                checkValid = false;
            }
            if(string.IsNullOrWhiteSpace(txtLName.Text))
            {
                errorProvider1.SetError(txtLName, "Please enter Last Name!");
                checkValid = false;
            }
            try
            {
                cbbOffice.SelectedItem.ToString();
            }
            catch (Exception)
            {
                errorProvider1.SetError(cbbOffice, "Please choose a item in this list");
                checkValid = false;
               
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Please enter Password!");
                checkValid = false;
            }
            if (!checkValid)
                return;
            bus_user.AddUser(txtEmail.Text, txtFName.Text, txtLName.Text, cbbOffice.Text, txtBirthday.Value, txtPass.Text);
            MessageBox.Show("Add user successful!"); 
        }

        private void txtEmailChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please enter email address!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtFNameChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                errorProvider1.SetError(txtFName, "Please enter email address!");
            }
            else
            {
                errorProvider1.SetError(txtFName, null);
            }
        }

        private void txtLNameChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                errorProvider1.SetError(txtLName, "Please enter email address!");
            }
            else
            {
                errorProvider1.SetError(txtLName, null);
            }
        }

        private void txtPassChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Please enter email address!");
            }
            else
            {
                errorProvider1.SetError(txtPass, null);
            }
        }

        private void checkValid_cbbBirtday(object sender, EventArgs e)
        {
            try
            {
                cbbOffice.SelectedItem.ToString();
                errorProvider1.SetError(cbbOffice, null);
                    
            }
            catch (Exception)
            {
                errorProvider1.SetError(cbbOffice, "Please choose a item in this list");
               

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
