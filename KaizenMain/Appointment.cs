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
    public partial class Appointment : Form
    {

        SqlDataAdapter daAppointment;
        SqlDataAdapter daStaff;
        SqlDataAdapter daTrans;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBAppointment;
        SqlCommandBuilder cmdAStaff;
        SqlCommandBuilder cmdATrans;
        DataRow drAppointment;
        String connStr, sqlAppointment,sqlStaff,sqlTrans;
        int selectedTab = 0;
        bool AppSelected = false;
        int AppIDSelected = 0;
        int IDNumber = 0;
        private bool dateChanged = false;
        public Appointment()
        {
            InitializeComponent();
        }




        private void txtSupEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveSup_Click(object sender, EventArgs e)
        {

        }

        private void btnClearSup_Click(object sender, EventArgs e)
        {

        }

        private void txtCompName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchIconSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchClearForm_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClearForm_Click(object sender, EventArgs e)
        {

        }

        private void btnEditIconSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEditClearForm_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteIconSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteClearForm_Click(object sender, EventArgs e)
        {

        }

        private void dgvApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           




        }

        private void lblAppID_Click(object sender, EventArgs e)
        {

        }

        private void lblAddAppID_Click(object sender, EventArgs e)
        {

        }

        private void lblDateB_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAppDate_Click(object sender, EventArgs e)
        {

        }

        private void lblAppTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStaffID_Click(object sender, EventArgs e)
        {

        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTransID_Click(object sender, EventArgs e)
        {

        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            MyAppointment MyAppointment = new MyAppointment();
            bool ok = true;
            errP.Clear();
            try
            {
                MyAppointment.AppID = lblAddAppID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddAppID, MyEx.toString());
            }

            try
            {
                MyAppointment.AppTime = (dtpAppDate.Value.ToUniversalTime());
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpAppDate, MyEx.toString());
            }

            try
            {
                MyAppointment.Duration = MyAppointment.Duration = Convert.ToInt32(txtDuration.Text.Trim());
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtDuration, MyEx.toString());
            }


            try
            {
                MyAppointment.DateBooked = dtpDateBooked.Value.ToUniversalTime();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpDateBooked, MyEx.toString());
            }
            try
            {
                MyAppointment.AppTime = dtpAppTime.Value.ToUniversalTime();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpAppTime, MyEx.toString());
            }

            try
            {
                MyAppointment.TransID = cmbATransID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbATransID, MyEx.toString());
            }

            try
            {
                MyAppointment.StaffID = cmbAStaffID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAStaffID, MyEx.toString());
            }


            try
            {
                if (ok)
                {
                    drAppointment = dsKaizen.Tables["Appointment"].NewRow();
                    drAppointment["AppID"] = MyAppointment.AppID;
                    drAppointment["DateBooked"] = MyAppointment.DateBooked;
                    drAppointment["AppDate"] = MyAppointment.Appdate;
                    drAppointment["AppTime"] = MyAppointment.AppTime;
                    drAppointment["Duration"] = MyAppointment.Duration;
                    drAppointment["StaffID"] = MyAppointment.StaffID;
                    drAppointment["TransID"] = MyAppointment.TransID;
                    

                    dsKaizen.Tables["Appointment"].Rows.Add(drAppointment);
                    daAppointment.Update(dsKaizen, "Appointment");

                    MessageBox.Show("Appointment Added");

                    if (MessageBox.Show("Do you wish to add another Appointment?", "Add Appointment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getAppID(dsKaizen.Tables["Appointment"].Rows.Count);
                    }
                    else
                        tabApp.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }
        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }
        private void getAppID(int noRows)
        {

            drAppointment = dsKaizen.Tables["Appointment"].Rows[noRows - 1];
            seperateNumber(drAppointment["AppID"].ToString());
            lblAppID.Text = "AP-" + (IDNumber + 1).ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpAppTime_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateBooked_ValueChanged(object sender, EventArgs e)
        {
            dtpDateBooked.Value = DateTime.Today;
        }

        private void tabDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Shown(object sender, EventArgs e)
        {
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";


            sqlAppointment = @"select * from Appointment";
            daAppointment = new SqlDataAdapter(sqlAppointment, connStr);
            cmdBAppointment = new SqlCommandBuilder(daAppointment);

            sqlStaff = @"select * from Staff";
            daStaff= new SqlDataAdapter(sqlStaff, connStr);
            cmdAStaff = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsKaizen, SchemaType.Source, "Staff");
            daStaff.Fill(dsKaizen, "Staff");

            sqlTrans = @"select * from Trans";
            daTrans = new SqlDataAdapter(sqlTrans, connStr);
            cmdATrans = new SqlCommandBuilder(daTrans);
            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");


            cmbAStaffID.DataSource = dsKaizen.Tables["Staff"];
            cmbAStaffID.ValueMember = "StaffID";
            cmbAStaffID.DisplayMember = "StaffID";

            cmbATransID.DataSource = dsKaizen.Tables["Trans"];
            cmbATransID.ValueMember = "TransID";
            cmbATransID.DisplayMember = "TransID";



           
            dgvApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //txtDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            txtDate.Text = DateTime.Now.DayOfWeek.ToString();
            txtYear.Text = DateTime.Now.ToShortDateString();

                DateTime dt = DateTime.Now;
            //dgvApp.Columns[0].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[1].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[2].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[3].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[4].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[5].HeaderCell.Style.BackColor = Color.White;
            //dgvApp.Columns[6].HeaderCell.Style.BackColor = Color.White;
            //dsKaizen.Tables["Appointment"].Clear();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dgvApp.Rows[j].Cells[i].Value = 3; 
                    dgvApp.Rows[j].Cells[i].Style.BackColor = Color.White;

                }



            }


            DateTime weekStart = this.dateTimePicker1.Value.Date;
            DateTime weekEnd = this.dateTimePicker1.Value.AddDays(6);
            dgvApp.Columns[0].HeaderText = dt.AddDays(0).ToShortDateString();
            dgvApp.Columns[1].HeaderText = dt.AddDays(1).ToShortDateString();
            dgvApp.Columns[2].HeaderText = dt.AddDays(2).ToShortDateString();
            dgvApp.Columns[3].HeaderText = dt.AddDays(3).ToShortDateString();
            dgvApp.Columns[4].HeaderText = dt.AddDays(4).ToShortDateString();
            dgvApp.Columns[5].HeaderText = dt.AddDays(5).ToShortDateString();
            dgvApp.Columns[6].HeaderText = dt.AddDays(6).ToShortDateString();
          


            daAppointment.FillSchema(dsKaizen, SchemaType.Source, "Appointment");
            daAppointment.Fill(dsKaizen, "Appointment");
            dgvApp.DataSource = dsKaizen.Tables["Appointment"];

            //foreach(DataRow dr in dsKaizen.Tables["Appointment"].Rows)
            //{

            //    string startTime = (dr["AppTime"].ToString());

            //    for(int i=0; i <6; i++)
            //    {
            //        if(Convert.ToDateTime(dr["AppDate"]).ToShortDateString().Equals(dgvApp.Columns.HeaderText.ToShortDateString()[i].ToShortDateString))
            //    }



            //}
            

            //dgvApp.Columns[0].Width = 100;
            //dgvApp.Columns[1].Width = 100;
            //dgvApp.Columns[2].Width = 100;
            //dgvApp.Columns[3].Width = 100;
            //dgvApp.Columns[4].Width = 100;
            //dgvApp.Columns[5].Width = 100;
            //dgvApp.Columns[6].Width = 100;



            //dgvApp.Rows.Add(9);




            tabApp.SelectedIndex = 1;
                    tabApp.SelectedIndex = 0;
        }

        private void tabApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabApp.SelectedIndex;
            tabApp.TabPages[tabApp.SelectedIndex].Focus();
            tabApp.TabPages[tabApp.SelectedIndex].CausesValidation = true;

            if (dgvApp.SelectedRows.Count == 0 && (tabApp.SelectedIndex == 1 || tabApp.SelectedIndex == 3 || tabApp.SelectedIndex == 4))
                tabApp.TabPages[tabApp.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabApp.SelectedIndex)
                {
                    case 0:
                        {
                           dsKaizen.Tables["Appointment"].Clear();
                           daAppointment.Fill(dsKaizen, "Appointment");

                            break;
                        }
                    case 1:
                        {
                            if (AppIDSelected == 0)
                            {
                                tabApp.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                //txtSeSuppID.Text = suppIDSelected.ToString();
                                txtSearchID.Text = "AP-" + AppIDSelected.ToString();
                                drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(txtSearchID.Text);

                                txtSeDateB.Text = drAppointment["DateBooked"].ToString();
                                txtSeAppDate.Text = drAppointment["AppDate"].ToString();
                                txtSeAppTime.Text = drAppointment["AppTime"].ToString();
                                txtSeAppDate.Text = drAppointment["AppDate"].ToString();
                                txtSeDuration.Text = drAppointment["Duration"].ToString();
                                txtSeStaffID.Text = drAppointment["StaffID"].ToString();
                                txtSeTransID.Text = drAppointment["TransID"].ToString();

                            }
                            break;

                        }

                    case 2:
                        {
                            //int noRows = dsKaizen.Tables["Appointment"].Rows.Count;

                            //if (noRows == 0)
                            //    lblAddAppID.Text = "AP-6000";
                            //else
                            //{
                            //    getAppID(noRows);
                            //}

                            //errP.Clear();
                            //clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (AppIDSelected == 0)
                            {
                                tabApp.SelectedIndex = 0;
                                break;
                            }
                            else
                            {


                                txtEdSearch.Text = "AP-" + AppIDSelected.ToString();

                                drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(txtEdSearch.Text);

                                txtEDDateB.Text = drAppointment["DateBooked"].ToString();
                                txtEDAppDate.Text = drAppointment["AppDate"].ToString();
                                txtEDAppTime.Text = drAppointment["AppTime"].ToString();
                                txtEDAppDate.Text = drAppointment["AppDate"].ToString();
                                txtEdDuration.Text = drAppointment["Duration"].ToString();
                                txtEDStaffID.Text = drAppointment["StaffID"].ToString();
                                txtEdTransID.Text = drAppointment["TransID"].ToString();

                               // disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (AppIDSelected == 0)
                            {
                                tabApp.SelectedIndex = 0;
                                break;
                            }
                            txtDLSearch.Text = "AP-" + AppIDSelected.ToString();


                            drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(txtDLSearch.Text);


                            txtDLDateB.Text = drAppointment["DateBooked"].ToString();
                            txtDLAppDate.Text = drAppointment["AppDate"].ToString();
                            txtDlAppTime.Text = drAppointment["AppTime"].ToString();
                            txtDLAppDate.Text = drAppointment["AppDate"].ToString();
                            txtDLDuration.Text = drAppointment["Duration"].ToString();
                            txtDLStaffID.Text = drAppointment["StaffID"].ToString();
                            txtDLTransID.Text = drAppointment["TransID"].ToString();



                            break;
                        }




                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddApp_Click_1(object sender, EventArgs e)
        {
            tabApp.SelectedIndex = 0;
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateChanged = true;
            
          
            DateTime dt1 = this.dateTimePicker1.Value.Date;


            dgvApp.Columns[0].HeaderText = dt1.AddDays(0).ToShortDateString();
            dgvApp.Columns[1].HeaderText = dt1.AddDays(1).ToShortDateString();
            dgvApp.Columns[2].HeaderText = dt1.AddDays(2).ToShortDateString();
            dgvApp.Columns[3].HeaderText = dt1.AddDays(3).ToShortDateString();
            dgvApp.Columns[4].HeaderText = dt1.AddDays(4).ToShortDateString();
            dgvApp.Columns[5].HeaderText = dt1.AddDays(5).ToShortDateString();
            dgvApp.Columns[6].HeaderText = dt1.AddDays(6).ToShortDateString();


            DateTime dt3 = this.dateTimePicker1.Value.Date;
            label1.Text = dt3.DayOfWeek.ToString();

            DateTime dt4 = this.dateTimePicker1.Value.Date.AddDays(1);
            DayLabel2.Text = dt4.DayOfWeek.ToString();

            DateTime dt5 = this.dateTimePicker1.Value.Date.AddDays(2);
            DayLabel3.Text = dt5.DayOfWeek.ToString();

            DateTime dt6 = this.dateTimePicker1.Value.Date.AddDays(3);
            DayLabel4.Text = dt6.DayOfWeek.ToString();

            DateTime dt7 = this.dateTimePicker1.Value.Date.AddDays(4);
            DayLabel5.Text = dt7.DayOfWeek.ToString();

            DateTime dt8 = this.dateTimePicker1.Value.Date.AddDays(5);
            DayLabel6.Text = dt8.DayOfWeek.ToString();

            DateTime dt9 = this.dateTimePicker1.Value.Date.AddDays(6);
            DayLabel7.Text = dt9.DayOfWeek.ToString();



        }

        private void btnApp_Click(object sender, EventArgs e)
        {

            //dgvApp.Rows[0].Cells[0].Style.BackColor = Color.LightGreen;
            //dgvApp.Rows[2].Cells[1].Style.SelectionBackColor = Color.AliceBlue;
            //dgvApp.Rows[2].Cells[1].Style.ForeColor = Color.Red;

            
        }

        private void dgvApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabApp.SelectedIndex = 2;
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
           
           
        }

        private void DayLabel2_Click(object sender, EventArgs e)
        {
            DateTime dt4 = this.dateTimePicker1.Value.Date.AddDays(-1);
            DayLabel2.Text = DateTime.Now.DayOfWeek.ToString();
        }

        void clearAddForm()
        {
            txtDuration.Clear();
            dtpAppDate.Value=DateTime.Today;
            dtpDateBooked.Value=DateTime.Today;
            dtpAppTime.Value = DateTime.Now;
            cmbATransID.SelectedIndex=0;
            cmbATransID.SelectedIndex = 0;
            txtDuration.Clear();
        

        }
    }
}
