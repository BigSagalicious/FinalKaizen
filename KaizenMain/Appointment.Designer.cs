namespace KaizenMain
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.dgvApp = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblDateB = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppTime = new System.Windows.Forms.Label();
            this.lblTransID = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblAddAppID = new System.Windows.Forms.Label();
            this.txtDateB = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.txtEdTransID = new System.Windows.Forms.TextBox();
            this.txtEDAppDate = new System.Windows.Forms.TextBox();
            this.txtEDAppTime = new System.Windows.Forms.TextBox();
            this.txtEDStaffID = new System.Windows.Forms.TextBox();
            this.txtEdDuration = new System.Windows.Forms.TextBox();
            this.txtEDDateB = new System.Windows.Forms.TextBox();
            this.lblEDStaffID = new System.Windows.Forms.Label();
            this.lblEDDuration = new System.Windows.Forms.Label();
            this.lblEDTransID = new System.Windows.Forms.Label();
            this.lblEDAppTime = new System.Windows.Forms.Label();
            this.lblEDAppDate = new System.Windows.Forms.Label();
            this.lblEdDateB = new System.Windows.Forms.Label();
            this.lblEdAppID = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSeTransID = new System.Windows.Forms.TextBox();
            this.txtSeAppDate = new System.Windows.Forms.TextBox();
            this.txtSeAppTime = new System.Windows.Forms.TextBox();
            this.txtSeStaffID = new System.Windows.Forms.TextBox();
            this.txtSeDuration = new System.Windows.Forms.TextBox();
            this.lblSeStaffID = new System.Windows.Forms.Label();
            this.lblSeDuration = new System.Windows.Forms.Label();
            this.lblSeTransID = new System.Windows.Forms.Label();
            this.lblSeAppTime = new System.Windows.Forms.Label();
            this.lblSeAppDate = new System.Windows.Forms.Label();
            this.lblSeDateB = new System.Windows.Forms.Label();
            this.lblSeAppID = new System.Windows.Forms.Label();
            this.txtSeDateB = new System.Windows.Forms.TextBox();
            this.iconSearchAppID = new System.Windows.Forms.PictureBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.pbEdSearch = new System.Windows.Forms.PictureBox();
            this.txtEdSearch = new System.Windows.Forms.TextBox();
            this.pbDlSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtDLSearch = new System.Windows.Forms.TextBox();
            this.btnAddApp = new KaizenMain.RoundButton();
            this.tabApp.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearchAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDlSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabApp
            // 
            this.tabApp.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabApp.Controls.Add(this.tabDisplay);
            this.tabApp.Controls.Add(this.tabSearch);
            this.tabApp.Controls.Add(this.tabAdd);
            this.tabApp.Controls.Add(this.tabEdit);
            this.tabApp.Controls.Add(this.tabDelete);
            this.tabApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabApp.ItemSize = new System.Drawing.Size(145, 25);
            this.tabApp.Location = new System.Drawing.Point(4, 2);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(742, 721);
            this.tabApp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabApp.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDisplay.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabDisplay.Controls.Add(this.btnAddApp);
            this.tabDisplay.Controls.Add(this.dateTimePicker1);
            this.tabDisplay.Controls.Add(this.dgvApp);
            this.tabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(734, 688);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "DISPLAY";
            // 
            // tabAdd
            // 
            this.tabAdd.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdd.Controls.Add(this.txtTransID);
            this.tabAdd.Controls.Add(this.txtAppDate);
            this.tabAdd.Controls.Add(this.txtAppTime);
            this.tabAdd.Controls.Add(this.txtStaffID);
            this.tabAdd.Controls.Add(this.txtDuration);
            this.tabAdd.Controls.Add(this.txtDateB);
            this.tabAdd.Controls.Add(this.lblAddAppID);
            this.tabAdd.Controls.Add(this.lblStaffID);
            this.tabAdd.Controls.Add(this.lblDuration);
            this.tabAdd.Controls.Add(this.lblTransID);
            this.tabAdd.Controls.Add(this.lblAppTime);
            this.tabAdd.Controls.Add(this.lblAppDate);
            this.tabAdd.Controls.Add(this.lblDateB);
            this.tabAdd.Controls.Add(this.lblAppID);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(734, 688);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "ADD";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabEdit
            // 
            this.tabEdit.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEdit.Controls.Add(this.pbEdSearch);
            this.tabEdit.Controls.Add(this.txtEdSearch);
            this.tabEdit.Controls.Add(this.txtEdTransID);
            this.tabEdit.Controls.Add(this.txtEDAppDate);
            this.tabEdit.Controls.Add(this.txtEDAppTime);
            this.tabEdit.Controls.Add(this.txtEDStaffID);
            this.tabEdit.Controls.Add(this.txtEdDuration);
            this.tabEdit.Controls.Add(this.txtEDDateB);
            this.tabEdit.Controls.Add(this.lblEDStaffID);
            this.tabEdit.Controls.Add(this.lblEDDuration);
            this.tabEdit.Controls.Add(this.lblEDTransID);
            this.tabEdit.Controls.Add(this.lblEDAppTime);
            this.tabEdit.Controls.Add(this.lblEDAppDate);
            this.tabEdit.Controls.Add(this.lblEdDateB);
            this.tabEdit.Controls.Add(this.lblEdAppID);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(734, 688);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "EDIT";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            this.tabDelete.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDelete.Controls.Add(this.pbDlSearchIcon);
            this.tabDelete.Controls.Add(this.txtDLSearch);
            this.tabDelete.Controls.Add(this.textBox13);
            this.tabDelete.Controls.Add(this.textBox14);
            this.tabDelete.Controls.Add(this.textBox15);
            this.tabDelete.Controls.Add(this.textBox16);
            this.tabDelete.Controls.Add(this.textBox17);
            this.tabDelete.Controls.Add(this.textBox18);
            this.tabDelete.Controls.Add(this.label10);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.label12);
            this.tabDelete.Controls.Add(this.label13);
            this.tabDelete.Controls.Add(this.label14);
            this.tabDelete.Controls.Add(this.label15);
            this.tabDelete.Controls.Add(this.label16);
            this.tabDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDelete.Location = new System.Drawing.Point(4, 29);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(734, 688);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "DELETE";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // dgvApp
            // 
            this.dgvApp.AllowUserToOrderColumns = true;
            this.dgvApp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApp.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApp.Location = new System.Drawing.Point(74, 144);
            this.dgvApp.Name = "dgvApp";
            this.dgvApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvApp.Size = new System.Drawing.Size(572, 274);
            this.dgvApp.TabIndex = 0;
            this.dgvApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApp_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabSearch
            // 
            this.tabSearch.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSearch.Controls.Add(this.iconSearchAppID);
            this.tabSearch.Controls.Add(this.txtSearchID);
            this.tabSearch.Controls.Add(this.txtSeDateB);
            this.tabSearch.Controls.Add(this.txtSeTransID);
            this.tabSearch.Controls.Add(this.txtSeAppDate);
            this.tabSearch.Controls.Add(this.txtSeAppTime);
            this.tabSearch.Controls.Add(this.txtSeStaffID);
            this.tabSearch.Controls.Add(this.txtSeDuration);
            this.tabSearch.Controls.Add(this.lblSeStaffID);
            this.tabSearch.Controls.Add(this.lblSeDuration);
            this.tabSearch.Controls.Add(this.lblSeTransID);
            this.tabSearch.Controls.Add(this.lblSeAppTime);
            this.tabSearch.Controls.Add(this.lblSeAppDate);
            this.tabSearch.Controls.Add(this.lblSeDateB);
            this.tabSearch.Controls.Add(this.lblSeAppID);
            this.tabSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(734, 688);
            this.tabSearch.TabIndex = 4;
            this.tabSearch.Text = "SEARCH";
            this.tabSearch.UseVisualStyleBackColor = true;
            this.tabSearch.Click += new System.EventHandler(this.tabSearch_Click);
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppID.Location = new System.Drawing.Point(53, 54);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(60, 20);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "AppID";
            this.lblAppID.Click += new System.EventHandler(this.lblAppID_Click);
            // 
            // lblDateB
            // 
            this.lblDateB.AutoSize = true;
            this.lblDateB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateB.Location = new System.Drawing.Point(53, 103);
            this.lblDateB.Name = "lblDateB";
            this.lblDateB.Size = new System.Drawing.Size(114, 20);
            this.lblDateB.TabIndex = 1;
            this.lblDateB.Text = "Date Booked";
            this.lblDateB.Click += new System.EventHandler(this.lblDateB_Click);
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppDate.Location = new System.Drawing.Point(53, 152);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(155, 20);
            this.lblAppDate.TabIndex = 2;
            this.lblAppDate.Text = "Appointment Date";
            this.lblAppDate.Click += new System.EventHandler(this.lblAppDate_Click);
            // 
            // lblAppTime
            // 
            this.lblAppTime.AutoSize = true;
            this.lblAppTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppTime.Location = new System.Drawing.Point(53, 196);
            this.lblAppTime.Name = "lblAppTime";
            this.lblAppTime.Size = new System.Drawing.Size(154, 20);
            this.lblAppTime.TabIndex = 3;
            this.lblAppTime.Text = "Appointment Time";
            this.lblAppTime.Click += new System.EventHandler(this.lblAppTime_Click);
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransID.Location = new System.Drawing.Point(58, 327);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(73, 20);
            this.lblTransID.TabIndex = 4;
            this.lblTransID.Text = "TransID";
            this.lblTransID.Click += new System.EventHandler(this.lblTransID_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDuration.Location = new System.Drawing.Point(53, 277);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(78, 20);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaffID.Location = new System.Drawing.Point(53, 232);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(73, 20);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Staff ID";
            this.lblStaffID.Click += new System.EventHandler(this.lblStaffID_Click);
            // 
            // lblAddAppID
            // 
            this.lblAddAppID.AutoSize = true;
            this.lblAddAppID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddAppID.Location = new System.Drawing.Point(259, 54);
            this.lblAddAppID.Name = "lblAddAppID";
            this.lblAddAppID.Size = new System.Drawing.Size(15, 20);
            this.lblAddAppID.TabIndex = 7;
            this.lblAddAppID.Text = "-";
            this.lblAddAppID.Click += new System.EventHandler(this.lblAddAppID_Click);
            // 
            // txtDateB
            // 
            this.txtDateB.Location = new System.Drawing.Point(243, 97);
            this.txtDateB.Name = "txtDateB";
            this.txtDateB.Size = new System.Drawing.Size(229, 26);
            this.txtDateB.TabIndex = 9;
            this.txtDateB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(243, 271);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(229, 26);
            this.txtDuration.TabIndex = 10;
            this.txtDuration.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(243, 229);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(229, 26);
            this.txtStaffID.TabIndex = 11;
            this.txtStaffID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAppTime
            // 
            this.txtAppTime.Location = new System.Drawing.Point(243, 193);
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(229, 26);
            this.txtAppTime.TabIndex = 12;
            this.txtAppTime.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(243, 146);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.Size = new System.Drawing.Size(229, 26);
            this.txtAppDate.TabIndex = 13;
            this.txtAppDate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(243, 321);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(229, 26);
            this.txtTransID.TabIndex = 14;
            // 
            // txtEdTransID
            // 
            this.txtEdTransID.Location = new System.Drawing.Point(235, 333);
            this.txtEdTransID.Name = "txtEdTransID";
            this.txtEdTransID.Size = new System.Drawing.Size(229, 26);
            this.txtEdTransID.TabIndex = 28;
            // 
            // txtEDAppDate
            // 
            this.txtEDAppDate.Location = new System.Drawing.Point(235, 155);
            this.txtEDAppDate.Name = "txtEDAppDate";
            this.txtEDAppDate.Size = new System.Drawing.Size(229, 26);
            this.txtEDAppDate.TabIndex = 27;
            // 
            // txtEDAppTime
            // 
            this.txtEDAppTime.Location = new System.Drawing.Point(235, 202);
            this.txtEDAppTime.Name = "txtEDAppTime";
            this.txtEDAppTime.Size = new System.Drawing.Size(229, 26);
            this.txtEDAppTime.TabIndex = 26;
            // 
            // txtEDStaffID
            // 
            this.txtEDStaffID.Location = new System.Drawing.Point(235, 238);
            this.txtEDStaffID.Name = "txtEDStaffID";
            this.txtEDStaffID.Size = new System.Drawing.Size(229, 26);
            this.txtEDStaffID.TabIndex = 25;
            // 
            // txtEdDuration
            // 
            this.txtEdDuration.Location = new System.Drawing.Point(235, 280);
            this.txtEdDuration.Name = "txtEdDuration";
            this.txtEdDuration.Size = new System.Drawing.Size(229, 26);
            this.txtEdDuration.TabIndex = 24;
            // 
            // txtEDDateB
            // 
            this.txtEDDateB.Location = new System.Drawing.Point(235, 109);
            this.txtEDDateB.Name = "txtEDDateB";
            this.txtEDDateB.Size = new System.Drawing.Size(229, 26);
            this.txtEDDateB.TabIndex = 23;
            // 
            // lblEDStaffID
            // 
            this.lblEDStaffID.AutoSize = true;
            this.lblEDStaffID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEDStaffID.Location = new System.Drawing.Point(54, 241);
            this.lblEDStaffID.Name = "lblEDStaffID";
            this.lblEDStaffID.Size = new System.Drawing.Size(73, 20);
            this.lblEDStaffID.TabIndex = 21;
            this.lblEDStaffID.Text = "Staff ID";
            // 
            // lblEDDuration
            // 
            this.lblEDDuration.AutoSize = true;
            this.lblEDDuration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEDDuration.Location = new System.Drawing.Point(54, 283);
            this.lblEDDuration.Name = "lblEDDuration";
            this.lblEDDuration.Size = new System.Drawing.Size(78, 20);
            this.lblEDDuration.TabIndex = 20;
            this.lblEDDuration.Text = "Duration";
            // 
            // lblEDTransID
            // 
            this.lblEDTransID.AutoSize = true;
            this.lblEDTransID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEDTransID.Location = new System.Drawing.Point(59, 333);
            this.lblEDTransID.Name = "lblEDTransID";
            this.lblEDTransID.Size = new System.Drawing.Size(73, 20);
            this.lblEDTransID.TabIndex = 19;
            this.lblEDTransID.Text = "TransID";
            // 
            // lblEDAppTime
            // 
            this.lblEDAppTime.AutoSize = true;
            this.lblEDAppTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEDAppTime.Location = new System.Drawing.Point(54, 202);
            this.lblEDAppTime.Name = "lblEDAppTime";
            this.lblEDAppTime.Size = new System.Drawing.Size(154, 20);
            this.lblEDAppTime.TabIndex = 18;
            this.lblEDAppTime.Text = "Appointment Time";
            // 
            // lblEDAppDate
            // 
            this.lblEDAppDate.AutoSize = true;
            this.lblEDAppDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEDAppDate.Location = new System.Drawing.Point(53, 155);
            this.lblEDAppDate.Name = "lblEDAppDate";
            this.lblEDAppDate.Size = new System.Drawing.Size(155, 20);
            this.lblEDAppDate.TabIndex = 17;
            this.lblEDAppDate.Text = "Appointment Date";
            // 
            // lblEdDateB
            // 
            this.lblEdDateB.AutoSize = true;
            this.lblEdDateB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdDateB.Location = new System.Drawing.Point(53, 109);
            this.lblEdDateB.Name = "lblEdDateB";
            this.lblEdDateB.Size = new System.Drawing.Size(114, 20);
            this.lblEdDateB.TabIndex = 16;
            this.lblEdDateB.Text = "Date Booked";
            // 
            // lblEdAppID
            // 
            this.lblEdAppID.AutoSize = true;
            this.lblEdAppID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdAppID.Location = new System.Drawing.Point(53, 54);
            this.lblEdAppID.Name = "lblEdAppID";
            this.lblEdAppID.Size = new System.Drawing.Size(60, 20);
            this.lblEdAppID.TabIndex = 15;
            this.lblEdAppID.Text = "AppID";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(256, 325);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(229, 26);
            this.textBox13.TabIndex = 28;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(256, 150);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(229, 26);
            this.textBox14.TabIndex = 27;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(256, 197);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(229, 26);
            this.textBox15.TabIndex = 26;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(256, 233);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(229, 26);
            this.textBox16.TabIndex = 25;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(256, 275);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(229, 26);
            this.textBox17.TabIndex = 24;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(256, 101);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(229, 26);
            this.textBox18.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(57, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Staff ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(57, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(57, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "TransID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(57, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Appointment Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(57, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Appointment Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(57, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Date Booked";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(57, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "AppID";
            // 
            // txtSeTransID
            // 
            this.txtSeTransID.Location = new System.Drawing.Point(252, 321);
            this.txtSeTransID.Name = "txtSeTransID";
            this.txtSeTransID.Size = new System.Drawing.Size(229, 26);
            this.txtSeTransID.TabIndex = 28;
            // 
            // txtSeAppDate
            // 
            this.txtSeAppDate.Location = new System.Drawing.Point(252, 146);
            this.txtSeAppDate.Name = "txtSeAppDate";
            this.txtSeAppDate.Size = new System.Drawing.Size(229, 26);
            this.txtSeAppDate.TabIndex = 27;
            // 
            // txtSeAppTime
            // 
            this.txtSeAppTime.Location = new System.Drawing.Point(252, 193);
            this.txtSeAppTime.Name = "txtSeAppTime";
            this.txtSeAppTime.Size = new System.Drawing.Size(229, 26);
            this.txtSeAppTime.TabIndex = 26;
            // 
            // txtSeStaffID
            // 
            this.txtSeStaffID.Location = new System.Drawing.Point(252, 229);
            this.txtSeStaffID.Name = "txtSeStaffID";
            this.txtSeStaffID.Size = new System.Drawing.Size(229, 26);
            this.txtSeStaffID.TabIndex = 25;
            // 
            // txtSeDuration
            // 
            this.txtSeDuration.Location = new System.Drawing.Point(252, 271);
            this.txtSeDuration.Name = "txtSeDuration";
            this.txtSeDuration.Size = new System.Drawing.Size(229, 26);
            this.txtSeDuration.TabIndex = 24;
            // 
            // lblSeStaffID
            // 
            this.lblSeStaffID.AutoSize = true;
            this.lblSeStaffID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeStaffID.Location = new System.Drawing.Point(53, 235);
            this.lblSeStaffID.Name = "lblSeStaffID";
            this.lblSeStaffID.Size = new System.Drawing.Size(73, 20);
            this.lblSeStaffID.TabIndex = 21;
            this.lblSeStaffID.Text = "Staff ID";
            // 
            // lblSeDuration
            // 
            this.lblSeDuration.AutoSize = true;
            this.lblSeDuration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeDuration.Location = new System.Drawing.Point(53, 277);
            this.lblSeDuration.Name = "lblSeDuration";
            this.lblSeDuration.Size = new System.Drawing.Size(78, 20);
            this.lblSeDuration.TabIndex = 20;
            this.lblSeDuration.Text = "Duration";
            // 
            // lblSeTransID
            // 
            this.lblSeTransID.AutoSize = true;
            this.lblSeTransID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeTransID.Location = new System.Drawing.Point(53, 327);
            this.lblSeTransID.Name = "lblSeTransID";
            this.lblSeTransID.Size = new System.Drawing.Size(73, 20);
            this.lblSeTransID.TabIndex = 19;
            this.lblSeTransID.Text = "TransID";
            // 
            // lblSeAppTime
            // 
            this.lblSeAppTime.AutoSize = true;
            this.lblSeAppTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeAppTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeAppTime.Location = new System.Drawing.Point(53, 196);
            this.lblSeAppTime.Name = "lblSeAppTime";
            this.lblSeAppTime.Size = new System.Drawing.Size(154, 20);
            this.lblSeAppTime.TabIndex = 18;
            this.lblSeAppTime.Text = "Appointment Time";
            // 
            // lblSeAppDate
            // 
            this.lblSeAppDate.AutoSize = true;
            this.lblSeAppDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeAppDate.Location = new System.Drawing.Point(53, 152);
            this.lblSeAppDate.Name = "lblSeAppDate";
            this.lblSeAppDate.Size = new System.Drawing.Size(155, 20);
            this.lblSeAppDate.TabIndex = 17;
            this.lblSeAppDate.Text = "Appointment Date";
            // 
            // lblSeDateB
            // 
            this.lblSeDateB.AutoSize = true;
            this.lblSeDateB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeDateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeDateB.Location = new System.Drawing.Point(53, 103);
            this.lblSeDateB.Name = "lblSeDateB";
            this.lblSeDateB.Size = new System.Drawing.Size(114, 20);
            this.lblSeDateB.TabIndex = 16;
            this.lblSeDateB.Text = "Date Booked";
            // 
            // lblSeAppID
            // 
            this.lblSeAppID.AutoSize = true;
            this.lblSeAppID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeAppID.Location = new System.Drawing.Point(53, 54);
            this.lblSeAppID.Name = "lblSeAppID";
            this.lblSeAppID.Size = new System.Drawing.Size(60, 20);
            this.lblSeAppID.TabIndex = 15;
            this.lblSeAppID.Text = "AppID";
            // 
            // txtSeDateB
            // 
            this.txtSeDateB.Location = new System.Drawing.Point(252, 105);
            this.txtSeDateB.Name = "txtSeDateB";
            this.txtSeDateB.Size = new System.Drawing.Size(229, 26);
            this.txtSeDateB.TabIndex = 29;
            // 
            // iconSearchAppID
            // 
            this.iconSearchAppID.BackColor = System.Drawing.Color.Transparent;
            this.iconSearchAppID.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.iconSearchAppID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconSearchAppID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSearchAppID.Location = new System.Drawing.Point(368, 49);
            this.iconSearchAppID.Name = "iconSearchAppID";
            this.iconSearchAppID.Size = new System.Drawing.Size(43, 31);
            this.iconSearchAppID.TabIndex = 226;
            this.iconSearchAppID.TabStop = false;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(252, 51);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(110, 26);
            this.txtSearchID.TabIndex = 225;
            // 
            // pbEdSearch
            // 
            this.pbEdSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbEdSearch.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pbEdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdSearch.Location = new System.Drawing.Point(362, 43);
            this.pbEdSearch.Name = "pbEdSearch";
            this.pbEdSearch.Size = new System.Drawing.Size(43, 31);
            this.pbEdSearch.TabIndex = 226;
            this.pbEdSearch.TabStop = false;
            // 
            // txtEdSearch
            // 
            this.txtEdSearch.Location = new System.Drawing.Point(235, 48);
            this.txtEdSearch.Name = "txtEdSearch";
            this.txtEdSearch.Size = new System.Drawing.Size(110, 26);
            this.txtEdSearch.TabIndex = 225;
            // 
            // pbDlSearchIcon
            // 
            this.pbDlSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbDlSearchIcon.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pbDlSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDlSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDlSearchIcon.Location = new System.Drawing.Point(372, 50);
            this.pbDlSearchIcon.Name = "pbDlSearchIcon";
            this.pbDlSearchIcon.Size = new System.Drawing.Size(43, 31);
            this.pbDlSearchIcon.TabIndex = 226;
            this.pbDlSearchIcon.TabStop = false;
            // 
            // txtDLSearch
            // 
            this.txtDLSearch.Location = new System.Drawing.Point(256, 52);
            this.txtDLSearch.Name = "txtDLSearch";
            this.txtDLSearch.Size = new System.Drawing.Size(110, 26);
            this.txtDLSearch.TabIndex = 225;
            // 
            // btnAddApp
            // 
            this.btnAddApp.BorderColor = System.Drawing.Color.Silver;
            this.btnAddApp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnAddApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApp.FlatAppearance.BorderSize = 0;
            this.btnAddApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApp.Location = new System.Drawing.Point(74, 69);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddApp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnAddApp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddApp.Size = new System.Drawing.Size(214, 40);
            this.btnAddApp.TabIndex = 222;
            this.btnAddApp.Text = "ADD APPOINTMENT";
            this.btnAddApp.TextColor = System.Drawing.Color.White;
            this.btnAddApp.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 698);
            this.Controls.Add(this.tabApp);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.tabApp.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearchAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDlSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.DataGridView dgvApp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private RoundButton btnAddApp;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblTransID;
        private System.Windows.Forms.Label lblAppTime;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblDateB;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDateB;
        private System.Windows.Forms.Label lblAddAppID;
        private System.Windows.Forms.TextBox txtSeTransID;
        private System.Windows.Forms.TextBox txtSeAppDate;
        private System.Windows.Forms.TextBox txtSeAppTime;
        private System.Windows.Forms.TextBox txtSeStaffID;
        private System.Windows.Forms.TextBox txtSeDuration;
        private System.Windows.Forms.Label lblSeStaffID;
        private System.Windows.Forms.Label lblSeDuration;
        private System.Windows.Forms.Label lblSeTransID;
        private System.Windows.Forms.Label lblSeAppTime;
        private System.Windows.Forms.Label lblSeAppDate;
        private System.Windows.Forms.Label lblSeDateB;
        private System.Windows.Forms.Label lblSeAppID;
        private System.Windows.Forms.TextBox txtEdTransID;
        private System.Windows.Forms.TextBox txtEDAppDate;
        private System.Windows.Forms.TextBox txtEDAppTime;
        private System.Windows.Forms.TextBox txtEDStaffID;
        private System.Windows.Forms.TextBox txtEdDuration;
        private System.Windows.Forms.TextBox txtEDDateB;
        private System.Windows.Forms.Label lblEDStaffID;
        private System.Windows.Forms.Label lblEDDuration;
        private System.Windows.Forms.Label lblEDTransID;
        private System.Windows.Forms.Label lblEDAppTime;
        private System.Windows.Forms.Label lblEDAppDate;
        private System.Windows.Forms.Label lblEdDateB;
        private System.Windows.Forms.Label lblEdAppID;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSeDateB;
        private System.Windows.Forms.PictureBox iconSearchAppID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.PictureBox pbEdSearch;
        private System.Windows.Forms.TextBox txtEdSearch;
        private System.Windows.Forms.PictureBox pbDlSearchIcon;
        private System.Windows.Forms.TextBox txtDLSearch;
    }
}