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
        bool custSelected = false;
        int custIDSelected = 0;
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
                        //clearAddForm();

                        getNumber(dsKaizen.Tables["Supplier"].Rows.Count);
                    }
                    else
                        tabSuppliers.SelectedIndex = 0;

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


    }

}
