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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.lblCustRep = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnCustDets = new KaizenMain.RoundButton();
            this.tabService = new System.Windows.Forms.TabPage();
            this.lblAppReport = new System.Windows.Forms.Label();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.roundButton1 = new KaizenMain.RoundButton();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustPayments = new KaizenMain.RoundButton();
            this.tabCustomerOutstandingInv = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundButton2 = new KaizenMain.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabCompTot = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stock1 = new KaizenMain.Stock();
            this.Invoice1 = new KaizenMain.Invoice();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Stock2 = new KaizenMain.Stock();
            this.tabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabService.SuspendLayout();
            this.tabRentals.SuspendLayout();
            this.tabCustomerOutstandingInv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCompTot.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabCustomerOutstandingInv);
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
            // tabCustomerOutstandingInv
            // 
            this.tabCustomerOutstandingInv.BackColor = System.Drawing.Color.White;
            this.tabCustomerOutstandingInv.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabCustomerOutstandingInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCustomerOutstandingInv.Controls.Add(this.textBox1);
            this.tabCustomerOutstandingInv.Controls.Add(this.label2);
            this.tabCustomerOutstandingInv.Controls.Add(this.roundButton2);
            this.tabCustomerOutstandingInv.Controls.Add(this.panel1);
            this.tabCustomerOutstandingInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabCustomerOutstandingInv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabCustomerOutstandingInv.Location = new System.Drawing.Point(4, 29);
            this.tabCustomerOutstandingInv.Name = "tabCustomerOutstandingInv";
            this.tabCustomerOutstandingInv.Size = new System.Drawing.Size(734, 688);
            this.tabCustomerOutstandingInv.TabIndex = 3;
            this.tabCustomerOutstandingInv.Text = "Customer Bill";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 29);
            this.textBox1.TabIndex = 192;
            this.textBox1.Text = "   -CUST No-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 29);
            this.label2.TabIndex = 191;
            this.label2.Text = "OUTSTANDING TRANSACTIONS";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.BorderColor = System.Drawing.Color.Silver;
            this.roundButton2.ButtonColor = System.Drawing.Color.SteelBlue;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.Location = new System.Drawing.Point(586, 9);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton2.onHoverButtonColor = System.Drawing.Color.White;
            this.roundButton2.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.roundButton2.Size = new System.Drawing.Size(138, 42);
            this.roundButton2.TabIndex = 190;
            this.roundButton2.Text = "GENERATE";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer4);
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 619);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer4.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(728, 619);
            this.crystalReportViewer4.TabIndex = 0;
            // 
            // tabCompTot
            // 
            this.tabCompTot.BackColor = System.Drawing.Color.White;
            this.tabCompTot.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabCompTot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCompTot.Controls.Add(this.panel2);
            this.tabCompTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabCompTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabCompTot.Location = new System.Drawing.Point(4, 29);
            this.tabCompTot.Name = "tabCompTot";
            this.tabCompTot.Size = new System.Drawing.Size(734, 688);
            this.tabCompTot.TabIndex = 4;
            this.tabCompTot.Text = "TOTALS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer5);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 682);
            this.panel2.TabIndex = 194;
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = 0;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer5.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.ReportSource = this.Stock2;
            this.crystalReportViewer5.Size = new System.Drawing.Size(726, 682);
            this.crystalReportViewer5.TabIndex = 0;
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
            this.tabCustomerOutstandingInv.ResumeLayout(false);
            this.tabCustomerOutstandingInv.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabCompTot.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.TabPage tabCustomerOutstandingInv;
        private System.Windows.Forms.TabPage tabCompTot;
        private RoundButton btnCustDets;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblCustRep;
        private RoundButton roundButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Label lblAppReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private System.Windows.Forms.Label label1;
        private RoundButton btnCustPayments;
        private Invoice Invoice1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private RoundButton roundButton2;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.Panel panel2;
        private Stock Stock1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
        private Stock Stock2;
    }
}