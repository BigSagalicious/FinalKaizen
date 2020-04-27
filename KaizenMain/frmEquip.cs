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
    public partial class frmEquip : Form
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

        public frmEquip()
        {
            InitializeComponent();
        }


        private void tabEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabEquip.SelectedIndex;
            tabEquip.TabPages[tabEquip.SelectedIndex].Focus();
            tabEquip.TabPages[tabEquip.SelectedIndex].CausesValidation = true;

            if (dgvEquip.SelectedRows.Count == 0 && (tabEquip.SelectedIndex == 1 || tabEquip.SelectedIndex == 3 || tabEquip.SelectedIndex == 4))
                tabEquip.TabPages[tabEquip.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabEquip.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Trans"].Clear();
                            daTrans.Fill(dsKaizen, "Trans");

                            break;
                        }
                    case 1:
                        {
                            if (equipIDSelected == 0)
                            {
                                tabEquip.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtSearchOrderID.Text = "TR-" + equipIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtSearchOrderID.Text);

                                dtpSearchDate.Value = (DateTime)drTrans["TransDate"];
                                txtSearchCustID.Text = drTrans["CustID"].ToString();

                                populateCustName(drTrans["CustID"].ToString(), txtSearchCustName , txtSearchCustTel);

                                populateOrderSum(txtSearchOrderID, dgvSearch);

                                lblSearchTCost.Text = drTrans["TransTotal"].ToString();
                                lblSearchOutstanding.Text = drTrans["BalanceOwed"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            dt.Clear();
                            int noRows = dsKaizen.Tables["Trans"].Rows.Count;

                            if (noRows == 0)
                                lblAddTransID.Text = "TR-9000";
                            else
                            {
                                getTransID(noRows);
                            }

                            errP.Clear();
                            //clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (equipIDSelected == 0)
                            {
                                tabEquip.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEditOrderID.Text = "TR-" + equipIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtEditOrderID.Text);


                                dtpEditDate.Value = (DateTime)drTrans["TransDate"];
                                txtEditCustID.Text = drTrans["CustID"].ToString();
                                populateCustName(drTrans["CustID"].ToString(), txtSearchCustName, txtSearchCustTel);
                                lblEditTCost.Text = drTrans["TransTotal"].ToString();
                                
                                //disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (equipIDSelected == 0)
                            {
                                tabEquip.SelectedIndex = 0;
                                break;
                            }
                            txtDeleteOrderID.Text = "TR-" + equipIDSelected.ToString();

                            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtDeleteOrderID.Text);

                            dtpDeleteDate.Value = (DateTime)drTrans["TransDate"];
                            txtDeleteCustID.Text = drTrans["CustID"].ToString();
                            populateCustName(drTrans["CustID"].ToString(), txtDeleteCustName, txtDeleteCustTel);
                            lblDeleteTCost.Text = drTrans["TransTotal"].ToString();

                            break;
                        }



                }
            }
        }
        private void frmEquip_Shown(object sender, EventArgs e)
        {
            tabEquip.TabPages[0].CausesValidation = true;
            tabEquip.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabEquip.TabPages[2].CausesValidation = true;
            tabEquip.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvEquip.SelectedRows.Count == 0)
            {
                equipSelected = false;
                equipIDSelected = 0;
            }
            else if (dgvEquip.SelectedRows.Count == 1)
            {

                equipSelected = true;
                seperateNumber(dgvEquip.SelectedRows[0].Cells[0].Value.ToString());
                equipIDSelected = IDNumber;
            }
        }

        void EditTabValidate(object sender, EventArgs e)
        {
            if (equipSelected == false && equipIDSelected == 0)
            {
                equipSelected = false;
                equipIDSelected = 0;
            }
            else if (dgvEquip.SelectedRows.Count == 1)
            {
                equipSelected = true;
                seperateNumber(dgvEquip.SelectedRows[0].Cells[0].Value.ToString());
                equipIDSelected = IDNumber;
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("StockID");
            dt.Columns.Add("StockDesc");
            dt.Columns.Add("PPU");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Cost");

            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlEquip = @"select * from Trans";
            daTrans = new SqlDataAdapter(sqlEquip, connStr);
            cmdBEquip = new SqlCommandBuilder(daTrans);

            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");
            dgvEquip.DataSource = dsKaizen.Tables["Trans"];
            dgvEquip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            tabEquip.SelectedIndex = 1;
            tabEquip.SelectedIndex = 0;

            populateEquipNameCmb(cmbAddEquipName);
            populateEquipNameCmb(cmbEditEquipName);

        }

        private void TransDets_Load(TextBox transIDTB, DataGridView dgvDetails)
        {


            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlTransDQuery = @"SELECT * FROM [TransDetails]";

            daTransD = new SqlDataAdapter(sqlTransDQuery, connStr);
            cmbTransD = new SqlCommandBuilder(daTransD);

            daTransD.FillSchema(dsKaizen, SchemaType.Source, "TransDetails");
            daTransD.Fill(dsKaizen, "TransDetails");
            dgvDetails.DataSource = dsKaizen.Tables["TransDetails"];
            dgvDetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvDetails.Columns["StartDate"].Visible = false;
            dgvDetails.Columns["EndDate"].Visible = false;
        }

        private void pbSearchSearh_Click(object sender, EventArgs e)
        {
            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtSearchOrderID.Text);

            dtpSearchDate.Value = (DateTime)drTrans["TransDate"];
            txtSearchCustID.Text = drTrans["CustID"].ToString();

            populateCustName(drTrans["CustID"].ToString(), txtSearchCustName, txtSearchCustTel);

            populateOrderSum(txtSearchOrderID, dgvSearch);

            lblSearchTCost.Text = drTrans["TransTotal"].ToString();
            lblSearchOutstanding.Text = drTrans["BalanceOwed"].ToString();
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
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

        private void iconAddSearchCustomer_Click(object sender, EventArgs e)
        {
            populateCustName(txtAddCustID.Text, txtAddCustName, txtAddCustTel);
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

        private void pbAddSearchEquip_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Stock", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (sqlReader["StockDescription"].ToString().Equals(cmbAddEquipName.Text.Trim()))
                    {
                        txtEquipIDAdd.Text = sqlReader["StockID"].ToString();
                        txtAddPPU.Text = sqlReader["PurPrice"].ToString();
                        txtAddQty.Text = "  -Please Enter-";

                        if (cmbAddEquipName.Text.Trim() == "")
                        {

                            if (sqlReader["StockID"].ToString().Equals(txtEquipIDAdd.Text))
                            {
                                cmbAddEquipName.Text = sqlReader["StockDescription"].ToString();
                                txtAddPPU.Text = sqlReader["PurPrice"].ToString();
                                txtAddQty.Text = "  -Please Enter-";
                            }
                        }
                    }
                }

                sqlReader.Close();
            }
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
                            row["PPU"] = sqlReader2["PurPrice"];
                        }
                    }
                    
                }
                sqlReader2.Close();

                foreach (DataRow row in dt.Rows)
                {
                    row["Cost"] = Convert.ToDouble(row["PPU"]) * Convert.ToDouble(row["Qty"]);
                }


                    dgvDetails.DataSource = dt;
            }
        }

        private void btnAddClearEquip_Click(object sender, EventArgs e)
        {
            AddClearEquip();
        }

        private void getTransID(int noRows)
        {

            drTrans = dsKaizen.Tables["Trans"].Rows[noRows - 1];
            seperateNumber(drTrans["TransID"].ToString());
            lblAddTransID.Text = "TR-" + (IDNumber + 1).ToString();

        }

        private void getTransDetailsID(int noRows)
        {

            drTrans = dsKaizen.Tables["TransDetails"].Rows[noRows - 1];
            seperateNumber(drTrans["TransDetsID"].ToString());
            TansDIDString = "TD-" + (IDNumber + 1).ToString();

        }

        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }

        private void btnAddAddEquip_Click(object sender, EventArgs e)
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

            //    lblAddTCost.Text = Convert.ToDouble(dt.Compute("Sum(Cost)", "")).ToString();
            //object orderTotal;
            //orderTotal = dt.Compute("Sum(Sum)",string.Empty);
            //lblAddTCost.Text = orderTotal.ToString();

            AddClearEquip();
        }

        private void btnAddCompleteOrder_Click(object sender, EventArgs e)
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
                errP.SetError(lblAddTransID, MyEx.toString());
            }

            try
            {
                myTrans.CustID = txtAddCustID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddTransID, MyEx.toString());
            }

            try
            {
                myTrans.TransOn = dtpAddDate.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpAddDate, MyEx.toString());
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

                try
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

                            MessageBox.Show("Purchase Order Added");

                    if (MessageBox.Show("Do you wish to Make another Order?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getTransID(dsKaizen.Tables["Trans"].Rows.Count);
                    }
                    else
                        tabEquip.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }


        private void roundButton15_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        void AddClearEquip()
        {
            txtEquipIDAdd.Text = "EQ-";
            cmbAddEquipName.Text = "";
            txtAddPPU.Text = "";
            txtAddQty.Text = "  -Please Enter-";
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

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

        void addTransDetail()
        {
            bool ok = true;
            using (SqlConnection connection = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                    dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM TransDetails", connection);
                    dataAdapter.InsertCommand = new SqlCommand("insert into TransDetails", connection);

                    getTransDetsnum();

                    foreach (DataRow dr in dt.Rows)
                    {
                        MyTransDetails myTransDetails = new MyTransDetails();

                        TansDIDString = "TD-" + (IDNumber + 1).ToString();

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

                        if (ok)
                        {
                            drTransDets = dsKaizen.Tables["TransDetails"].NewRow();
                            drTransDets["TransDetsID"] = myTransDetails.TransDetsID;
                            drTransDets["TransID"] = myTransDetails.TransID;
                            drTransDets["StockID"] = myTransDetails.StockID;
                            drTransDets["Qty"] = myTransDetails.Qty;
                            drTransDets["StartDate"] = null;
                            drTransDets["EndDate"] = null;

                            dsKaizen.Tables["TransDetails"].Rows.Add(drTransDets);

                            new SqlCommandBuilder(dataAdapter);
                            dataAdapter.Update(dsKaizen);
                            
                        }
                    }
                }

            }
        }

        private void clearAddForm()
        {
            lblAddTransID.Text = "";
            dtpAddDate.Value = DateTime.Today; 
            txtAddCustID.Text = "";
            txtAddCustName.Text = "";
            txtAddCustTel.Text = "";
            AddClearEquip();
            lblAddTCost.Text = "-";
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
    }
}
