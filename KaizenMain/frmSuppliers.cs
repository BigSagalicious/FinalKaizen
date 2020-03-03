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
        string suppIDSelected = "";
        public frmSuppliers()
        {
            InitializeComponent();
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
                            if (suppIDSelected == "")
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtSeSuppID.Text = suppIDSelected.ToString();

                                drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtSeSuppID.Text);

                                //txtSeFore.Text = drSupplier["CustFName"].ToString();
                               // txtSearchSurname.Text = drCustomer["CustSName"].ToString();
                                txtSeCompName.Text = drSupplier["SuppName"].ToString();
                                txtSeSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                               // txtSearchCounty.Text = drSupplier["County"].ToString();
                                //txtSearchPcode.Text = drSupplier["CustPCode"].ToString();
                                txtSeSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                                txtSeSuppTel.Text = drSupplier["SuppTel"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Supplier"].Rows.Count;

                            if (noRows == 0)
                                lblSuppID.Text = "SU1000";
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
                            if (suppIDSelected == "")
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEdSuppID.Text = suppIDSelected.ToString();

                                drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtEdSuppID.Text);
                                /*  if (drCustomer["Title"].ToString() == "Mr")
                                      cmbEdit.SelectedIndex = 0;
                                  if (drCustomer["Title"].ToString() == "Mrs")
                                      cmbEdit.SelectedIndex = 1;
                                  if (drCustomer["Title"].ToString() == "Miss")
                                      cmbEdit.SelectedIndex = 2;
                                  if (drCustomer["Title"].ToString() == "Ms")
                                     cmbEdit.SelectedIndex = 3;
  */
                                //txtSeFore.Text = drSupplier["CustFName"].ToString();
                                // txtSearchSurname.Text = drCustomer["CustSName"].ToString();
                                txtEdCompName.Text = drSupplier["SuppName"].ToString();
                                txtEdSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                                // txtSearchCounty.Text = drSupplier["County"].ToString();
                                //txtSearchPcode.Text = drSupplier["CustPCode"].ToString();
                                txtEdSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                                txtEDSuppTel.Text = drSupplier["SuppTel"].ToString();

                                //disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (suppIDSelected == "")
                            {
                                tabSupplier.SelectedIndex = 0;
                                break;
                            }
                            txtEdSuppID.Text = suppIDSelected.ToString();

                            drSupplier = dsKaizen.Tables["Supplier"].Rows.Find(txtEdSuppID.Text);

                            //txtSeFore.Text = drSupplier["CustFName"].ToString();
                            // txtSearchSurname.Text = drCustomer["CustSName"].ToString();
                            txtDlCompName.Text = drSupplier["SuppName"].ToString();
                            txtDlSuppAddress.Text = drSupplier["SuppAddress"].ToString();
                            // txtSearchCounty.Text = drSupplier["County"].ToString();
                            //txtSearchPcode.Text = drSupplier["CustPCode"].ToString();
                            txtDlSuppEmail.Text = drSupplier["SuppEmail"].ToString();
                            txtDlSuppTel.Text = drSupplier["SuppTel"].ToString();
                            break;
                        }



                }
            }
        }

        private void txtSuppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveSup_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            // errP.Clear();
            try
            {
                mySupplier.SuppID = txtDlSuppID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                // errP.SetError(lblAdCustNo, MyEx.toString());
            }


            try
            {
                mySupplier.Surname = txtSupSurname.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                // errP.SetError(txtAddForename, MyEx.toString());
            }

            try
            {
                mySupplier.Forename = txtSupForename.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddSurname, MyEx.toString());
            }

            try
            {
                mySupplier.Street = txtSupAddress.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                // errP.SetError(txtAddAddress, MyEx.toString());
            }

            try
            {
                mySupplier.Town = txtSupTown.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddTown, MyEx.toString());
            }

            try
            {
                mySupplier.County = txtCounty.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddCounty, MyEx.toString());
            }

            try
            {
                mySupplier.Postcode = txtSupPost.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddPostcode, MyEx.toString());
            }

            try
            {
                mySupplier.TelNo = txtSupTel.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddTel, MyEx.toString());
            }

            try
            {
                mySupplier.Email = txtSupEmail.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtAddEmail, MyEx.toString());
            }

            try
            {
                mySupplier.CompanyName = txtCompName.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                //errP.SetError(txtCompNameEmail, MyEx.toString());
            }


            try
            {
                if (ok)
                {
                    drSupplier = dsKaizen.Tables["Supplier"].NewRow();
                    drSupplier["SuppID"] = mySupplier.SuppID;
                    drSupplier["SupFname"] = mySupplier.Forename;
                    drSupplier["CustSname"] = mySupplier.Surname;
                    drSupplier["CustAddress"] = mySupplier.Street;
                    drSupplier["CustAddress"] = mySupplier.Street;
                    drSupplier["TownCity"] = mySupplier.Town;
                    drSupplier["County"] = mySupplier.County;
                    drSupplier["CustPCode"] = mySupplier.Postcode;
                    drSupplier["CustTel"] = mySupplier.TelNo;
                    drSupplier["CustEmail"] = mySupplier.Email;

                    dsKaizen.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsKaizen, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you wish to add another Supplier?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getNumber(dsKaizen.Tables["Supplier"].Rows.Count);
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
        private void getNumber(int noRows)
        {
            drSupplier = dsKaizen.Tables["Supplier"].Rows[noRows - 1];
            //lblAdCustNo.Text = (int.Parse(drCustomer["CustID"].ToString()) + 1).ToString();
        }

        void clearAddForm()
        {
            txtSuppID.Clear();
            txtSupForename.Clear();
            txtSupSurname.Clear();
            txtSupAddress.Clear();
            txtSupTown.Clear();
            txtCounty.Clear();
            txtSupPost.Clear();
            txtSupTel.Clear();
            txtSupEmail.Clear();
            txtCompName.Clear();

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";

            // connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);

            daSupplier.FillSchema(dsKaizen, SchemaType.Source, "Customer");
            daSupplier.Fill(dsKaizen, "Customer");
            dgvSuppliers.DataSource = dsKaizen.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabSupplier.SelectedIndex = 1;
            tabSupplier.SelectedIndex = 0;



        }
    }

}
