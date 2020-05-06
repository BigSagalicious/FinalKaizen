namespace KaizenMain
{
    partial class frmInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInv));
            this.tabInv = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.dgvPayTrans = new System.Windows.Forms.DataGridView();
            this.tabMakePay = new System.Windows.Forms.TabPage();
            this.dtpPPay = new System.Windows.Forms.DateTimePicker();
            this.lblPPayOut = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPPayTot = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPPayCustName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPPayCustNo = new System.Windows.Forms.Label();
            this.lblPPayTranType = new System.Windows.Forms.Label();
            this.lblPPayInvID = new System.Windows.Forms.Label();
            this.btnPPay = new KaizenMain.RoundButton();
            this.pBPPayTransSearch = new System.Windows.Forms.PictureBox();
            this.roundButton15 = new KaizenMain.RoundButton();
            this.dgvPPay = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBPayTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPPayTransID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAddCreditAcc = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPayTodayTot = new System.Windows.Forms.Label();
            this.lblMultiOutstanding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSInvLeft = new System.Windows.Forms.PictureBox();
            this.pbSInvRight = new System.Windows.Forms.PictureBox();
            this.dgvMultiPay = new System.Windows.Forms.DataGridView();
            this.dgvLoadTrans = new System.Windows.Forms.DataGridView();
            this.btnConfirmPay = new KaizenMain.RoundButton();
            this.pbSearchCustomer = new System.Windows.Forms.PictureBox();
            this.btnMultiClear = new KaizenMain.RoundButton();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPastPayments = new System.Windows.Forms.TabPage();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSICustName = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.tabInv.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayTrans)).BeginInit();
            this.tabMakePay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPPayTransSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPay)).BeginInit();
            this.tabAddCreditAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSInvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSInvRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).BeginInit();
            this.tabPastPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInv
            // 
            this.tabInv.AllowDrop = true;
            this.tabInv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabInv.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabInv.Controls.Add(this.tabDisplay);
            this.tabInv.Controls.Add(this.tabMakePay);
            this.tabInv.Controls.Add(this.tabAddCreditAcc);
            this.tabInv.Controls.Add(this.tabPastPayments);
            this.tabInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInv.ItemSize = new System.Drawing.Size(182, 25);
            this.tabInv.Location = new System.Drawing.Point(3, 2);
            this.tabInv.Multiline = true;
            this.tabInv.Name = "tabInv";
            this.tabInv.SelectedIndex = 0;
            this.tabInv.Size = new System.Drawing.Size(742, 721);
            this.tabInv.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabInv.TabIndex = 7;
            this.tabInv.TabStop = false;
            this.tabInv.SelectedIndexChanged += new System.EventHandler(this.tabPayment_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(159)))));
            this.tabDisplay.Controls.Add(this.dgvPayTrans);
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(734, 688);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "OVERDUE";
            // 
            // dgvPayTrans
            // 
            this.dgvPayTrans.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPayTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayTrans.Location = new System.Drawing.Point(6, 9);
            this.dgvPayTrans.Name = "dgvPayTrans";
            this.dgvPayTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayTrans.Size = new System.Drawing.Size(722, 670);
            this.dgvPayTrans.TabIndex = 1;
            // 
            // tabMakePay
            // 
            this.tabMakePay.BackColor = System.Drawing.Color.White;
            this.tabMakePay.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabMakePay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMakePay.Controls.Add(this.dtpPPay);
            this.tabMakePay.Controls.Add(this.lblPPayOut);
            this.tabMakePay.Controls.Add(this.label19);
            this.tabMakePay.Controls.Add(this.lblPPayTot);
            this.tabMakePay.Controls.Add(this.label17);
            this.tabMakePay.Controls.Add(this.lblPPayCustName);
            this.tabMakePay.Controls.Add(this.label15);
            this.tabMakePay.Controls.Add(this.lblPPayCustNo);
            this.tabMakePay.Controls.Add(this.lblPPayTranType);
            this.tabMakePay.Controls.Add(this.lblPPayInvID);
            this.tabMakePay.Controls.Add(this.btnPPay);
            this.tabMakePay.Controls.Add(this.pBPPayTransSearch);
            this.tabMakePay.Controls.Add(this.roundButton15);
            this.tabMakePay.Controls.Add(this.dgvPPay);
            this.tabMakePay.Controls.Add(this.label26);
            this.tabMakePay.Controls.Add(this.txtBPayTo);
            this.tabMakePay.Controls.Add(this.label9);
            this.tabMakePay.Controls.Add(this.label10);
            this.tabMakePay.Controls.Add(this.txtPPayTransID);
            this.tabMakePay.Controls.Add(this.label11);
            this.tabMakePay.Controls.Add(this.label12);
            this.tabMakePay.Location = new System.Drawing.Point(4, 29);
            this.tabMakePay.Name = "tabMakePay";
            this.tabMakePay.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakePay.Size = new System.Drawing.Size(734, 688);
            this.tabMakePay.TabIndex = 1;
            this.tabMakePay.Text = "PART PAYMENT";
            // 
            // dtpPPay
            // 
            this.dtpPPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPPay.Location = new System.Drawing.Point(508, 30);
            this.dtpPPay.Name = "dtpPPay";
            this.dtpPPay.Size = new System.Drawing.Size(200, 26);
            this.dtpPPay.TabIndex = 183;
            // 
            // lblPPayOut
            // 
            this.lblPPayOut.AutoSize = true;
            this.lblPPayOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayOut.Location = new System.Drawing.Point(230, 293);
            this.lblPPayOut.Name = "lblPPayOut";
            this.lblPPayOut.Size = new System.Drawing.Size(17, 24);
            this.lblPPayOut.TabIndex = 182;
            this.lblPPayOut.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(44, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 24);
            this.label19.TabIndex = 181;
            this.label19.Text = "Outstanding:      £";
            // 
            // lblPPayTot
            // 
            this.lblPPayTot.AutoSize = true;
            this.lblPPayTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayTot.Location = new System.Drawing.Point(230, 251);
            this.lblPPayTot.Name = "lblPPayTot";
            this.lblPPayTot.Size = new System.Drawing.Size(17, 24);
            this.lblPPayTot.TabIndex = 180;
            this.lblPPayTot.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(44, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 24);
            this.label17.TabIndex = 179;
            this.label17.Text = "Total:                 £";
            // 
            // lblPPayCustName
            // 
            this.lblPPayCustName.AutoSize = true;
            this.lblPPayCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayCustName.Location = new System.Drawing.Point(230, 212);
            this.lblPPayCustName.Name = "lblPPayCustName";
            this.lblPPayCustName.Size = new System.Drawing.Size(17, 24);
            this.lblPPayCustName.TabIndex = 178;
            this.lblPPayCustName.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(44, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 24);
            this.label15.TabIndex = 177;
            this.label15.Text = "Customer Name";
            // 
            // lblPPayCustNo
            // 
            this.lblPPayCustNo.AutoSize = true;
            this.lblPPayCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayCustNo.Location = new System.Drawing.Point(230, 173);
            this.lblPPayCustNo.Name = "lblPPayCustNo";
            this.lblPPayCustNo.Size = new System.Drawing.Size(17, 24);
            this.lblPPayCustNo.TabIndex = 176;
            this.lblPPayCustNo.Text = "-";
            // 
            // lblPPayTranType
            // 
            this.lblPPayTranType.AutoSize = true;
            this.lblPPayTranType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayTranType.Location = new System.Drawing.Point(230, 136);
            this.lblPPayTranType.Name = "lblPPayTranType";
            this.lblPPayTranType.Size = new System.Drawing.Size(17, 24);
            this.lblPPayTranType.TabIndex = 175;
            this.lblPPayTranType.Text = "-";
            // 
            // lblPPayInvID
            // 
            this.lblPPayInvID.AutoSize = true;
            this.lblPPayInvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPPayInvID.Location = new System.Drawing.Point(230, 60);
            this.lblPPayInvID.Name = "lblPPayInvID";
            this.lblPPayInvID.Size = new System.Drawing.Size(17, 24);
            this.lblPPayInvID.TabIndex = 174;
            this.lblPPayInvID.Text = "-";
            // 
            // btnPPay
            // 
            this.btnPPay.BackColor = System.Drawing.Color.White;
            this.btnPPay.BorderColor = System.Drawing.Color.Silver;
            this.btnPPay.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnPPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPPay.FlatAppearance.BorderSize = 0;
            this.btnPPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPay.Location = new System.Drawing.Point(298, 622);
            this.btnPPay.Name = "btnPPay";
            this.btnPPay.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnPPay.onHoverButtonColor = System.Drawing.Color.White;
            this.btnPPay.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnPPay.Size = new System.Drawing.Size(189, 40);
            this.btnPPay.TabIndex = 171;
            this.btnPPay.Text = "PAY";
            this.btnPPay.TextColor = System.Drawing.Color.White;
            this.btnPPay.UseVisualStyleBackColor = false;
            this.btnPPay.Click += new System.EventHandler(this.btnPPay_Click);
            // 
            // pBPPayTransSearch
            // 
            this.pBPPayTransSearch.BackColor = System.Drawing.Color.Transparent;
            this.pBPPayTransSearch.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pBPPayTransSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBPPayTransSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBPPayTransSearch.Location = new System.Drawing.Point(407, 94);
            this.pBPPayTransSearch.Name = "pBPPayTransSearch";
            this.pBPPayTransSearch.Size = new System.Drawing.Size(43, 31);
            this.pBPPayTransSearch.TabIndex = 169;
            this.pBPPayTransSearch.TabStop = false;
            // 
            // roundButton15
            // 
            this.roundButton15.BorderColor = System.Drawing.Color.Silver;
            this.roundButton15.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton15.FlatAppearance.BorderSize = 0;
            this.roundButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton15.Location = new System.Drawing.Point(526, 205);
            this.roundButton15.Name = "roundButton15";
            this.roundButton15.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton15.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.Size = new System.Drawing.Size(163, 40);
            this.roundButton15.TabIndex = 168;
            this.roundButton15.Text = "CLEAR";
            this.roundButton15.TextColor = System.Drawing.Color.White;
            this.roundButton15.UseVisualStyleBackColor = true;
            // 
            // dgvPPay
            // 
            this.dgvPPay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPPay.Location = new System.Drawing.Point(27, 332);
            this.dgvPPay.Name = "dgvPPay";
            this.dgvPPay.Size = new System.Drawing.Size(681, 216);
            this.dgvPPay.TabIndex = 34;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(44, 173);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(180, 24);
            this.label26.TabIndex = 31;
            this.label26.Text = "Customer Number";
            // 
            // txtBPayTo
            // 
            this.txtBPayTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBPayTo.Location = new System.Drawing.Point(370, 567);
            this.txtBPayTo.Name = "txtBPayTo";
            this.txtBPayTo.Size = new System.Drawing.Size(185, 29);
            this.txtBPayTo.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(180, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pay Today          £";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(44, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Transaction Type";
            // 
            // txtPPayTransID
            // 
            this.txtPPayTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPPayTransID.Location = new System.Drawing.Point(234, 94);
            this.txtPPayTransID.Name = "txtPPayTransID";
            this.txtPPayTransID.Size = new System.Drawing.Size(149, 29);
            this.txtPPayTransID.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(44, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Transaction ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(44, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Invoice ID";
            // 
            // tabAddCreditAcc
            // 
            this.tabAddCreditAcc.BackColor = System.Drawing.Color.White;
            this.tabAddCreditAcc.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabAddCreditAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAddCreditAcc.Controls.Add(this.lblSICustName);
            this.tabAddCreditAcc.Controls.Add(this.dateTimePicker1);
            this.tabAddCreditAcc.Controls.Add(this.lblPayTodayTot);
            this.tabAddCreditAcc.Controls.Add(this.lblMultiOutstanding);
            this.tabAddCreditAcc.Controls.Add(this.label2);
            this.tabAddCreditAcc.Controls.Add(this.label1);
            this.tabAddCreditAcc.Controls.Add(this.pbSInvLeft);
            this.tabAddCreditAcc.Controls.Add(this.pbSInvRight);
            this.tabAddCreditAcc.Controls.Add(this.dgvMultiPay);
            this.tabAddCreditAcc.Controls.Add(this.dgvLoadTrans);
            this.tabAddCreditAcc.Controls.Add(this.btnConfirmPay);
            this.tabAddCreditAcc.Controls.Add(this.pbSearchCustomer);
            this.tabAddCreditAcc.Controls.Add(this.btnMultiClear);
            this.tabAddCreditAcc.Controls.Add(this.txtCustID);
            this.tabAddCreditAcc.Controls.Add(this.label28);
            this.tabAddCreditAcc.Location = new System.Drawing.Point(4, 29);
            this.tabAddCreditAcc.Name = "tabAddCreditAcc";
            this.tabAddCreditAcc.Size = new System.Drawing.Size(734, 688);
            this.tabAddCreditAcc.TabIndex = 2;
            this.tabAddCreditAcc.Text = "SETTLE INVOICE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 208;
            // 
            // lblPayTodayTot
            // 
            this.lblPayTodayTot.AutoSize = true;
            this.lblPayTodayTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPayTodayTot.Location = new System.Drawing.Point(586, 436);
            this.lblPayTodayTot.Name = "lblPayTodayTot";
            this.lblPayTodayTot.Size = new System.Drawing.Size(17, 24);
            this.lblPayTodayTot.TabIndex = 207;
            this.lblPayTodayTot.Text = "-";
            // 
            // lblMultiOutstanding
            // 
            this.lblMultiOutstanding.AutoSize = true;
            this.lblMultiOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMultiOutstanding.Location = new System.Drawing.Point(232, 436);
            this.lblMultiOutstanding.Name = "lblMultiOutstanding";
            this.lblMultiOutstanding.Size = new System.Drawing.Size(17, 24);
            this.lblMultiOutstanding.TabIndex = 206;
            this.lblMultiOutstanding.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(408, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 205;
            this.label2.Text = "Pay Today    £";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 204;
            this.label1.Text = "Still Outstanding £";
            // 
            // pbSInvLeft
            // 
            this.pbSInvLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbSInvLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSInvLeft.BackgroundImage")));
            this.pbSInvLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSInvLeft.Location = new System.Drawing.Point(346, 273);
            this.pbSInvLeft.Name = "pbSInvLeft";
            this.pbSInvLeft.Size = new System.Drawing.Size(48, 41);
            this.pbSInvLeft.TabIndex = 202;
            this.pbSInvLeft.TabStop = false;
            this.pbSInvLeft.Click += new System.EventHandler(this.pbSInvLeft_Click);
            // 
            // pbSInvRight
            // 
            this.pbSInvRight.BackColor = System.Drawing.Color.Transparent;
            this.pbSInvRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSInvRight.BackgroundImage")));
            this.pbSInvRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSInvRight.Location = new System.Drawing.Point(346, 226);
            this.pbSInvRight.Name = "pbSInvRight";
            this.pbSInvRight.Size = new System.Drawing.Size(48, 41);
            this.pbSInvRight.TabIndex = 201;
            this.pbSInvRight.TabStop = false;
            this.pbSInvRight.Click += new System.EventHandler(this.pbSInvRight_Click);
            // 
            // dgvMultiPay
            // 
            this.dgvMultiPay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMultiPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiPay.Location = new System.Drawing.Point(412, 127);
            this.dgvMultiPay.Name = "dgvMultiPay";
            this.dgvMultiPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultiPay.Size = new System.Drawing.Size(275, 289);
            this.dgvMultiPay.TabIndex = 200;
            // 
            // dgvLoadTrans
            // 
            this.dgvLoadTrans.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoadTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTrans.Location = new System.Drawing.Point(50, 127);
            this.dgvLoadTrans.Name = "dgvLoadTrans";
            this.dgvLoadTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTrans.Size = new System.Drawing.Size(275, 289);
            this.dgvLoadTrans.TabIndex = 199;
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.BackColor = System.Drawing.Color.White;
            this.btnConfirmPay.BorderColor = System.Drawing.Color.Silver;
            this.btnConfirmPay.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPay.FlatAppearance.BorderSize = 0;
            this.btnConfirmPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPay.Location = new System.Drawing.Point(276, 550);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnConfirmPay.onHoverButtonColor = System.Drawing.Color.White;
            this.btnConfirmPay.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnConfirmPay.Size = new System.Drawing.Size(189, 40);
            this.btnConfirmPay.TabIndex = 197;
            this.btnConfirmPay.Text = "CONFIRM PAYMENT";
            this.btnConfirmPay.TextColor = System.Drawing.Color.White;
            this.btnConfirmPay.UseVisualStyleBackColor = false;
            this.btnConfirmPay.Click += new System.EventHandler(this.btnConfirmPay_Click);
            // 
            // pbSearchCustomer
            // 
            this.pbSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchCustomer.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pbSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchCustomer.Location = new System.Drawing.Point(441, 31);
            this.pbSearchCustomer.Name = "pbSearchCustomer";
            this.pbSearchCustomer.Size = new System.Drawing.Size(43, 31);
            this.pbSearchCustomer.TabIndex = 195;
            this.pbSearchCustomer.TabStop = false;
            this.pbSearchCustomer.Click += new System.EventHandler(this.pbSearchCustomer_Click);
            // 
            // btnMultiClear
            // 
            this.btnMultiClear.BorderColor = System.Drawing.Color.Silver;
            this.btnMultiClear.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnMultiClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiClear.FlatAppearance.BorderSize = 0;
            this.btnMultiClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMultiClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMultiClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiClear.Location = new System.Drawing.Point(572, 27);
            this.btnMultiClear.Name = "btnMultiClear";
            this.btnMultiClear.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnMultiClear.onHoverButtonColor = System.Drawing.Color.White;
            this.btnMultiClear.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnMultiClear.Size = new System.Drawing.Size(115, 40);
            this.btnMultiClear.TabIndex = 193;
            this.btnMultiClear.Text = "CLEAR";
            this.btnMultiClear.TextColor = System.Drawing.Color.White;
            this.btnMultiClear.UseVisualStyleBackColor = true;
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCustID.Location = new System.Drawing.Point(236, 31);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(185, 29);
            this.txtCustID.TabIndex = 176;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(46, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(124, 24);
            this.label28.TabIndex = 175;
            this.label28.Text = "Customer ID";
            // 
            // tabPastPayments
            // 
            this.tabPastPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(119)))), ((int)(((byte)(159)))));
            this.tabPastPayments.Controls.Add(this.dgvPayments);
            this.tabPastPayments.Location = new System.Drawing.Point(4, 29);
            this.tabPastPayments.Name = "tabPastPayments";
            this.tabPastPayments.Size = new System.Drawing.Size(734, 688);
            this.tabPastPayments.TabIndex = 3;
            this.tabPastPayments.Text = "PAST PAYMENTS";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // lblSICustName
            // 
            this.lblSICustName.AutoSize = true;
            this.lblSICustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSICustName.Location = new System.Drawing.Point(148, 83);
            this.lblSICustName.Name = "lblSICustName";
            this.lblSICustName.Size = new System.Drawing.Size(160, 24);
            this.lblSICustName.TabIndex = 209;
            this.lblSICustName.Text = "Customer Name";
            // 
            // dgvPayments
            // 
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(6, 9);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(722, 670);
            this.dgvPayments.TabIndex = 2;
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 723);
            this.Controls.Add(this.tabInv);
            this.Name = "frmInv";
            this.Text = "frmInv";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.Shown += new System.EventHandler(this.frmPayments_Shown);
            this.tabInv.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayTrans)).EndInit();
            this.tabMakePay.ResumeLayout(false);
            this.tabMakePay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPPayTransSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPay)).EndInit();
            this.tabAddCreditAcc.ResumeLayout(false);
            this.tabAddCreditAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSInvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSInvRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).EndInit();
            this.tabPastPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInv;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabMakePay;
        private System.Windows.Forms.TextBox txtBPayTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPPayTransID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabAddCreditAcc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvPPay;
        private RoundButton roundButton15;
        private System.Windows.Forms.PictureBox pBPPayTransSearch;
        private RoundButton btnPPay;
        private RoundButton btnConfirmPay;
        private System.Windows.Forms.PictureBox pbSearchCustomer;
        private RoundButton btnMultiClear;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblPPayInvID;
        private System.Windows.Forms.Label lblPPayOut;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPPayTot;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPPayCustName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPPayCustNo;
        private System.Windows.Forms.Label lblPPayTranType;
        private System.Windows.Forms.DataGridView dgvPayTrans;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.DateTimePicker dtpPPay;
        private System.Windows.Forms.TabPage tabPastPayments;
        private System.Windows.Forms.PictureBox pbSInvLeft;
        private System.Windows.Forms.PictureBox pbSInvRight;
        private System.Windows.Forms.DataGridView dgvMultiPay;
        private System.Windows.Forms.DataGridView dgvLoadTrans;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPayTodayTot;
        private System.Windows.Forms.Label lblMultiOutstanding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSICustName;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}