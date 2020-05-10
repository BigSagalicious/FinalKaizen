using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaizenMain
{
    public partial class frmSuppliers : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        int selectedTab = 0;
        bool suppSelected = false;
        int suppIDSelected =0;
        int IDNumber = 0;
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void tabSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabSupplier.SelectedIndex;
            tabSupplier.TabPages[tabSupplier.SelectedIndex].Focus();
            tabSupplier.TabPages[tabSupplier.SelectedIndex].CausesValidation = true;

            if (dgvSuppliers.SelectedRows.Count == 0 && (tabSupplier.SelectedIndex == 1 || tabSupplier.SelectedIndex == 3 || tabSupplier.SelectedIndex == 4))
                tabSupplier.TabPages[tabSupplier.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabSupplier.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Supplier"].Clear();
                            daSupplier.Fill(dsKaizen, "Supplier");

                            break;
                        }
                    case 1:
                        {
                            if (suppIDSelected == 0)
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                //txtSeSuppID.Text = suppIDSelected.ToString();
                                txtSeSuppID.Text = "SU-" + suppIDSelected.ToString();
                                drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtSeSuppID.Text);


                                txtSeCompName.Text = drSupplier["SuppName"].ToString();
                                txtSeContactName.Text = drSupplier["SuppCont"].ToString();
                                txtSeSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                                txtSeSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                                txtSeSuppTel.Text = drSupplier["SuppTel"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Supplier"].Rows.Count;

                            if (noRows == 0)
                                lblSuppID.Text = "SU-1000";
                            else
                            {
                                getSuppID(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (suppIDSelected == 0)
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            else
                            {


                                txtEdSuppID.Text = "SU-" + suppIDSelected.ToString();
                                
                                drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtEdSuppID.Text);

                                txtEdCompName.Text = drSupplier["SuppName"].ToString();
                                txtEdContact.Text = drSupplier["SuppCont"].ToString();
                                txtEdSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                                txtEdSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                                txtEDSuppTel.Text = drSupplier["SuppTel"].ToString();

                                disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (suppIDSelected == 0)
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            txtDlSuppID.Text = "SU-" + suppIDSelected.ToString();
                          

                            drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtDlSuppID.Text);


                            txtDlCompName.Text = drSupplier["SuppName"].ToString();
                            txtDlContact.Text = drSupplier["SuppCont"].ToString();
                            txtDlSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                            txtDlSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                            txtDlSuppTel.Text = drSupplier["SuppTel"].ToString();
                            txtDlCompName.Enabled = false;
                            txtDlContact.Enabled = false;
                            txtDlSuppAddress.Enabled = false;
                            txtDlSuppTel.Enabled = false;
                            txtDlSuppEmail.Enabled = false;


                            break;
                        }




                }
            }

        }








        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveSup_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errP.Clear();
            try
            {
                mySupplier.SuppID = lblSuppID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblSuppID, MyEx.toString());
            }

            try
            {
                mySupplier.Address = txtSupAddress.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSupAddress, MyEx.toString());
            }

            try
            {
                mySupplier.CompanyContact = txtContact.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtContact, MyEx.toString());
            }
            

            try
            {
                mySupplier.TelNo = txtSupTel.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSupTel, MyEx.toString());
            }

            try
            {
                mySupplier.Email = txtSupEmail.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSupEmail, MyEx.toString());
            }

            try
            {
                mySupplier.CompanyName = txtCompName.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCompName, MyEx.toString());
            }


            try
            {
                if (ok)
                {
                    drSupplier = dsKaizen.Tables["Supplier"].NewRow();
                    drSupplier["SuppID"] = mySupplier.SuppID;
                    drSupplier["SuppName"] = mySupplier.CompanyName;
                    drSupplier["SuppCont"] = mySupplier.CompanyContact;
                    drSupplier["SuppAddress"] = mySupplier.Address;
                    drSupplier["SuppTel"] = mySupplier.TelNo;
                    drSupplier["SuppEmail"] = mySupplier.Email;

                    dsKaizen.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsKaizen, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you wish to add another Supplier?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getSuppID(dsKaizen.Tables["Supplier"].Rows.Count);
                    }
                    else
                        tabSupplier.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }
        private void getSuppID(int noRows)
        {

            drSupplier = dsKaizen.Tables["Supplier"].Rows[noRows - 1];
            seperateNumber(drSupplier["SuppID"].ToString());
            lblSuppID.Text = "SU-" + (IDNumber + 1).ToString();

        }
 
        

        private void lblSeSuppContact_Click(object sender, EventArgs e)
        {

        }

        private void txtSeContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSeSuppAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtSeSuppAddress_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void disableEditTxtboxes()
        {
            txtEdSuppID.Enabled = false;
            txtEdCompName.Enabled = false;
            txtEdContact.Enabled = false;
            txtEdSuppAddress.Enabled = false;
            txtEDSuppTel.Enabled = false;
            txtEdSuppEmail.Enabled = false;
            
        }
        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                suppSelected = false;
                suppIDSelected = 0;
            }
            else if (dgvSuppliers.SelectedRows.Count == 1)
            {

                suppSelected = true;
                seperateNumber(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                suppIDSelected = IDNumber;
            }
        }

        void DispTabValidate(object sender, EventArgs e)
        {
            if (suppSelected == false && suppIDSelected == 0)
            {
                suppSelected = false;
                suppIDSelected = 0;
            }
            else if (dgvSuppliers.SelectedRows.Count == 1)
            {
                suppSelected = true;
                seperateNumber(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                suppIDSelected = IDNumber;
             
            }
        }
        void EditTabValidate(object sender, EventArgs e)
        {
            if (suppSelected == false && suppIDSelected == 0)
            {
                suppSelected = false;
                suppIDSelected = 0;
            }
            else if (dgvSuppliers.SelectedRows.Count == 1)
            {
                suppSelected = true;
                seperateNumber(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                suppIDSelected = IDNumber;
                

            }
        }

        private void frmSuppliers_Shown(object sender, EventArgs e)
        {
            tabSupplier.TabPages[0].CausesValidation = true;
            tabSupplier.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabSupplier.TabPages[2].CausesValidation = true;
            tabSupplier.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

       

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            if (btnEditSupp.Text == "EDIT SUPPLIER")
            {
                enableEditTxtboxes();

                btnEditSupp.Text = "Save";
            }
            else
            {
                MySupplier mySupplier = new MySupplier();
                bool ok = true;
                errP.Clear();
               

                try
                {
                    mySupplier.Address = txtEdSuppAddress.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdSuppAddress, MyEx.toString());
                }

                try
                {
                    mySupplier.CompanyContact = txtEdContact.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdContact, MyEx.toString());
                }


                try
                {
                    mySupplier.TelNo = txtEDSuppTel.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEDSuppTel, MyEx.toString());
                }

                try
                {
                    mySupplier.Email = txtEdSuppEmail.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdSuppEmail, MyEx.toString());
                }

                try
                {
                    mySupplier.CompanyName = txtEdCompName.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdCompName, MyEx.toString());
                }


                try
                {
                    if (ok)
                    {
                        drSupplier.BeginEdit();
                        //drSupplier = dsKaizen.Tables["Supplier"].NewRow();
                        drSupplier["SuppName"] = mySupplier.CompanyName;
                        drSupplier["SuppCont"] = mySupplier.CompanyContact;
                        drSupplier["SuppAddress"] = mySupplier.Address;
                        drSupplier["SuppTel"] = mySupplier.TelNo;
                        drSupplier["SuppEmail"] = mySupplier.Email;

                        drSupplier.EndEdit();
                        daSupplier.Update(dsKaizen, "Supplier");

                        MessageBox.Show("Supplier Details Updated", "Supplier");

                        

                        btnEditSupp.Text = "EDIT CUSTOMER";
                        tabSupplier.SelectedIndex = 0;



                    }
                    //disableEditTxtboxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            

        }   
        }

        private void txtCompName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompName.Text.Length >= 2 && txtCompName.Text.Length <= 50)
                txtCompName.BackColor = Color.White;
            else
                txtCompName.BackColor = Color.LightCoral;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text.Length >= 2 && txtCompName.Text.Length <= 50)
                txtContact.BackColor = Color.White;
            else
                txtContact.BackColor = Color.LightCoral;
        }

        private void txtSupAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtSupAddress.Text.Length >= 2 && txtSupAddress.Text.Length <= 50)
                txtSupAddress.BackColor = Color.White;
            else
                txtSupAddress.BackColor = Color.LightCoral;
        }

        private void txtSupTel_TextChanged(object sender, EventArgs e)
        {
            if (txtSeSuppTel.Text.Length >= 2 && txtSeSuppTel.Text.Length <= 50)
                txtSeSuppTel.BackColor = Color.White;
            else
                txtSeSuppTel.BackColor = Color.LightCoral;
        }

        private void txtSupEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtSupEmail.Text.Length >= 2 && txtSupEmail.Text.Length <= 50)
                txtSupEmail.BackColor = Color.White;
            else
                txtSupEmail.BackColor = Color.LightCoral;
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supplier_load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\ADAM-PC; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";
            

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);

            daSupplier.FillSchema(dsKaizen, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsKaizen, "Supplier");
            dgvSuppliers.DataSource = dsKaizen.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabSupplier.SelectedIndex = 1;
            tabSupplier.SelectedIndex = 0;
        }

        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }

        private void both(object sender, ScrollEventArgs e)
        {

        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Supplier from the list.", "Select Supplier");

            }
            else
            {
                drSupplier = dsKaizen.Tables["Supplier"].Rows.
                    Find(dgvSuppliers.SelectedRows[0].Cells[0].Value);

                string tempName = drSupplier["SuppName"].ToString() + "\'s";
                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?",
                    "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsKaizen, "Supplier");
                    MessageBox.Show("Details Removed for " + tempName);
                    clearDeleteForm();

                }

            }
        }

        private void enableEditTxtboxes()
        {

            txtEdCompName.Enabled = true;
            txtEdContact.Enabled = true;
            txtEdSuppAddress.Enabled = true;
            txtEdSuppEmail.Enabled = true;
            txtEDSuppTel.Enabled = true;
        }

        private void SearchIconSE_Click(object sender, EventArgs e)
        {
            string searchValue = txtSeSuppID.Text;

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvSuppliers.Rows)
                {
                      if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    {
                        errP.SetError(txtSeSuppID, "ID not found");
                    }
                    else if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtSeSuppID.Text);


                        txtSeCompName.Text = drSupplier["SuppName"].ToString();
                        txtSeContactName.Text = drSupplier["SuppCont"].ToString();
                        txtSeSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                        txtSeSuppTel.Text = drSupplier["SuppTel"].ToString();
                        txtSeSuppEmail.Text = drSupplier["SuppEmail"].ToString();


                        break;
                    }
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Not Found!");
            }
        }

        private void btnEdSearchIcon_Click(object sender, EventArgs e)
        {
            string searchValue = txtEdSuppID.Text;

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvSuppliers.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    {
                        errP.SetError(txtEdSuppID, "ID not found");
                    }
                    else if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtEdSuppID.Text);


                        txtEdCompName.Text = drSupplier["SuppName"].ToString();
                        txtEdContact.Text = drSupplier["SuppCont"].ToString();
                        txtEdSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                        txtEDSuppTel.Text = drSupplier["SuppTel"].ToString();
                        txtEdSuppEmail.Text = drSupplier["SuppEmail"].ToString();


                        break;
                    }
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Not Found!");
            }
        }

        private void btnDeleteSearchIcon_Click(object sender, EventArgs e)
        {
            string searchValue = txtDlSuppID.Text;

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvSuppliers.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    {
                        errP.SetError(txtDlSuppID, "ID not found");
                    }
                    else if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtDlSuppID.Text);


                        txtDlCompName.Text = drSupplier["SuppName"].ToString();
                        txtDlContact.Text = drSupplier["SuppCont"].ToString();
                        txtDlSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                        txtDlSuppTel.Text = drSupplier["SuppTel"].ToString();
                        txtDlSuppEmail.Text = drSupplier["SuppEmail"].ToString();


                        break;
                    }
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Not Found!");
            }
        }

        private void btnDlClearSupp_Click(object sender, EventArgs e)
        {
            clearDeleteForm();
        }

        private void btnEdSuppClear_Click(object sender, EventArgs e)
        {
            clearEditForm();
        }

        void clearDeleteForm()
        {
            txtDlCompName.Clear();
            txtDlContact.Clear();
            txtDlSuppAddress.Clear();
            txtDlSuppEmail.Clear();
            txtDlSuppTel.Clear();
            txtDlSuppID.Clear();
           
       
        }
        void clearEditForm()
        {
            txtEdCompName.Clear();
            txtEdContact.Clear();
            txtEdSuppAddress.Clear();
            txtEdSuppEmail.Clear();
            txtEDSuppTel.Clear();
            txtDlSuppID.Clear();


        }

        void clearSearchForm()
        {
            txtSeCompName.Clear();
            txtSeContactName.Clear();
            txtSeSuppAddress.Clear();
            txtSeSuppEmail.Clear();
            txtSeSuppTel.Clear();
            txtSeSuppID.Clear();


        }

        private void btnClearSup_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        private void btnSeSuppClear_Click(object sender, EventArgs e)
        {
            clearSearchForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 4;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 3;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 1;
        }

        void clearAddForm()
        {
            txtCompName.Clear();
            txtContact.Clear();
            txtSupAddress.Clear();
            txtSupTel.Clear();
            txtSupEmail.Clear();
            txtCompName.Clear();

        }
    }
   



}
