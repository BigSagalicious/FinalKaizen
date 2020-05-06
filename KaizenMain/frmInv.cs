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
    public partial class frmInv : Form
    {
        SqlDataAdapter daPayments,daTrans;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmbPayment, cmbTrans;
        DataRow drTrans, drPayment;
        String connStr, sqlPayments, sqlTrans, findPayID;
        string datarowToDelete;
        int selectedTab = 0;
        bool InvSelected = false, isNull = false;
        int TransIDSelected = 0;
        Double outstanding, paytoday;

        DataTable dt = new DataTable(), dtOutstanding = new DataTable(), dtPayToday = new DataTable();
        public frmInv()
        {
            InitializeComponent();
        }

        private void pbSearchCustomer_Click(object sender, EventArgs e)
        {
            populateCustName(txtCustID.Text.Trim(), lblSICustName);

            dtOutstanding.Clear();
            dtPayToday.Clear();

            populateCustOutStandingTrans(txtCustID, dgvLoadTrans);


        }

        void MoveTransBetweendgv(DataTable tableSend, DataTable tableRec, DataGridView dgvSend, DataGridView dgvRec)
        {

            outstanding = 0;
            paytoday = 0;
            datarowToDelete = "";

            int rowindex = dgvSend.CurrentCell.RowIndex;

            foreach (DataRow dr in tableSend.Rows.Cast<DataRow>().ToList())
            {
                if (dgvSend.Rows[rowindex].Cells[0].Value.ToString() == dr[0].ToString())
                {
                    tableRec.Rows.Add(dr.ItemArray);
                    datarowToDelete = dr[0].ToString();
                }
            }

            foreach (DataRow dr in tableSend.Rows.Cast<DataRow>().ToList())
            {
                if (dr[0].ToString() == datarowToDelete)
                    dr.Delete();
            }

            dgvLoadTrans.DataSource = dtOutstanding;
            dgvLoadTrans.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMultiPay.DataSource = dtPayToday;
            dgvMultiPay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            foreach (DataRow dr in dtOutstanding.Rows.Cast<DataRow>().ToList())
            {
                outstanding += Convert.ToDouble(dr["Due"]);
            }

            foreach (DataRow row in dtPayToday.Rows.Cast<DataRow>().ToList())
            {
                paytoday += Convert.ToDouble(row["Due"]);
            }

            lblMultiOutstanding.Text = outstanding.ToString();
            lblPayTodayTot.Text = paytoday.ToString();
        }

        private void pbSInvRight_Click(object sender, EventArgs e)
        {

            MoveTransBetweendgv(dtOutstanding, dtPayToday, dgvLoadTrans,  dgvMultiPay);

        }

        private void pbSInvLeft_Click(object sender, EventArgs e)
        {
            MoveTransBetweendgv(dtPayToday, dtOutstanding, dgvMultiPay, dgvLoadTrans);
        }

        private void btnConfirmPay_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errP.Clear();
            foreach (DataRow dr in dtPayToday.Rows)
            {
                MyTrans myTrans = new MyTrans();

                errP.Clear();

                drTrans = dsKaizen.Tables["Trans"].Rows.Find(dr[0].ToString());

                try
                {
                    myTrans.CustID = txtCustID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCustID, MyEx.toString());
                }

                try
                {
                    myTrans.TransOn = DateTime.Parse(dr[2].ToString());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }

                try
                {
                    myTrans.TransTotal = Convert.ToDouble(drTrans["TransTotal"].ToString());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }
                try
                {
                    myTrans.BalOwed = 0.00;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
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

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }

                MyPayment myPayment = new MyPayment();

                getPaysnum();

                try
                {
                    myPayment.PayID = "PY-" + (seperateNumber(findPayID) + 1).ToString();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }

                try
                {
                    myPayment.TransID = dr[0].ToString();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }

                try
                {
                    myPayment.PayAmount = Convert.ToDouble(dr[1].ToString());

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }

                try
                {
                    myPayment.PayDate = DateTime.Today;

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(btnConfirmPay, MyEx.toString());
                }


                if (ok)
                {
                    drPayment = dsKaizen.Tables["Payments"].NewRow();
                    drPayment["PayID"] = myPayment.PayID;
                    drPayment["TransID"] = myPayment.TransID;
                    drPayment["PayAmount"] = myPayment.PayAmount;
                    drPayment["PayDate"] = myPayment.PayDate;



                    dsKaizen.Tables["Payments"].Rows.Add(drPayment);
                    daPayments.Update(dsKaizen, "Payments");

                   
                }
                MessageBox.Show("Payment Taken", "Order");
            }
        }
        private void tabPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabInv.SelectedIndex;
            tabInv.TabPages[tabInv.SelectedIndex].Focus();
            tabInv.TabPages[tabInv.SelectedIndex].CausesValidation = true;

            if (dgvPayTrans.SelectedRows.Count == 0 && (tabInv.SelectedIndex == 1 || tabInv.SelectedIndex == 2))
                tabInv.TabPages[tabInv.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabInv.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Payments"].Clear();
                            daPayments.Fill(dsKaizen, "Payments");
                            break;
                        }
                    case 1:
                        {
                            getPaysnum();
                            dt.Clear();

                            int noRowsDets = dsKaizen.Tables["Payments"].Rows.Count;

                            if (noRowsDets == 0)
                            {
                                lblPPayInvID.Text = "PY-8000";
                            }
                            else
                            {
                                lblPPayInvID.Text = "PY-" + (seperateNumber(findPayID)+1).ToString();

                                txtPPayTransID.Text = "TR-" + TransIDSelected.ToString();

                                drTrans = dsKaizen.Tables["Trans"].Rows.Find("TR-" + TransIDSelected);

                                lblPPayTranType.Text = drTrans["TransType"].ToString();

                                lblPPayCustNo.Text = drTrans["CustID"].ToString();

                                populateCustName(drTrans["CustID"].ToString(), lblPPayCustName);

                                lblPPayTot.Text = drTrans["TransTotal"].ToString();

                                lblPPayOut.Text = drTrans["BalanceOwed"].ToString();

                                populateOrderSum(txtPPayTransID, dgvPPay);
                            }
                            break;
                        }

                    case 2:
                        {
                            break;

                        }
                }
            }
        }

        private void btnPPay_Click(object sender, EventArgs e)
        {
            MyPayment myPayment = new MyPayment();
            bool ok = true;
            errP.Clear();

            try
            {
                myPayment.PayID = lblPPayInvID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblPPayInvID, MyEx.toString());
            }

            try
            {
                myPayment.TransID = txtPPayTransID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPPayTransID, MyEx.toString());
            }

            try
            {
                myPayment.PayAmount = Convert.ToDouble(txtBPayTo.Text.Trim());

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtBPayTo, MyEx.toString());
            }


            if (ok)
            {
                drPayment = dsKaizen.Tables["Payments"].NewRow();
                drPayment["PayID"] = myPayment.PayID;
                drPayment["TransID"] = myPayment.TransID;
                drPayment["PayAmount"] = myPayment.PayAmount;
                drPayment["PayDate"] = myPayment.PayDate;



                dsKaizen.Tables["Payments"].Rows.Add(drPayment);
                daPayments.Update(dsKaizen, "Payments");



                MyTrans myTrans = new MyTrans();

                errP.Clear();

                drTrans = dsKaizen.Tables["Trans"].Rows.Find(txtPPayTransID.Text);

                try
                {
                    myTrans.CustID = lblPPayCustNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCustID, MyEx.toString());
                }

                try
                {
                    myTrans.TransOn = dtpPPay.Value;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dtpPPay, MyEx.toString());
                }

                try
                {
                    myTrans.TransTotal = Convert.ToDouble(lblPPayTot.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblPPayTot, MyEx.toString());
                }
                try
                {
                    myTrans.BalOwed = (Convert.ToDouble(lblPPayOut.Text.Trim())) - (Convert.ToDouble(txtBPayTo.Text.Trim()));
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtBPayTo, MyEx.toString());
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

                        MessageBox.Show("Payment Taken", "Order");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("StockID");
            dt.Columns.Add("StockDesc");
            dt.Columns.Add("Qty");

            dtOutstanding.Columns.Add("TransID");
            dtOutstanding.Columns.Add("Due");
            dtOutstanding.Columns.Add("OrderDate");

            dtPayToday.Columns.Add("TransID");
            dtPayToday.Columns.Add("Due");
            dtPayToday.Columns.Add("OrderDate");

            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlTrans = @"select * from Trans where Paid = 'N'";
            daTrans = new SqlDataAdapter(sqlTrans, connStr);
            cmbTrans = new SqlCommandBuilder(daTrans);
            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");

            sqlPayments = @"SELECT * FROM [Payments]";

            daPayments = new SqlDataAdapter(sqlPayments, connStr);
            cmbPayment = new SqlCommandBuilder(daPayments);

            daPayments.FillSchema(dsKaizen, SchemaType.Source, "Payments");
            daPayments.Fill(dsKaizen, "Payments");

            dgvPayTrans.DataSource = dsKaizen.Tables["Trans"];
            dgvPayTrans.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvPayments.DataSource = dsKaizen.Tables["Payments"];
            dgvPayments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabInv.SelectedIndex = 0;

        }

        private void frmPayments_Shown(object sender, EventArgs e)
        {
            tabInv.TabPages[0].CausesValidation = true;
            tabInv.TabPages[0].Validating += new CancelEventHandler(PayTabValidate);

        }

        void PayTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvPayTrans.SelectedRows.Count == 0)
            {
                TransIDSelected = 0;
            }
            else if (dgvPayTrans.SelectedRows.Count == 1)
            {
                TransIDSelected = seperateNumber(dgvPayTrans.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        public static int seperateNumber(string ID)
        {
            int IDNumber = 0;
            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

            return IDNumber;

        }

        void populateCustName(String CustID, Label lblName)
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
                        lblName.Text = sqlReader["CustFName"].ToString() + " " + sqlReader["CustSName"].ToString();                  

                    }
                }

                sqlReader.Close();
            }
        }

        void getPaysnum()
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Payments", sqlConnectionEqT);
                sqlConnectionEqT.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();


                while (sqlReader.Read())
                {
                    findPayID = sqlReader["PayID"].ToString();
                    //seperateNumber(sqlReader["TransDetsID"].ToString());
                }


            }
        }

        void populateCustOutStandingTrans(TextBox transIDTB, DataGridView dgvDetails)
        {
            using (SqlConnection sqlConnectionEqT = new SqlConnection(@"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true "))
            {
                SqlCommand sqlTransCmd = new SqlCommand("select * from Trans", sqlConnectionEqT);    

                sqlConnectionEqT.Open();

                SqlDataReader sqlReader1 = sqlTransCmd.ExecuteReader();

                while (sqlReader1.Read())
                {
                    if (sqlReader1["CustID"].ToString().Equals(transIDTB.Text) && sqlReader1["Paid"].ToString().Equals("N"))
                    {
                        DataRow row = dtOutstanding.NewRow();
                        row["TransID"] = sqlReader1["TransID"];
                        row["Due"] = sqlReader1["BalanceOwed"];
                        row["OrderDate"] = sqlReader1["TransDate"];
                        dtOutstanding.Rows.Add(row);
                    }
                }

                sqlReader1.Close();

                foreach (DataRow row in dtOutstanding.Rows)
                {
                    outstanding += Convert.ToDouble(row["Due"]);
                }

                lblMultiOutstanding.Text = outstanding.ToString();

                dgvLoadTrans.DataSource = dtOutstanding;
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
                        }
                    }

                }
                sqlReader2.Close();

                dgvPPay.DataSource = dt;
            }
        }

    }
}
