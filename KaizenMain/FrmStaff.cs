using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KaizenMain
{
    public partial class FrmStaff : Form
    {
        SqlDataAdapter daStaff,daStaffDetails,daJr;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBStaff;
        SqlCommand cmbStaffDetails;
        SqlCommandBuilder cmdJr;
        DataRow drStaff;
        DataRow drJr;
        DataRow drStaffDetails;
        SqlConnection conn;
        String connStr, sqlStaff,sqlStaffDetails,sqlJr;
        int selectedTab = 0;
        bool staffSelected = false;
        int staffIDSelected = 0;
        int IDNumber = 0;
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void FrmStaff_Shown(object sender, EventArgs e)
        {
            tabStaff.TabPages[0].CausesValidation = true;
            tabStaff.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabStaff.TabPages[2].CausesValidation = true;
            tabStaff.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        private void Staff_load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = .\ADAM-PC; Initial Catalog = Kaizen;Integrated Security = true ";
            connStr = @"Data Source = .\GARETHSSQL; Initial Catalog = Kaizen;Integrated Security = true ";
            //connStr = @"Data Source = .; Initial Catalog = Kaizen;Integrated Security = true ";

            sqlStaffDetails = @"Select StaffID,StaffSName, StaffFName,StaffSName+','+StaffFName as name,Job, JobDesc, StaffTel, StaffEmail from staff where StaffSName LIKE @Name Order by StaffID";
            conn = new SqlConnection(connStr);
            cmbStaffDetails = new SqlCommand(sqlStaffDetails, conn);
            cmbStaffDetails.Parameters.Add("@Name", SqlDbType.VarChar);
            daStaffDetails = new SqlDataAdapter(cmbStaffDetails);
            daStaffDetails.FillSchema(dsKaizen, SchemaType.Source, "Staff");

            sqlStaff = @"select * from Staff order by StaffID";
            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            cmdBStaff = new SqlCommandBuilder(daStaff);

            daStaff.FillSchema(dsKaizen, SchemaType.Source, "Staff");
            daStaff.Fill(dsKaizen, "Staff");
            dgvStaff.DataSource = dsKaizen.Tables["Staff"];
            dgvStaff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            sqlJr = @"select * from JobRole";
            daJr = new SqlDataAdapter(sqlJr, connStr);
            cmdJr = new SqlCommandBuilder(daStaff);
            daJr.FillSchema(dsKaizen, SchemaType.Source, "JobRole");
            daJr.Fill(dsKaizen, "JobRole");
            cmbAJr.DataSource = dsKaizen.Tables["JobRole"];
            cmbAJr.ValueMember = "Job";
            cmbAJr.DisplayMember = "Job";

            tabStaff.SelectedIndex = 1;
            tabStaff.SelectedIndex = 0;
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                staffSelected = false;
                staffIDSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {

                staffSelected = true;
                seperateNumber(dgvStaff.SelectedRows[0].Cells[0].Value.ToString());
                staffIDSelected = IDNumber;
            }
        }

        void DispTabValidate(object sender, EventArgs e)
        {
            if (staffSelected == false && staffIDSelected == 0)
            {
                staffSelected = false;
                staffIDSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                seperateNumber(dgvStaff.SelectedRows[0].Cells[0].Value.ToString());
                staffIDSelected = IDNumber;

            }
        }
        void EditTabValidate(object sender, EventArgs e)
        {
            if (staffSelected == false && staffIDSelected == 0)
            {
                staffSelected = false;
                staffIDSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                seperateNumber(dgvStaff.SelectedRows[0].Cells[0].Value.ToString());
                staffIDSelected = IDNumber;


            }
        }

        private void FrmStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabStaff.SelectedIndex;
            tabStaff.TabPages[tabStaff.SelectedIndex].Focus();
            tabStaff.TabPages[tabStaff.SelectedIndex].CausesValidation = true;

            if (dgvStaff.SelectedRows.Count == 0 && (tabStaff.SelectedIndex == 1 || tabStaff.SelectedIndex == 3 || tabStaff.SelectedIndex == 4))
                tabStaff.TabPages[tabStaff.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabStaff.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Staff"].Clear();
                            daStaff.Fill(dsKaizen, "Staff");

                            break;
                        }
                    case 1:
                        {
                            if (staffIDSelected == 0)
                            {
                                tabStaff.SelectedIndex = 0;
                                
                                break;
                            }
                            else
                            {


                                try
                                {
                                    
                                   

                                    dsKaizen.Tables["Staff"].Clear();
                                    

                                   


                                }
                                catch (MyException ex)
                                {
                                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Not Found!");
                                }

                            }
                            break;

                        }

                    case 2:
                        {
                            int noRows = dsKaizen.Tables["Staff"].Rows.Count;

                            if (noRows == 0)
                                lblAddStaffID.Text = "ST-5000";
                            else
                            {
                                getStaffID(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
                            break;

                        }
                    case 3:
                        {
                            if (staffIDSelected == 0)
                            {
                                tabStaff.SelectedIndex = 0;
                                break;
                            }
                            else
                            {


                                lblEdStaffID.Text = "ST-" + staffIDSelected.ToString();

                                drStaff = dsKaizen.Tables["Staff"].Rows.Find(lblEdStaffID.Text);

                                txtEdForeN.Text = drStaff["StaffFName"].ToString();
                                txtEdSurN.Text = drStaff["StaffSName"].ToString();
                                txtEdJobR.Text = drStaff["Job"].ToString();
                                txtEdJobDesc.Text = drStaff["JobDesc"].ToString();
                                txtEdEmail.Text = drStaff["StaffEmail"].ToString();
                                txtEdTel.Text = drStaff["StaffTel"].ToString();

                                disableEditTxtboxes();

                                break;

                            }
                        }
                    case 4:
                        {
                            if (staffIDSelected == 0)
                            {
                                tabStaff.SelectedIndex = 0;
                                break;
                            }
                            txtDeStaffID.Text = "ST-" + staffIDSelected.ToString();


                            drStaff = dsKaizen.Tables["Staff"].Rows.Find(txtDeStaffID.Text);


                            txtDeForeN.Text = drStaff["StaffFName"].ToString();
                            txtDeSurN.Text = drStaff["StaffSName"].ToString();
                            txtDeJobR.Text = drStaff["Job"].ToString();
                            txtDeJobDesc.Text = drStaff["JobDesc"].ToString();
                            txtDeEmail.Text = drStaff["StaffEmail"].ToString();
                            txtDeTel.Text = drStaff["StaffTel"].ToString();



                            break;
                        }




                }
            }
        }

        void seperateNumber(string ID)
        {

            char[] spearator = { '-' };

            String[] strlist = ID.Split(spearator);

            IDNumber = Convert.ToInt32(strlist[1]);

        }

        private void getStaffID(int noRows)
        {

            drStaff = dsKaizen.Tables["Staff"].Rows[noRows - 1];
            seperateNumber(drStaff["StaffID"].ToString());
            lblAddStaffID.Text = "ST-" + (IDNumber + 1).ToString();

        }

        private void disableEditTxtboxes()
        {

            txtEdForeN.Enabled = false;
            txtEdSurN.Enabled = false;
            txtEdJobR.Enabled = false;
            txtEdJobDesc.Enabled = false;
            txtEdEmail.Enabled = false;
            txtEdTel.Enabled = false;

        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            clearAddForm();
        }

        private void btnAAStaff_Click(object sender, EventArgs e)
        {
            MyStaff myStaff = new MyStaff();
            bool ok = true;
            errP.Clear();
            try
            {
                myStaff.StaffID = lblAddStaffID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddStaffID, MyEx.toString());
            }

            try
            {
                myStaff.Email = txtAEmail.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAEmail, MyEx.toString());
            }

            try
            {
                myStaff.Forename = txtAForeN.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAForeN, MyEx.toString());
            }


            try
            {
                myStaff.TelNo = txtATel.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtATel, MyEx.toString());
            }

            try
            {
                myStaff.Job = cmbAJr.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAJr, MyEx.toString());
            }

            try
            {
                myStaff.Surname = txtASurN.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtASurN, MyEx.toString());
            }
            try
            {
                myStaff.JobDescription = txtAJobDesc.Text.Trim();
            }

            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAJobDesc, MyEx.toString());
            }


            try
            {
                if (ok)
                {
                    drStaff = dsKaizen.Tables["Staff"].NewRow();
                    drStaff["StaffID"] = myStaff.StaffID;
                    drStaff["StaffFName"] = myStaff.Forename;
                    drStaff["StaffSName"] = myStaff.Surname;
                    drStaff["Job"] = myStaff.Job;
                    drStaff["JobDesc"] = myStaff.JobDescription;
                    drStaff["StaffEmail"] = myStaff.Email;
                    drStaff["StaffTel"] = myStaff.TelNo;

                    dsKaizen.Tables["Staff"].Rows.Add(drStaff);
                    daStaff.Update(dsKaizen, "Staff");

                    MessageBox.Show("Employee Added");

                    if (MessageBox.Show("Do you wish to add another Employee?", "Add Employee", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();

                        getStaffID(dsKaizen.Tables["Staff"].Rows.Count);
                    }
                    else
                        tabStaff.SelectedIndex = 0;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdEdit_Click(object sender, EventArgs e)
        {
            if (btnEdEdit.Text.Trim() == "EDIT")
            {

                enableEditTxtboxes();
                btnEdEdit.Text = "Save";
            }
            else
            {
                MyStaff myStaff = new MyStaff();
                bool ok = true;
                errP.Clear();
                try
                {
                    myStaff.StaffID = lblEdStaffID.Text.Trim();

                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEdStaffID, MyEx.toString());
                }

                try
                {
                    myStaff.Email = txtEdEmail.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdEmail, MyEx.toString());
                }

                try
                {
                    myStaff.Forename = txtEdForeN.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdForeN, MyEx.toString());
                }


                try
                {
                    myStaff.TelNo = txtEdTel.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdTel, MyEx.toString());
                }

                try
                {
                    myStaff.Job = txtEdJobR.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdJobR, MyEx.toString());
                }

                try
                {
                    myStaff.Surname = txtEdSurN.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdSurN, MyEx.toString());
                }
                try
                {
                    myStaff.JobDescription = txtEdJobDesc.Text.Trim();
                }

                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEdJobDesc, MyEx.toString());
                }
                try
                {
                    if (ok)
                    {
                        drStaff.BeginEdit();
                       
                        drStaff["StaffID"] = myStaff.StaffID;
                        drStaff["StaffFName"] = myStaff.Forename;
                        drStaff["StaffSName"] = myStaff.Surname;
                        drStaff["Job"] = myStaff.Job;
                        drStaff["JobDesc"] = myStaff.JobDescription;
                        drStaff["StaffEmail"] = myStaff.Email;
                        drStaff["StaffTel"] = myStaff.TelNo;

                        drStaff.EndEdit();
                        daStaff.Update(dsKaizen, "Staff");

                        btnEdEdit.Text = "EDIT";
                        
                        MessageBox.Show("Employee Details Updated", "Staff");

                        

                        
                        tabStaff.SelectedIndex = 0;

                        disableEditTxtboxes();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error !", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }



            }
        }

        void clearAddForm()
        {
            txtAEmail.Clear();
            txtAForeN.Clear();
            txtAJobDesc.Clear();
            cmbAJr.SelectedIndex=0;
            txtASurN.Clear();
            txtATel.Clear();

        }

        private void btnDeDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Employee from the list.", "Select Employee");

            }
            else
            {
                drStaff = dsKaizen.Tables["Staff"].Rows.
                    Find(dgvStaff.SelectedRows[0].Cells[0].Value);

                string tempName = drStaff["StaffFName"].ToString() + "\'s";
                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?",
                    "Add Staff", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drStaff.Delete();
                    daStaff.Update(dsKaizen, "Staff");
                    MessageBox.Show("Details Removed for " + tempName);
                    //clearDeleteForm();
                    IDNumber += 1;
                    tabStaff.SelectedIndex = 0;
                }
                
            }
        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void lbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void iconSearchStaffID_Click(object sender, EventArgs e)
        {
            
            String str = txtSeName.Text.Trim();

            dsKaizen.Tables["Staff"].Clear();
            fillListboxStaff(str);
            fillListboxID(str);
        }

        private void btnDisSearch_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 1;
        }

        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 2;
        }

        private void btnDisEdit_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 3;
            disableEditTxtboxes();
        }

        private void btnDisDel_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 4;
            txtDeEmail.Enabled = false;
            txtDeForeN.Enabled = false;
            txtDeJobR.Enabled = false;
            txtDeStaffID.Enabled = false;
            txtDeSurN.Enabled = false;
            txtDeTel.Enabled = false;
            txtDeJobDesc.Enabled = false;
        }

        private void txtSearchDisStaff_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enableEditTxtboxes()
        {
            txtEdForeN.Enabled = true;
            txtEdSurN.Enabled = true;
            txtEdJobR.Enabled = true;
            txtEdJobDesc.Enabled = true;
            txtEdEmail.Enabled = true;
            txtEdTel.Enabled = true;
        }

        private void fillListboxStaff(String str)
        {
            cmbStaffDetails.Parameters["@Name"].Value = str + "%";
            daStaffDetails.Fill(dsKaizen, "Staff");

            lbStaff.DataSource = dsKaizen.Tables["Staff"];
            lbStaff.DisplayMember = "name";
            lbStaff.ValueMember = "StaffID";
        }
        private void fillListboxID(String str)
        {
            cmbStaffDetails.Parameters["@Name"].Value = str + "%";
            daStaffDetails.Fill(dsKaizen, "Staff");

            lbID.DataSource = dsKaizen.Tables["Staff"];
            lbID.DisplayMember = "StaffID";
            lbID.ValueMember = "StaffID";

            lbJob.DataSource = dsKaizen.Tables["Staff"];
            lbJob.DisplayMember = "Job";
            lbJob.ValueMember = "StaffID";

            lbJobDesc.DataSource = dsKaizen.Tables["Staff"];
            lbJobDesc.DisplayMember = "JobDesc";
            lbJobDesc.ValueMember = "StaffID";

            lbEmail.DataSource = dsKaizen.Tables["Staff"];
            lbEmail.DisplayMember = "StaffEmail";
            lbEmail.ValueMember = "StaffID";

            lbTel.DataSource = dsKaizen.Tables["Staff"];
            lbTel.DisplayMember = "StaffTel";
            lbTel.ValueMember = "StaffID";

        }


    }
}
