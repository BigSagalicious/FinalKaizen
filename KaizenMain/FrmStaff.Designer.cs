namespace KaizenMain
{
    partial class FrmStaff
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
            this.components = new System.ComponentModel.Container();
            this.tabStaff = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnDisEdit = new KaizenMain.RoundButton();
            this.btnDisSearch = new KaizenMain.RoundButton();
            this.btnDisAdd = new KaizenMain.RoundButton();
            this.btnDisDel = new KaizenMain.RoundButton();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.lbTel = new System.Windows.Forms.ListBox();
            this.lbEmail = new System.Windows.Forms.ListBox();
            this.lbJobDesc = new System.Windows.Forms.ListBox();
            this.lbJob = new System.Windows.Forms.ListBox();
            this.lbID = new System.Windows.Forms.ListBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.txtSeName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSTelNo = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.lblSJobDesc = new System.Windows.Forms.Label();
            this.lblSJob = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.ListBox();
            this.iconSearchStaffID = new System.Windows.Forms.PictureBox();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnClearAdd = new KaizenMain.RoundButton();
            this.lblAddStaffID = new System.Windows.Forms.Label();
            this.lblAJobDesc = new System.Windows.Forms.Label();
            this.txtAJobDesc = new System.Windows.Forms.TextBox();
            this.lblAJobR = new System.Windows.Forms.Label();
            this.txtATel = new System.Windows.Forms.TextBox();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            this.txtASurN = new System.Windows.Forms.TextBox();
            this.txtAForeN = new System.Windows.Forms.TextBox();
            this.lblATelNo = new System.Windows.Forms.Label();
            this.lblAEmail = new System.Windows.Forms.Label();
            this.lblASur = new System.Windows.Forms.Label();
            this.lblAFore = new System.Windows.Forms.Label();
            this.lblAStaffID = new System.Windows.Forms.Label();
            this.btnAAStaff = new KaizenMain.RoundButton();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.lblEdStaffID = new System.Windows.Forms.Label();
            this.lblEdJobDesc = new System.Windows.Forms.Label();
            this.txtEdJobDesc = new System.Windows.Forms.TextBox();
            this.txtEdJobR = new System.Windows.Forms.TextBox();
            this.lblEdJobR = new System.Windows.Forms.Label();
            this.txtEdTel = new System.Windows.Forms.TextBox();
            this.txtEdEmail = new System.Windows.Forms.TextBox();
            this.txtEdSurN = new System.Windows.Forms.TextBox();
            this.txtEdForeN = new System.Windows.Forms.TextBox();
            this.lblEdTel = new System.Windows.Forms.Label();
            this.lblEdEmail = new System.Windows.Forms.Label();
            this.lblEdSurN = new System.Windows.Forms.Label();
            this.lblEdForeN = new System.Windows.Forms.Label();
            this.lblEdStaff = new System.Windows.Forms.Label();
            this.btnEdEdit = new KaizenMain.RoundButton();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.lblDeJobDesc = new System.Windows.Forms.Label();
            this.txtDeJobDesc = new System.Windows.Forms.TextBox();
            this.txtDeJobR = new System.Windows.Forms.TextBox();
            this.lblDeJobR = new System.Windows.Forms.Label();
            this.txtDeTel = new System.Windows.Forms.TextBox();
            this.txtDeEmail = new System.Windows.Forms.TextBox();
            this.txtDeSurN = new System.Windows.Forms.TextBox();
            this.txtDeForeN = new System.Windows.Forms.TextBox();
            this.txtDeStaffID = new System.Windows.Forms.TextBox();
            this.lblDeTel = new System.Windows.Forms.Label();
            this.lblDeEmail = new System.Windows.Forms.Label();
            this.lblDeSurN = new System.Windows.Forms.Label();
            this.lblDeForeN = new System.Windows.Forms.Label();
            this.lblDeStaffID = new System.Windows.Forms.Label();
            this.btnDeDelete = new KaizenMain.RoundButton();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbAJr = new System.Windows.Forms.ComboBox();
            this.tabStaff.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearchStaffID)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStaff
            // 
            this.tabStaff.AllowDrop = true;
            this.tabStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabStaff.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabStaff.Controls.Add(this.tabDisplay);
            this.tabStaff.Controls.Add(this.tabSearch);
            this.tabStaff.Controls.Add(this.tabAdd);
            this.tabStaff.Controls.Add(this.tabEdit);
            this.tabStaff.Controls.Add(this.tabDelete);
            this.tabStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStaff.ItemSize = new System.Drawing.Size(145, 25);
            this.tabStaff.Location = new System.Drawing.Point(0, 1);
            this.tabStaff.Multiline = true;
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.SelectedIndex = 0;
            this.tabStaff.Size = new System.Drawing.Size(742, 721);
            this.tabStaff.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStaff.TabIndex = 9;
            this.tabStaff.TabStop = false;
            this.tabStaff.SelectedIndexChanged += new System.EventHandler(this.FrmStaff_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(159)))));
            this.tabDisplay.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo3;
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDisplay.Controls.Add(this.btnDisEdit);
            this.tabDisplay.Controls.Add(this.btnDisSearch);
            this.tabDisplay.Controls.Add(this.btnDisAdd);
            this.tabDisplay.Controls.Add(this.btnDisDel);
            this.tabDisplay.Controls.Add(this.dgvStaff);
            this.tabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(734, 688);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "DISPLAY";
            // 
            // btnDisEdit
            // 
            this.btnDisEdit.BackColor = System.Drawing.Color.White;
            this.btnDisEdit.BorderColor = System.Drawing.Color.Silver;
            this.btnDisEdit.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDisEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisEdit.FlatAppearance.BorderSize = 0;
            this.btnDisEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDisEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDisEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisEdit.Location = new System.Drawing.Point(368, 344);
            this.btnDisEdit.Name = "btnDisEdit";
            this.btnDisEdit.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisEdit.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDisEdit.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisEdit.Size = new System.Drawing.Size(135, 40);
            this.btnDisEdit.TabIndex = 248;
            this.btnDisEdit.Text = "EDIT";
            this.btnDisEdit.TextColor = System.Drawing.Color.White;
            this.btnDisEdit.UseVisualStyleBackColor = false;
            this.btnDisEdit.Click += new System.EventHandler(this.btnDisEdit_Click);
            // 
            // btnDisSearch
            // 
            this.btnDisSearch.BackColor = System.Drawing.Color.White;
            this.btnDisSearch.BorderColor = System.Drawing.Color.Silver;
            this.btnDisSearch.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDisSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisSearch.FlatAppearance.BorderSize = 0;
            this.btnDisSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDisSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDisSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisSearch.Location = new System.Drawing.Point(8, 344);
            this.btnDisSearch.Name = "btnDisSearch";
            this.btnDisSearch.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisSearch.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDisSearch.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisSearch.Size = new System.Drawing.Size(126, 40);
            this.btnDisSearch.TabIndex = 247;
            this.btnDisSearch.Text = "SEARCH";
            this.btnDisSearch.TextColor = System.Drawing.Color.White;
            this.btnDisSearch.UseVisualStyleBackColor = false;
            this.btnDisSearch.Click += new System.EventHandler(this.btnDisSearch_Click);
            // 
            // btnDisAdd
            // 
            this.btnDisAdd.BackColor = System.Drawing.Color.White;
            this.btnDisAdd.BorderColor = System.Drawing.Color.Silver;
            this.btnDisAdd.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDisAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisAdd.FlatAppearance.BorderSize = 0;
            this.btnDisAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDisAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDisAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisAdd.Location = new System.Drawing.Point(186, 344);
            this.btnDisAdd.Name = "btnDisAdd";
            this.btnDisAdd.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisAdd.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDisAdd.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisAdd.Size = new System.Drawing.Size(126, 40);
            this.btnDisAdd.TabIndex = 246;
            this.btnDisAdd.Text = "ADD";
            this.btnDisAdd.TextColor = System.Drawing.Color.White;
            this.btnDisAdd.UseVisualStyleBackColor = false;
            this.btnDisAdd.Click += new System.EventHandler(this.btnDisAdd_Click);
            // 
            // btnDisDel
            // 
            this.btnDisDel.BackColor = System.Drawing.Color.White;
            this.btnDisDel.BorderColor = System.Drawing.Color.Silver;
            this.btnDisDel.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDisDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisDel.FlatAppearance.BorderSize = 0;
            this.btnDisDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDisDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDisDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisDel.Location = new System.Drawing.Point(555, 344);
            this.btnDisDel.Name = "btnDisDel";
            this.btnDisDel.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisDel.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDisDel.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDisDel.Size = new System.Drawing.Size(125, 40);
            this.btnDisDel.TabIndex = 245;
            this.btnDisDel.Text = "DELETE";
            this.btnDisDel.TextColor = System.Drawing.Color.White;
            this.btnDisDel.UseVisualStyleBackColor = false;
            this.btnDisDel.Click += new System.EventHandler(this.btnDisDel_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvStaff.Location = new System.Drawing.Point(8, 49);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(718, 263);
            this.dgvStaff.TabIndex = 19;
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSearch.Controls.Add(this.lbTel);
            this.tabSearch.Controls.Add(this.lbEmail);
            this.tabSearch.Controls.Add(this.lbJobDesc);
            this.tabSearch.Controls.Add(this.lbJob);
            this.tabSearch.Controls.Add(this.lbID);
            this.tabSearch.Controls.Add(this.lblSID);
            this.tabSearch.Controls.Add(this.txtSeName);
            this.tabSearch.Controls.Add(this.lblName);
            this.tabSearch.Controls.Add(this.lblSTelNo);
            this.tabSearch.Controls.Add(this.lblSEmail);
            this.tabSearch.Controls.Add(this.lblSJobDesc);
            this.tabSearch.Controls.Add(this.lblSJob);
            this.tabSearch.Controls.Add(this.lbStaff);
            this.tabSearch.Controls.Add(this.iconSearchStaffID);
            this.tabSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(734, 688);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "SEARCH";
            this.tabSearch.Click += new System.EventHandler(this.tabSearch_Click);
            // 
            // lbTel
            // 
            this.lbTel.FormattingEnabled = true;
            this.lbTel.ItemHeight = 24;
            this.lbTel.Location = new System.Drawing.Point(166, 437);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(342, 28);
            this.lbTel.TabIndex = 257;
            // 
            // lbEmail
            // 
            this.lbEmail.FormattingEnabled = true;
            this.lbEmail.ItemHeight = 24;
            this.lbEmail.Location = new System.Drawing.Point(166, 392);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(342, 28);
            this.lbEmail.TabIndex = 256;
            // 
            // lbJobDesc
            // 
            this.lbJobDesc.FormattingEnabled = true;
            this.lbJobDesc.ItemHeight = 24;
            this.lbJobDesc.Location = new System.Drawing.Point(168, 299);
            this.lbJobDesc.Name = "lbJobDesc";
            this.lbJobDesc.Size = new System.Drawing.Size(539, 28);
            this.lbJobDesc.TabIndex = 255;
            // 
            // lbJob
            // 
            this.lbJob.FormattingEnabled = true;
            this.lbJob.ItemHeight = 24;
            this.lbJob.Location = new System.Drawing.Point(166, 228);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(293, 28);
            this.lbJob.TabIndex = 254;
            // 
            // lbID
            // 
            this.lbID.FormattingEnabled = true;
            this.lbID.ItemHeight = 24;
            this.lbID.Location = new System.Drawing.Point(166, 169);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(293, 28);
            this.lbID.TabIndex = 253;
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(7, 173);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(74, 24);
            this.lblSID.TabIndex = 251;
            this.lblSID.Text = "Staff ID";
            // 
            // txtSeName
            // 
            this.txtSeName.Location = new System.Drawing.Point(130, 22);
            this.txtSeName.Name = "txtSeName";
            this.txtSeName.Size = new System.Drawing.Size(248, 29);
            this.txtSeName.TabIndex = 250;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 24);
            this.lblName.TabIndex = 249;
            this.lblName.Text = "Surname";
            // 
            // lblSTelNo
            // 
            this.lblSTelNo.AutoSize = true;
            this.lblSTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSTelNo.Location = new System.Drawing.Point(2, 441);
            this.lblSTelNo.Name = "lblSTelNo";
            this.lblSTelNo.Size = new System.Drawing.Size(73, 24);
            this.lblSTelNo.TabIndex = 247;
            this.lblSTelNo.Text = "Tel No";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSEmail.Location = new System.Drawing.Point(6, 392);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(69, 24);
            this.lblSEmail.TabIndex = 245;
            this.lblSEmail.Text = "E-Mail";
            // 
            // lblSJobDesc
            // 
            this.lblSJobDesc.AutoSize = true;
            this.lblSJobDesc.Location = new System.Drawing.Point(7, 303);
            this.lblSJobDesc.Name = "lblSJobDesc";
            this.lblSJobDesc.Size = new System.Drawing.Size(155, 24);
            this.lblSJobDesc.TabIndex = 244;
            this.lblSJobDesc.Text = "Job Description";
            // 
            // lblSJob
            // 
            this.lblSJob.AutoSize = true;
            this.lblSJob.Location = new System.Drawing.Point(7, 232);
            this.lblSJob.Name = "lblSJob";
            this.lblSJob.Size = new System.Drawing.Size(94, 24);
            this.lblSJob.TabIndex = 241;
            this.lblSJob.Text = "Job-Role";
            // 
            // lbStaff
            // 
            this.lbStaff.FormattingEnabled = true;
            this.lbStaff.ItemHeight = 24;
            this.lbStaff.Location = new System.Drawing.Point(30, 65);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(348, 76);
            this.lbStaff.TabIndex = 229;
            this.lbStaff.SelectedIndexChanged += new System.EventHandler(this.lbStaff_SelectedIndexChanged);
            // 
            // iconSearchStaffID
            // 
            this.iconSearchStaffID.BackColor = System.Drawing.Color.Transparent;
            this.iconSearchStaffID.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.iconSearchStaffID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconSearchStaffID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSearchStaffID.Location = new System.Drawing.Point(398, 22);
            this.iconSearchStaffID.Name = "iconSearchStaffID";
            this.iconSearchStaffID.Size = new System.Drawing.Size(43, 31);
            this.iconSearchStaffID.TabIndex = 228;
            this.iconSearchStaffID.TabStop = false;
            this.iconSearchStaffID.Click += new System.EventHandler(this.iconSearchStaffID_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdd.Controls.Add(this.cmbAJr);
            this.tabAdd.Controls.Add(this.btnClearAdd);
            this.tabAdd.Controls.Add(this.lblAddStaffID);
            this.tabAdd.Controls.Add(this.lblAJobDesc);
            this.tabAdd.Controls.Add(this.txtAJobDesc);
            this.tabAdd.Controls.Add(this.lblAJobR);
            this.tabAdd.Controls.Add(this.txtATel);
            this.tabAdd.Controls.Add(this.txtAEmail);
            this.tabAdd.Controls.Add(this.txtASurN);
            this.tabAdd.Controls.Add(this.txtAForeN);
            this.tabAdd.Controls.Add(this.lblATelNo);
            this.tabAdd.Controls.Add(this.lblAEmail);
            this.tabAdd.Controls.Add(this.lblASur);
            this.tabAdd.Controls.Add(this.lblAFore);
            this.tabAdd.Controls.Add(this.lblAStaffID);
            this.tabAdd.Controls.Add(this.btnAAStaff);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(734, 688);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "ADD";
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.BorderColor = System.Drawing.Color.Silver;
            this.btnClearAdd.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnClearAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAdd.FlatAppearance.BorderSize = 0;
            this.btnClearAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAdd.Location = new System.Drawing.Point(523, 59);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnClearAdd.onHoverButtonColor = System.Drawing.Color.White;
            this.btnClearAdd.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnClearAdd.Size = new System.Drawing.Size(168, 40);
            this.btnClearAdd.TabIndex = 244;
            this.btnClearAdd.Text = "CLEAR";
            this.btnClearAdd.TextColor = System.Drawing.Color.White;
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
            // 
            // lblAddStaffID
            // 
            this.lblAddStaffID.AutoSize = true;
            this.lblAddStaffID.Location = new System.Drawing.Point(198, 22);
            this.lblAddStaffID.Name = "lblAddStaffID";
            this.lblAddStaffID.Size = new System.Drawing.Size(17, 24);
            this.lblAddStaffID.TabIndex = 243;
            this.lblAddStaffID.Text = "-";
            // 
            // lblAJobDesc
            // 
            this.lblAJobDesc.AutoSize = true;
            this.lblAJobDesc.Location = new System.Drawing.Point(37, 231);
            this.lblAJobDesc.Name = "lblAJobDesc";
            this.lblAJobDesc.Size = new System.Drawing.Size(155, 24);
            this.lblAJobDesc.TabIndex = 242;
            this.lblAJobDesc.Text = "Job Description";
            // 
            // txtAJobDesc
            // 
            this.txtAJobDesc.Location = new System.Drawing.Point(198, 202);
            this.txtAJobDesc.Multiline = true;
            this.txtAJobDesc.Name = "txtAJobDesc";
            this.txtAJobDesc.Size = new System.Drawing.Size(291, 104);
            this.txtAJobDesc.TabIndex = 241;
            // 
            // lblAJobR
            // 
            this.lblAJobR.AutoSize = true;
            this.lblAJobR.Location = new System.Drawing.Point(37, 160);
            this.lblAJobR.Name = "lblAJobR";
            this.lblAJobR.Size = new System.Drawing.Size(94, 24);
            this.lblAJobR.TabIndex = 239;
            this.lblAJobR.Text = "Job-Role";
            // 
            // txtATel
            // 
            this.txtATel.Location = new System.Drawing.Point(197, 404);
            this.txtATel.Name = "txtATel";
            this.txtATel.Size = new System.Drawing.Size(437, 29);
            this.txtATel.TabIndex = 237;
            // 
            // txtAEmail
            // 
            this.txtAEmail.Location = new System.Drawing.Point(197, 333);
            this.txtAEmail.Name = "txtAEmail";
            this.txtAEmail.Size = new System.Drawing.Size(437, 29);
            this.txtAEmail.TabIndex = 235;
            // 
            // txtASurN
            // 
            this.txtASurN.Location = new System.Drawing.Point(198, 109);
            this.txtASurN.Name = "txtASurN";
            this.txtASurN.Size = new System.Drawing.Size(291, 29);
            this.txtASurN.TabIndex = 233;
            // 
            // txtAForeN
            // 
            this.txtAForeN.Location = new System.Drawing.Point(197, 63);
            this.txtAForeN.Name = "txtAForeN";
            this.txtAForeN.Size = new System.Drawing.Size(291, 29);
            this.txtAForeN.TabIndex = 231;
            // 
            // lblATelNo
            // 
            this.lblATelNo.AutoSize = true;
            this.lblATelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblATelNo.Location = new System.Drawing.Point(33, 409);
            this.lblATelNo.Name = "lblATelNo";
            this.lblATelNo.Size = new System.Drawing.Size(73, 24);
            this.lblATelNo.TabIndex = 236;
            this.lblATelNo.Text = "Tel No";
            // 
            // lblAEmail
            // 
            this.lblAEmail.AutoSize = true;
            this.lblAEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAEmail.Location = new System.Drawing.Point(37, 333);
            this.lblAEmail.Name = "lblAEmail";
            this.lblAEmail.Size = new System.Drawing.Size(69, 24);
            this.lblAEmail.TabIndex = 234;
            this.lblAEmail.Text = "E-Mail";
            // 
            // lblASur
            // 
            this.lblASur.AutoSize = true;
            this.lblASur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblASur.Location = new System.Drawing.Point(37, 114);
            this.lblASur.Name = "lblASur";
            this.lblASur.Size = new System.Drawing.Size(94, 24);
            this.lblASur.TabIndex = 232;
            this.lblASur.Text = "Surname";
            // 
            // lblAFore
            // 
            this.lblAFore.AutoSize = true;
            this.lblAFore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAFore.Location = new System.Drawing.Point(37, 68);
            this.lblAFore.Name = "lblAFore";
            this.lblAFore.Size = new System.Drawing.Size(106, 24);
            this.lblAFore.TabIndex = 230;
            this.lblAFore.Text = "Forename";
            // 
            // lblAStaffID
            // 
            this.lblAStaffID.AutoSize = true;
            this.lblAStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStaffID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAStaffID.Location = new System.Drawing.Point(37, 22);
            this.lblAStaffID.Name = "lblAStaffID";
            this.lblAStaffID.Size = new System.Drawing.Size(74, 24);
            this.lblAStaffID.TabIndex = 228;
            this.lblAStaffID.Text = "Staff ID";
            // 
            // btnAAStaff
            // 
            this.btnAAStaff.BorderColor = System.Drawing.Color.Silver;
            this.btnAAStaff.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnAAStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAStaff.FlatAppearance.BorderSize = 0;
            this.btnAAStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAAStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAAStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAAStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAAStaff.Location = new System.Drawing.Point(282, 524);
            this.btnAAStaff.Name = "btnAAStaff";
            this.btnAAStaff.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAAStaff.onHoverButtonColor = System.Drawing.Color.White;
            this.btnAAStaff.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAAStaff.Size = new System.Drawing.Size(168, 40);
            this.btnAAStaff.TabIndex = 238;
            this.btnAAStaff.Text = "ADD EMPLOYEE";
            this.btnAAStaff.TextColor = System.Drawing.Color.White;
            this.btnAAStaff.UseVisualStyleBackColor = true;
            this.btnAAStaff.Click += new System.EventHandler(this.btnAAStaff_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.White;
            this.tabEdit.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEdit.Controls.Add(this.lblEdStaffID);
            this.tabEdit.Controls.Add(this.lblEdJobDesc);
            this.tabEdit.Controls.Add(this.txtEdJobDesc);
            this.tabEdit.Controls.Add(this.txtEdJobR);
            this.tabEdit.Controls.Add(this.lblEdJobR);
            this.tabEdit.Controls.Add(this.txtEdTel);
            this.tabEdit.Controls.Add(this.txtEdEmail);
            this.tabEdit.Controls.Add(this.txtEdSurN);
            this.tabEdit.Controls.Add(this.txtEdForeN);
            this.tabEdit.Controls.Add(this.lblEdTel);
            this.tabEdit.Controls.Add(this.lblEdEmail);
            this.tabEdit.Controls.Add(this.lblEdSurN);
            this.tabEdit.Controls.Add(this.lblEdForeN);
            this.tabEdit.Controls.Add(this.lblEdStaff);
            this.tabEdit.Controls.Add(this.btnEdEdit);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(734, 688);
            this.tabEdit.TabIndex = 3;
            this.tabEdit.Text = "EDIT";
            // 
            // lblEdStaffID
            // 
            this.lblEdStaffID.AutoSize = true;
            this.lblEdStaffID.Location = new System.Drawing.Point(192, 20);
            this.lblEdStaffID.Name = "lblEdStaffID";
            this.lblEdStaffID.Size = new System.Drawing.Size(17, 24);
            this.lblEdStaffID.TabIndex = 243;
            this.lblEdStaffID.Text = "-";
            // 
            // lblEdJobDesc
            // 
            this.lblEdJobDesc.AutoSize = true;
            this.lblEdJobDesc.Location = new System.Drawing.Point(31, 229);
            this.lblEdJobDesc.Name = "lblEdJobDesc";
            this.lblEdJobDesc.Size = new System.Drawing.Size(155, 24);
            this.lblEdJobDesc.TabIndex = 242;
            this.lblEdJobDesc.Text = "Job Description";
            // 
            // txtEdJobDesc
            // 
            this.txtEdJobDesc.Location = new System.Drawing.Point(192, 200);
            this.txtEdJobDesc.Multiline = true;
            this.txtEdJobDesc.Name = "txtEdJobDesc";
            this.txtEdJobDesc.Size = new System.Drawing.Size(291, 104);
            this.txtEdJobDesc.TabIndex = 241;
            // 
            // txtEdJobR
            // 
            this.txtEdJobR.Location = new System.Drawing.Point(192, 153);
            this.txtEdJobR.Name = "txtEdJobR";
            this.txtEdJobR.Size = new System.Drawing.Size(291, 29);
            this.txtEdJobR.TabIndex = 240;
            // 
            // lblEdJobR
            // 
            this.lblEdJobR.AutoSize = true;
            this.lblEdJobR.Location = new System.Drawing.Point(31, 158);
            this.lblEdJobR.Name = "lblEdJobR";
            this.lblEdJobR.Size = new System.Drawing.Size(94, 24);
            this.lblEdJobR.TabIndex = 239;
            this.lblEdJobR.Text = "Job-Role";
            // 
            // txtEdTel
            // 
            this.txtEdTel.Location = new System.Drawing.Point(191, 402);
            this.txtEdTel.Name = "txtEdTel";
            this.txtEdTel.Size = new System.Drawing.Size(437, 29);
            this.txtEdTel.TabIndex = 237;
            // 
            // txtEdEmail
            // 
            this.txtEdEmail.Location = new System.Drawing.Point(191, 331);
            this.txtEdEmail.Name = "txtEdEmail";
            this.txtEdEmail.Size = new System.Drawing.Size(437, 29);
            this.txtEdEmail.TabIndex = 235;
            // 
            // txtEdSurN
            // 
            this.txtEdSurN.Location = new System.Drawing.Point(192, 107);
            this.txtEdSurN.Name = "txtEdSurN";
            this.txtEdSurN.Size = new System.Drawing.Size(291, 29);
            this.txtEdSurN.TabIndex = 233;
            // 
            // txtEdForeN
            // 
            this.txtEdForeN.Location = new System.Drawing.Point(191, 61);
            this.txtEdForeN.Name = "txtEdForeN";
            this.txtEdForeN.Size = new System.Drawing.Size(291, 29);
            this.txtEdForeN.TabIndex = 231;
            // 
            // lblEdTel
            // 
            this.lblEdTel.AutoSize = true;
            this.lblEdTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdTel.Location = new System.Drawing.Point(27, 407);
            this.lblEdTel.Name = "lblEdTel";
            this.lblEdTel.Size = new System.Drawing.Size(73, 24);
            this.lblEdTel.TabIndex = 236;
            this.lblEdTel.Text = "Tel No";
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdEmail.Location = new System.Drawing.Point(31, 331);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(69, 24);
            this.lblEdEmail.TabIndex = 234;
            this.lblEdEmail.Text = "E-Mail";
            // 
            // lblEdSurN
            // 
            this.lblEdSurN.AutoSize = true;
            this.lblEdSurN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdSurN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdSurN.Location = new System.Drawing.Point(31, 112);
            this.lblEdSurN.Name = "lblEdSurN";
            this.lblEdSurN.Size = new System.Drawing.Size(94, 24);
            this.lblEdSurN.TabIndex = 232;
            this.lblEdSurN.Text = "Surname";
            // 
            // lblEdForeN
            // 
            this.lblEdForeN.AutoSize = true;
            this.lblEdForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdForeN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdForeN.Location = new System.Drawing.Point(31, 66);
            this.lblEdForeN.Name = "lblEdForeN";
            this.lblEdForeN.Size = new System.Drawing.Size(106, 24);
            this.lblEdForeN.TabIndex = 230;
            this.lblEdForeN.Text = "Forename";
            // 
            // lblEdStaff
            // 
            this.lblEdStaff.AutoSize = true;
            this.lblEdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdStaff.Location = new System.Drawing.Point(31, 20);
            this.lblEdStaff.Name = "lblEdStaff";
            this.lblEdStaff.Size = new System.Drawing.Size(74, 24);
            this.lblEdStaff.TabIndex = 228;
            this.lblEdStaff.Text = "Staff ID";
            // 
            // btnEdEdit
            // 
            this.btnEdEdit.BorderColor = System.Drawing.Color.Silver;
            this.btnEdEdit.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnEdEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdEdit.FlatAppearance.BorderSize = 0;
            this.btnEdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdEdit.Location = new System.Drawing.Point(555, 13);
            this.btnEdEdit.Name = "btnEdEdit";
            this.btnEdEdit.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdEdit.onHoverButtonColor = System.Drawing.Color.White;
            this.btnEdEdit.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdEdit.TabIndex = 238;
            this.btnEdEdit.Text = "EDIT";
            this.btnEdEdit.TextColor = System.Drawing.Color.White;
            this.btnEdEdit.UseVisualStyleBackColor = true;
            this.btnEdEdit.Click += new System.EventHandler(this.btnEdEdit_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.White;
            this.tabDelete.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDelete.Controls.Add(this.lblDeJobDesc);
            this.tabDelete.Controls.Add(this.txtDeJobDesc);
            this.tabDelete.Controls.Add(this.txtDeJobR);
            this.tabDelete.Controls.Add(this.lblDeJobR);
            this.tabDelete.Controls.Add(this.txtDeTel);
            this.tabDelete.Controls.Add(this.txtDeEmail);
            this.tabDelete.Controls.Add(this.txtDeSurN);
            this.tabDelete.Controls.Add(this.txtDeForeN);
            this.tabDelete.Controls.Add(this.txtDeStaffID);
            this.tabDelete.Controls.Add(this.lblDeTel);
            this.tabDelete.Controls.Add(this.lblDeEmail);
            this.tabDelete.Controls.Add(this.lblDeSurN);
            this.tabDelete.Controls.Add(this.lblDeForeN);
            this.tabDelete.Controls.Add(this.lblDeStaffID);
            this.tabDelete.Controls.Add(this.btnDeDelete);
            this.tabDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabDelete.Location = new System.Drawing.Point(4, 29);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(734, 688);
            this.tabDelete.TabIndex = 4;
            this.tabDelete.Text = "DELETE";
            // 
            // lblDeJobDesc
            // 
            this.lblDeJobDesc.AutoSize = true;
            this.lblDeJobDesc.Location = new System.Drawing.Point(37, 229);
            this.lblDeJobDesc.Name = "lblDeJobDesc";
            this.lblDeJobDesc.Size = new System.Drawing.Size(155, 24);
            this.lblDeJobDesc.TabIndex = 264;
            this.lblDeJobDesc.Text = "Job Description";
            // 
            // txtDeJobDesc
            // 
            this.txtDeJobDesc.Location = new System.Drawing.Point(198, 200);
            this.txtDeJobDesc.Multiline = true;
            this.txtDeJobDesc.Name = "txtDeJobDesc";
            this.txtDeJobDesc.Size = new System.Drawing.Size(291, 104);
            this.txtDeJobDesc.TabIndex = 263;
            // 
            // txtDeJobR
            // 
            this.txtDeJobR.Location = new System.Drawing.Point(198, 153);
            this.txtDeJobR.Name = "txtDeJobR";
            this.txtDeJobR.Size = new System.Drawing.Size(291, 29);
            this.txtDeJobR.TabIndex = 262;
            // 
            // lblDeJobR
            // 
            this.lblDeJobR.AutoSize = true;
            this.lblDeJobR.Location = new System.Drawing.Point(37, 158);
            this.lblDeJobR.Name = "lblDeJobR";
            this.lblDeJobR.Size = new System.Drawing.Size(94, 24);
            this.lblDeJobR.TabIndex = 261;
            this.lblDeJobR.Text = "Job-Role";
            // 
            // txtDeTel
            // 
            this.txtDeTel.Location = new System.Drawing.Point(197, 402);
            this.txtDeTel.Name = "txtDeTel";
            this.txtDeTel.Size = new System.Drawing.Size(437, 29);
            this.txtDeTel.TabIndex = 259;
            // 
            // txtDeEmail
            // 
            this.txtDeEmail.Location = new System.Drawing.Point(197, 331);
            this.txtDeEmail.Name = "txtDeEmail";
            this.txtDeEmail.Size = new System.Drawing.Size(437, 29);
            this.txtDeEmail.TabIndex = 257;
            // 
            // txtDeSurN
            // 
            this.txtDeSurN.Location = new System.Drawing.Point(198, 107);
            this.txtDeSurN.Name = "txtDeSurN";
            this.txtDeSurN.Size = new System.Drawing.Size(291, 29);
            this.txtDeSurN.TabIndex = 255;
            // 
            // txtDeForeN
            // 
            this.txtDeForeN.Location = new System.Drawing.Point(197, 61);
            this.txtDeForeN.Name = "txtDeForeN";
            this.txtDeForeN.Size = new System.Drawing.Size(291, 29);
            this.txtDeForeN.TabIndex = 253;
            // 
            // txtDeStaffID
            // 
            this.txtDeStaffID.Location = new System.Drawing.Point(197, 17);
            this.txtDeStaffID.Name = "txtDeStaffID";
            this.txtDeStaffID.Size = new System.Drawing.Size(158, 29);
            this.txtDeStaffID.TabIndex = 251;
            // 
            // lblDeTel
            // 
            this.lblDeTel.AutoSize = true;
            this.lblDeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeTel.Location = new System.Drawing.Point(33, 407);
            this.lblDeTel.Name = "lblDeTel";
            this.lblDeTel.Size = new System.Drawing.Size(73, 24);
            this.lblDeTel.TabIndex = 258;
            this.lblDeTel.Text = "Tel No";
            // 
            // lblDeEmail
            // 
            this.lblDeEmail.AutoSize = true;
            this.lblDeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeEmail.Location = new System.Drawing.Point(37, 331);
            this.lblDeEmail.Name = "lblDeEmail";
            this.lblDeEmail.Size = new System.Drawing.Size(69, 24);
            this.lblDeEmail.TabIndex = 256;
            this.lblDeEmail.Text = "E-Mail";
            // 
            // lblDeSurN
            // 
            this.lblDeSurN.AutoSize = true;
            this.lblDeSurN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeSurN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeSurN.Location = new System.Drawing.Point(37, 112);
            this.lblDeSurN.Name = "lblDeSurN";
            this.lblDeSurN.Size = new System.Drawing.Size(94, 24);
            this.lblDeSurN.TabIndex = 254;
            this.lblDeSurN.Text = "Surname";
            // 
            // lblDeForeN
            // 
            this.lblDeForeN.AutoSize = true;
            this.lblDeForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeForeN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeForeN.Location = new System.Drawing.Point(37, 66);
            this.lblDeForeN.Name = "lblDeForeN";
            this.lblDeForeN.Size = new System.Drawing.Size(106, 24);
            this.lblDeForeN.TabIndex = 252;
            this.lblDeForeN.Text = "Forename";
            // 
            // lblDeStaffID
            // 
            this.lblDeStaffID.AutoSize = true;
            this.lblDeStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeStaffID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeStaffID.Location = new System.Drawing.Point(37, 20);
            this.lblDeStaffID.Name = "lblDeStaffID";
            this.lblDeStaffID.Size = new System.Drawing.Size(74, 24);
            this.lblDeStaffID.TabIndex = 250;
            this.lblDeStaffID.Text = "Staff ID";
            // 
            // btnDeDelete
            // 
            this.btnDeDelete.BorderColor = System.Drawing.Color.Silver;
            this.btnDeDelete.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeDelete.FlatAppearance.BorderSize = 0;
            this.btnDeDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeDelete.Location = new System.Drawing.Point(520, 10);
            this.btnDeDelete.Name = "btnDeDelete";
            this.btnDeDelete.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDeDelete.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDeDelete.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDeDelete.Size = new System.Drawing.Size(152, 40);
            this.btnDeDelete.TabIndex = 260;
            this.btnDeDelete.Text = "DELETE";
            this.btnDeDelete.TextColor = System.Drawing.Color.White;
            this.btnDeDelete.UseVisualStyleBackColor = true;
            this.btnDeDelete.Click += new System.EventHandler(this.btnDeDelete_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // cmbAJr
            // 
            this.cmbAJr.FormattingEnabled = true;
            this.cmbAJr.Location = new System.Drawing.Point(197, 162);
            this.cmbAJr.Name = "cmbAJr";
            this.cmbAJr.Size = new System.Drawing.Size(291, 32);
            this.cmbAJr.TabIndex = 245;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 723);
            this.Controls.Add(this.tabStaff);
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.Load += new System.EventHandler(this.Staff_load);
            this.Shown += new System.EventHandler(this.FrmStaff_Shown);
            this.tabStaff.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearchStaffID)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStaff;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label lblAddStaffID;
        private System.Windows.Forms.Label lblAJobDesc;
        private System.Windows.Forms.TextBox txtAJobDesc;
        private System.Windows.Forms.Label lblAJobR;
        private System.Windows.Forms.TextBox txtATel;
        private System.Windows.Forms.TextBox txtAEmail;
        private System.Windows.Forms.TextBox txtASurN;
        private System.Windows.Forms.TextBox txtAForeN;
        private System.Windows.Forms.Label lblATelNo;
        private System.Windows.Forms.Label lblAEmail;
        private System.Windows.Forms.Label lblASur;
        private System.Windows.Forms.Label lblAFore;
        private System.Windows.Forms.Label lblAStaffID;
        private RoundButton btnAAStaff;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Label lblEdJobDesc;
        private System.Windows.Forms.TextBox txtEdJobDesc;
        private System.Windows.Forms.TextBox txtEdJobR;
        private System.Windows.Forms.Label lblEdJobR;
        private System.Windows.Forms.TextBox txtEdTel;
        private System.Windows.Forms.TextBox txtEdEmail;
        private System.Windows.Forms.TextBox txtEdSurN;
        private System.Windows.Forms.TextBox txtEdForeN;
        private System.Windows.Forms.Label lblEdTel;
        private System.Windows.Forms.Label lblEdEmail;
        private System.Windows.Forms.Label lblEdSurN;
        private System.Windows.Forms.Label lblEdForeN;
        private System.Windows.Forms.Label lblEdStaff;
        private RoundButton btnEdEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label lblDeJobDesc;
        private System.Windows.Forms.TextBox txtDeJobDesc;
        private System.Windows.Forms.TextBox txtDeJobR;
        private System.Windows.Forms.Label lblDeJobR;
        private System.Windows.Forms.TextBox txtDeTel;
        private System.Windows.Forms.TextBox txtDeEmail;
        private System.Windows.Forms.TextBox txtDeSurN;
        private System.Windows.Forms.TextBox txtDeForeN;
        private System.Windows.Forms.TextBox txtDeStaffID;
        private System.Windows.Forms.Label lblDeTel;
        private System.Windows.Forms.Label lblDeEmail;
        private System.Windows.Forms.Label lblDeSurN;
        private System.Windows.Forms.Label lblDeForeN;
        private System.Windows.Forms.Label lblDeStaffID;
        private RoundButton btnDeDelete;
        private System.Windows.Forms.Label lblEdStaffID;
        private System.Windows.Forms.ErrorProvider errP;
        private RoundButton btnClearAdd;
        private System.Windows.Forms.PictureBox iconSearchStaffID;
        private System.Windows.Forms.ListBox lbStaff;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.TextBox txtSeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSTelNo;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.Label lblSJobDesc;
        private System.Windows.Forms.Label lblSJob;
        private System.Windows.Forms.ListBox lbID;
        private System.Windows.Forms.ListBox lbTel;
        private System.Windows.Forms.ListBox lbEmail;
        private System.Windows.Forms.ListBox lbJobDesc;
        private System.Windows.Forms.ListBox lbJob;
        private RoundButton btnDisEdit;
        private RoundButton btnDisSearch;
        private RoundButton btnDisAdd;
        private RoundButton btnDisDel;
        private System.Windows.Forms.ComboBox cmbAJr;
    }
}