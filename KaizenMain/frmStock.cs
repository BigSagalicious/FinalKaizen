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
    public partial class frmStock : Form
    {

        SqlDataAdapter daStock, daSupplier;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBStock;
        DataRow drStock;
        String connStr, sqlStock;
        int selectedTab = 0;
        bool stockSelected = false;
        int stockIDSelected = 0;
        int IDNumber = 0;
        public frmStock()
        {
            InitializeComponent();
        }

        //TAB PAGES CHANGING

        private void tabStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabStock.SelectedIndex;
            tabStock.TabPages[tabStock.SelectedIndex].Focus();
            tabStock.TabPages[tabStock.SelectedIndex].CausesValidation = true;

            if (dgvStock.SelectedRows.Count == 0 && (tabStock.SelectedIndex == 1 || tabStock.SelectedIndex == 3 || tabStock.SelectedIndex == 4))
                tabStock.TabPages[tabStock.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabStock.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Stock"].Clear();
                            daStock.Fill(dsKaizen, "Stock");

                            break;
                        }
                    case 1:
                        {
                            if (stockIDSelected == 0)
                            {
                                tabStock.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtSearchStockID.Text = "EQ-" + stockIDSelected.ToString();

                                drStock = dsKaizen.Tables["Stock"].Rows.Find(txtSearchStockID.Text);

                                txtSearchDesc.Text = drStock["StockDescription"].ToString();
                                cmbSearchProdType.Text = drStock["EquipType"].ToString();
                                txtSearchQTY.Text = drStock["QtyInStock"].ToString();
                                txtSearchPurchase.Text = drStock["PurPrice"].ToString();
                                txtSearchRental.Text = drStock["RentPrice"].ToString();
                                txtSearchService.Text = drStock["ServPrice"].ToString();
                                txtSearchProdSupplierID.Text = drStock["SuppID"].ToString();

                                populateSuppName(drStock["SuppID"].ToString(), txtSearchProdSupplierName);
                                    
                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Stock"].Rows.Count;

                            if (noRows == 0)
                                lblAddStockID.Text = "EQ-1000";
                            else
                            {
                                getStockID(noRows);
                            }

                            errP.Clear();
                            //clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (stockIDSelected == 0)
                            {
                                tabStock.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                txtEditStockID.Text = "EQ-" + stockIDSelected.ToString();

                                drStock = dsKaizen.Tables["Stock"].Rows.Find(txtEditStockID.Text);

                                
                                txtEditDesc.Text = drStock["StockDescription"].ToString();
                                cmbEditProdType.Text = drStock["EquipType"].ToString();
                                txtEditQTY.Text = drStock["QtyInStock"].ToString();
                                txtEditPurchase.Text = drStock["PurPrice"].ToString();
                                txtEditRental.Text = drStock["RentPrice"].ToString();
                                txtEditService.Text = drStock["ServPrice"].ToString();
                                txtEditProdSupplierID.Text = drStock["SuppID"].ToString();

                                populateSuppName(drStock["SuppID"].ToString(), txtEditProdSupplierName);

                                //disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (stockIDSelected == 0)
                            {
                                tabStock.SelectedIndex = 0;
                                break;
                            }
                            txtDeleteStockID.Text = stockIDSelected.ToString();

                            drStock = dsKaizen.Tables["Stock"].Rows.Find(txtDeleteStockID.Text);

                            txtDeleteStockID.Text = drStock["StockID"].ToString();
                            txtDeleteDesc.Text = drStock["StockDescription"].ToString();
                            cmbDeleteProdType.Text = drStock["EquipType"].ToString();
                            txtDeleteQTY.Text = drStock["QtyInStock"].ToString();
                            txtDeletePurchase.Text = drStock["PurPrice"].ToString();
                            txtDeleteRental.Text = drStock["RentPrice"].ToString();
                            txtDeleteService.Text = drStock["ServPrice"].ToString();
                            txtDeleteProdSupplierID.Text = drStock["SuppID"].ToString();

                            populateSuppName(drStock["SuppID"].ToString(), txtDeleteProdSupplierName);

                            break;
                        }



                }
            }
        }

        private void getStockID(int noRows)
        {

            drStock = dsKaizen.Tables["Stock"].Rows[noRows - 1];
            seperateNumber(drStock["StockID"].ToString());
            lblAddStockID.Text = "EQ-" +(IDNumber + 1).ToString();

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyStock myStock = new MyStock();
            bool ok = true;
            errP.Clear();
            try
            {
                myStock.StockID = lblAddStockID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddStockID, MyEx.toString());
            }          

            try
            {
                myStock.StockDesc = txtAddDesc.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddDesc, MyEx.toString());
            }

            try
            {
                myStock.QtyInStock = Convert.ToInt32(txtAddQTY.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddQTY, MyEx.toString());
            }

            try
            {
                myStock.EquipType = cmbAddProdType.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddProdType, MyEx.toString());
            }

            try
            {
                myStock.PurPrice = Convert.ToDouble(txtAddPurchase.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddPurchase, MyEx.toString());
            }

            try
            {
                myStock.RentalPrice = Convert.ToDouble(txtAddRental.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddRental, MyEx.toString());
            }

            try
            {
                myStock.ServicePrice = Convert.ToDouble(txtAddService.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddService, MyEx.toString());
            }

            try
            {
                myStock.SuppID = txtAddProdSupplierID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddProdSupplierID, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drStock = dsKaizen.Tables["Stock"].NewRow();
                    drStock["StockID"] = myStock.StockID;
                    drStock["StockDescription"] = myStock.StockDesc;
                    drStock["Equiptype"] = myStock.EquipType;
                    drStock["PurPrice"] = myStock.PurPrice;
                    drStock["RentPrice"] = myStock.RentalPrice;
                    drStock["ServPrice"] = myStock.ServicePrice;
                    drStock["QtyInStock"] = myStock.QtyInStock;
                    drStock["SuppID"] = myStock.SuppID;
    

                    dsKaizen.Tables["Stock"].Rows.Add(drStock);
                    daStock.Update(dsKaizen, "Stock");

                    MessageBox.Show("Stock Item/s Added");

                    if (MessageBox.Show("Do you wish to add more stock items?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getStockID(dsKaizen.Tables["Stock"].Rows.Count);
                    }
                    else
                        tabStock.SelectedIndex = 0;

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
            if (btnEditStock.Text == "EDIT STOCK")
            {
                enableEditTxtboxes();

                btnEditStock.Text = "Save";
            }
            else
            {
                MyStock myStock = new MyStock();
                bool ok = true;
                errP.Clear();


                try
                {
                    myStock.StockDesc = txtEditDesc.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditDesc, MyEx.toString());
                }

                try
                {
                    myStock.QtyInStock = Convert.ToInt32(txtEditQTY.Text.Trim());
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditQTY, MyEx.toString());
                }

                try
                {
                    myStock.EquipType = cmbEditProdType.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditProdType, MyEx.toString());
                }

                try
                {
                    myStock.PurPrice = Convert.ToDouble(txtEditPurchase.Text.Trim());
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditPurchase, MyEx.toString());
                }

                try
                {
                    myStock.RentalPrice = Convert.ToDouble(txtEditRental.Text.Trim());
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditRental, MyEx.toString());
                }

                try
                {
                    myStock.ServicePrice = Convert.ToDouble(txtEditService.Text.Trim());
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditService, MyEx.toString());
                }


                try
                {
                    myStock.SuppID = txtEditProdSupplierID.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditProdSupplierID, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drStock.BeginEdit();
                        drStock["StockDescription"] = myStock.StockDesc;
                        drStock["EquipType"] = myStock.EquipType;
                        drStock["PurPrice"] = myStock.PurPrice;
                        drStock["RentPrice"] = myStock.RentalPrice;
                        drStock["ServPrice"] = myStock.ServicePrice;
                        drStock["QtyInStock"] = myStock.QtyInStock;
                        drStock["SuppID"] = myStock.SuppID;

                        drStock.EndEdit();
                        daStock.Update(dsKaizen, "Stock");

                        MessageBox.Show("Stock Details Updated", "Stock");

                        disableEditTxtboxes();

                        btnEditStock.Text = "EDIT STOCK";
                        tabStock.SelectedIndex = 0;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }


            }


        }


        void clearAddForm()
        {
            txtAddDesc.Clear();
            cmbAddProdType.SelectedIndex = 0;
            txtAddQTY.Clear();
            txtAddPurchase.Clear();
            txtAddRental.Clear();
            txtAddService.Clear();
            txtAddProdSupplierID.Clear();
            txtAddProdSupplierName.Clear();
        }

        void clearSearchForm()
        {
            txtSearchStockID.Clear();
            txtSearchDesc.Clear();
            cmbSearchProdType.SelectedIndex = 0;
            txtSearchQTY.Clear();
            txtSearchPurchase.Clear();
            txtSearchRental.Clear();
            txtSearchService.Clear();
            txtSearchProdSupplierID.Clear();
            txtSearchProdSupplierName.Clear();
        }

        void clearEditForm()
        {
            txtEditStockID.Clear();
            txtEditDesc.Clear();
            cmbEditProdType.SelectedIndex = 0;
            txtEditQTY.Clear();
            txtEditPurchase.Clear();
            txtEditRental.Clear();
            txtEditService.Clear();
            txtEditProdSupplierID.Clear();
            txtEditProdSupplierName.Clear();
        }

        void clearDeleteForm()
        {
            txtDeleteStockID.Clear();
            txtDeleteDesc.Clear();
            cmbDeleteProdType.SelectedIndex = 0;
            txtDeleteQTY.Clear();
            txtDeletePurchase.Clear();
            txtDeleteRental.Clear();
            txtDeleteService.Clear();
            txtDeleteProdSupplierID.Clear();
            txtDeleteProdSupplierName.Clear();
        }

        private void enableEditTxtboxes()
        {
            txtEditDesc.Enabled = true;
            cmbEditProdType.Enabled = true;
            txtEditQTY.Enabled = true;
            txtEditPurchase.Enabled = true;
            txtEditRental.Enabled = true;
            txtEditService.Enabled = true;
            txtEditProdSupplierID.Enabled = true;            
        }

        private void disableEditTxtboxes()
        {
            txtEditDesc.Enabled = false;
            cmbEditProdType.Enabled = false;
            txtEditQTY.Enabled = false;
            txtEditPurchase.Enabled = false;
            txtEditRental.Enabled = false;
            txtEditService.Enabled = false;
            txtEditProdSupplierID.Enabled = false;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
             connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";


            sqlStock = @"select * from Stock";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);

            daStock.FillSchema(dsKaizen, SchemaType.Source, "Stock");
            daStock.Fill(dsKaizen, "Stock");
            dgvStock.DataSource = dsKaizen.Tables["Stock"];
            dgvStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            populateEquipTypeCmb(cmbSearchProdType);
            populateEquipTypeCmb(cmbAddProdType);
            populateEquipTypeCmb(cmbEditProdType);
            populateEquipTypeCmb(cmbDeleteProdType);

            tabStock.SelectedIndex = 1;
            tabStock.SelectedIndex = 0;

        }

        private void frmStock_Shown(object sender, EventArgs e)
        {
            tabStock.TabPages[0].CausesValidation = true;
            tabStock.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabStock.TabPages[2].CausesValidation = true;
            tabStock.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                stockSelected = false;
                stockIDSelected = 0;
            }
            else if (dgvStock.SelectedRows.Count == 1)
            {

                stockSelected = true;
                seperateNumber(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                stockIDSelected = IDNumber;
            }
        }

        void DispTabValidate(object sender, EventArgs e)
        {
            if (stockSelected == false && stockIDSelected == 0)
            {
                stockSelected = false;
                stockIDSelected = 0;
            }
            else if (dgvStock.SelectedRows.Count == 1)
            {
                stockSelected = true;
                seperateNumber(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                stockIDSelected = IDNumber;
            }
        }
        void EditTabValidate(object sender, EventArgs e)
        {
            if (stockSelected == false && stockIDSelected == 0)
            {
                stockSelected = false;
                stockIDSelected = 0;
            }
            else if (dgvStock.SelectedRows.Count == 1)
            {
                stockSelected = true;
                seperateNumber(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                stockIDSelected = IDNumber;
            }
        }

        private void txtSearchProdSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            clearEditForm();
        }

        private void btnDeleteClear_Click(object sender, EventArgs e)
        {
            clearDeleteForm();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            clearSearchForm();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProdSupplierID_TextChanged(object sender, EventArgs e)
        {

        }

        void seperateNumber(string ID)
        {
          
            char[] spearator = {'-'};

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }

        private void addSuppSearchIcon_Click(object sender, EventArgs e)
        {
            populateSuppName(txtAddProdSupplierID.Text, txtAddProdSupplierName);
        }

        private void editSuppSearchIcon_Click(object sender, EventArgs e)
        {
            populateSuppName(txtEditProdSupplierID.Text, txtEditProdSupplierName);
        }

        private void btnSearchIconSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchStockID.Text;

            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        drStock = dsKaizen.Tables["Stock"].Rows.Find(txtSearchStockID.Text);

                        txtSearchDesc.Text = drStock["StockDescription"].ToString();
                        cmbSearchProdType.Text = drStock["EquipType"].ToString();
                        txtSearchQTY.Text = drStock["QtyInStock"].ToString();
                        txtSearchPurchase.Text = drStock["PurPrice"].ToString();
                        txtSearchRental.Text = drStock["RentPrice"].ToString();
                        txtSearchService.Text = drStock["ServPrice"].ToString();
                        txtSearchProdSupplierID.Text = drStock["SuppID"].ToString();

                        populateSuppName(drStock["SuppID"].ToString(), txtSearchProdSupplierName);
                        break;
                    }
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Not Found!");
            }
        }

        void populateEquipTypeCmb (ComboBox comboBox)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM EquipmentType", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboBox.Items.Add(sqlReader["EquipType"].ToString());
                }

                sqlReader.Close();
            }
        }

        void populateSuppName(String SuppID, TextBox textBox)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Supplier", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (sqlReader["SuppID"].ToString().Equals(SuppID))
                    {
                        textBox.Text = sqlReader["SuppName"].ToString();
                    }
                }

                sqlReader.Close();
            }
        }
    }
}
