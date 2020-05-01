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
            dt.Columns.Add("PPU");
            dt.Columns.Add("Qty");
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabDelete_Click(object sender, EventArgs e)
        {

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

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
