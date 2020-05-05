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
        SqlDataAdapter daPayments;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drPayments;
        String connStr, sqlPayments;
        int selectedTab = 0;
        bool InvSelected = false, isNull = false;
        int custIDSelected = 0;
        public frmInv()
        {
            InitializeComponent();
        }

        private void tabPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabInv.SelectedIndex;
            tabInv.TabPages[tabInv.SelectedIndex].Focus();
            tabInv.TabPages[tabInv.SelectedIndex].CausesValidation = true;

            if (dgvInvoice.SelectedRows.Count == 0 && (tabInv.SelectedIndex == 1 || tabInv.SelectedIndex == 2))
                tabInv.TabPages[tabInv.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabInv.SelectedIndex)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            break;
                        }

                    case 2:
                        {
                            break;

                        }
                }
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlPayments = @"select * from Payments";
            daPayments = new SqlDataAdapter(sqlPayments, connStr);
            cmdBCustomer = new SqlCommandBuilder(daPayments);

            daPayments.FillSchema(dsKaizen, SchemaType.Source, "Payments");
            daPayments.Fill(dsKaizen, "Payments");
            dgvInvoice.DataSource = dsKaizen.Tables["Payments"];
            dgvInvoice.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabInv.SelectedIndex = 0;

        }

        private void frmPayments_Shown(object sender, EventArgs e)
        {
            tabInv.TabPages[0].CausesValidation = true;
            tabInv.TabPages[0].Validating += new CancelEventHandler(PayTabValidate);

        }

        void PayTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count == 0)
            {
                //custSelected = false;
                custIDSelected = 0;
            }
            else if (dgvInvoice.SelectedRows.Count == 1)
            {

//custSelected = true;
                custIDSelected = Convert.ToInt32(dgvInvoice.SelectedRows[0].Cells[0].Value);
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
