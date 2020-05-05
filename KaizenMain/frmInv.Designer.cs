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
            this.tabInv = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.tabMakePay = new System.Windows.Forms.TabPage();
            this.rBCreditAccount = new System.Windows.Forms.RadioButton();
            this.rBTansPayment = new System.Windows.Forms.RadioButton();
            this.roundButton16 = new KaizenMain.RoundButton();
            this.roundButton17 = new KaizenMain.RoundButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.roundButton15 = new KaizenMain.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAddCreditAcc = new System.Windows.Forms.TabPage();
            this.roundButton7 = new KaizenMain.RoundButton();
            this.roundButton5 = new KaizenMain.RoundButton();
            this.roundButton6 = new KaizenMain.RoundButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundButton4 = new KaizenMain.RoundButton();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabInv.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.tabMakePay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAddCreditAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInv.ItemSize = new System.Drawing.Size(244, 25);
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
            this.tabDisplay.Controls.Add(this.dgvInvoice);
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(734, 688);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "DISPLAY PAYMENTS";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(6, 6);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(722, 673);
            this.dgvInvoice.TabIndex = 2;
            // 
            // tabMakePay
            // 
            this.tabMakePay.BackColor = System.Drawing.Color.White;
            this.tabMakePay.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabMakePay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMakePay.Controls.Add(this.rBCreditAccount);
            this.tabMakePay.Controls.Add(this.rBTansPayment);
            this.tabMakePay.Controls.Add(this.roundButton16);
            this.tabMakePay.Controls.Add(this.roundButton17);
            this.tabMakePay.Controls.Add(this.pictureBox6);
            this.tabMakePay.Controls.Add(this.roundButton15);
            this.tabMakePay.Controls.Add(this.dataGridView1);
            this.tabMakePay.Controls.Add(this.label27);
            this.tabMakePay.Controls.Add(this.textBox27);
            this.tabMakePay.Controls.Add(this.label26);
            this.tabMakePay.Controls.Add(this.textBox26);
            this.tabMakePay.Controls.Add(this.textBox7);
            this.tabMakePay.Controls.Add(this.label7);
            this.tabMakePay.Controls.Add(this.textBox8);
            this.tabMakePay.Controls.Add(this.label8);
            this.tabMakePay.Controls.Add(this.textBox9);
            this.tabMakePay.Controls.Add(this.label9);
            this.tabMakePay.Controls.Add(this.textBox10);
            this.tabMakePay.Controls.Add(this.label10);
            this.tabMakePay.Controls.Add(this.textBox11);
            this.tabMakePay.Controls.Add(this.label11);
            this.tabMakePay.Controls.Add(this.textBox12);
            this.tabMakePay.Controls.Add(this.label12);
            this.tabMakePay.Location = new System.Drawing.Point(4, 29);
            this.tabMakePay.Name = "tabMakePay";
            this.tabMakePay.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakePay.Size = new System.Drawing.Size(734, 688);
            this.tabMakePay.TabIndex = 1;
            this.tabMakePay.Text = "MAKE PAYMENT";
            // 
            // rBCreditAccount
            // 
            this.rBCreditAccount.AutoSize = true;
            this.rBCreditAccount.Location = new System.Drawing.Point(390, 18);
            this.rBCreditAccount.Name = "rBCreditAccount";
            this.rBCreditAccount.Size = new System.Drawing.Size(109, 17);
            this.rBCreditAccount.TabIndex = 173;
            this.rBCreditAccount.TabStop = true;
            this.rBCreditAccount.Text = "Credit Account";
            this.rBCreditAccount.UseVisualStyleBackColor = true;
            // 
            // rBTansPayment
            // 
            this.rBTansPayment.AutoSize = true;
            this.rBTansPayment.Location = new System.Drawing.Point(173, 18);
            this.rBTansPayment.Name = "rBTansPayment";
            this.rBTansPayment.Size = new System.Drawing.Size(88, 17);
            this.rBTansPayment.TabIndex = 172;
            this.rBTansPayment.TabStop = true;
            this.rBTansPayment.Text = "Tansaction";
            this.rBTansPayment.UseVisualStyleBackColor = true;
            // 
            // roundButton16
            // 
            this.roundButton16.BackColor = System.Drawing.Color.White;
            this.roundButton16.BorderColor = System.Drawing.Color.Silver;
            this.roundButton16.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton16.FlatAppearance.BorderSize = 0;
            this.roundButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton16.Location = new System.Drawing.Point(173, 619);
            this.roundButton16.Name = "roundButton16";
            this.roundButton16.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton16.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton16.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton16.Size = new System.Drawing.Size(189, 40);
            this.roundButton16.TabIndex = 171;
            this.roundButton16.Text = "E-MAIL INVOICE";
            this.roundButton16.TextColor = System.Drawing.Color.White;
            this.roundButton16.UseVisualStyleBackColor = false;
            // 
            // roundButton17
            // 
            this.roundButton17.BackColor = System.Drawing.Color.White;
            this.roundButton17.BorderColor = System.Drawing.Color.Silver;
            this.roundButton17.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton17.FlatAppearance.BorderSize = 0;
            this.roundButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton17.Location = new System.Drawing.Point(390, 619);
            this.roundButton17.Name = "roundButton17";
            this.roundButton17.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton17.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton17.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton17.Size = new System.Drawing.Size(189, 40);
            this.roundButton17.TabIndex = 170;
            this.roundButton17.Text = "PRINT INVOICE";
            this.roundButton17.TextColor = System.Drawing.Color.White;
            this.roundButton17.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(434, 55);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 31);
            this.pictureBox6.TabIndex = 169;
            this.pictureBox6.TabStop = false;
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
            this.roundButton15.Location = new System.Drawing.Point(574, 44);
            this.roundButton15.Name = "roundButton15";
            this.roundButton15.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton15.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.Size = new System.Drawing.Size(115, 40);
            this.roundButton15.TabIndex = 168;
            this.roundButton15.Text = "CLEAR";
            this.roundButton15.TextColor = System.Drawing.Color.White;
            this.roundButton15.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 181);
            this.dataGridView1.TabIndex = 34;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(44, 259);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 24);
            this.label27.TabIndex = 33;
            this.label27.Text = "Supplier Name";
            // 
            // textBox27
            // 
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox27.Location = new System.Drawing.Point(234, 338);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(185, 29);
            this.textBox27.TabIndex = 32;
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
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox26.Location = new System.Drawing.Point(234, 170);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(185, 29);
            this.textBox26.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(234, 297);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(185, 29);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(44, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Supplier No";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(234, 256);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(185, 29);
            this.textBox8.TabIndex = 24;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(44, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Invoice Paid";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox9.Location = new System.Drawing.Point(234, 213);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(185, 29);
            this.textBox9.TabIndex = 22;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(44, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Price";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox10.Location = new System.Drawing.Point(234, 133);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(185, 29);
            this.textBox10.TabIndex = 20;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
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
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox11.Location = new System.Drawing.Point(234, 94);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(185, 29);
            this.textBox11.TabIndex = 18;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
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
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox12.Location = new System.Drawing.Point(234, 57);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(185, 29);
            this.textBox12.TabIndex = 16;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tabAddCreditAcc
            // 
            this.tabAddCreditAcc.BackColor = System.Drawing.Color.White;
            this.tabAddCreditAcc.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabAddCreditAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAddCreditAcc.Controls.Add(this.roundButton7);
            this.tabAddCreditAcc.Controls.Add(this.roundButton5);
            this.tabAddCreditAcc.Controls.Add(this.roundButton6);
            this.tabAddCreditAcc.Controls.Add(this.pictureBox3);
            this.tabAddCreditAcc.Controls.Add(this.pictureBox1);
            this.tabAddCreditAcc.Controls.Add(this.roundButton4);
            this.tabAddCreditAcc.Controls.Add(this.textBox33);
            this.tabAddCreditAcc.Controls.Add(this.label34);
            this.tabAddCreditAcc.Controls.Add(this.label1);
            this.tabAddCreditAcc.Controls.Add(this.textBox1);
            this.tabAddCreditAcc.Controls.Add(this.label2);
            this.tabAddCreditAcc.Controls.Add(this.textBox2);
            this.tabAddCreditAcc.Controls.Add(this.textBox3);
            this.tabAddCreditAcc.Controls.Add(this.label3);
            this.tabAddCreditAcc.Controls.Add(this.textBox4);
            this.tabAddCreditAcc.Controls.Add(this.label4);
            this.tabAddCreditAcc.Controls.Add(this.textBox5);
            this.tabAddCreditAcc.Controls.Add(this.label5);
            this.tabAddCreditAcc.Controls.Add(this.textBox6);
            this.tabAddCreditAcc.Controls.Add(this.label6);
            this.tabAddCreditAcc.Controls.Add(this.textBox25);
            this.tabAddCreditAcc.Controls.Add(this.label25);
            this.tabAddCreditAcc.Controls.Add(this.txtCustID);
            this.tabAddCreditAcc.Controls.Add(this.label28);
            this.tabAddCreditAcc.Location = new System.Drawing.Point(4, 29);
            this.tabAddCreditAcc.Name = "tabAddCreditAcc";
            this.tabAddCreditAcc.Size = new System.Drawing.Size(734, 688);
            this.tabAddCreditAcc.TabIndex = 2;
            this.tabAddCreditAcc.Text = "CREDIT ACCOUNT";
            this.tabAddCreditAcc.Click += new System.EventHandler(this.tabAdd_Click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.White;
            this.roundButton7.BorderColor = System.Drawing.Color.Silver;
            this.roundButton7.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton7.Location = new System.Drawing.Point(65, 595);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton7.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton7.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton7.Size = new System.Drawing.Size(189, 40);
            this.roundButton7.TabIndex = 198;
            this.roundButton7.Text = "ADD INVOICE";
            this.roundButton7.TextColor = System.Drawing.Color.White;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.White;
            this.roundButton5.BorderColor = System.Drawing.Color.Silver;
            this.roundButton5.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton5.Location = new System.Drawing.Point(271, 595);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton5.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton5.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton5.Size = new System.Drawing.Size(189, 40);
            this.roundButton5.TabIndex = 197;
            this.roundButton5.Text = "E-MAIL INVOICE";
            this.roundButton5.TextColor = System.Drawing.Color.White;
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.White;
            this.roundButton6.BorderColor = System.Drawing.Color.Silver;
            this.roundButton6.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton6.Location = new System.Drawing.Point(482, 595);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton6.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton6.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton6.Size = new System.Drawing.Size(189, 40);
            this.roundButton6.TabIndex = 196;
            this.roundButton6.Text = "PRINT INVOICE";
            this.roundButton6.TextColor = System.Drawing.Color.White;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(441, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 31);
            this.pictureBox3.TabIndex = 195;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KaizenMain.Properties.Resources.search_icon_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(441, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.TabIndex = 194;
            this.pictureBox1.TabStop = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BorderColor = System.Drawing.Color.Silver;
            this.roundButton4.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.Location = new System.Drawing.Point(576, 54);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton4.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton4.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton4.Size = new System.Drawing.Size(115, 40);
            this.roundButton4.TabIndex = 193;
            this.roundButton4.Text = "CLEAR";
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox33.Location = new System.Drawing.Point(236, 388);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(455, 29);
            this.textBox33.TabIndex = 192;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(43, 391);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 24);
            this.label34.TabIndex = 191;
            this.label34.Text = "Comments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 190;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(236, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 29);
            this.textBox1.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 188;
            this.label2.Text = "Customer Number";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(236, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 29);
            this.textBox2.TabIndex = 187;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(236, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 29);
            this.textBox3.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 185;
            this.label3.Text = "Supplier No";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(236, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 29);
            this.textBox4.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 183;
            this.label4.Text = "Invoice Paid";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(236, 214);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 29);
            this.textBox5.TabIndex = 182;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(46, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 181;
            this.label5.Text = "Price";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(236, 134);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(185, 29);
            this.textBox6.TabIndex = 180;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(46, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 179;
            this.label6.Text = "Transaction Type";
            // 
            // textBox25
            // 
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox25.Location = new System.Drawing.Point(236, 95);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(185, 29);
            this.textBox25.TabIndex = 178;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(46, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 24);
            this.label25.TabIndex = 177;
            this.label25.Text = "Transaction ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCustID.Location = new System.Drawing.Point(236, 58);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(185, 29);
            this.txtCustID.TabIndex = 176;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(46, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(124, 24);
            this.label28.TabIndex = 175;
            this.label28.Text = "Customer ID";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.tabMakePay.ResumeLayout(false);
            this.tabMakePay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAddCreditAcc.ResumeLayout(false);
            this.tabAddCreditAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInv;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabMakePay;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabAddCreditAcc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundButton roundButton15;
        private System.Windows.Forms.PictureBox pictureBox6;
        private RoundButton roundButton16;
        private RoundButton roundButton17;
        private RoundButton roundButton7;
        private RoundButton roundButton5;
        private RoundButton roundButton6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton roundButton4;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.RadioButton rBCreditAccount;
        private System.Windows.Forms.RadioButton rBTansPayment;
    }
}