﻿using System;
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
        SqlDataAdapter daEquip;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBEquip;
        DataRow drTrans;
        String connStr, sqlEquip;
        int selectedTab = 0;
        bool equipSelected = false;
        int equipIDSelected = 0;
        int IDNumber = 0;
        public frmEquip()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmEquip_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                            daEquip.Fill(dsKaizen, "Trans");

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
                                lblSearchTCost.Text = drTrans["TransTotal"].ToString();
                                lblSearchOutstanding.Text = drTrans["BalanceOwed"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
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
            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlEquip = @"select * from Trans WHERE TransType = 'Purchase'";
            daEquip = new SqlDataAdapter(sqlEquip, connStr);
            cmdBEquip = new SqlCommandBuilder(daEquip);

            daEquip.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daEquip.Fill(dsKaizen, "Trans");
            dgvEquip.DataSource = dsKaizen.Tables["Trans"];
            dgvEquip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvEquip.Columns["StartDate"].Visible = false;
            dgvEquip.Columns["EndDate"].Visible = false;

            tabEquip.SelectedIndex = 1;
            tabEquip.SelectedIndex = 0;



        }

        private void getTransID(int noRows)
        {

            drTrans = dsKaizen.Tables["Trans"].Rows[noRows - 1];
            seperateNumber(drTrans["TransID"].ToString());
            lblAddTransID.Text = "TR-" + (IDNumber + 1).ToString();

        }

        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

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
    }
}
