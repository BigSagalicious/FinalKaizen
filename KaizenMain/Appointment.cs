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
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBAppointment;
        DataRow drAppointment;
        String connStr, sqlAppointment;
        int selectedTab = 0;
        bool AppSelected = false;
        int AppIDSelected = 0;
        int IDNumber = 0;
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
                MyAppointment.Duration = Convert.ToInt32(txtDuration.Text);
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
                MyAppointment.TransID = txtTransID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTransID, MyEx.toString());
            }

            try
            {
                MyAppointment.StaffID = txtStaffID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtStaffID, MyEx.toString());
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
            lblAppID.Text = "SU-" + (IDNumber + 1).ToString();

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

            daAppointment.FillSchema(dsKaizen, SchemaType.Source, "Appointment");
            daAppointment.Fill(dsKaizen, "Appointment");
            dgvApp.DataSource = dsKaizen.Tables["Appointment"];
            dgvApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
                            int noRows = dsKaizen.Tables["Appointment"].Rows.Count;

                            if (noRows == 0)
                                lblAppID.Text = "AP-6000";
                            else
                            {
                                getAppID(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
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

        void clearAddForm()
        {
            txtStaffID.Clear();
            dtpAppDate.Value=DateTime.Today;
            dtpDateBooked.Value=DateTime.Today;
            dtpAppTime.Value = DateTime.Now;
            txtTransID.Clear();
            txtDuration.Clear();
        

        }
    }
}
