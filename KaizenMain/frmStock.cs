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
                            int noRows = dsKaizen.Tables["Customer"].Rows.Count;

                            if (noRows == 0)
                                lblAddStockID.Text = "ST1000";
                            else
                            {
                                getStockNumber(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
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
                                txtEditID.Text = stockIDSelected.ToString();

                                drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtEditID.Text);
  
                                txtEditForename.Text = drCustomer["CustFName"].ToString();
                                txtEditSurname.Text = drCustomer["CustSName"].ToString();
                                txtEditAddress.Text = drCustomer["CustAddress"].ToString();
                                txtEditTown.Text = drCustomer["TownCity"].ToString();
                                txtEditCounty.Text = drCustomer["County"].ToString();
                                txtEditPostcode.Text = drCustomer["CustPCode"].ToString();
                                txtEditEmail.Text = drCustomer["CustEmail"].ToString();
                                txtEditTel.Text = drCustomer["CustTel"].ToString();

                                disableEditTxtboxes();

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
                            txtDeleteID.Text = stockIDSelected.ToString();

                            drCustomer = dsKaizen.Tables["Customer"].Rows.Find(txtDeleteID.Text);

                            txtDeleteForename.Text = drCustomer["CustFName"].ToString();
                            txtDeleteSurname.Text = drCustomer["CustSName"].ToString();
                            txtDeleteAddress.Text = drCustomer["CustAddress"].ToString();
                            txtDeleteTown.Text = drCustomer["TownCity"].ToString();
                            txtDeleteCounty.Text = drCustomer["County"].ToString();
                            txtDeletePostcode.Text = drCustomer["CustPCode"].ToString();
                            txtDeleteEmail.Text = drCustomer["CustEmail"].ToString();
                            txtDeleteTel.Text = drCustomer["CustTel"].ToString();
                            break;
                        }



                }
            }
        }

        private void getStockNumber(int noRows)
        {

            drStock = dsKaizen.Tables["Stock"].Rows[noRows - 1];
            lblAddStockID.Text = (int.Parse(drStock["StockID"].ToString()) + 1).ToString();
        }
        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
