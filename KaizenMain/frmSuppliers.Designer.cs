namespace KaizenMain
{
    partial class frmSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabSupplier = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.roundButton3 = new KaizenMain.RoundButton();
            this.roundButton2 = new KaizenMain.RoundButton();
            this.roundButton1 = new KaizenMain.RoundButton();
            this.label41 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.txtSeContactName = new System.Windows.Forms.TextBox();
            this.btnPrintSupplier = new KaizenMain.RoundButton();
            this.btnSeSuppClear = new KaizenMain.RoundButton();
            this.SearchIconSE = new System.Windows.Forms.PictureBox();
            this.lblSeCompName = new System.Windows.Forms.Label();
            this.txtSeCompName = new System.Windows.Forms.TextBox();
            this.txtSeSuppTel = new System.Windows.Forms.TextBox();
            this.lblSeSuppTel = new System.Windows.Forms.Label();
            this.txtSeSuppEmail = new System.Windows.Forms.TextBox();
            this.lblSeSuppEmail = new System.Windows.Forms.Label();
            this.txtSeSuppAddress = new System.Windows.Forms.TextBox();
            this.lblSeSuppAddress = new System.Windows.Forms.Label();
            this.lblSeSuppContact = new System.Windows.Forms.Label();
            this.txtSeSuppID = new System.Windows.Forms.TextBox();
            this.lblSeSuppID = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtSupEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSaveSup = new KaizenMain.RoundButton();
            this.btnClearSup = new KaizenMain.RoundButton();
            this.lblCompName = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtSupTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSupAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtEdContact = new System.Windows.Forms.TextBox();
            this.btnEditSupp = new KaizenMain.RoundButton();
            this.btnEdSuppClear = new KaizenMain.RoundButton();
            this.btnEdSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblEdCompName = new System.Windows.Forms.Label();
            this.txtEdCompName = new System.Windows.Forms.TextBox();
            this.txtEDSuppTel = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtEdSuppEmail = new System.Windows.Forms.TextBox();
            this.lblEdSupEmail = new System.Windows.Forms.Label();
            this.txtEdSuppAddress = new System.Windows.Forms.TextBox();
            this.lblEdSuppAddress = new System.Windows.Forms.Label();
            this.lblEdContact = new System.Windows.Forms.Label();
            this.txtEdSuppID = new System.Windows.Forms.TextBox();
            this.lblEdSupID = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtDlContact = new System.Windows.Forms.TextBox();
            this.btnDeleteSupp = new KaizenMain.RoundButton();
            this.btnDlClearSupp = new KaizenMain.RoundButton();
            this.btnDeleteSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblDlCompName = new System.Windows.Forms.Label();
            this.txtDlCompName = new System.Windows.Forms.TextBox();
            this.txtDlSuppTel = new System.Windows.Forms.TextBox();
            this.lblDlSuppTel = new System.Windows.Forms.Label();
            this.txtDlSuppEmail = new System.Windows.Forms.TextBox();
            this.lblDlSuppEmail = new System.Windows.Forms.Label();
            this.txtDlSuppAddress = new System.Windows.Forms.TextBox();
            this.lblDlSupAddress = new System.Windows.Forms.Label();
            this.lblDContact = new System.Windows.Forms.Label();
            this.txtDlSuppID = new System.Windows.Forms.TextBox();
            this.lblDelSuppID = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabSupplier.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconSE)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdSearchIcon)).BeginInit();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSupplier
            // 
            this.tabSupplier.AllowDrop = true;
            this.tabSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabSupplier.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSupplier.Controls.Add(this.tabDisplay);
            this.tabSupplier.Controls.Add(this.tabSearch);
            this.tabSupplier.Controls.Add(this.tabAdd);
            this.tabSupplier.Controls.Add(this.tabEdit);
            this.tabSupplier.Controls.Add(this.tabDelete);
            this.tabSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSupplier.ItemSize = new System.Drawing.Size(145, 25);
            this.tabSupplier.Location = new System.Drawing.Point(3, 6);
            this.tabSupplier.Multiline = true;
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.SelectedIndex = 0;
            this.tabSupplier.Size = new System.Drawing.Size(742, 721);
            this.tabSupplier.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSupplier.TabIndex = 7;
            this.tabSupplier.TabStop = false;
            this.tabSupplier.SelectedIndexChanged += new System.EventHandler(this.tabSupplier_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(159)))));
            this.tabDisplay.Controls.Add(this.dgvSuppliers);
            this.tabDisplay.Controls.Add(this.roundButton3);
            this.tabDisplay.Controls.Add(this.roundButton2);
            this.tabDisplay.Controls.Add(this.roundButton1);
            this.tabDisplay.Controls.Add(this.label41);
            this.tabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(734, 688);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "DISPLAY";
            // 
            // dgvSuppliers
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.Location = new System.Drawing.Point(23, 70);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(678, 595);
            this.dgvSuppliers.TabIndex = 19;
            this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
            this.dgvSuppliers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.both);
            // 
            // roundButton3
            // 
            this.roundButton3.BorderColor = System.Drawing.Color.Silver;
            this.roundButton3.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.Location = new System.Drawing.Point(442, 6);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton3.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton3.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton3.Size = new System.Drawing.Size(104, 40);
            this.roundButton3.TabIndex = 15;
            this.roundButton3.Text = "TYPE";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.BorderColor = System.Drawing.Color.Silver;
            this.roundButton2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.Location = new System.Drawing.Point(332, 6);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton2.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton2.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton2.Size = new System.Drawing.Size(104, 40);
            this.roundButton2.TabIndex = 14;
            this.roundButton2.Text = "ID";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundButton1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(222, 6);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton1.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton1.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton1.Size = new System.Drawing.Size(104, 40);
            this.roundButton1.TabIndex = 13;
            this.roundButton1.Text = "A - Z";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label41.Location = new System.Drawing.Point(140, 13);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(76, 24);
            this.label41.TabIndex = 11;
            this.label41.Text = "Sort By";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSearch.Controls.Add(this.txtSeContactName);
            this.tabSearch.Controls.Add(this.btnPrintSupplier);
            this.tabSearch.Controls.Add(this.btnSeSuppClear);
            this.tabSearch.Controls.Add(this.SearchIconSE);
            this.tabSearch.Controls.Add(this.lblSeCompName);
            this.tabSearch.Controls.Add(this.txtSeCompName);
            this.tabSearch.Controls.Add(this.txtSeSuppTel);
            this.tabSearch.Controls.Add(this.lblSeSuppTel);
            this.tabSearch.Controls.Add(this.txtSeSuppEmail);
            this.tabSearch.Controls.Add(this.lblSeSuppEmail);
            this.tabSearch.Controls.Add(this.txtSeSuppAddress);
            this.tabSearch.Controls.Add(this.lblSeSuppAddress);
            this.tabSearch.Controls.Add(this.lblSeSuppContact);
            this.tabSearch.Controls.Add(this.txtSeSuppID);
            this.tabSearch.Controls.Add(this.lblSeSuppID);
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
            // txtSeContactName
            // 
            this.txtSeContactName.Location = new System.Drawing.Point(217, 151);
            this.txtSeContactName.Name = "txtSeContactName";
            this.txtSeContactName.Size = new System.Drawing.Size(494, 29);
            this.txtSeContactName.TabIndex = 225;
            this.txtSeContactName.TextChanged += new System.EventHandler(this.txtSeContactName_TextChanged);
            // 
            // btnPrintSupplier
            // 
            this.btnPrintSupplier.BorderColor = System.Drawing.Color.Silver;
            this.btnPrintSupplier.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnPrintSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSupplier.FlatAppearance.BorderSize = 0;
            this.btnPrintSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSupplier.Location = new System.Drawing.Point(273, 592);
            this.btnPrintSupplier.Name = "btnPrintSupplier";
            this.btnPrintSupplier.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnPrintSupplier.onHoverButtonColor = System.Drawing.Color.White;
            this.btnPrintSupplier.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnPrintSupplier.Size = new System.Drawing.Size(189, 40);
            this.btnPrintSupplier.TabIndex = 224;
            this.btnPrintSupplier.Text = "PRINT SUPPLIER";
            this.btnPrintSupplier.TextColor = System.Drawing.Color.White;
            this.btnPrintSupplier.UseVisualStyleBackColor = true;
            // 
            // btnSeSuppClear
            // 
            this.btnSeSuppClear.BorderColor = System.Drawing.Color.Silver;
            this.btnSeSuppClear.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnSeSuppClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeSuppClear.FlatAppearance.BorderSize = 0;
            this.btnSeSuppClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeSuppClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeSuppClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeSuppClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeSuppClear.Location = new System.Drawing.Point(582, 37);
            this.btnSeSuppClear.Name = "btnSeSuppClear";
            this.btnSeSuppClear.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnSeSuppClear.onHoverButtonColor = System.Drawing.Color.White;
            this.btnSeSuppClear.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnSeSuppClear.Size = new System.Drawing.Size(115, 40);
            this.btnSeSuppClear.TabIndex = 223;
            this.btnSeSuppClear.Text = "CLEAR";
            this.btnSeSuppClear.TextColor = System.Drawing.Color.White;
            this.btnSeSuppClear.UseVisualStyleBackColor = true;
            this.btnSeSuppClear.Click += new System.EventHandler(this.btnSeSuppClear_Click);
            // 
            // SearchIconSE
            // 
            this.SearchIconSE.BackColor = System.Drawing.Color.Transparent;
            this.SearchIconSE.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.SearchIconSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIconSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchIconSE.Location = new System.Drawing.Point(403, 41);
            this.SearchIconSE.Name = "SearchIconSE";
            this.SearchIconSE.Size = new System.Drawing.Size(43, 31);
            this.SearchIconSE.TabIndex = 222;
            this.SearchIconSE.TabStop = false;
            this.SearchIconSE.Click += new System.EventHandler(this.SearchIconSE_Click);
            // 
            // lblSeCompName
            // 
            this.lblSeCompName.AutoSize = true;
            this.lblSeCompName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeCompName.Location = new System.Drawing.Point(37, 99);
            this.lblSeCompName.Name = "lblSeCompName";
            this.lblSeCompName.Size = new System.Drawing.Size(159, 24);
            this.lblSeCompName.TabIndex = 61;
            this.lblSeCompName.Text = "Company Name";
            // 
            // txtSeCompName
            // 
            this.txtSeCompName.Location = new System.Drawing.Point(217, 99);
            this.txtSeCompName.Name = "txtSeCompName";
            this.txtSeCompName.Size = new System.Drawing.Size(494, 29);
            this.txtSeCompName.TabIndex = 60;
            // 
            // txtSeSuppTel
            // 
            this.txtSeSuppTel.Location = new System.Drawing.Point(217, 319);
            this.txtSeSuppTel.Name = "txtSeSuppTel";
            this.txtSeSuppTel.Size = new System.Drawing.Size(294, 29);
            this.txtSeSuppTel.TabIndex = 59;
            // 
            // lblSeSuppTel
            // 
            this.lblSeSuppTel.AutoSize = true;
            this.lblSeSuppTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeSuppTel.Location = new System.Drawing.Point(37, 324);
            this.lblSeSuppTel.Name = "lblSeSuppTel";
            this.lblSeSuppTel.Size = new System.Drawing.Size(73, 24);
            this.lblSeSuppTel.TabIndex = 58;
            this.lblSeSuppTel.Text = "Tel No";
            // 
            // txtSeSuppEmail
            // 
            this.txtSeSuppEmail.Location = new System.Drawing.Point(217, 259);
            this.txtSeSuppEmail.Name = "txtSeSuppEmail";
            this.txtSeSuppEmail.Size = new System.Drawing.Size(294, 29);
            this.txtSeSuppEmail.TabIndex = 57;
            // 
            // lblSeSuppEmail
            // 
            this.lblSeSuppEmail.AutoSize = true;
            this.lblSeSuppEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeSuppEmail.Location = new System.Drawing.Point(37, 264);
            this.lblSeSuppEmail.Name = "lblSeSuppEmail";
            this.lblSeSuppEmail.Size = new System.Drawing.Size(69, 24);
            this.lblSeSuppEmail.TabIndex = 56;
            this.lblSeSuppEmail.Text = "E-Mail";
            // 
            // txtSeSuppAddress
            // 
            this.txtSeSuppAddress.Location = new System.Drawing.Point(217, 209);
            this.txtSeSuppAddress.Name = "txtSeSuppAddress";
            this.txtSeSuppAddress.Size = new System.Drawing.Size(494, 29);
            this.txtSeSuppAddress.TabIndex = 46;
            this.txtSeSuppAddress.TextChanged += new System.EventHandler(this.txtSeSuppAddress_TextChanged);
            // 
            // lblSeSuppAddress
            // 
            this.lblSeSuppAddress.AutoSize = true;
            this.lblSeSuppAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeSuppAddress.Location = new System.Drawing.Point(37, 214);
            this.lblSeSuppAddress.Name = "lblSeSuppAddress";
            this.lblSeSuppAddress.Size = new System.Drawing.Size(87, 24);
            this.lblSeSuppAddress.TabIndex = 45;
            this.lblSeSuppAddress.Text = "Address";
            this.lblSeSuppAddress.Click += new System.EventHandler(this.lblSeSuppAddress_Click);
            // 
            // lblSeSuppContact
            // 
            this.lblSeSuppContact.AutoSize = true;
            this.lblSeSuppContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeSuppContact.Location = new System.Drawing.Point(37, 151);
            this.lblSeSuppContact.Name = "lblSeSuppContact";
            this.lblSeSuppContact.Size = new System.Drawing.Size(174, 24);
            this.lblSeSuppContact.TabIndex = 41;
            this.lblSeSuppContact.Text = "Company Contact";
            this.lblSeSuppContact.Click += new System.EventHandler(this.lblSeSuppContact_Click);
            // 
            // txtSeSuppID
            // 
            this.txtSeSuppID.Location = new System.Drawing.Point(217, 41);
            this.txtSeSuppID.Name = "txtSeSuppID";
            this.txtSeSuppID.Size = new System.Drawing.Size(157, 29);
            this.txtSeSuppID.TabIndex = 40;
            // 
            // lblSeSuppID
            // 
            this.lblSeSuppID.AutoSize = true;
            this.lblSeSuppID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeSuppID.Location = new System.Drawing.Point(37, 44);
            this.lblSeSuppID.Name = "lblSeSuppID";
            this.lblSeSuppID.Size = new System.Drawing.Size(113, 24);
            this.lblSeSuppID.TabIndex = 39;
            this.lblSeSuppID.Text = "Supplier ID";
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdd.Controls.Add(this.lblSuppID);
            this.tabAdd.Controls.Add(this.txtSupEmail);
            this.tabAdd.Controls.Add(this.txtContact);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.BtnSaveSup);
            this.tabAdd.Controls.Add(this.btnClearSup);
            this.tabAdd.Controls.Add(this.lblCompName);
            this.tabAdd.Controls.Add(this.txtCompName);
            this.tabAdd.Controls.Add(this.txtSupTel);
            this.tabAdd.Controls.Add(this.lblTel);
            this.tabAdd.Controls.Add(this.lblEmail);
            this.tabAdd.Controls.Add(this.txtSupAddress);
            this.tabAdd.Controls.Add(this.lblAddress);
            this.tabAdd.Controls.Add(this.lblSupID);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(734, 688);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "ADD";
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuppID.Location = new System.Drawing.Point(222, 54);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(17, 24);
            this.lblSuppID.TabIndex = 251;
            this.lblSuppID.Text = "-";
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Location = new System.Drawing.Point(217, 334);
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.Size = new System.Drawing.Size(294, 29);
            this.txtSupEmail.TabIndex = 250;
            this.txtSupEmail.TextChanged += new System.EventHandler(this.txtSupEmail_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(217, 157);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(494, 29);
            this.txtContact.TabIndex = 249;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 248;
            this.label1.Text = "Company Contact";
            // 
            // BtnSaveSup
            // 
            this.BtnSaveSup.BorderColor = System.Drawing.Color.Silver;
            this.BtnSaveSup.ButtonColor = System.Drawing.Color.SteelBlue;
            this.BtnSaveSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveSup.FlatAppearance.BorderSize = 0;
            this.BtnSaveSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSaveSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSaveSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveSup.Location = new System.Drawing.Point(273, 602);
            this.BtnSaveSup.Name = "BtnSaveSup";
            this.BtnSaveSup.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.BtnSaveSup.onHoverButtonColor = System.Drawing.Color.White;
            this.BtnSaveSup.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.BtnSaveSup.Size = new System.Drawing.Size(189, 40);
            this.BtnSaveSup.TabIndex = 247;
            this.BtnSaveSup.Text = "SAVE SUPPLIER";
            this.BtnSaveSup.TextColor = System.Drawing.Color.White;
            this.BtnSaveSup.UseVisualStyleBackColor = true;
            this.BtnSaveSup.Click += new System.EventHandler(this.BtnSaveSup_Click);
            // 
            // btnClearSup
            // 
            this.btnClearSup.BorderColor = System.Drawing.Color.Silver;
            this.btnClearSup.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnClearSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSup.FlatAppearance.BorderSize = 0;
            this.btnClearSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSup.Location = new System.Drawing.Point(582, 47);
            this.btnClearSup.Name = "btnClearSup";
            this.btnClearSup.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnClearSup.onHoverButtonColor = System.Drawing.Color.White;
            this.btnClearSup.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnClearSup.Size = new System.Drawing.Size(115, 40);
            this.btnClearSup.TabIndex = 246;
            this.btnClearSup.Text = "CLEAR";
            this.btnClearSup.TextColor = System.Drawing.Color.White;
            this.btnClearSup.UseVisualStyleBackColor = true;
            this.btnClearSup.Click += new System.EventHandler(this.btnClearSup_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompName.Location = new System.Drawing.Point(41, 109);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(159, 24);
            this.lblCompName.TabIndex = 244;
            this.lblCompName.Text = "Company Name";
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(217, 104);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(494, 29);
            this.txtCompName.TabIndex = 243;
            this.txtCompName.TextChanged += new System.EventHandler(this.txtCompName_TextChanged);
            // 
            // txtSupTel
            // 
            this.txtSupTel.Location = new System.Drawing.Point(217, 271);
            this.txtSupTel.Name = "txtSupTel";
            this.txtSupTel.Size = new System.Drawing.Size(294, 29);
            this.txtSupTel.TabIndex = 242;
            this.txtSupTel.TextChanged += new System.EventHandler(this.txtSupTel_TextChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTel.Location = new System.Drawing.Point(41, 276);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(73, 24);
            this.lblTel.TabIndex = 241;
            this.lblTel.Text = "Tel No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(41, 334);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 24);
            this.lblEmail.TabIndex = 239;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(217, 212);
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Size = new System.Drawing.Size(494, 29);
            this.txtSupAddress.TabIndex = 232;
            this.txtSupAddress.TextChanged += new System.EventHandler(this.txtSupAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(41, 215);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 24);
            this.lblAddress.TabIndex = 231;
            this.lblAddress.Text = "Address";
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupID.Location = new System.Drawing.Point(41, 54);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(113, 24);
            this.lblSupID.TabIndex = 225;
            this.lblSupID.Text = "Supplier ID";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.White;
            this.tabEdit.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEdit.Controls.Add(this.txtEdContact);
            this.tabEdit.Controls.Add(this.btnEditSupp);
            this.tabEdit.Controls.Add(this.btnEdSuppClear);
            this.tabEdit.Controls.Add(this.btnEdSearchIcon);
            this.tabEdit.Controls.Add(this.lblEdCompName);
            this.tabEdit.Controls.Add(this.txtEdCompName);
            this.tabEdit.Controls.Add(this.txtEDSuppTel);
            this.tabEdit.Controls.Add(this.lblTelNo);
            this.tabEdit.Controls.Add(this.txtEdSuppEmail);
            this.tabEdit.Controls.Add(this.lblEdSupEmail);
            this.tabEdit.Controls.Add(this.txtEdSuppAddress);
            this.tabEdit.Controls.Add(this.lblEdSuppAddress);
            this.tabEdit.Controls.Add(this.lblEdContact);
            this.tabEdit.Controls.Add(this.txtEdSuppID);
            this.tabEdit.Controls.Add(this.lblEdSupID);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(734, 688);
            this.tabEdit.TabIndex = 3;
            this.tabEdit.Text = "EDIT";
            // 
            // txtEdContact
            // 
            this.txtEdContact.Location = new System.Drawing.Point(217, 161);
            this.txtEdContact.Name = "txtEdContact";
            this.txtEdContact.Size = new System.Drawing.Size(494, 29);
            this.txtEdContact.TabIndex = 248;
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.BorderColor = System.Drawing.Color.Silver;
            this.btnEditSupp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnEditSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupp.FlatAppearance.BorderSize = 0;
            this.btnEditSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupp.Location = new System.Drawing.Point(273, 602);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEditSupp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnEditSupp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEditSupp.Size = new System.Drawing.Size(189, 40);
            this.btnEditSupp.TabIndex = 247;
            this.btnEditSupp.Text = "EDIT SUPPLIER";
            this.btnEditSupp.TextColor = System.Drawing.Color.White;
            this.btnEditSupp.UseVisualStyleBackColor = true;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnEdSuppClear
            // 
            this.btnEdSuppClear.BorderColor = System.Drawing.Color.Silver;
            this.btnEdSuppClear.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnEdSuppClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdSuppClear.FlatAppearance.BorderSize = 0;
            this.btnEdSuppClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdSuppClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdSuppClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdSuppClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdSuppClear.Location = new System.Drawing.Point(582, 40);
            this.btnEdSuppClear.Name = "btnEdSuppClear";
            this.btnEdSuppClear.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdSuppClear.onHoverButtonColor = System.Drawing.Color.White;
            this.btnEdSuppClear.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdSuppClear.Size = new System.Drawing.Size(115, 40);
            this.btnEdSuppClear.TabIndex = 246;
            this.btnEdSuppClear.Text = "CLEAR";
            this.btnEdSuppClear.TextColor = System.Drawing.Color.White;
            this.btnEdSuppClear.UseVisualStyleBackColor = true;
            this.btnEdSuppClear.Click += new System.EventHandler(this.btnEdSuppClear_Click);
            // 
            // btnEdSearchIcon
            // 
            this.btnEdSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnEdSearchIcon.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.btnEdSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdSearchIcon.Location = new System.Drawing.Point(379, 49);
            this.btnEdSearchIcon.Name = "btnEdSearchIcon";
            this.btnEdSearchIcon.Size = new System.Drawing.Size(43, 31);
            this.btnEdSearchIcon.TabIndex = 245;
            this.btnEdSearchIcon.TabStop = false;
            this.btnEdSearchIcon.Click += new System.EventHandler(this.btnEdSearchIcon_Click);
            // 
            // lblEdCompName
            // 
            this.lblEdCompName.AutoSize = true;
            this.lblEdCompName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdCompName.Location = new System.Drawing.Point(37, 109);
            this.lblEdCompName.Name = "lblEdCompName";
            this.lblEdCompName.Size = new System.Drawing.Size(159, 24);
            this.lblEdCompName.TabIndex = 244;
            this.lblEdCompName.Text = "Company Name";
            // 
            // txtEdCompName
            // 
            this.txtEdCompName.Location = new System.Drawing.Point(217, 109);
            this.txtEdCompName.Name = "txtEdCompName";
            this.txtEdCompName.Size = new System.Drawing.Size(494, 29);
            this.txtEdCompName.TabIndex = 243;
            // 
            // txtEDSuppTel
            // 
            this.txtEDSuppTel.Location = new System.Drawing.Point(217, 337);
            this.txtEDSuppTel.Name = "txtEDSuppTel";
            this.txtEDSuppTel.Size = new System.Drawing.Size(294, 29);
            this.txtEDSuppTel.TabIndex = 242;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelNo.Location = new System.Drawing.Point(37, 340);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(73, 24);
            this.lblTelNo.TabIndex = 241;
            this.lblTelNo.Text = "Tel No";
            // 
            // txtEdSuppEmail
            // 
            this.txtEdSuppEmail.Location = new System.Drawing.Point(217, 282);
            this.txtEdSuppEmail.Name = "txtEdSuppEmail";
            this.txtEdSuppEmail.Size = new System.Drawing.Size(294, 29);
            this.txtEdSuppEmail.TabIndex = 240;
            // 
            // lblEdSupEmail
            // 
            this.lblEdSupEmail.AutoSize = true;
            this.lblEdSupEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdSupEmail.Location = new System.Drawing.Point(37, 287);
            this.lblEdSupEmail.Name = "lblEdSupEmail";
            this.lblEdSupEmail.Size = new System.Drawing.Size(69, 24);
            this.lblEdSupEmail.TabIndex = 239;
            this.lblEdSupEmail.Text = "E-Mail";
            // 
            // txtEdSuppAddress
            // 
            this.txtEdSuppAddress.Location = new System.Drawing.Point(217, 221);
            this.txtEdSuppAddress.Name = "txtEdSuppAddress";
            this.txtEdSuppAddress.Size = new System.Drawing.Size(494, 29);
            this.txtEdSuppAddress.TabIndex = 232;
            // 
            // lblEdSuppAddress
            // 
            this.lblEdSuppAddress.AutoSize = true;
            this.lblEdSuppAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdSuppAddress.Location = new System.Drawing.Point(37, 224);
            this.lblEdSuppAddress.Name = "lblEdSuppAddress";
            this.lblEdSuppAddress.Size = new System.Drawing.Size(87, 24);
            this.lblEdSuppAddress.TabIndex = 231;
            this.lblEdSuppAddress.Text = "Address";
            // 
            // lblEdContact
            // 
            this.lblEdContact.AutoSize = true;
            this.lblEdContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdContact.Location = new System.Drawing.Point(37, 161);
            this.lblEdContact.Name = "lblEdContact";
            this.lblEdContact.Size = new System.Drawing.Size(174, 24);
            this.lblEdContact.TabIndex = 227;
            this.lblEdContact.Text = "Company Contact";
            // 
            // txtEdSuppID
            // 
            this.txtEdSuppID.Location = new System.Drawing.Point(216, 51);
            this.txtEdSuppID.Name = "txtEdSuppID";
            this.txtEdSuppID.Size = new System.Drawing.Size(157, 29);
            this.txtEdSuppID.TabIndex = 226;
            // 
            // lblEdSupID
            // 
            this.lblEdSupID.AutoSize = true;
            this.lblEdSupID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdSupID.Location = new System.Drawing.Point(37, 54);
            this.lblEdSupID.Name = "lblEdSupID";
            this.lblEdSupID.Size = new System.Drawing.Size(113, 24);
            this.lblEdSupID.TabIndex = 225;
            this.lblEdSupID.Text = "Supplier ID";
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.White;
            this.tabDelete.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDelete.Controls.Add(this.txtDlContact);
            this.tabDelete.Controls.Add(this.btnDeleteSupp);
            this.tabDelete.Controls.Add(this.btnDlClearSupp);
            this.tabDelete.Controls.Add(this.btnDeleteSearchIcon);
            this.tabDelete.Controls.Add(this.lblDlCompName);
            this.tabDelete.Controls.Add(this.txtDlCompName);
            this.tabDelete.Controls.Add(this.txtDlSuppTel);
            this.tabDelete.Controls.Add(this.lblDlSuppTel);
            this.tabDelete.Controls.Add(this.txtDlSuppEmail);
            this.tabDelete.Controls.Add(this.lblDlSuppEmail);
            this.tabDelete.Controls.Add(this.txtDlSuppAddress);
            this.tabDelete.Controls.Add(this.lblDlSupAddress);
            this.tabDelete.Controls.Add(this.lblDContact);
            this.tabDelete.Controls.Add(this.txtDlSuppID);
            this.tabDelete.Controls.Add(this.lblDelSuppID);
            this.tabDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDelete.Location = new System.Drawing.Point(4, 29);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(734, 688);
            this.tabDelete.TabIndex = 4;
            this.tabDelete.Text = "DELETE";
            // 
            // txtDlContact
            // 
            this.txtDlContact.Location = new System.Drawing.Point(218, 161);
            this.txtDlContact.Name = "txtDlContact";
            this.txtDlContact.Size = new System.Drawing.Size(494, 29);
            this.txtDlContact.TabIndex = 248;
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSupp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupp.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupp.Location = new System.Drawing.Point(273, 602);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDeleteSupp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDeleteSupp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDeleteSupp.Size = new System.Drawing.Size(189, 40);
            this.btnDeleteSupp.TabIndex = 247;
            this.btnDeleteSupp.Text = "DELETE SUPPLIER";
            this.btnDeleteSupp.TextColor = System.Drawing.Color.White;
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnDlClearSupp
            // 
            this.btnDlClearSupp.BorderColor = System.Drawing.Color.Silver;
            this.btnDlClearSupp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnDlClearSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDlClearSupp.FlatAppearance.BorderSize = 0;
            this.btnDlClearSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDlClearSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDlClearSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlClearSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlClearSupp.Location = new System.Drawing.Point(582, 47);
            this.btnDlClearSupp.Name = "btnDlClearSupp";
            this.btnDlClearSupp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDlClearSupp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnDlClearSupp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnDlClearSupp.Size = new System.Drawing.Size(115, 40);
            this.btnDlClearSupp.TabIndex = 246;
            this.btnDlClearSupp.Text = "CLEAR";
            this.btnDlClearSupp.TextColor = System.Drawing.Color.White;
            this.btnDlClearSupp.UseVisualStyleBackColor = true;
            this.btnDlClearSupp.Click += new System.EventHandler(this.btnDlClearSupp_Click);
            // 
            // btnDeleteSearchIcon
            // 
            this.btnDeleteSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSearchIcon.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.btnDeleteSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSearchIcon.Location = new System.Drawing.Point(395, 49);
            this.btnDeleteSearchIcon.Name = "btnDeleteSearchIcon";
            this.btnDeleteSearchIcon.Size = new System.Drawing.Size(43, 31);
            this.btnDeleteSearchIcon.TabIndex = 245;
            this.btnDeleteSearchIcon.TabStop = false;
            this.btnDeleteSearchIcon.Click += new System.EventHandler(this.btnDeleteSearchIcon_Click);
            // 
            // lblDlCompName
            // 
            this.lblDlCompName.AutoSize = true;
            this.lblDlCompName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDlCompName.Location = new System.Drawing.Point(37, 109);
            this.lblDlCompName.Name = "lblDlCompName";
            this.lblDlCompName.Size = new System.Drawing.Size(159, 24);
            this.lblDlCompName.TabIndex = 244;
            this.lblDlCompName.Text = "Company Name";
            // 
            // txtDlCompName
            // 
            this.txtDlCompName.Location = new System.Drawing.Point(218, 106);
            this.txtDlCompName.Name = "txtDlCompName";
            this.txtDlCompName.Size = new System.Drawing.Size(494, 29);
            this.txtDlCompName.TabIndex = 243;
            // 
            // txtDlSuppTel
            // 
            this.txtDlSuppTel.Location = new System.Drawing.Point(218, 342);
            this.txtDlSuppTel.Name = "txtDlSuppTel";
            this.txtDlSuppTel.Size = new System.Drawing.Size(294, 29);
            this.txtDlSuppTel.TabIndex = 242;
            // 
            // lblDlSuppTel
            // 
            this.lblDlSuppTel.AutoSize = true;
            this.lblDlSuppTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDlSuppTel.Location = new System.Drawing.Point(33, 345);
            this.lblDlSuppTel.Name = "lblDlSuppTel";
            this.lblDlSuppTel.Size = new System.Drawing.Size(73, 24);
            this.lblDlSuppTel.TabIndex = 241;
            this.lblDlSuppTel.Text = "Tel No";
            // 
            // txtDlSuppEmail
            // 
            this.txtDlSuppEmail.Location = new System.Drawing.Point(218, 287);
            this.txtDlSuppEmail.Name = "txtDlSuppEmail";
            this.txtDlSuppEmail.Size = new System.Drawing.Size(294, 29);
            this.txtDlSuppEmail.TabIndex = 240;
            // 
            // lblDlSuppEmail
            // 
            this.lblDlSuppEmail.AutoSize = true;
            this.lblDlSuppEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDlSuppEmail.Location = new System.Drawing.Point(37, 290);
            this.lblDlSuppEmail.Name = "lblDlSuppEmail";
            this.lblDlSuppEmail.Size = new System.Drawing.Size(69, 24);
            this.lblDlSuppEmail.TabIndex = 239;
            this.lblDlSuppEmail.Text = "E-Mail";
            // 
            // txtDlSuppAddress
            // 
            this.txtDlSuppAddress.Location = new System.Drawing.Point(218, 219);
            this.txtDlSuppAddress.Name = "txtDlSuppAddress";
            this.txtDlSuppAddress.Size = new System.Drawing.Size(494, 29);
            this.txtDlSuppAddress.TabIndex = 232;
            // 
            // lblDlSupAddress
            // 
            this.lblDlSupAddress.AutoSize = true;
            this.lblDlSupAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDlSupAddress.Location = new System.Drawing.Point(37, 224);
            this.lblDlSupAddress.Name = "lblDlSupAddress";
            this.lblDlSupAddress.Size = new System.Drawing.Size(87, 24);
            this.lblDlSupAddress.TabIndex = 231;
            this.lblDlSupAddress.Text = "Address";
            // 
            // lblDContact
            // 
            this.lblDContact.AutoSize = true;
            this.lblDContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDContact.Location = new System.Drawing.Point(37, 161);
            this.lblDContact.Name = "lblDContact";
            this.lblDContact.Size = new System.Drawing.Size(174, 24);
            this.lblDContact.TabIndex = 227;
            this.lblDContact.Text = "Company Contact";
            // 
            // txtDlSuppID
            // 
            this.txtDlSuppID.Location = new System.Drawing.Point(218, 47);
            this.txtDlSuppID.Name = "txtDlSuppID";
            this.txtDlSuppID.Size = new System.Drawing.Size(157, 29);
            this.txtDlSuppID.TabIndex = 226;
            // 
            // lblDelSuppID
            // 
            this.lblDelSuppID.AutoSize = true;
            this.lblDelSuppID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDelSuppID.Location = new System.Drawing.Point(37, 54);
            this.lblDelSuppID.Name = "lblDelSuppID";
            this.lblDelSuppID.Size = new System.Drawing.Size(113, 24);
            this.lblDelSuppID.TabIndex = 225;
            this.lblDelSuppID.Text = "Supplier ID";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 723);
            this.Controls.Add(this.tabSupplier);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.Supplier_load);
            this.Shown += new System.EventHandler(this.frmSuppliers_Shown);
            this.tabSupplier.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconSE)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdSearchIcon)).EndInit();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSupplier;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblSeCompName;
        private System.Windows.Forms.TextBox txtSeCompName;
        private System.Windows.Forms.TextBox txtSeSuppTel;
        private System.Windows.Forms.Label lblSeSuppTel;
        private System.Windows.Forms.TextBox txtSeSuppEmail;
        private System.Windows.Forms.Label lblSeSuppEmail;
        private System.Windows.Forms.TextBox txtSeSuppAddress;
        private System.Windows.Forms.Label lblSeSuppAddress;
        private System.Windows.Forms.Label lblSeSuppContact;
        private System.Windows.Forms.TextBox txtSeSuppID;
        private System.Windows.Forms.Label lblSeSuppID;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
        private RoundButton roundButton1;
        private RoundButton btnSeSuppClear;
        private System.Windows.Forms.PictureBox SearchIconSE;
        private RoundButton btnPrintSupplier;
        private RoundButton BtnSaveSup;
        private RoundButton btnClearSup;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtSupTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSupAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSupID;
        private RoundButton btnEditSupp;
        private RoundButton btnEdSuppClear;
        private System.Windows.Forms.PictureBox btnEdSearchIcon;
        private System.Windows.Forms.Label lblEdCompName;
        private System.Windows.Forms.TextBox txtEdCompName;
        private System.Windows.Forms.TextBox txtEDSuppTel;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtEdSuppEmail;
        private System.Windows.Forms.Label lblEdSupEmail;
        private System.Windows.Forms.TextBox txtEdSuppAddress;
        private System.Windows.Forms.Label lblEdSuppAddress;
        private System.Windows.Forms.Label lblEdContact;
        private System.Windows.Forms.TextBox txtEdSuppID;
        private System.Windows.Forms.Label lblEdSupID;
        private RoundButton btnDeleteSupp;
        private RoundButton btnDlClearSupp;
        private System.Windows.Forms.PictureBox btnDeleteSearchIcon;
        private System.Windows.Forms.Label lblDlCompName;
        private System.Windows.Forms.TextBox txtDlCompName;
        private System.Windows.Forms.TextBox txtDlSuppTel;
        private System.Windows.Forms.Label lblDlSuppTel;
        private System.Windows.Forms.TextBox txtDlSuppEmail;
        private System.Windows.Forms.Label lblDlSuppEmail;
        private System.Windows.Forms.TextBox txtDlSuppAddress;
        private System.Windows.Forms.Label lblDlSupAddress;
        private System.Windows.Forms.TextBox txtDlSuppID;
        private System.Windows.Forms.Label lblDelSuppID;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.TextBox txtSeContactName;
        private System.Windows.Forms.TextBox txtSupEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtEdContact;
        private System.Windows.Forms.TextBox txtDlContact;
        private System.Windows.Forms.Label lblDContact;
    }
}