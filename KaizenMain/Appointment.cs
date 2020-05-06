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
using System.Globalization;

namespace KaizenMain
{
    public partial class Appointment : Form
    {

        SqlDataAdapter daAppointment;
        SqlDataAdapter daStaff;
        SqlDataAdapter daTrans;
        SqlDataAdapter daAll;
        SqlDataAdapter daAppval;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdAll;
        SqlCommandBuilder cmdAStaff;
        SqlCommandBuilder cmdATrans;
        SqlCommand cmdAppointment;
        SqlCommand cmdAppval;
        DataRow drAppointment;
        DataRow drAppval;
        DataRow drStaff;
        SqlConnection conn = new SqlConnection();
        bool booked = false;
        
        String connStr, sqlAppointment,sqlStaff,sqlTrans,sqlAll,sqlAppval;

        int selectedTab = 0;
        bool AppSelected = false;
        int AppIDSelected = 0;
        int IDNumber = 0;
        private bool found = false;
        DateTime[] thisWeek = new DateTime[7];
        String [] ATime = new String[9];
        int[] DTime = new int[9];
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
          
        }
        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }
        private void getAppID(int noRows)
        {

            drAppointment = dsKaizen.Tables["Appointment"].Rows[noRows-1 ];
            seperateNumber(drAppointment["AppID"].ToString());
            lblAddAppID.Text = "AP-" + (IDNumber + 1).ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpAppTime_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DisplayApps();
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
            tabApp.TabPages[0].CausesValidation = true;
            tabApp.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabApp.TabPages[2].CausesValidation = true;
            tabApp.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            

            //connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            DateTime dts = new DateTime(2020, 2, 10);
            DateTime dte = new DateTime(2080, 12, 25);
            cmbStaff.DataSource = dsKaizen.Tables["Staff"];
            cmbStaff.ValueMember = "StaffID";
            cmbStaff.DisplayMember = "StaffID";

            conn = new SqlConnection(connStr);
            sqlAppointment = @"select * from Appointment WHERE Appointment.AppDate BETWEEN @FrmDT AND @ToDT AND Appointment.StaffID= @StaffID";
            cmdAppointment = new SqlCommand(sqlAppointment, conn);
            cmdAppointment.Parameters.Add("@FrmDT", SqlDbType.Date);
            cmdAppointment.Parameters.Add("@ToDT", SqlDbType.Date);
            cmdAppointment.Parameters.Add("@StaffID", SqlDbType.VarChar);
            cmdAppointment.Parameters["@FrmDt"].Value = dts;
            cmdAppointment.Parameters["@ToDt"].Value = dte;
            cmdAppointment.Parameters["@StaffID"].Value = cmbStaff.Text.Trim();
            daAppointment = new SqlDataAdapter(cmdAppointment);
            daAppointment.FillSchema(dsKaizen, SchemaType.Source, "Appointment");
            daAppointment.Fill(dsKaizen, "Appointment");
            //daAll.Fill(dsKaizen, "Appointment");
            //MessageBox.Show(dsKaizen.Tables["Appointment"].Rows.Count.ToString());

            

            sqlStaff = @"select * from Staff";
            daStaff= new SqlDataAdapter(sqlStaff, connStr);
            cmdAStaff = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsKaizen, SchemaType.Source, "Staff");
            daStaff.Fill(dsKaizen, "Staff");

            sqlAll = @"select * from Appointment";
            daAll = new SqlDataAdapter(sqlAll, connStr);
            cmdAll = new SqlCommandBuilder(daAll);
            daAll.FillSchema(dsKaizen, SchemaType.Source, "Appointment");
            daAll.Fill(dsKaizen, "Appointment");

            sqlTrans = @"select * from Trans";
            daTrans = new SqlDataAdapter(sqlTrans, connStr);
            cmdATrans = new SqlCommandBuilder(daTrans);
            daTrans.FillSchema(dsKaizen, SchemaType.Source, "Trans");
            daTrans.Fill(dsKaizen, "Trans");


            cmbAStaffID.DataSource = dsKaizen.Tables["Staff"];
            cmbAStaffID.ValueMember = "StaffID";
            cmbAStaffID.DisplayMember = "StaffID";

            cmbEdStaffID.DataSource = dsKaizen.Tables["Staff"];
            cmbEdStaffID.ValueMember = "StaffID";
            cmbEdStaffID.DisplayMember = "StaffID";

            cmbATransID.DataSource = dsKaizen.Tables["Trans"];
            cmbATransID.ValueMember = "TransID";
            cmbATransID.DisplayMember = "TransID";

            cmbEditTransID.DataSource = dsKaizen.Tables["Trans"];
            cmbEditTransID.ValueMember = "TransID";
            cmbEditTransID.DisplayMember = "TransID";

            cmbStaff.DataSource = dsKaizen.Tables["Staff"];
            cmbStaff.ValueMember = "StaffID";
            cmbStaff.DisplayMember = "StaffID";

            

            dgvApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            txtDate.Text = DateTime.Now.DayOfWeek.ToString();
            txtYear.Text = DateTime.Now.ToShortDateString();
            DateTime dt = DateTime.Now;

            dgvApp.Columns[0].HeaderText = dt.AddDays(0).ToShortDateString();
            dgvApp.Columns[1].HeaderText = dt.AddDays(1).ToShortDateString();
            dgvApp.Columns[2].HeaderText = dt.AddDays(2).ToShortDateString();
            dgvApp.Columns[3].HeaderText = dt.AddDays(3).ToShortDateString();
            dgvApp.Columns[4].HeaderText = dt.AddDays(4).ToShortDateString();
            dgvApp.Columns[5].HeaderText = dt.AddDays(5).ToShortDateString();
            dgvApp.Columns[6].HeaderText = dt.AddDays(6).ToShortDateString();

            dgvApp.Columns[0].Width = 100;
            dgvApp.Columns[1].Width = 100;
            dgvApp.Columns[2].Width = 100;
            dgvApp.Columns[3].Width = 100;
            dgvApp.Columns[4].Width = 100;
            dgvApp.Columns[5].Width = 100;
            dgvApp.Columns[6].Width = 100;

            ATime[0] = "09:00:00";
            ATime[1] = "10:00:00";
            ATime[2] = "11:00:00";
            ATime[3] = "12:00:00";
            ATime[4] = "13:00:00";
            ATime[5] = "14:00:00";
            ATime[6] = "15:00:00";
            ATime[7] = "16:00:00";
            ATime[8] = "17:00:00";

            for(int i=0; i<ATime.Length;i++)
            {
                cmbAddTime.Items.Add(ATime[i].ToString());
                cmbEdTimes.Items.Add(ATime[i].ToString());
            }



            DTime[0] = 1;
            DTime[1] = 2;
            DTime[2] = 3;
            DTime[3] = 4;
            DTime[4] = 5;
            DTime[5] = 6;
            DTime[6] = 7;
            DTime[7] = 8;
            DTime[8] = 9;

            for(int k=0; k<DTime.Length;k++)
            {
                cmbDuration.Items.Add(DTime[k].ToString());
                cmbEdDur.Items.Add(DTime[k].ToString());
            }
            
            DisplayApps();






            pnlAppDetails.Visible = false;



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
                            //DisplayApps();
                           

                            daAll.Fill(dsKaizen, "Appointment");

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
                                txtSearchID.Text = AppIDSelected.ToString();
                                drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(txtSearchID.Text);
                                txtSeDBooked.Text= drAppointment["DateBooked"].ToString();
                                txtSeAppDate.Text = drAppointment["AppDate"].ToString();
                                txtSeAppTime.Text = drAppointment["AppTime"].ToString();
                                txtSeDuration.Text = drAppointment["Duration"].ToString();
                                txtSeStaffID.Text = drAppointment["StaffID"].ToString();
                                txtSeTransID.Text = drAppointment["TransID"].ToString();
                                txtSDesc.Text = drAppointment["AppDesc"].ToString();
                            }
                            break;

                        }

                    case 2:
                        {
                            
                            int noRows = dsKaizen.Tables["Appointment"].Rows.Count;

                            if (noRows == 0)
                               lblAddAppID.Text = "AP-6000";
                            else
                            {
                                //dtpAppDate.Enabled = false;
                                //cmbAddTime.Enabled = false;
                                //dtpDateBooked.Enabled = false;
                                //cmbDuration.Enabled = false;
                                //txtADesc.Enabled = false;
                                //cmbAStaffID.Enabled = false;
                                //cmbATransID.Enabled = false;

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
                                lblEditAID.Text = "AP-" + AppIDSelected.ToString();



 
                                drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(lblEdAppID.Text);

                                lblEditAID.Text = drAppointment["AppID"].ToString();
                                dtpEdAppBooked.Value = (DateTime)drAppointment["DateBooked"];
                                dtpEdAppDate.Value = (DateTime)drAppointment["AppDate"];
                                cmbEdDur.Text = drAppointment["Duration"].ToString();
                                cmbEditTransID.Text = drAppointment["TransID"].ToString();
                                cmbEdStaffID.Text = drAppointment["StaffID"].ToString();
                                cmbEdTimes.Text = drAppointment["AppTime"].ToString();
                                txtEDesc.Text = drAppointment["AppDesc"].ToString();




                            }


                                

                                // disableEditTxtboxes();
                              

                                    break;

                            
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
                            txtDDesc.Text = drAppointment["AppDesc"].ToString();


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
            MyAppointment myAppointment = new MyAppointment();
            bool ok = true;
            errP.Clear();
            try
            {
                myAppointment.AppID = lblAddAppID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddAppID, MyEx.toString());
            }

            try
            {
               
                
                myAppointment.AppTime = cmbAddTime.Text.Trim();

            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddTime, MyEx.toString());
            }

            try
            {
                myAppointment.Duration = Convert.ToInt32(cmbDuration.Text.Trim());
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbDuration, MyEx.toString());
            }


            try
            {
                myAppointment.DateBooked = DateTime.Parse(dtpDateBooked.Text.Trim());

            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpDateBooked, MyEx.toString());
            }

            try
            {
                myAppointment.Appdate = DateTime.Parse(dtpAppDate.Text.Trim());

            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpDateBooked, MyEx.toString());
            }

            try
            {
                myAppointment.TransID = cmbATransID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbATransID, MyEx.toString());
            }

            try
            {
                myAppointment.StaffID = cmbAStaffID.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAStaffID, MyEx.toString());
            }
            try
            {
                myAppointment.AppDesc = txtADesc.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtADesc, MyEx.toString());
            }
            try
                {
                if (ok)
                {
                    //string theDate = dtpAppDate.Value.ToString("yyyy-MM-dd");
                    ////MessageBox.Show(theDate);

                    //DateTime Range = new DateTime(2020, 02, 02);
                    //TimeSpan time = TimeSpan.Parse(cmbAddTime.Text.Trim());
                    //conn = new SqlConnection(connStr);
                    //sqlAppval = @"select count(*)from Appointment WHERE /*Appointment.AppDate = @FrmDT AND*/ Appointment.StaffID= @StaffID AND Appointment.AppTime=@AppTime";
                    //cmdAppval = new SqlCommand(sqlAppval, conn);
                    //cmdAppval.Parameters.Add("@FrmDT", SqlDbType.Date);
                    //cmdAppval.Parameters.Add("@StaffID", SqlDbType.VarChar);
                    //cmdAppval.Parameters.Add("@AppTime", SqlDbType.VarChar);
                    //cmdAppval.Parameters["@FrmDt"].Value =DateTime.Parse(theDate);
                    //cmdAppval.Parameters["@StaffID"].Value = cmbStaff.Text.Trim();
                    //cmdAppval.Parameters["@AppTime"].Value = cmbAddTime.SelectedItem;
                    //daAppval = new SqlDataAdapter(cmdAppval);
                    //daAppval.FillSchema(dsKaizen, SchemaType.Source, "Appointment");
                    //daAppval.Fill(dsKaizen, "Appointment");
                    //conn.Open();
                    //Int32 count = Convert.ToInt32(cmdAppval.ExecuteScalar());
                    //MessageBox.Show(count.ToString());
                    //if (count > 0)
                    //{
                    //    found = true;
                    //    MessageBox.Show("you Cannane do that", "Appointment");
                    //    tabApp.SelectedIndex = 0;
                    //}
                    
                        //found = false;
                        DataRow drAppointment = dsKaizen.Tables["Appointment"].NewRow();
                        drAppointment["AppID"] = myAppointment.AppID;
                        drAppointment["DateBooked"] = myAppointment.DateBooked;
                        drAppointment["AppDate"] = myAppointment.Appdate;
                        drAppointment["AppTime"] = cmbAddTime.Text;
                        drAppointment["Duration"] = Convert.ToInt32(cmbDuration.Text);
                        drAppointment["StaffID"] = myAppointment.StaffID;
                        drAppointment["TransID"] = myAppointment.TransID;
                        drAppointment["AppDesc"] = myAppointment.AppDesc;
                        dsKaizen.Tables["Appointment"].Rows.Add(drAppointment);
                        SqlCommandBuilder daAppoinment = new SqlCommandBuilder(daAppointment);
                        daAppointment.UpdateCommand = daAppoinment.GetUpdateCommand();
                        daAppointment.Update(dsKaizen, "Appointment");
                        MessageBox.Show("Appointment Added");
                        txtADesc.Text = "";
                        dtpAppDate.Enabled = true;

                        if (MessageBox.Show("Do you wish to add another Appointment?", "Add Appointment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clearAddForm();

                            getAppID(dsKaizen.Tables["Appointment"].Rows.Count);
                        }
                        else
                        {
                            tabApp.SelectedIndex = 0;
                            DisplayApps();



                        }
                    


                   
                    





                }



            }

                    

                   
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DisplayApps();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {

            

        }

        private void tabApp_Validated(object sender, EventArgs e)
        {

        }

        private void dgvApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabApp.SelectedIndex = 2;

            //drAppointment=dsKaizen.Tables["Appointment"].Rows.Find()

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dgvApp.CurrentCell.ColumnIndex.Equals(i) && e.RowIndex != -1)
                    {
                        if (dgvApp.CurrentCell != null && dgvApp.CurrentCell.Value != null)
                        {

                            lblEditAID.Text = dgvApp.CurrentCell.Value.ToString();
                            txtSearchID.Text = dgvApp.CurrentCell.Value.ToString();
                            txtDLSearch.Text = dgvApp.CurrentCell.Value.ToString();
                            btnEdit.Enabled = true;
                            btDelete.Enabled = true;
                            btnSearch.Enabled = true;
                           
                        }
                        else
                        {
                            
                            lblEditAID.Text = "AP-6000";
                            txtSearchID.Text = "AP-6000";
                            txtDLSearch.Text = "AP-6000";
                            btnEdit.Enabled = false;
                            btDelete.Enabled = false;
                            btnSearch.Enabled = false;

                            

                            if (dgvApp.CurrentCell.RowIndex.Equals(0))
                            {
                                cmbAddTime.SelectedIndex = 0;
                                //cmbAddTime.Enabled = false;
                            }
                            else if(dgvApp.CurrentCell.RowIndex.Equals(1))
                            {
                               
                                cmbAddTime.SelectedIndex=1;
                                
                            }

                            else if (dgvApp.CurrentCell.RowIndex.Equals(2))
                            {

                                cmbAddTime.SelectedIndex = 2;
                                
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(3))
                            {

                                cmbAddTime.SelectedIndex = 3;
                                
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(4))
                            {

                                cmbAddTime.SelectedIndex = 4;
                                
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(5))
                            {

                                cmbAddTime.SelectedIndex = 5;
                               
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(6))
                            {

                                cmbAddTime.SelectedIndex = 6;
                                
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(7))
                            {

                                cmbAddTime.SelectedIndex = 7;
                                
                            }
                            else if (dgvApp.CurrentCell.RowIndex.Equals(8))
                            {

                                cmbAddTime.SelectedIndex = 8;
                                
                            }

                            if(dgvApp.CurrentCell.ColumnIndex.Equals(0))
                            {
                               
                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(0);

                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(1))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(1);
                               

                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(2))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(2);
                                

                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(3))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(3);
                                
                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(4))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(4);
                                
                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(5))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(5);
                                

                            }
                            else if (dgvApp.CurrentCell.ColumnIndex.Equals(6))
                            {

                                DateTime dt13 = this.dateTimePicker1.Value.Date;
                                dtpAppDate.Value = dt13.AddDays(6);
                                

                            }
                            
                            tabApp.SelectedIndex = 2;
                            
                        }
                           
                   

                        foreach (DataRow dr in dsKaizen.Tables["Appointment"].Rows)
                        {
                            if ((dr["AppID"].Equals(lblEditAID.Text)))
                            {
                                dtpEdAppBooked.Value = (DateTime)dr["DateBooked"];
                                dtpEdAppDate.Value = (DateTime)dr["AppDate"];
                                cmbEdTimes.Text = dr["AppTime"].ToString();
                                cmbEdDur.Text = dr["Duration"].ToString();
                                cmbEdStaffID.Text = dr["StaffID"].ToString();
                                cmbEditTransID.Text = dr["TransID"].ToString();
                                txtEDesc.Text = dr["AppDesc"].ToString();
                               // DisplayApps();
                            }


                        }

                        foreach (DataRow dr in dsKaizen.Tables["Appointment"].Rows)
                        {
                            if ((dr["AppID"].Equals(txtSearchID.Text)))
                            {
                                txtSeDBooked.Text= dr["DateBooked"].ToString();
                                txtSeAppDate.Text = dr["AppDate"].ToString();
                                txtSeAppTime.Text = dr["AppTime"].ToString();
                                txtSeDuration.Text = dr["Duration"].ToString();
                                txtSeStaffID.Text = dr["StaffID"].ToString();
                                txtSeTransID.Text = dr["TransID"].ToString();
                                txtSDesc.Text = dr["AppDesc"].ToString();

                                txtpnAppDate.Text = dr["AppDate"].ToString();
                                txtpnAppDur.Text = dr["Duration"].ToString();
                                txtAppDet.Text = dr["AppDesc"].ToString();
                                txtpnStaff.Text = dr["StaffID"].ToString();
                                txtpnAppTime.Text = dr["AppTime"].ToString();

                            }


                        }

                        foreach (DataRow dr in dsKaizen.Tables["Appointment"].Rows)
                        {
                            if ((dr["AppID"].Equals(txtDLSearch.Text)))
                            {
                                txtDLDateB.Text = dr["DateBooked"].ToString();
                                txtDLAppDate.Text = dr["AppDate"].ToString();
                                txtDlAppTime.Text = dr["AppTime"].ToString();
                                txtDLDuration.Text = dr["Duration"].ToString();
                                txtDLStaffID.Text = dr["StaffID"].ToString();
                                txtDLTransID.Text = dr["TransID"].ToString();
                                txtDDesc.Text = dr["AppDesc"].ToString();

                            }


                        }
                    }


                }



            }
            



        }
        private void label1_Click_2(object sender, EventArgs e)
        {
           
           
        }

        private void DayLabel2_Click(object sender, EventArgs e)
        {
            DateTime dt4 = this.dateTimePicker1.Value.Date.AddDays(-1);
            DayLabel2.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void cmbATransID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void clearAddForm()
        {
           
            dtpAppDate.Value=DateTime.Today;
            dtpDateBooked.Value=DateTime.Today;
            cmbAddTime.SelectedIndex=0;
            cmbATransID.SelectedIndex=0;
            cmbAStaffID.SelectedIndex = 0;
            cmbDuration.SelectedIndex=0;
        

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dtpAppDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
            tabApp.SelectedIndex = 3;


        }
        //Delete button
        private void roundButton3_Click(object sender, EventArgs e)
        {
            tabApp.SelectedIndex = 4;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            tabApp.SelectedIndex = 1;
        }

        
        private void btnEditApp_Click(object sender, EventArgs e)
        {
            if (btnEditApp.Text == "EDIT")
            {
               

                    dtpEdAppBooked.Enabled=false;
                    dtpEdAppDate.Enabled = true;
                    cmbEdTimes.Enabled = true;
                    cmbEditTransID.Enabled = true;
                    cmbEdStaffID.Enabled = true;
                    cmbEdDur.Enabled = true;
                    txtEDesc.Enabled = true;
                
                


                btnEditApp.Text = "SAVE";
            }
            else
            {
                MyAppointment myAppointment = new MyAppointment();
                bool ok = true;
                errP.Clear();
                try


                {
                    myAppointment.AppID = lblEditAID.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditAID, MyEx.toString());
                }

                try
                {


                    myAppointment.AppTime = cmbEdTimes.Text.Trim();

                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEdTimes, MyEx.toString());
                }

                try
                {
                    myAppointment.Duration = Convert.ToInt32(cmbEdDur.Text.Trim());
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEdDur, MyEx.toString());
                }


                try
                {
                    myAppointment.DateBooked = DateTime.Parse(dtpEdAppBooked.Text.Trim());

                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dtpEdAppBooked, MyEx.toString());
                }

                try
                {
                    myAppointment.Appdate = DateTime.Parse(dtpEdAppDate.Text.Trim());

                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dtpEdAppDate, MyEx.toString());
                }

                try
                {
                    myAppointment.TransID = cmbEditTransID.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditTransID, MyEx.toString());
                }

                try
                {
                    myAppointment.StaffID = cmbEdStaffID.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEdStaffID, MyEx.toString());
                }
                try
                {
                    myAppointment.AppDesc = txtEDesc.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEDesc, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        
                        drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(lblEditAID.Text);
                        drAppointment.BeginEdit();
                        //drAppointment = dsKaizen.Tables["Appointment"].NewRow();
                        drAppointment["AppID"] = myAppointment.AppID;
                        drAppointment["DateBooked"] = myAppointment.DateBooked;
                        drAppointment["AppDate"] = myAppointment.Appdate;
                        drAppointment["AppTime"] = cmbEdTimes.Text;
                        drAppointment["Duration"] = Convert.ToInt32(cmbEdDur.Text);
                        drAppointment["StaffID"] = myAppointment.StaffID;
                        drAppointment["TransID"] = myAppointment.TransID;
                        drAppointment["AppDesc"] = myAppointment.AppDesc;
                        drAppointment.EndEdit();
                        SqlCommandBuilder daAppoinment = new SqlCommandBuilder(daAppointment);
                        daAppointment.UpdateCommand = daAppoinment.GetUpdateCommand();
                        daAppointment.Update(dsKaizen, "Appointment");
                        MessageBox.Show("Appointment Updated");

                        tabApp.SelectedIndex = 0;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnDelDel_Click(object sender, EventArgs e)
        {

 
            drAppointment = dsKaizen.Tables["Appointment"].Rows.Find(txtDLSearch.Text);

            string tempName = drAppointment["AppID"].ToString() + "\'s";
                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?",
                    "Add Appointment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                     drAppointment.Delete();
                     SqlCommandBuilder daAppoinment = new SqlCommandBuilder(daAppointment);
                     daAppointment.UpdateCommand = daAppoinment.GetUpdateCommand();
                     daAppointment.Update(dsKaizen, "Appointment");
                     MessageBox.Show("Details Removed for " + tempName);
                     tabApp.SelectedIndex = 0; 
                    //clearDeleteForm();

                }

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayApps();
        }

        private void lblAddAppID_ForeColorChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvApp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void cmbStaff_SelectedValueChanged(object sender, EventArgs e)
        {
            //btnRefresh_Click(sender, e);


        }

        private void cmbStaff_DropDownClosed(object sender, EventArgs e)
        {
            DisplayApps();
            //btnRefresh_Click(sender, e);
            

        }

        private void btnClosePnl_Click(object sender, EventArgs e)
        {
            pnlAppDetails.Visible = false;
        }

        private void dgvApp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           pnlAppDetails.Visible = true;
            txtpnAppDate.Enabled = false;
            txtpnStaff.Enabled = false;
            txtpnAppDur.Enabled = false;
            txtAppDet.Enabled = false;
            txtpnAppTime.Enabled = false;
        }

        private void dgvApp_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlAppDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStaff_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbAStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvApp.SelectedRows.Count == 0)
            {
                AppSelected = false;
                AppIDSelected = 0;
            }
            else if (dgvApp.SelectedRows.Count == 1)
            {

                AppSelected = true;
                AppIDSelected = Convert.ToInt32(dgvApp.SelectedRows[0].Cells[0].Value);
            }
        }

        void DispTabValidate(object sender, EventArgs e)
        {
            if (AppSelected == false && AppIDSelected == 0)
            {
                AppSelected = false;
                AppIDSelected = 0;
            }
            else if (dgvApp.SelectedRows.Count == 1)
            {
                AppSelected = true;
                seperateNumber(dgvApp.SelectedRows[0].Cells[0].Value.ToString());
                AppIDSelected = IDNumber;
            }
        }
        void EditTabValidate(object sender, EventArgs e)
        {
            if (AppSelected == false && AppIDSelected == 0)
            {
                AppSelected = false;
                AppIDSelected = 0;
            }
            else if (dgvApp.SelectedRows.Count == 1)
            {
                AppSelected = true;
                seperateNumber(dgvApp.SelectedRows[0].Cells[0].Value.ToString());
                AppIDSelected = IDNumber;
            }
        }

        public void DisplayApps()
        {
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



            DateTime dt12 = this.dateTimePicker1.Value.Date;

            dgvApp.Columns[0].HeaderText = dt12.AddDays(0).ToShortDateString();
            dgvApp.Columns[1].HeaderText = dt12.AddDays(1).ToShortDateString();
            dgvApp.Columns[2].HeaderText = dt12.AddDays(2).ToShortDateString();
            dgvApp.Columns[3].HeaderText = dt12.AddDays(3).ToShortDateString();
            dgvApp.Columns[4].HeaderText = dt12.AddDays(4).ToShortDateString();
            dgvApp.Columns[5].HeaderText = dt12.AddDays(5).ToShortDateString();
            dgvApp.Columns[6].HeaderText = dt12.AddDays(6).ToShortDateString();

            for(int p=0;p<7;p++)
            {
                dtpAppDate.Value = dt12;


            }

            dgvApp.Rows.Add(9);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dgvApp.Rows[j].Cells[i].Value = null;
                    dgvApp.Rows[j].Cells[i].Style.BackColor = Color.White;

                }



            }
            DateTime weekStart = this.dateTimePicker1.Value.Date;
            DateTime weekEnd = this.dateTimePicker1.Value.AddDays(6);

            thisWeek[0] = weekStart.Date;
            thisWeek[1] = weekStart.AddDays(1).Date;
            thisWeek[2] = weekStart.AddDays(2).Date;
            thisWeek[3] = weekStart.AddDays(3).Date;
            thisWeek[4] = weekStart.AddDays(4).Date;
            thisWeek[5] = weekStart.AddDays(5).Date;
            thisWeek[6] = weekStart.AddDays(6).Date;
            cmdAppointment.Parameters["@StaffID"].Equals(cmbAStaffID.SelectedValue);
            cmdAppointment.Parameters["@FrmDt"].Value = weekStart;
            cmdAppointment.Parameters["@ToDt"].Value = weekEnd.AddDays(6);
            drStaff = dsKaizen.Tables["Staff"].Rows.Find(cmbAStaffID.SelectedValue);
           // if (cmbAStaffID.SelectedValue.Equals(drStaff["StaffID"]))
            
                
            if (cmbAStaffID.SelectedItem != null)
            {
                txtDisFor.Text = drStaff["StaffFName"].ToString();
                txtDisSur.Text = drStaff["StaffSName"].ToString();
            }

            




                daAppointment.Fill(dsKaizen, "Appointment");

           

            foreach (DataRow dr in dsKaizen.Tables["Appointment"].Rows)
            {
                string startTime = (dr["AppTime"].ToString());

                for (int i = 0; i < 7; i++)
                {
                    if ((dr["AppDate"]).Equals(thisWeek[i]) && dr["StaffID"].Equals(cmbStaff.SelectedValue))
                    {

                       
                        for (int j = 0; j < 9; j++)
                        {


                            if (ATime[j].Equals(startTime))
                            {
                                dgvApp.Rows[j].Cells[i].Style.BackColor = Color.DarkBlue;
                                dgvApp.Rows[j].Cells[i].ReadOnly=true;
                                dgvApp.Rows[j].Cells[i].Value = dr["AppID"].ToString();
                                booked = true;




                                for (int k = 1; k <= Convert.ToInt32(dr["Duration"])-1; k++)
                                {

                                    dgvApp.Rows[j + k].Cells[i].Style.BackColor = Color.Gray;

                                    if (k.Equals(1))
                                    {
                                        
                                        dgvApp.Rows[j + k].Cells[i].Value = "";
                                    }
                                    else if (k.Equals(2))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(3))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(4))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(5))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(6))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(7))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(8))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                    else if (k.Equals(9))
                                    {
                                        dgvApp.Rows[j + k].Cells[i].Value = "";

                                    }
                                }
                            }

                           



                        }
                    }
                }



            }







        }

       
    }
}
