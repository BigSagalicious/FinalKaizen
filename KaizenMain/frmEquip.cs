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
        SqlDataAdapter daEquip;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBEquip;
        DataRow drTrans;
        String connStr, sqlEquip;
        int selectedTab = 0;
        bool equipSelected = false;
        int equipIDSelected = 0;
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
                equipIDSelected = Convert.ToInt32(dgvEquip.SelectedRows[0].Cells[0].Value);
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
                equipIDSelected = Convert.ToInt32(dgvEquip.SelectedRows[0].Cells[0].Value);
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
    }
}
