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
        int custNoSelected = 0;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            //lblAddCustNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {

                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();
            try
            {
                myCustomer.CustomerNo = Convert.ToInt32(lblAdCustNo.Text.Trim());

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
                myCustomer.Forename = txtDeleteForename.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtDeleteForename, MyEx.toString());
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
                if (ok)
                {
                    drCustomer = dsKaizen.Tables["Customer"].NewRow();
                    drCustomer["CustomerNo"] = myCustomer.CustomerNo;
                    drCustomer["Forename"] = myCustomer.Forename;
                    drCustomer["Surname"] = myCustomer.Surname;
                    drCustomer["Street"] = myCustomer.Street;
                    drCustomer["Town"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["Postcode"] = myCustomer.Postcode;
                    drCustomer["TelNo"] = myCustomer.TelNo;

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

        void clearAddForm()
        {

            txtDeleteForename.Clear();
            txtAddForename.Clear();
            txtAddAddress.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTel.Clear();
            txtAddEmail.Clear();

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = Kaizen;Integrated Security = true ";

            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            //connStr = "Server=[.];Database=[Kaizen];Trusted_Connection=true";

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
    }
}


