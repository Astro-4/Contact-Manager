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
    public partial class PersonalEditor : Form
    {
        DbConn dbConn = new DbConn();
        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbDepart.Enabled = true;
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
            tbDepart.Text = String.Empty;
            tbTel.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbAddr.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
        }

        private void dGVPersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString());
            tbFname.Text = dGVPersonalRecords.SelectedCells[1].Value.ToString();
            tbLname.Text = dGVPersonalRecords.SelectedCells[2].Value.ToString();
            tbDepart.Text = dGVPersonalRecords.SelectedCells[3].Value.ToString();
            tbTel.Text = dGVPersonalRecords.SelectedCells[4].Value.ToString();
            tbEmail.Text = dGVPersonalRecords.SelectedCells[5].Value.ToString();
            tbAddr.Text = dGVPersonalRecords.SelectedCells[6].Value.ToString();
            tbCity.Text = dGVPersonalRecords.SelectedCells[7].Value.ToString();
            tbPostcode.Text = dGVPersonalRecords.SelectedCells[8].Value.ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactDepartment = tbDepart.Text;
            personalContact.PersonalTel = tbTel.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactAddr = tbAddr.Text;
            personalContact.ContactCity= tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            dbConn.InsertPersonal(personalContact);
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbDepart.Enabled = false;
            tbTel.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            btnUpdateSelected.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();

        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbDepart.Enabled = true;
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
            int index = Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactDepartment = tbDepart.Text;
            personalContact.PersonalTel = tbTel.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactAddr = tbAddr.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            dbConn.UpdatePersonal(personalContact);
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbDepart.Enabled = false;
            tbTel.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            btnUpdateSelected.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            string caption = "Do you want to delete contact ID no " + Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes) {
                dbConn.DeletePersonal(Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString()));
                dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();
            }

        }
    }
}
