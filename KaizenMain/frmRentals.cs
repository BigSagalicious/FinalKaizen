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
    public partial class frmRentals : Form
    {
        SqlDataAdapter daTrans, daTransD;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBEquip, cmbTransD;
        DataRow drTrans, drTransDets;
        String connStr, sqlEquip, sqlTransDQuery, TansDIDString, findTransID;
        int selectedTab = 0;
        bool equipSelected = false;
        int equipIDSelected = 0;
        int IDNumber = 0;

        DataTable dt = new DataTable();

        public frmRentals()
        {
            InitializeComponent();
        }


        private void tabEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabRentals.SelectedIndex;
            tabRentals.TabPages[tabRentals.SelectedIndex].Focus();
            tabRentals.TabPages[tabRentals.SelectedIndex].CausesValidation = true;

            if (dgvRentals.SelectedRows.Count == 0 && (tabRentals.SelectedIndex == 1 || tabRentals.SelectedIndex == 3 || tabRentals.SelectedIndex == 4))
                tabRentals.TabPages[tabRentals.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabRentals.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Trans"].Clear();
                            daTrans.Fill(dsKaizen, "Trans");

                            break;
                        }
                    case 1:
                        {
                            dt.Clear();
                            if (equipIDSelected == 0)
                            {
                                tabRentals.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtSearchOrderID.Text = "TR-" + equipIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtSearchOrderID.Text);

                                dtpSearchDate.Value = (DateTime)drTrans["TransDate"];
                                txtSearchCustID.Text = drTrans["CustID"].ToString();

                                populateCustName(drTrans["CustID"].ToString(), txtSearchCustName, txtSearchCustTel);

                                populateOrderSum(txtSearchOrderID, dgvSearch);

                                lblSearchTCost.Text = drTrans["TransTotal"].ToString();
                                lbl4354.Text = drTrans["BalanceOwed"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            dt.Clear();
                            int noRows = dsKaizen.Tables["Trans"].Rows.Count;
                            int noRowsDets = dsKaizen.Tables["TransDetails"].Rows.Count;

                            if (noRows == 0)
                                lblAddTransID.Text = "TR-9000";
                            else
                            {
                                getTransID(noRows);
                            }

                            if (noRowsDets == 0)
                            {
                                getTransDetailsID(noRowsDets);
                            }

                            errP.Clear();
                            //clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            dt.Clear();
                            if (equipIDSelected == 0)
                            {
                                tabRentals.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEditOrderID.Text = "TR-" + equipIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtEditOrderID.Text);


                                dtpSearchDate.Value = (DateTime)drTrans["TransDate"];
                                txtEditCustID.Text = drTrans["CustID"].ToString();

                                populateCustName(drTrans["CustID"].ToString(), txtEditCustName, txtEditCustTel);

                                populateOrderSum(txtEditOrderID, dgvEdit);

                                lblEditTCost.Text = drTrans["TransTotal"].ToString();
                                lblEditOutstanding.Text = drTrans["BalanceOwed"].ToString();

                                //disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            dt.Clear();
                            if (equipIDSelected == 0)
                            {
                                tabRentals.SelectedIndex = 0;
                                break;
                            }
                            txtDeleteOrderID.Text = "TR-" + equipIDSelected.ToString();

                            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtDeleteOrderID.Text);

                            dtpDeleteDate.Value = (DateTime)drTrans["TransDate"];
                            txtDeleteCustID.Text = drTrans["CustID"].ToString();
                            populateCustName(drTrans["CustID"].ToString(), txtDeleteCustName, txtDeleteCustTel);
                            lblDeleteTCost.Text = drTrans["TransTotal"].ToString();
                            lblDeleteOutstanding.Text = drTrans["BalanceOwed"].ToString();

                            break;
                        }



                }
            }
        }
        private void frmRentals_Shown(object sender, EventArgs e)
        {
            tabRentals.TabPages[0].CausesValidation = true;
            tabRentals.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabRentals.TabPages[2].CausesValidation = true;
            tabRentals.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvRentals.SelectedRows.Count == 0)
            {
                equipSelected = false;
                equipIDSelected = 0;
            }
            else if (dgvRentals.SelectedRows.Count == 1)
            {

                equipSelected = true;

                equipIDSelected = seperateNumber(dgvRentals.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        void EditTabValidate(object sender, EventArgs e)
        {
            if (equipSelected == false && equipIDSelected == 0)
            {
                equipSelected = false;
                equipIDSelected = 0;
            }
            else if (dgvRentals.SelectedRows.Count == 1)
            {
                equipSelected = true;

                equipIDSelected = seperateNumber(dgvRentals.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("StockID");
            dt.Columns.Add("StockDesc");
            dt.Columns.Add("RPU");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Months");
            dt.Columns.Add("StartDate");
            dt.Columns.Add("EndDate");
            dt.Columns.Add("Cost");

            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlEquip = @"select * from Trans where TransType = 'Rental'";
            daTrans = new SqlDataAdapter(sqlEquip, connStr);
            cmdBEquip = new SqlCommandBuilder(daTrans);
            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");

            sqlTransDQuery = @"SELECT * FROM [TransDetails]";

            daTransD = new SqlDataAdapter(sqlTransDQuery, connStr);
            cmbTransD = new SqlCommandBuilder(daTransD);

            daTransD.FillSchema(dsKaizen, SchemaType.Source, "TransDetails");
            daTransD.Fill(dsKaizen, "TransDetails");

            dgvRentals.DataSource = dsKaizen.Tables["Trans"];
            dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvRentals.Columns["TransType"].Visible = false;

            tabRentals.SelectedIndex = 1;
            tabRentals.SelectedIndex = 0;

            populateEquipNameCmb(cmbAddEquipName);
            populateEquipNameCmb(cmbEditEquipName);

        }


        void populateEquipNameCmb(ComboBox comboBox)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Stock", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboBox.Items.Add(sqlReader["StockDescription"].ToString());
                }

                sqlReader.Close();
            }
        }

        void populateCustName(String CustID, TextBox textBoxN, TextBox textBoxT)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Customer", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (sqlReader["CustID"].ToString().Equals(CustID))
                    {
                        textBoxN.Text = sqlReader["CustFName"].ToString() + " " + sqlReader["CustSName"].ToString();
                        textBoxT.Text = sqlReader["CustTel"].ToString();

                    }
                }

                sqlReader.Close();
            }
        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        private void btnAddEquipTrans_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow row = dt.NewRow();

                row["StockID"] = txtEquipIDAdd.Text;
                row["StockDesc"] = cmbAddEquipName.Text.Trim();
                row["PPU"] = txtAddPPU.Text;
                row["Qty"] = txtAddQty.Text;
                row["Cost"] = Convert.ToDouble(row["PPU"]) * Convert.ToDouble(row["Qty"]);


                dt.Rows.Add(row);

                dgvAddOrder.DataSource = dt;

                double orderTotal = 0.00;

                foreach (DataRow dr in dt.Rows)
                {
                    orderTotal += System.Convert.ToDouble(dr["Cost"]);
                }

                lblAddTCost.Text = orderTotal.ToString();

                AddClearEquip();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input correct Equipment details?", "Input", MessageBoxButtons.OK);
            }
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            AddClearEquip();
        }

        private void btnCompleteAdd_Click(object sender, EventArgs e)
        {
            MyTrans myTrans = new MyTrans();
            bool ok = true;
            errP.Clear();

            try
            {
                myTrans.TransID = lblAddTransID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddTransID, MyEx.toString());
            }

            try
            {
                myTrans.CustID = txtAddCustID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCustID, MyEx.toString());
            }


            try
            {
                myTrans.TransOn = dTPAdd.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dTPAdd, MyEx.toString());
            }

            try
            {
                myTrans.TransTotal = Convert.ToDouble(lblAddTCost.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddTCost, MyEx.toString());
            }
            catch (FormatException frmex)
            {
                ok = false;
                MessageBox.Show("Please Input Order Details Before Adding", "Order");
            }

            //   try
            {
                if (ok)
                {
                    drTrans = dsKaizen.Tables["Trans"].NewRow();
                    drTrans["TransID"] = myTrans.TransID;
                    drTrans["TransType"] = "Purchase";
                    drTrans["CustID"] = myTrans.CustID;
                    drTrans["TransDate"] = myTrans.TransOn;
                    drTrans["TransTotal"] = myTrans.TransTotal;
                    drTrans["BalanceOwed"] = myTrans.TransTotal;
                    drTrans["Paid"] = 'N';

                    dsKaizen.Tables["Trans"].Rows.Add(drTrans);
                    daTrans.Update(dsKaizen, "Trans");

                    //                  getTransDetailsID(dsKaizen.Tables["TransDetails"].Rows.Count);
                    getTransDetsnum();
                    int utdDetsNumber = seperateNumber(findTransID);

                    foreach (DataRow dr in dt.Rows)
                    {
                        MyTransDetails myTransDetails = new MyTransDetails();

                        utdDetsNumber += 1;

                        TansDIDString = "TD-" + utdDetsNumber;

                        try
                        {
                            myTransDetails.TransDetsID = TansDIDString;

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            myTransDetails.TransID = lblAddTransID.Text.Trim();

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            myTransDetails.StockID = dr["StockID"].ToString();

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            myTransDetails.Qty = Convert.ToInt32(dr["Qty"]);

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            myTransDetails.EndDate = dtpAddEnd.Value;
                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(dtpAddEnd, MyEx.toString());
                        }

                        try
                        {
                            myTransDetails.StartDate = dtpAddStart.Value;
                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                            errP.SetError(dtpAddStart, MyEx.toString());
                        }

                        if (ok)
                        {
                            drTransDets = dsKaizen.Tables["TransDetails"].NewRow();

                            drTransDets["TransDetsID"] = myTransDetails.TransDetsID;
                            drTransDets["TransID"] = myTransDetails.TransID;
                            drTransDets["StockID"] = myTransDetails.StockID;
                            drTransDets["Qty"] = myTransDetails.Qty;
                            drTransDets["StartDate"] = myTransDetails.StartDate;
                            drTransDets["EndDate"] = myTransDetails.EndDate;

                            dsKaizen.Tables["TransDetails"].Rows.Add(drTransDets);

                            new SqlCommandBuilder(daTransD);
                            daTransD.Update(dsKaizen, "TransDetails");

                        }
                    }


                    MessageBox.Show("Purchase Order Added");

                    if (MessageBox.Show("Do you wish to Make another Order?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getTransID(dsKaizen.Tables["Trans"].Rows.Count);
                    }
                    else
                        tabRentals.SelectedIndex = 0;
                

                }

            }
            // catch (Exception ex)
            {
                // MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                //   MessageBoxIcon.Error);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchOrderID.Text = "TR-";
            dtpSearchDate.Value = DateTime.Today;
            txtSearchCustID.Clear();
            txtSearchCustName.Clear();
            txtSearchCustTel.Clear();
            dt.Clear();
            dgvSearch.DataSource = dt;
            lblSearchTCost.Text = "£";
            lblSearchTCost.Text = "£";
        }

        void populateOrderSum(TextBox transIDTB, DataGridView dgvDetails)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlDetailsCmd = new SqlCommand("select * from TransDetails", sqlConnectionEqT);
                SqlCommand sqlStockCmd = new SqlCommand("select * from Stock", sqlConnectionEqT);

                sqlConnectionEqT.Open();
                SqlDataReader sqlReader1 = sqlDetailsCmd.ExecuteReader();

                while (sqlReader1.Read())
                {
                    if (sqlReader1["TransID"].ToString().Equals(transIDTB.Text))
                    {
                        DataRow row = dt.NewRow();
                        row["StockID"] = sqlReader1["StockID"];
                        row["Qty"] = sqlReader1["Qty"];
                        row["StartDate"] = sqlReader1["StartDate"];
                        row["EndDate"] = sqlReader1["EndDate"];
                        dt.Rows.Add(row);
                    }
                }

                sqlReader1.Close();

                SqlDataReader sqlReader2 = sqlStockCmd.ExecuteReader();

                while (sqlReader2.Read())
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["StockID"].Equals(sqlReader2["StockID"].ToString()))
                        {
                            row["StockDesc"] = sqlReader2["StockDescription"];
                            row["RPU"] = sqlReader2["RentPrice"];
                        }
                    }

                }
                sqlReader2.Close();

                foreach (DataRow row in dt.Rows)
                {

                    row["Months"] = ((DateTime.Parse(row["EndDate"].ToString()).Year - DateTime.Parse(row["StartDate"].ToString()).Year) * 12) + DateTime.Parse(row["EndDate"].ToString()).Month - DateTime.Parse(row["StartDate"].ToString()).Month;
                    row["Cost"] = Convert.ToDouble(row["RPU"]) * Convert.ToDouble(row["Qty"]) * Convert.ToDouble(row["Months"]);
                }


                dgvDetails.DataSource = dt;
            }
        }

        private void getTransID(int noRows)
        {

            drTrans = dsKaizen.Tables["Trans"].Rows[noRows - 1];

            lblAddTransID.Text = "TR-" + (seperateNumber(drTrans["TransID"].ToString()) + 1).ToString();

        }

        private void getTransDetailsID(int noRows)
        {

            drTrans = dsKaizen.Tables["TransDetails"].Rows[noRows - 1];

            TansDIDString = "TD-" + (seperateNumber(drTrans["TransDetsID"].ToString()) + 1).ToString();

        }

        public static int seperateNumber(string ID)
        {
            int IDNumber = 0;
            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

            return IDNumber;

        }

        private void clearAddForm()
        {
            lblAddTransID.Text = "";
            dTPAdd.Value = DateTime.Today;
            txtAddCustID.Text = "";
            txtAddCustName.Text = "";
            txtAddCustTel.Text = "";
            AddClearEquip();
            lblAddTCost.Text = "-";
            dtpAddEnd.Value = DateTime.Today;
            dtpAddStart.Value = DateTime.Today;
            dt.Clear();
            int noRows = dsKaizen.Tables["Trans"].Rows.Count;

            if (noRows == 0)
                lblAddTransID.Text = "TR-9000";
            else
            {
                getTransID(noRows);
            }

            errP.Clear();
        }

        void AddClearEquip()
        {
            txtEquipIDAdd.Text = "EQ-";
            cmbAddEquipName.Text = "";
            txtAddPPU.Text = "";
            txtAddQty.Text = "  -Enter-";
        }

        void getTransDetsnum()
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM TransDetails", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();


                while (sqlReader.Read())
                {
                    findTransID = sqlReader["TransDetsID"].ToString();
                    //seperateNumber(sqlReader["TransDetsID"].ToString());
                }

                seperateNumber(findTransID);
            }
        }

    }
}
