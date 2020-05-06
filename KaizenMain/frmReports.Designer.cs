namespace KaizenMain
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.lblCustRep = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnCustDets = new KaizenMain.RoundButton();
            this.tabService = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.roundButton1 = new KaizenMain.RoundButton();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.roundButton14 = new KaizenMain.RoundButton();
            this.roundButton13 = new KaizenMain.RoundButton();
            this.roundButton10 = new KaizenMain.RoundButton();
            this.roundButton11 = new KaizenMain.RoundButton();
            this.roundButton12 = new KaizenMain.RoundButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabCompTot = new System.Windows.Forms.TabPage();
            this.roundButton15 = new KaizenMain.RoundButton();
            this.roundButton16 = new KaizenMain.RoundButton();
            this.roundButton17 = new KaizenMain.RoundButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAppReport = new System.Windows.Forms.Label();
            this.btnCustPayments = new KaizenMain.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabService.SuspendLayout();
            this.tabRentals.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabCompTot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Controls.Add(this.tabRentals);
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabCompTot);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(145, 25);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 721);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSales
            // 
            this.tabSales.BackColor = System.Drawing.Color.White;
            this.tabSales.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSales.Controls.Add(this.lblCustRep);
            this.tabSales.Controls.Add(this.crystalReportViewer1);
            this.tabSales.Controls.Add(this.btnCustDets);
            this.tabSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabSales.Location = new System.Drawing.Point(4, 29);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(734, 688);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "CUSTOMERS";
            this.tabSales.Click += new System.EventHandler(this.tabSales_Click);
            // 
            // lblCustRep
            // 
            this.lblCustRep.AutoSize = true;
            this.lblCustRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustRep.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustRep.Location = new System.Drawing.Point(6, 3);
            this.lblCustRep.Name = "lblCustRep";
            this.lblCustRep.Size = new System.Drawing.Size(404, 29);
            this.lblCustRep.TabIndex = 187;
            this.lblCustRep.Text = "CUSTOMER CONTACT DETAILS";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(6, 54);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(728, 634);
            this.crystalReportViewer1.TabIndex = 186;
            // 
            // btnCustDets
            // 
            this.btnCustDets.BackColor = System.Drawing.Color.Transparent;
            this.btnCustDets.BorderColor = System.Drawing.Color.Silver;
            this.btnCustDets.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnCustDets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustDets.FlatAppearance.BorderSize = 0;
            this.btnCustDets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCustDets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCustDets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustDets.Location = new System.Drawing.Point(428, 6);
            this.btnCustDets.Name = "btnCustDets";
            this.btnCustDets.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnCustDets.onHoverButtonColor = System.Drawing.Color.White;
            this.btnCustDets.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnCustDets.Size = new System.Drawing.Size(275, 42);
            this.btnCustDets.TabIndex = 185;
            this.btnCustDets.Text = "VIEW CUSTOMER DETAILS";
            this.btnCustDets.TextColor = System.Drawing.Color.White;
            this.btnCustDets.UseVisualStyleBackColor = false;
            this.btnCustDets.Click += new System.EventHandler(this.btnCustDets_Click);
            // 
            // tabService
            // 
            this.tabService.BackColor = System.Drawing.Color.White;
            this.tabService.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabService.Controls.Add(this.lblAppReport);
            this.tabService.Controls.Add(this.crystalReportViewer2);
            this.tabService.Controls.Add(this.roundButton1);
            this.tabService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabService.Location = new System.Drawing.Point(4, 29);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(734, 688);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "APPOINTMENTS";
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(26, 54);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(698, 587);
            this.crystalReportViewer2.TabIndex = 187;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundButton1.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(449, 6);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton1.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton1.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton1.Size = new System.Drawing.Size(275, 42);
            this.roundButton1.TabIndex = 186;
            this.roundButton1.Text = "VIEW APPOINTMENT DETAILS";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // tabRentals
            // 
            this.tabRentals.BackColor = System.Drawing.Color.White;
            this.tabRentals.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabRentals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabRentals.Controls.Add(this.crystalReportViewer3);
            this.tabRentals.Controls.Add(this.label1);
            this.tabRentals.Controls.Add(this.btnCustPayments);
            this.tabRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabRentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabRentals.Location = new System.Drawing.Point(4, 29);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Size = new System.Drawing.Size(734, 688);
            this.tabRentals.TabIndex = 2;
            this.tabRentals.Text = "PAYMENTS";
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.Color.White;
            this.tabStock.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabStock.Controls.Add(this.roundButton14);
            this.tabStock.Controls.Add(this.roundButton13);
            this.tabStock.Controls.Add(this.roundButton10);
            this.tabStock.Controls.Add(this.roundButton11);
            this.tabStock.Controls.Add(this.roundButton12);
            this.tabStock.Controls.Add(this.pictureBox7);
            this.tabStock.Controls.Add(this.pictureBox8);
            this.tabStock.Controls.Add(this.textBox3);
            this.tabStock.Controls.Add(this.label3);
            this.tabStock.Controls.Add(this.label4);
            this.tabStock.Controls.Add(this.textBox4);
            this.tabStock.Controls.Add(this.label14);
            this.tabStock.Controls.Add(this.label5);
            this.tabStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabStock.Location = new System.Drawing.Point(4, 29);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(734, 688);
            this.tabStock.TabIndex = 3;
            this.tabStock.Text = "STOCK";
            // 
            // roundButton14
            // 
            this.roundButton14.BackColor = System.Drawing.Color.Transparent;
            this.roundButton14.BorderColor = System.Drawing.Color.Silver;
            this.roundButton14.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton14.FlatAppearance.BorderSize = 0;
            this.roundButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton14.Location = new System.Drawing.Point(122, 193);
            this.roundButton14.Name = "roundButton14";
            this.roundButton14.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton14.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton14.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton14.Size = new System.Drawing.Size(483, 115);
            this.roundButton14.TabIndex = 206;
            this.roundButton14.Text = "CURRENT PARTS";
            this.roundButton14.TextColor = System.Drawing.Color.White;
            this.roundButton14.UseVisualStyleBackColor = false;
            // 
            // roundButton13
            // 
            this.roundButton13.BackColor = System.Drawing.Color.Transparent;
            this.roundButton13.BorderColor = System.Drawing.Color.Silver;
            this.roundButton13.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton13.FlatAppearance.BorderSize = 0;
            this.roundButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton13.Location = new System.Drawing.Point(122, 43);
            this.roundButton13.Name = "roundButton13";
            this.roundButton13.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton13.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton13.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton13.Size = new System.Drawing.Size(483, 115);
            this.roundButton13.TabIndex = 205;
            this.roundButton13.Text = "CURRENT EQUIPMENT";
            this.roundButton13.TextColor = System.Drawing.Color.White;
            this.roundButton13.UseVisualStyleBackColor = false;
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.Transparent;
            this.roundButton10.BorderColor = System.Drawing.Color.Silver;
            this.roundButton10.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton10.Location = new System.Drawing.Point(393, 452);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton10.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton10.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton10.Size = new System.Drawing.Size(275, 62);
            this.roundButton10.TabIndex = 204;
            this.roundButton10.Text = "YEAR TO DATE";
            this.roundButton10.TextColor = System.Drawing.Color.White;
            this.roundButton10.UseVisualStyleBackColor = false;
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.Transparent;
            this.roundButton11.BorderColor = System.Drawing.Color.Silver;
            this.roundButton11.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton11.FlatAppearance.BorderSize = 0;
            this.roundButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton11.Location = new System.Drawing.Point(52, 452);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton11.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton11.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton11.Size = new System.Drawing.Size(275, 62);
            this.roundButton11.TabIndex = 203;
            this.roundButton11.Text = "MONTH TO DATE";
            this.roundButton11.TextColor = System.Drawing.Color.White;
            this.roundButton11.UseVisualStyleBackColor = false;
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.Transparent;
            this.roundButton12.BorderColor = System.Drawing.Color.Silver;
            this.roundButton12.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton12.FlatAppearance.BorderSize = 0;
            this.roundButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton12.Location = new System.Drawing.Point(393, 562);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton12.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton12.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton12.Size = new System.Drawing.Size(275, 62);
            this.roundButton12.TabIndex = 202;
            this.roundButton12.Text = "FROM SELECTED DATE";
            this.roundButton12.TextColor = System.Drawing.Color.White;
            this.roundButton12.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(285, 611);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 31);
            this.pictureBox7.TabIndex = 201;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(285, 546);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(43, 31);
            this.pictureBox8.TabIndex = 200;
            this.pictureBox8.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 613);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 29);
            this.textBox3.TabIndex = 199;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 198;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 197;
            this.label4.Text = "Start Date";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 548);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 29);
            this.textBox4.TabIndex = 196;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(37, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(321, 17);
            this.label14.TabIndex = 195;
            this.label14.Text = "Please select the time frame for the report:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "STOCK LOG:";
            // 
            // tabCompTot
            // 
            this.tabCompTot.BackColor = System.Drawing.Color.White;
            this.tabCompTot.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabCompTot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCompTot.Controls.Add(this.roundButton15);
            this.tabCompTot.Controls.Add(this.roundButton16);
            this.tabCompTot.Controls.Add(this.roundButton17);
            this.tabCompTot.Controls.Add(this.pictureBox9);
            this.tabCompTot.Controls.Add(this.pictureBox10);
            this.tabCompTot.Controls.Add(this.textBox5);
            this.tabCompTot.Controls.Add(this.label6);
            this.tabCompTot.Controls.Add(this.label9);
            this.tabCompTot.Controls.Add(this.textBox6);
            this.tabCompTot.Controls.Add(this.label13);
            this.tabCompTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabCompTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabCompTot.Location = new System.Drawing.Point(4, 29);
            this.tabCompTot.Name = "tabCompTot";
            this.tabCompTot.Size = new System.Drawing.Size(734, 688);
            this.tabCompTot.TabIndex = 4;
            this.tabCompTot.Text = "TOTALS";
            // 
            // roundButton15
            // 
            this.roundButton15.BackColor = System.Drawing.Color.Transparent;
            this.roundButton15.BorderColor = System.Drawing.Color.Silver;
            this.roundButton15.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton15.FlatAppearance.BorderSize = 0;
            this.roundButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton15.Location = new System.Drawing.Point(403, 101);
            this.roundButton15.Name = "roundButton15";
            this.roundButton15.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton15.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton15.Size = new System.Drawing.Size(275, 62);
            this.roundButton15.TabIndex = 214;
            this.roundButton15.Text = "YEAR TO DATE";
            this.roundButton15.TextColor = System.Drawing.Color.White;
            this.roundButton15.UseVisualStyleBackColor = false;
            // 
            // roundButton16
            // 
            this.roundButton16.BackColor = System.Drawing.Color.Transparent;
            this.roundButton16.BorderColor = System.Drawing.Color.Silver;
            this.roundButton16.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton16.FlatAppearance.BorderSize = 0;
            this.roundButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton16.Location = new System.Drawing.Point(62, 101);
            this.roundButton16.Name = "roundButton16";
            this.roundButton16.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton16.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton16.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton16.Size = new System.Drawing.Size(275, 62);
            this.roundButton16.TabIndex = 213;
            this.roundButton16.Text = "MONTH TO DATE";
            this.roundButton16.TextColor = System.Drawing.Color.White;
            this.roundButton16.UseVisualStyleBackColor = false;
            // 
            // roundButton17
            // 
            this.roundButton17.BackColor = System.Drawing.Color.Transparent;
            this.roundButton17.BorderColor = System.Drawing.Color.Silver;
            this.roundButton17.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton17.FlatAppearance.BorderSize = 0;
            this.roundButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton17.Location = new System.Drawing.Point(403, 211);
            this.roundButton17.Name = "roundButton17";
            this.roundButton17.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton17.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton17.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton17.Size = new System.Drawing.Size(275, 62);
            this.roundButton17.TabIndex = 212;
            this.roundButton17.Text = "FROM SELECTED DATE";
            this.roundButton17.TextColor = System.Drawing.Color.White;
            this.roundButton17.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(295, 260);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 31);
            this.pictureBox9.TabIndex = 211;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(295, 195);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(43, 31);
            this.pictureBox10.TabIndex = 210;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(170, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 29);
            this.textBox5.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(59, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 208;
            this.label6.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(51, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 207;
            this.label9.Text = "Start Date";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(170, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 29);
            this.textBox6.TabIndex = 206;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(47, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 17);
            this.label13.TabIndex = 205;
            this.label13.Text = "Please select the time frame for the report:";
            // 
            // lblAppReport
            // 
            this.lblAppReport.AutoSize = true;
            this.lblAppReport.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAppReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppReport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAppReport.Location = new System.Drawing.Point(22, 14);
            this.lblAppReport.Name = "lblAppReport";
            this.lblAppReport.Size = new System.Drawing.Size(410, 29);
            this.lblAppReport.TabIndex = 188;
            this.lblAppReport.Text = "APPOINTMENT DETAIL REPORT";
            // 
            // btnCustPayments
            // 
            this.btnCustPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnCustPayments.BorderColor = System.Drawing.Color.Silver;
            this.btnCustPayments.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnCustPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustPayments.FlatAppearance.BorderSize = 0;
            this.btnCustPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCustPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCustPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustPayments.Location = new System.Drawing.Point(456, 3);
            this.btnCustPayments.Name = "btnCustPayments";
            this.btnCustPayments.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnCustPayments.onHoverButtonColor = System.Drawing.Color.White;
            this.btnCustPayments.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnCustPayments.Size = new System.Drawing.Size(275, 42);
            this.btnCustPayments.TabIndex = 187;
            this.btnCustPayments.Text = "VIEW CUSTOMER PAYMENTS";
            this.btnCustPayments.TextColor = System.Drawing.Color.White;
            this.btnCustPayments.UseVisualStyleBackColor = false;
            this.btnCustPayments.Click += new System.EventHandler(this.btnCustPayments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 189;
            this.label1.Text = "CUSTOMER PAYMENT REPORT";
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Location = new System.Drawing.Point(10, 51);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(714, 634);
            this.crystalReportViewer3.TabIndex = 190;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 723);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.tabControl1.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.tabRentals.ResumeLayout(false);
            this.tabRentals.PerformLayout();
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabCompTot.ResumeLayout(false);
            this.tabCompTot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabCompTot;
        private RoundButton roundButton14;
        private RoundButton roundButton13;
        private RoundButton roundButton10;
        private RoundButton roundButton11;
        private RoundButton roundButton12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private RoundButton roundButton15;
        private RoundButton roundButton16;
        private RoundButton roundButton17;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private RoundButton btnCustDets;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblCustRep;
        private RoundButton roundButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Label lblAppReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private System.Windows.Forms.Label label1;
        private RoundButton btnCustPayments;
    }
}