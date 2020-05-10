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
        String connStr, sqlEquip, sqlTransDQuery, TansDIDString, findTransID, findTrans;
        int selectedTab = 0, ogTransDrows = 0;
        bool equipSelected = false;
        int equipIDSelected = 0,newTransDeatilsadded = -1, currentQty, newQty;
        int IDNumber = 0;

        DataTable dt = new DataTable(), EditTransDTable = new DataTable();

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
                                lblSearchBalOwed.Text = drTrans["BalanceOwed"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            dt.Clear();
                            getTransnum();

                            int noRows = dsKaizen.Tables["Trans"].Rows.Count;
                            int noRowsDets = dsKaizen.Tables["TransDetails"].Rows.Count;

                            if (findTrans == "")
                                lblAddTransID.Text = "TR-9000";
                            else
                            {
                                lblAddTransID.Text = "TR-" + (seperateNumber(findTrans) + 1).ToString();

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
                            ogTransDrows = 0;
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
            dt.Columns.Add("Cost");
            dt.Columns.Add("Months");
            dt.Columns.Add("StartDate");
            dt.Columns.Add("EndDate");


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
                row["RPU"] = txtAddPPU.Text;
                row["Qty"] = txtAddQty.Text;
                row["StartDate"] = dtpAddStart.Value;
                row["EndDate"] = dtpAddEnd.Value;
                row["Months"] = ((DateTime.Parse(row["EndDate"].ToString()).Year - DateTime.Parse(row["StartDate"].ToString()).Year) * 12) + DateTime.Parse(row["EndDate"].ToString()).Month - DateTime.Parse(row["StartDate"].ToString()).Month;
                row["Cost"] = Convert.ToDouble(row["RPU"]) * Convert.ToDouble(row["Qty"]) * Convert.ToDouble(row["Months"]);

                if (((DateTime.Parse(row["EndDate"].ToString()).Year - DateTime.Parse(row["StartDate"].ToString()).Year) * 12) + DateTime.Parse(row["EndDate"].ToString()).Month - DateTime.Parse(row["StartDate"].ToString()).Month <= 0)
                {
                    MessageBox.Show("End date must be at least a month after the start date?", "Input", MessageBoxButtons.OK);
                }
                else {
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
                    drTrans["TransType"] = "Rental";
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
                            GetCurrentStock(myTransDetails.StockID);
                            drTransDets["StartDate"] = myTransDetails.StartDate;
                            drTransDets["EndDate"] = myTransDetails.EndDate;

                            dsKaizen.Tables["TransDetails"].Rows.Add(drTransDets);

                            newQty = currentQty - myTransDetails.Qty;

                            string constr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";
                            SqlConnection con = new SqlConnection(constr);
                            DataSet ds = new DataSet();
                            con.Open();
                            SqlCommand cmd = new SqlCommand(" UPDATE Stock SET QtyInStock = " + newQty + " WHERE StockID ='" + myTransDetails.StockID + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            new SqlCommandBuilder(daTransD);
                            daTransD.Update(dsKaizen, "TransDetails");

                        }
                    }


                    MessageBox.Show("Purchase Order Added");

                    if (MessageBox.Show("Do you wish to Make another Order?", "Add Rental", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
            lblSearchTCost.Text = "-";
            lblSearchBalOwed.Text = "-";
        }

        private void pbIconSearchEquip_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Stock", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (sqlReader["StockID"].ToString().Equals(txtEquipIDAdd.Text))
                    {
                        cmbAddEquipName.Text = sqlReader["StockDescription"].ToString();
                        txtAddPPU.Text = sqlReader["RentPrice"].ToString();
                        txtAddQty.Text = "  -Please Enter-";
                    }
                    else if (sqlReader["StockDescription"].ToString().Equals(cmbAddEquipName.Text.Trim()))
                    {
                        txtEquipIDAdd.Text = sqlReader["StockID"].ToString();
                        txtAddPPU.Text = sqlReader["RentPrice"].ToString();
                        txtAddQty.Text = "  -Please Enter-";
                    }
                }

                sqlReader.Close();
            }
        }

        private void pbAddSearchCustID_Click(object sender, EventArgs e)
        {
            populateCustName(txtAddCustID.Text, txtAddCustName, txtAddCustTel);
        }

        private void pbEdittransSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();

            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtEditOrderID.Text);
            if (drTrans == null)
            {

                errP.SetError(txtEditOrderID, "ID not found");
            }
            else
            {
                gatherTransDForEdit(txtEditOrderID.Text);

                dtpEditDate.Value = (DateTime)drTrans["TransDate"];
                txtEditCustID.Text = drTrans["CustID"].ToString();

                populateCustName(drTrans["CustID"].ToString(), txtEditCustName, txtEditCustTel);

                populateOrderSum(txtEditOrderID, dgvEdit);

                lblEditTCost.Text = drTrans["TransTotal"].ToString();
                lblEditOutstanding.Text = drTrans["BalanceOwed"].ToString();

                dgvEdit.ClearSelection();
            }
        }

        private void btnAddTransD_Click(object sender, EventArgs e)
        {
            {
                DataRow row = dt.NewRow();
                DataRow rw = EditTransDTable.NewRow();
                try
                {
                    rw["TransDetsID"] = "Temp";
                    rw["TransID"] = "Temp";

                    row["StockID"] = txtEditEquipID.Text;
                    rw["StockID"] = txtEditEquipID.Text;

                    row["StockDesc"] = cmbEditEquipName.Text.Trim();

                    row["StartDate"] = dtpEditStartD.Value;
                    rw["StartDate"] = dtpEditStartD.Value;

                    row["EndDate"] = dtpEditEndD.Value;
                    rw["EndDate"] = dtpEditEndD.Value;

                    row["RPU"] = txtEditRPItem.Text;

                    row["Qty"] = txtEditQty.Text;
                    rw["Qty"] = txtEditQty.Text;

                    row["Months"] = ((DateTime.Parse(row["EndDate"].ToString()).Year - DateTime.Parse(row["StartDate"].ToString()).Year) * 12) + DateTime.Parse(row["EndDate"].ToString()).Month - DateTime.Parse(row["StartDate"].ToString()).Month;
                    row["Cost"] = Convert.ToDouble(row["RPU"]) * Convert.ToDouble(row["Qty"]) * Convert.ToDouble(row["Months"]);


                    lblEditOutstanding.Text = (System.Convert.ToDouble(lblEditOutstanding.Text) + System.Convert.ToDouble(row["Cost"])).ToString();

                    dt.Rows.Add(row);
                    EditTransDTable.Rows.Add(rw);

                    dgvEdit.DataSource = dt;

                    double orderTotal = 0.00;

                    foreach (DataRow dr in dt.Rows)
                    {
                        orderTotal += System.Convert.ToDouble(dr["Cost"]);
                    }

                    lblEditTCost.Text = orderTotal.ToString();

                    AddClearEquip();


                    newTransDeatilsadded += 1;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please input correct Equipment details?", "Input", MessageBoxButtons.OK);
                }
            }
        }

        private void btnEditEditTransD_Click(object sender, EventArgs e)
        {
            double tempBalOwed = Convert.ToDouble(lblEditOutstanding.Text), tempTcost = Convert.ToDouble(lblEditTCost.Text);

            if (dgvEdit.CurrentCell == dgvEdit.Rows[0].Cells[0])
            {
                MessageBox.Show("Please select an item to edit?", "Edit Item", MessageBoxButtons.OK);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (dt.Rows.IndexOf(row) == dgvEdit.CurrentCell.RowIndex)
                    {
                        row["StockID"] = txtEditEquipID.Text;
                        row["StockDesc"] = cmbEditEquipName.Text.Trim();
                        row["RPU"] = txtEditRPItem.Text;
                        row["Qty"] = txtEditQty.Text;
                        row["StartDate"] = dtpEditStartD.Value;
                        row["EndDate"] = dtpEditEndD.Value;
                        row["Months"] = ((DateTime.Parse(row["EndDate"].ToString()).Year - DateTime.Parse(row["StartDate"].ToString()).Year) * 12) + DateTime.Parse(row["EndDate"].ToString()).Month - DateTime.Parse(row["StartDate"].ToString()).Month;
                        row["Cost"] = Convert.ToDouble(row["RPU"]) * Convert.ToDouble(row["Qty"]) * Convert.ToDouble(row["Months"]);
                    }
                }
                dgvEdit.DataSource = dt;


                double orderTotal = 0.00;

                foreach (DataRow dr in dt.Rows)
                {
                    orderTotal += System.Convert.ToDouble(dr["Cost"]);
                }

                lblEditTCost.Text = orderTotal.ToString();
                lblEditOutstanding.Text = ((orderTotal - tempTcost) + tempBalOwed).ToString();

            }
        }

        private void btnEditTrans_Click(object sender, EventArgs e)
        {
            daTransD.Update(dsKaizen, "TransDetails");

            if (btnEditTrans.Text == "EDIT RENTAL")
            {
                enableEdittxtB();

                btnEditTrans.Text = "SAVE";
            }
            else
            {


                gatherTransDForEdit(txtEditOrderID.Text);
                bool ok = true;

                for (int i = 0; i < ogTransDrows; i++)
                {

                    if (string.Equals(dt.Rows[i][1].ToString(), "Deleted"))
                    {
                        string deleteID = EditTransDTable.Rows[i][0].ToString();

                        deleteTranDets(deleteID);

                        daTransD.Update(dsKaizen, "TransDetails");
                    }
                    if (!Equals(dt.Rows[i][3], EditTransDTable.Rows[i][3]) || !Equals(dt.Rows[i][0], EditTransDTable.Rows[i][2]))
                    {
                        drTransDets = dsKaizen.Tables["TransDetails"].Rows.Find(EditTransDTable.Rows[i][0].ToString());

                        MyTransDetails myTransDetails = new MyTransDetails();

                        errP.Clear();

                        try
                        {
                            myTransDetails.StockID = drTransDets["StockID"].ToString();

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            myTransDetails.Qty = Convert.ToInt32(drTransDets["Qty"]);

                        }
                        catch (MyException MyEx)
                        {
                            ok = false;
                        }

                        try
                        {
                            if (ok)
                            {
                                drTransDets.BeginEdit();
                                drTransDets["StockID"] = myTransDetails.StockID;
                                drTransDets["Qty"] = myTransDetails.Qty;


                                drTransDets.EndEdit();
                                daTransD.Update(dsKaizen, "TransDetails");

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                                MessageBoxIcon.Error);
                        }

                    }
                }
                if (ogTransDrows < dt.Rows.Count)
                {
                    getTransDetsnum();
                    int utdDetsNumber = seperateNumber(findTransID);

                    // for (int i = 0; i < (dt.Rows.Count - ogTransDrows); i++)
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dt.Rows.IndexOf(dr) < ogTransDrows)
                        {

                        }
                        else
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
                                myTransDetails.TransID = txtEditOrderID.Text.Trim();

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
                                myTransDetails.StartDate = dtpEditStartD.Value;
                            }
                            catch (MyException MyEx)
                            {
                                ok = false;
                                errP.SetError(dtpEditStartD, MyEx.toString());
                            }

                            try
                            {
                                myTransDetails.EndDate = dtpEditEndD.Value;
                            }
                            catch (MyException MyEx)
                            {
                                ok = false; 
                                errP.SetError(dtpEditEndD, MyEx.toString());
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
                    }
                }
                MyTrans myTrans = new MyTrans();

                errP.Clear();

                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtEditOrderID.Text);

                try
                {
                    myTrans.CustID = txtEditCustID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCustID, MyEx.toString());
                }

                try
                {
                    myTrans.TransOn = dtpEditDate.Value;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dtpEditDate, MyEx.toString());
                }

                try
                {
                    myTrans.TransTotal = Convert.ToDouble(lblEditTCost.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditTCost, MyEx.toString());
                }
                try
                {
                    myTrans.BalOwed = Convert.ToDouble(lblEditOutstanding.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditOutstanding, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drTrans.BeginEdit();
                        drTrans["CustID"] = myTrans.CustID;
                        drTrans["TransDate"] = myTrans.TransOn;
                        drTrans["TransTotal"] = myTrans.TransTotal;
                        drTrans["BalanceOwed"] = myTrans.BalOwed;

                        if (myTrans.BalOwed <= 0)
                            drTrans["Paid"] = 'Y';
                        else
                            drTrans["Paid"] = 'N';

                        drTrans.EndEdit();
                        daTrans.Update(dsKaizen, "Trans");

                        MessageBox.Show("Purchase Details Updated", "Order");

                        disableEdittxtB();

                        btnEditTrans.Text = "EDIT RENTAL";
                        tabRentals.SelectedIndex = 0;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
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
                    ogTransDrows += 1;
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

        void getTransnum()
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Trans", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();


                while (sqlReader.Read())
                {
                    findTrans = sqlReader["TransID"].ToString();
                    //seperateNumber(sqlReader["TransDetsID"].ToString());
                }


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

        private void GetCurrentStock(string stockID)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Stock", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (sqlReader["StockID"].ToString().Equals(stockID))
                    {
                        currentQty = (int)sqlReader["QtyInStock"];
                    }
                }

                sqlReader.Close();
            }
        }

        void gatherTransDForEdit(string TransID)
        {
            EditTransDTable.Clear();
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM TransDetails WHERE TransID = '" + TransID + "'", sqlConnectionEqT);
                sqlConnectionEqT.Open();

                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    EditTransDTable.Load(reader);
                }

                sqlConnectionEqT.Close();
            }
        }

        public static void deleteTranDets(string TransNumber)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM TransDetails WHERE TransDetsID = '" + TransNumber + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void editgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dgvEdit.Rows[ind];
            txtEditEquipID.Text = selectedRows.Cells[0].Value.ToString();
            cmbEditEquipName.Text = selectedRows.Cells[1].Value.ToString();
            txtEditRPItem.Text = selectedRows.Cells[2].Value.ToString();
            txtEditQty.Text = selectedRows.Cells[3].Value.ToString();
            dtpEditEndD.Value = DateTime.Parse(selectedRows.Cells[7].Value.ToString());
            dtpEditStartD.Value = DateTime.Parse(selectedRows.Cells[6].Value.ToString());
        }

        private void enableEdittxtB()
        {
            dtpEditDate.Enabled = true;
            txtEditCustID.Enabled = true;
            txtEditEquipID.Enabled = true;
            cmbEditEquipName.Enabled = true;
            txtEditQty.Enabled = true;
        }

        private void disableEdittxtB()
        {
            dtpEditDate.Enabled = false;
            txtEditCustID.Enabled = false;
            txtEditEquipID.Enabled = false;
            cmbEditEquipName.Enabled = false;
            txtEditQty.Enabled = false;
        }
    }
}

