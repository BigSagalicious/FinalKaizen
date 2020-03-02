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
        SqlDataAdapter daStock;
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
                                txtSearchStockID.Text = stockIDSelected.ToString();

                                drStock = dsKaizen.Tables["Stock"].Rows.Find(txtSearchStockID.Text);

                                txtSearchProdID.Text = drStock["ProdID"].ToString();
                                cmbSearchProdType.Text = drStock["CustSName"].ToString();
                                txtSearchQTY.Text = drStock["QtyInStock"].ToString();
                                txtSearchProdDesc.Text = drStock["StockDesc"].ToString();
                                txtSearchPrice.Text = drStock["SellingPrice"].ToString();
                                txtSearchProdSupplierID.Text = drStock["SuppID"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Stock"].Rows.Count;

                            if (noRows == 0)
                                lblAddStockID.Text = "ST1000";
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
                                txtEditStockID.Text = stockIDSelected.ToString();

                                drStock = dsKaizen.Tables["Stock"].Rows.Find(txtEditStockID.Text);

                                txtEditStockID.Text = drStock["StockID"].ToString();
                                txtEditProdID.Text = drStock["ProdID"].ToString();
                                cmbEditProdType.Text = drStock["CustSName"].ToString();
                                txtEditQTY.Text = drStock["QtyInStock"].ToString();
                                txtEditProdDesc.Text = drStock["StockDesc"].ToString();
                                txtEditPrice.Text = drStock["SellingPrice"].ToString();
                                txtEditProdSupplierID.Text = drStock["SuppID"].ToString();

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
                            txtEditProdID.Text = drStock["ProdID"].ToString();
                            cmbEditProdType.Text = drStock["CustSName"].ToString();
                            txtEditQTY.Text = drStock["QtyInStock"].ToString();
                            txtEditProdDesc.Text = drStock["StockDesc"].ToString();
                            txtEditPrice.Text = drStock["SellingPrice"].ToString();
                            txtEditProdSupplierID.Text = drStock["SuppID"].ToString();
                            break;
                        }



                }
            }
        }

        private void getStockID(int noRows)
        {

            drStock = dsKaizen.Tables["Stock"].Rows[noRows - 1];
            seperateNumber(drStock["StockID"].ToString());
            lblAddStockID.Text = "ST-" +(IDNumber + 1).ToString();

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        void clearAddForm()
        {

            txtAddProdID.Clear();
            cmbAddProdType.SelectedIndex = 0;
            txtAddQTY.Clear();
            txtAddProdDesc.Clear();
            txtAddPrice.Clear();
            txtAddProdSupplierID.Clear();

        }

        void clearSearchForm()
        {
            txtSearchStockID.Clear();
            txtSearchProdID.Clear();
            cmbSearchProdType.SelectedIndex = 0;
            txtSearchQTY.Clear();
            txtSearchProdDesc.Clear();
            txtSearchPrice.Clear();
            txtSearchProdSupplierID.Clear();

        }

        void clearEditForm()
        {
            txtEditStockID.Clear();
            txtEditProdID.Clear();
            cmbEditProdType.SelectedIndex = 0;
            txtEditQTY.Clear();
            txtEditProdDesc.Clear();
            txtEditPrice.Clear();
            txtEditProdSupplierID.Clear();

        }

        void clearDeleteForm()
        {

            txtDeleteStockID.Clear();
            txtDeleteProdID.Clear();
            cmbDeleteProdType.SelectedIndex = 0;
            txtDeleteQTY.Clear();
            txtDeleteProdDesc.Clear();
            txtDeletePrice.Clear();
            txtDeleteProdSupplierID.Clear();

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = Kaizen;Integrated Security = true ";

            // connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlStock = @"select * from Stock";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdBStock = new SqlCommandBuilder(daStock);

            daStock.FillSchema(dsKaizen, SchemaType.Source, "Stock");
            daStock.Fill(dsKaizen, "Stock");
            dgvStock.DataSource = dsKaizen.Tables["Stock"];
            dgvStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
                stockIDSelected = Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value);
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
                stockIDSelected = Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value);
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
                stockIDSelected = Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value);
            }
        }

        void seperateNumber(string ID)
        {
          
            char[] spearator = {'-'};

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }
    }
}
