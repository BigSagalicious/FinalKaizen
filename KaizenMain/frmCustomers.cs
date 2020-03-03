using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KaizenMain
{
    public partial class frmCustomers : Form
    {
        SqlDataAdapter daCustomer;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custIDSelected = 0;
        public frmCustomers()
        {
            InitializeComponent();
        }


        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabCustomer.SelectedIndex;
            tabCustomer.TabPages[tabCustomer.SelectedIndex].Focus();
            tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;

            if (dgvCustomers.SelectedRows.Count == 0 && (tabCustomer.SelectedIndex == 1 || tabCustomer.SelectedIndex == 3 || tabCustomer.SelectedIndex == 4))
                tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabCustomer.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Customer"].Clear();
                            daCustomer.Fill(dsKaizen, "Customer");

                            break;
                        }
                    case 1:
                        {
                            if (custIDSelected == 0)
                            {
                                tabCustomer.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtSearchID.Text = custIDSelected.ToString();

                                drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtSearchID.Text);

                                txtSearchForename.Text = drCustomer["CustFName"].ToString();
                                txtSearchSurname.Text = drCustomer["CustSName"].ToString();
                                txtSearchAddress.Text = drCustomer["CustAddress"].ToString();
                                txtSearchTown.Text = drCustomer["TownCity"].ToString();
                                txtSearchCounty.Text = drCustomer["County"].ToString();
                                txtSearchPcode.Text = drCustomer["CustPCode"].ToString();
                                txtSearchEmail.Text = drCustomer["CustEmail"].ToString();
                                txtSearchTel.Text = drCustomer["CustTel"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Customer"].Rows.Count;

                            if (noRows == 0)
                                lblAdCustNo.Text = "1000";
                            else
                            {
                                getNumber(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (custIDSelected == 0)
                            {
                                tabCustomer.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEditID.Text = custIDSelected.ToString();

                                drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtEditID.Text);
                                /*  if (drCustomer["Title"].ToString() == "Mr")
                                      cmbEdit.SelectedIndex = 0;
                                  if (drCustomer["Title"].ToString() == "Mrs")
                                      cmbEdit.SelectedIndex = 1;
                                  if (drCustomer["Title"].ToString() == "Miss")
                                      cmbEdit.SelectedIndex = 2;
                                  if (drCustomer["Title"].ToString() == "Ms")
                                     cmbEdit.SelectedIndex = 3;
  */
                                txtEditForename.Text = drCustomer["CustFName"].ToString();
                                txtEditSurname.Text = drCustomer["CustSName"].ToString();
                                txtEditAddress.Text = drCustomer["CustAddress"].ToString();
                                txtEditTown.Text = drCustomer["TownCity"].ToString();
                                txtEditCounty.Text = drCustomer["County"].ToString();
                                txtEditPostcode.Text = drCustomer["CustPCode"].ToString();
                                txtEditEmail.Text = drCustomer["CustEmail"].ToString();
                                txtEditTel.Text = drCustomer["CustTel"].ToString();

                                disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (custIDSelected == 0)
                            {
                                tabCustomer.SelectedIndex = 0;
                                break;
                            }
                            txtDeleteID.Text = custIDSelected.ToString();

                            drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtDeleteID.Text);

                            txtDeleteForename.Text = drCustomer["CustFName"].ToString();
                            txtDeleteSurname.Text = drCustomer["CustSName"].ToString();
                            txtDeleteAddress.Text = drCustomer["CustAddress"].ToString();
                            txtDeleteTown.Text = drCustomer["TownCity"].ToString();
                            txtDeleteCounty.Text = drCustomer["County"].ToString();
                            txtDeletePostcode.Text = drCustomer["CustPCode"].ToString();
                            txtDeleteEmail.Text = drCustomer["CustEmail"].ToString();
                            txtDeleteTel.Text = drCustomer["CustTel"].ToString();
                            break;
                        }



                }
            }
        }

        //Get Forename data
        private void txtAddForename_TextChanged(object sender, EventArgs e)
        {
            if (txtDeleteForename.Text.Length >= 2 && txtDeleteForename.Text.Length <= 15)
                txtDeleteForename.BackColor = Color.White;
            else
                txtDeleteForename.BackColor = Color.LightCoral;
        }
        //get Surname data
        private void txtAddSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtAddForename.Text.Length >= 2 && txtAddForename.Text.Length <= 15)
                txtAddForename.BackColor = Color.White;
            else
                txtAddForename.BackColor = Color.LightCoral;
        }
        //get Address data
        private void txtAddAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddAddress.Text.Length >= 2 && txtAddAddress.Text.Length <= 15)
                txtAddAddress.BackColor = Color.White;
            else
                txtAddAddress.BackColor = Color.LightCoral;
        }
        //Get town data
        private void txtAddTown_TextChanged(object sender, EventArgs e)
        {
            if (txtAddTown.Text.Length >= 2 && txtAddTown.Text.Length <= 15)
                txtAddTown.BackColor = Color.White;
            else
                txtAddTown.BackColor = Color.LightCoral;
        }
        //Get County Data
        private void txtAddCounty_TextChanged(object sender, EventArgs e)
        {
            if (txtAddCounty.Text.Length >= 2 && txtAddCounty.Text.Length <= 15)
                txtAddCounty.BackColor = Color.White;
            else
                txtAddCounty.BackColor = Color.LightCoral;
        }
        //Get Postcode data
        private void txtAddPostcode_TextChanged(object sender, EventArgs e)
        {
            if (txtAddPostcode.Text.Length >= 2 && txtAddPostcode.Text.Length <= 15)
                txtAddPostcode.BackColor = Color.White;
            else
                txtAddPostcode.BackColor = Color.LightCoral;
        }
        //Get Email Data 
        private void txtAddEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtAddEmail.Text.Length >= 2 && txtAddEmail.Text.Length <= 40)
                txtAddEmail.BackColor = Color.White;
            else
                txtAddEmail.BackColor = Color.LightCoral;
        }
        // Get Telephone Number data 
        private void txtAddTel_TextChanged(object sender, EventArgs e)
        {
            if (txtAddTel.Text.Length >= 2 && txtAddTel.Text.Length <= 15)
                txtAddTel.BackColor = Color.White;
            else
                txtAddTel.BackColor = Color.LightCoral;
        }


        private void getNumber(int noRows)
        {
            drCustomer = dsKaizen.Tables["Customer"].Rows[noRows - 1];
            lblAdCustNo.Text = (int.Parse(drCustomer["CustID"].ToString()) + 1).ToString();
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                custSelected = false;
                custIDSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {

                custSelected = true;
                custIDSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }

        void DispTabValidate(object sender, EventArgs e)
        {
            if (custSelected == false && custIDSelected == 0)
            {
                custSelected = false;
                custIDSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custIDSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }
        void EditTabValidate(object sender, EventArgs e)
        {
            if (custSelected == false && custIDSelected == 0)
            {
                custSelected = false;
                custIDSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custIDSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();
            try
            {
                myCustomer.CustID = Convert.ToInt32(lblAdCustNo.Text.Trim());

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAdCustNo, MyEx.toString());
            }


            try
            {
                myCustomer.Surname = txtAddForename.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddForename, MyEx.toString());
            }

            try
            {
                myCustomer.Forename = txtAddSurname.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSurname, MyEx.toString());
            }

            try
            {
                myCustomer.Street = txtAddAddress.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddAddress, MyEx.toString());
            }

            try
            {
                myCustomer.Town = txtAddTown.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTown, MyEx.toString());
            }

            try
            {
                myCustomer.County = txtAddCounty.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyEx.toString());
            }

            try
            {
                myCustomer.Postcode = txtAddPostcode.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyEx.toString());
            }

            try
            {
                myCustomer.TelNo = txtAddTel.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTel, MyEx.toString());
            }

            try
            {
                myCustomer.Email = txtAddEmail.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drCustomer = dsKaizen.Tables["Customer"].NewRow();
                    drCustomer["CustID"] = myCustomer.CustID;
                    drCustomer["CustFname"] = myCustomer.Forename;
                    drCustomer["CustSname"] = myCustomer.Surname;
                    drCustomer["CustAddress"] = myCustomer.Street;
                    drCustomer["TownCity"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["CustPCode"] = myCustomer.Postcode;
                    drCustomer["CustTel"] = myCustomer.TelNo;
                    drCustomer["CustEmail"] = myCustomer.Email;

                    dsKaizen.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsKaizen, "Customer");

                    MessageBox.Show("Customer Added");

                    if (MessageBox.Show("Do you wish to add another customer?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsKaizen.Tables["Customer"].Rows.Count);
                    }
                    else
                        tabCustomer.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (btnEditEditCust.Text == "EDIT CUSTOMER")
            {
                enableEditTxtboxes();

                btnEditEditCust.Text = "Save";
            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errP.Clear();

                try
                {
                    myCustomer.Surname = txtEditForename.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditForename, MyEx.toString());
                }

                try
                {
                    myCustomer.Forename = txtEditSurname.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyEx.toString());
                }

                try
                {
                    myCustomer.Street = txtEditAddress.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditAddress, MyEx.toString());
                }

                try
                {
                    myCustomer.Town = txtEditTown.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTown, MyEx.toString());
                }

                try
                {
                    myCustomer.County = txtEditCounty.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCounty, MyEx.toString());
                }

                try
                {
                    myCustomer.Postcode = txtEditPostcode.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditPostcode, MyEx.toString());
                }

                try
                {
                    myCustomer.TelNo = txtEditTel.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTel, MyEx.toString());
                }

                try
                {
                    myCustomer.Email = txtEditEmail.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditEmail, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();
                        drCustomer["CustFname"] = myCustomer.Forename;
                        drCustomer["CustSname"] = myCustomer.Surname;
                        drCustomer["CustAddress"] = myCustomer.Street;
                        drCustomer["TownCity"] = myCustomer.Town;
                        drCustomer["County"] = myCustomer.County;
                        drCustomer["CustPCode"] = myCustomer.Postcode;
                        drCustomer["CustTel"] = myCustomer.TelNo;
                        drCustomer["CustEmail"] = myCustomer.Email;

                        drCustomer.EndEdit();
                        daCustomer.Update(dsKaizen, "Customer");

                        MessageBox.Show("Customer Details Updated", "Customer");

                        disableEditTxtboxes();

                        btnEditEditCust.Text = "EDIT CUSTOMER";
                        tabCustomer.SelectedIndex = 0;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }


            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");

            }
            else
            {
                drCustomer = dsKaizen.Tables["Customer"].Rows.
                    Find(dgvCustomers.SelectedRows[0].Cells[0].Value);

                string tempName = drCustomer["CustFname"].ToString() + " " +
                    drCustomer["CustSname"].ToString() + "\'s";
                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?",
                    "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(dsKaizen, "Customer");
                    MessageBox.Show("Details Removed for " + tempName);
                    clearDeleteForm();

                }

            }
        }

        void clearAddForm()
        {

            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddAddress.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTel.Clear();
            txtAddEmail.Clear();

        }

        void clearSearchForm()
        {
            txtSearchID.Clear();
            txtSearchForename.Clear();
            txtSearchSurname.Clear();
            txtSearchAddress.Clear();
            txtSearchTown.Clear();
            txtSearchCounty.Clear();
            txtSearchPcode.Clear();
            txtSearchTel.Clear();
            txtSearchEmail.Clear();

        }

        void clearEditForm()
        {
            txtEditID.Clear();
            txtEditForename.Clear();
            txtEditSurname.Clear();
            txtEditAddress.Clear();
            txtEditTown.Clear();
            txtEditCounty.Clear();
            txtEditPostcode.Clear();
            txtEditTel.Clear();
            txtEditEmail.Clear();

        }

        void clearDeleteForm()
        {

            txtDeleteID.Clear();
            txtDeleteForename.Clear();
            txtDeleteSurname.Clear();
            txtDeleteAddress.Clear();
            txtDeleteTown.Clear();
            txtDeleteCounty.Clear();
            txtDeletePostcode.Clear();
            txtDeleteTel.Clear();
            txtDeleteEmail.Clear();

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";

            // connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);

            daCustomer.FillSchema(dsKaizen, SchemaType.Source, "Customer");
            daCustomer.Fill(dsKaizen, "Customer");
            dgvCustomers.DataSource = dsKaizen.Tables["Customer"];
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabCustomer.SelectedIndex = 1;
            tabCustomer.SelectedIndex = 0;



        }

        private void btnSearchClearForm_Click(object sender, EventArgs e)
        {
            clearSearchForm();
        }

        private void btnAddClearForm_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        private void btnEditClearForm_Click(object sender, EventArgs e)
        {
            clearEditForm();
        }

        private void btnDeleteClearForm_Click(object sender, EventArgs e)
        {
            clearDeleteForm();
        }

        private void frmCustomer_Shown(object sender, EventArgs e)
        {
            tabCustomer.TabPages[0].CausesValidation = true;
            tabCustomer.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabCustomer.TabPages[2].CausesValidation = true;
            tabCustomer.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        private void enableEditTxtboxes()
        {
            txtEditForename.Enabled = true;
            txtEditSurname.Enabled = true;
            txtEditAddress.Enabled = true;
            txtEditTown.Enabled = true;
            txtEditCounty.Enabled = true;
            txtEditPostcode.Enabled = true;
            txtEditTel.Enabled = true;
            txtEditEmail.Enabled = true;
        }

        private void disableEditTxtboxes()
        {
            txtEditForename.Enabled = false;
            txtEditSurname.Enabled = false;
            txtEditAddress.Enabled = false;
            txtEditTown.Enabled = false;
            txtEditCounty.Enabled = false;
            txtEditPostcode.Enabled = false;
            txtEditTel.Enabled = false;
            txtEditEmail.Enabled = false;
        }

        // Searching and populating feilds for customers
        private void btnSearchIconSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchID.Text;

            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtSearchID.Text);

                        txtSearchForename.Text = drCustomer["CustFName"].ToString();
                        txtSearchSurname.Text = drCustomer["CustSName"].ToString();
                        txtSearchAddress.Text = drCustomer["CustAddress"].ToString();
                        txtSearchTown.Text = drCustomer["TownCity"].ToString();
                        txtSearchCounty.Text = drCustomer["County"].ToString();
                        txtSearchPcode.Text = drCustomer["CustPCode"].ToString();
                        txtSearchEmail.Text = drCustomer["CustEmail"].ToString();
                        txtSearchTel.Text = drCustomer["CustTel"].ToString();
                        break;
                    }
                }
            }
            catch (MyException Exception)
            {
                MessageBox.Show("Not found");
            }
        }
        private void btnEditIconSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtEditID.Text;

            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtEditID.Text);

                        txtEditForename.Text = drCustomer["CustFName"].ToString();
                        txtEditSurname.Text = drCustomer["CustSName"].ToString();
                        txtEditAddress.Text = drCustomer["CustAddress"].ToString();
                        txtEditTown.Text = drCustomer["TownCity"].ToString();
                        txtEditCounty.Text = drCustomer["County"].ToString();
                        txtEditPostcode.Text = drCustomer["CustPCode"].ToString();
                        txtEditEmail.Text = drCustomer["CustEmail"].ToString();
                        txtEditTel.Text = drCustomer["CustTel"].ToString();
                        break;
                    }
                }
            }
            catch (MyException Exception)
            {
                MessageBox.Show("Not found");
            }
        }
        private void btnDeleteIconSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtDeleteID.Text;

            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtDeleteID.Text);

                                txtDeleteForename.Text = drCustomer["CustFName"].ToString();
                                txtDeleteSurname.Text = drCustomer["CustSName"].ToString();
                                txtDeleteAddress.Text = drCustomer["CustAddress"].ToString();
                                txtDeleteTown.Text = drCustomer["TownCity"].ToString();
                                txtDeleteCounty.Text = drCustomer["County"].ToString();
                                txtDeletePostcode.Text = drCustomer["CustPCode"].ToString();
                                txtDeleteEmail.Text = drCustomer["CustEmail"].ToString();
                                txtDeleteTel.Text = drCustomer["CustTel"].ToString();
                                break;
                    }
                }
            }
            catch (MyException Exception)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}


