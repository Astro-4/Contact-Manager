using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisContactManagerCSharp
{
    public partial class BusinessEditor : Form
    {
        DbConn dbConn = new DbConn();
        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbComp.Enabled = true;
            tbPosition.Enabled = true;
            tbTel.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            btnUpdateSelected.Enabled = false;
            btnDeleteSelected.Enabled = false;
            btnSaveNew.Enabled = true;
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbComp.Text = String.Empty;
            tbPosition.Text = String.Empty;
            tbTel.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbAddr.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
        }

        private void dGVBusinessRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
            tbFname.Text = dGVBusinessRecords.SelectedCells[1].Value.ToString();
            tbLname.Text = dGVBusinessRecords.SelectedCells[2].Value.ToString();
            tbComp.Text = dGVBusinessRecords.SelectedCells[3].Value.ToString();
            tbPosition.Text = dGVBusinessRecords.SelectedCells[4].Value.ToString();
            tbTel.Text = dGVBusinessRecords.SelectedCells[5].Value.ToString();
            tbEmail.Text = dGVBusinessRecords.SelectedCells[6].Value.ToString();
            tbAddr.Text = dGVBusinessRecords.SelectedCells[7].Value.ToString();
            tbCity.Text = dGVBusinessRecords.SelectedCells[8].Value.ToString();
            tbPostcode.Text = dGVBusinessRecords.SelectedCells[9].Value.ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactFname = tbFname.Text;
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactCompany = tbComp.Text;
            businessContact.ContactPosition = tbPosition.Text;
            businessContact.BusinessTel = tbTel.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.ContactAddr = tbAddr.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            dbConn.InsertBusiness(businessContact);
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbComp.Enabled = false;
            tbPosition.Enabled = false;
            tbTel.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            btnUpdateSelected.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbComp.Enabled = true;
            tbPosition.Enabled = true;
            tbTel.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            btnUpdateSelected.Enabled = false;
            btnDeleteSelected.Enabled = false;
            btnAddNew.Enabled = false;
            btnSaveSelected.Enabled = true;
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactID = index;
            businessContact.ContactFname = tbFname.Text;
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactCompany = tbComp.Text;
            businessContact.ContactPosition = tbPosition.Text;
            businessContact.BusinessTel = tbTel.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.ContactAddr = tbAddr.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            dbConn.UpdateBusiness(businessContact);
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbComp.Enabled = false;
            tbPosition.Enabled = false;
            tbTel.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            btnUpdateSelected.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            string caption = "Do you want to delete contact ID no " + Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DeleteBusiness(Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString()));
                dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
            }
        }
    }
}
