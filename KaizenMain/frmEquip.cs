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
        String connStr, sqlEquip, sqlTransDQuery, TansDIDString, findTransID, findTrans;
        int selectedTab = 0;
        bool equipSelected = false;
        int equipIDSelected = 0, ogTransDrows = 0;
        int IDNumber = 0;

        DataTable dt = new DataTable(), EditTransDTable = new DataTable();

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
                            dt.Clear();
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
                            getTransnum();
                            

                            int noRowsDets = dsKaizen.Tables["TransDetails"].Rows.Count;

                            if (findTrans == "")
                                lblAddTransID.Text = "TR-9000";
                            else
                            {
                                lblAddTransID.Text = "TR-" + (seperateNumber(findTrans) +1).ToString();

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
                                tabEquip.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEditOrderID.Text = "TR-" + equipIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtEditOrderID.Text);

                                gatherTransDForEdit(txtEditOrderID.Text);

                                dtpEditDate.Value = (DateTime)drTrans["TransDate"];
                                txtEditCustID.Text = drTrans["CustID"].ToString();

                                populateCustName(drTrans["CustID"].ToString(), txtEditCustName, txtEditCustTel);

                                populateOrderSum(txtEditOrderID, dgvEdit);

                                lblEditTCost.Text = drTrans["TransTotal"].ToString();
                                lblEditOutstanding.Text = drTrans["BalanceOwed"].ToString();

                                dgvEdit.ClearSelection();
                                //disableEditTxtboxes();
                                

                                break;

                            }
                        }
                    case 4:
                        {
                           
                            dt.Clear();
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

                            populateOrderSum(txtDeleteOrderID, dgvDelete);

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
                
                equipIDSelected = seperateNumber(dgvEquip.SelectedRows[0].Cells[0].Value.ToString());
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
                
                equipIDSelected = seperateNumber(dgvEquip.SelectedRows[0].Cells[0].Value.ToString());
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

            sqlEquip = @"select * from Trans where TransType = 'Purchase'";
            daTrans = new SqlDataAdapter(sqlEquip, connStr);
            cmdBEquip = new SqlCommandBuilder(daTrans);
            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");

            sqlTransDQuery = @"SELECT * FROM [TransDetails]";

            daTransD = new SqlDataAdapter(sqlTransDQuery, connStr);
            cmbTransD = new SqlCommandBuilder(daTransD);

            daTransD.FillSchema(dsKaizen, SchemaType.Source, "TransDetails");
            daTransD.Fill(dsKaizen, "TransDetails");

            dgvEquip.DataSource = dsKaizen.Tables["Trans"];
            dgvEquip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvEquip.Columns["TransType"].Visible = false;

            tabEquip.SelectedIndex = 1;
            tabEquip.SelectedIndex = 0;

            populateEquipNameCmb(cmbAddEquipName);
            populateEquipNameCmb(cmbEditEquipName);

        }

        private void pbSearchSearh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtSearchOrderID.Text);

            if (drTrans == null)
            {

                errP.SetError(txtSearchOrderID, "ID not found");
            }
            else
            {
                dtpSearchDate.Value = (DateTime)drTrans["TransDate"];
                txtSearchCustID.Text = drTrans["CustID"].ToString();

                populateCustName(drTrans["CustID"].ToString(), txtSearchCustName, txtSearchCustTel);

                populateOrderSum(txtSearchOrderID, dgvSearch);

                lblSearchTCost.Text = drTrans["TransTotal"].ToString();
                lblSearchOutstanding.Text = drTrans["BalanceOwed"].ToString();
            }
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
        private void editgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dgvEdit.Rows[ind];
            txtEditEquipID.Text = selectedRows.Cells[0].Value.ToString();
            cmbEditEquipName.Text = selectedRows.Cells[1].Value.ToString();
            txtEditPPItem.Text = selectedRows.Cells[2].Value.ToString();
            txtEditQty.Text = selectedRows.Cells[3].Value.ToString();
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
                    if (sqlReader["StockID"].ToString().Equals(txtEquipIDAdd.Text))
                    {
                        cmbAddEquipName.Text = sqlReader["StockDescription"].ToString();
                        txtAddPPU.Text = sqlReader["PurPrice"].ToString();
                        txtAddQty.Text = "  -Please Enter-";
                    }
                    else if (sqlReader["StockDescription"].ToString().Equals(cmbAddEquipName.Text.Trim()))
                    {
                        txtEquipIDAdd.Text = sqlReader["StockID"].ToString();
                        txtAddPPU.Text = sqlReader["PurPrice"].ToString();
                        txtAddQty.Text = "  -Please Enter-";
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
                    ogTransDrows += 1;

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

        private void btnAddAddEquip_Click(object sender, EventArgs e)
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
            catch (FormatException frmex)
            {
                ok = false;
                MessageBox.Show("Please Input Order Details Before Adding", "Order");
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

                        if (ok)
                        {
                            drTransDets = dsKaizen.Tables["TransDetails"].NewRow();

                            drTransDets["TransDetsID"] = myTransDetails.TransDetsID;
                            drTransDets["TransID"] = myTransDetails.TransID;
                            drTransDets["StockID"] = myTransDetails.StockID;
                            drTransDets["Qty"] = myTransDetails.Qty;
                            drTransDets["StartDate"] = DBNull.Value;
                            drTransDets["EndDate"] = DBNull.Value;

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
                        tabEquip.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEquip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Transaction from the list.", "Select Trans");
            }
            else
            {
                drTrans = dsKaizen.Tables["Trans"].Rows.
                    Find(dgvEquip.SelectedRows[0].Cells[0].Value);

                string tempName = drTrans["TransID"].ToString();
                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?",
                    "Delete Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drTrans.Delete();
                    deleteTranDRow(tempName);
                    daTrans.Update(dsKaizen, "Trans");
                    daTransD.Update(dsKaizen, "TransDetails");
                    MessageBox.Show("Details Removed for " + tempName);
                    clearDeleteForm();

                }

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

        private void btnEditTransD_Click(object sender, EventArgs e)
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
                        row["PPU"] = txtEditPPItem.Text;
                        row["Qty"] = txtEditQty.Text;
                        row["Cost"] = Convert.ToDouble(row["PPU"]) * Convert.ToDouble(row["Qty"]);
                    }
                }
                dgvEdit.DataSource = dt;


                double orderTotal = 0.00;

                foreach (DataRow dr in dt.Rows)
                {
                    orderTotal += System.Convert.ToDouble(dr["Cost"]);
                }

                lblEditTCost.Text = orderTotal.ToString();
                lblEditOutstanding.Text = ((orderTotal-tempTcost)+tempBalOwed).ToString();

            }
        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAddTransD_Click(object sender, EventArgs e)
        {
            {
                DataRow row = dt.NewRow();
                try
                {
                    row["StockID"] = txtEditEquipID.Text;
                    row["StockDesc"] = cmbEditEquipName.Text.Trim();
                    row["PPU"] = txtEditPPItem.Text;
                    row["Qty"] = txtEditQty.Text;
                    row["Cost"] = Convert.ToDouble(row["PPU"]) * Convert.ToDouble(row["Qty"]);


                lblEditOutstanding.Text = (System.Convert.ToDouble(lblEditOutstanding.Text) + System.Convert.ToDouble(row["Cost"])).ToString();

                dt.Rows.Add(row);

                dgvEdit.DataSource = dt;

                double orderTotal = 0.00;

                foreach (DataRow dr in dt.Rows)
                {
                    orderTotal += System.Convert.ToDouble(dr["Cost"]);
                }

                lblEditTCost.Text = orderTotal.ToString();

                AddClearEquip();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please input correct Equipment details?", "Input", MessageBoxButtons.OK);
                }
            }
        }

        private void pbEditSearchEquip_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
                {
                    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Stock", sqlConnectionEqT);
                    sqlConnectionEqT.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        if (sqlReader["StockID"].ToString().Equals(txtEditEquipID.Text))
                        {
                            cmbEditEquipName.Text = sqlReader["StockDescription"].ToString();
                            txtEditPPItem.Text = sqlReader["PurPrice"].ToString();
                            txtEditQty.Text = "  -Please Enter-";
                        }
                        else if (sqlReader["StockDescription"].ToString().Equals(cmbEditEquipName.Text.Trim()))
                        {
                            txtEditEquipID.Text = sqlReader["StockID"].ToString();
                            txtEditPPItem.Text = sqlReader["PurPrice"].ToString();
                            txtEditQty.Text = "  -Please Enter-";
                        }
                    }

                    sqlReader.Close();
                }
            }
        }

        private void btnEditTransDClear_Click(object sender, EventArgs e)
        {
            {
                txtEditEquipID.Text = "EQ-";
                cmbEditEquipName.Text = "";
                txtEditPPItem.Text = "";
                txtEditQty.Text = "  -Please Enter-";
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditTrans_Click(object sender, EventArgs e)
        {
            daTransD.Update(dsKaizen, "TransDetails");
            if (btnEditTrans.Text == "EDIT ORDER")
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
                    if (ogTransDrows < dt.Rows.Count)
                    {
                        getTransDetsnum();
                        int utdDetsNumber = seperateNumber(findTransID);

                        // for (int i = 0; i < (dt.Rows.Count - ogTransDrows); i++)
                        foreach (DataRow dr in dt.Rows)
                        {
                            if(dt.Rows.IndexOf(dr)< ogTransDrows)
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
                                    drTransDets["StartDate"] = DBNull.Value;
                                    drTransDets["EndDate"] = DBNull.Value;

                                    dsKaizen.Tables["TransDetails"].Rows.Add(drTransDets);

                                    new SqlCommandBuilder(daTransD);
                                    daTransD.Update(dsKaizen, "TransDetails");
                                }
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
                        
                        btnEditTrans.Text = "EDIT ORDER";
                        tabEquip.SelectedIndex = 0;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditDeleteTransD_Click(object sender, EventArgs e)
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
                        row["StockID"] = "Deleted";
                        row["StockDesc"] = "Deleted";
                        row["PPU"] = 0;
                        row["Qty"] = 0;
                        row["Cost"] = Convert.ToDouble(row["PPU"]) * Convert.ToDouble(row["Qty"]);
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

        private void btnEditClear_Click(object sender, EventArgs e)
        {
            clearEditForm();
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

        private void txtAddCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dt.Clear();

            drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtDeleteOrderID.Text);
            if (drTrans == null)
            {

                errP.SetError(txtDeleteOrderID, "ID not found");
            }
            else
            {
                dtpDeleteDate.Value = (DateTime)drTrans["TransDate"];
                txtDeleteCustID.Text = drTrans["CustID"].ToString();

                populateCustName(drTrans["CustID"].ToString(), txtDeleteCustName, txtDeleteCustTel);

                populateOrderSum(txtDeleteOrderID, dgvDelete);

                lblDeleteTCost.Text = drTrans["TransTotal"].ToString();
            }
        }

        private void pbEditSearchTrans_Click(object sender, EventArgs e)
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

        private void roundButton3_Click(object sender, EventArgs e)
        {
            Appointment frm = new Appointment();
        }

        private void btnAddBookDel_Click(object sender, EventArgs e)
        {
            Appointment frm = new Appointment();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Appointment frm = new Appointment();
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
                            drTransDets["StartDate"] = DBNull.Value;
                            drTransDets["EndDate"] = DBNull.Value;

                            dsKaizen.Tables["TransDetails"].Rows.Add(drTransDets);

                            new SqlCommandBuilder(dataAdapter);
                            dataAdapter.Update(dsKaizen, "TransDetails");
                            
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

        private void clearEditForm()
        {
            txtEditOrderID.Text = "";
            dtpEditDate.Value = DateTime.Today;
            txtEditCustID.Text = "";
            txtEditCustName.Text = "";
            txtEditCustTel.Text = "";
            txtEditEquipID.Text = "EQ-";
            cmbEditEquipName.Text = "";
            txtEditPPItem.Text = "";
            txtEditQty.Text = "  -Please Enter-";
            lblEditTCost.Text = "-";
            lblEditOutstanding.Text = "-";
            dt.Clear();
            EditTransDTable.Clear();

            int noRows = dsKaizen.Tables["Trans"].Rows.Count;

            if (noRows == 0)
                lblAddTransID.Text = "TR-9000";
            else
            {
                getTransID(noRows);
            }

            errP.Clear();
        }
        private void clearDeleteForm()
        {
            txtDeleteOrderID.Text = "";
            dtpDeleteDate.Value = DateTime.Today;
            txtDeleteCustID.Text = "";
            txtDeleteCustName.Text = "";
            txtDeleteCustTel.Text = "";
            lblDeleteTCost.Text = "-";
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

        public static void deleteTranDRow(string TransNumber)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM TransDetails WHERE TransID = '" + TransNumber + "'", con))
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
    }
}

