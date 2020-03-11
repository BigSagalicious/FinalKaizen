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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAppointment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddApp = new KaizenMain.RoundButton();
            this.btnAddEmployee = new KaizenMain.RoundButton();
            this.btnEdApp = new KaizenMain.RoundButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRIDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabAppointment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAppointment
            // 
            this.tabAppointment.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabAppointment.Controls.Add(this.tabPage1);
            this.tabAppointment.Controls.Add(this.tabPage2);
            this.tabAppointment.Controls.Add(this.tabPage3);
            this.tabAppointment.Controls.Add(this.tabPage4);
            this.tabAppointment.Controls.Add(this.tabPage5);
            this.tabAppointment.Controls.Add(this.tabPage6);
            this.tabAppointment.Location = new System.Drawing.Point(0, 3);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.SelectedIndex = 0;
            this.tabAppointment.Size = new System.Drawing.Size(716, 713);
            this.tabAppointment.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnAddApp);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.btnEdApp);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.dgvAll);
            this.tabPage1.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddApp
            // 
            this.btnAddApp.BorderColor = System.Drawing.Color.Silver;
            this.btnAddApp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnAddApp.FlatAppearance.BorderSize = 0;
            this.btnAddApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApp.Location = new System.Drawing.Point(305, 22);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddApp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnAddApp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddApp.Size = new System.Drawing.Size(166, 40);
            this.btnAddApp.TabIndex = 17;
            this.btnAddApp.Text = "ADD APOINTMENT";
            this.btnAddApp.TextColor = System.Drawing.Color.White;
            this.btnAddApp.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(252, 608);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddEmployee.onHoverButtonColor = System.Drawing.Color.White;
            this.btnAddEmployee.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnAddEmployee.Size = new System.Drawing.Size(166, 40);
            this.btnAddEmployee.TabIndex = 16;
            this.btnAddEmployee.Text = "ADD EMPLOYEE";
            this.btnAddEmployee.TextColor = System.Drawing.Color.White;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEdApp
            // 
            this.btnEdApp.BorderColor = System.Drawing.Color.Silver;
            this.btnEdApp.ButtonColor = System.Drawing.Color.SteelBlue;
            this.btnEdApp.FlatAppearance.BorderSize = 0;
            this.btnEdApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdApp.Location = new System.Drawing.Point(514, 22);
            this.btnEdApp.Name = "btnEdApp";
            this.btnEdApp.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdApp.onHoverButtonColor = System.Drawing.Color.White;
            this.btnEdApp.onHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnEdApp.Size = new System.Drawing.Size(166, 40);
            this.btnEdApp.TabIndex = 15;
            this.btnEdApp.Text = "EDIT APPOINTMENT";
            this.btnEdApp.TextColor = System.Drawing.Color.White;
            this.btnEdApp.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dgvAll
            // 
            this.dgvAll.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.FRIDAY,
            this.Column5,
            this.Column6});
            this.dgvAll.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAll.Location = new System.Drawing.Point(32, 174);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.Size = new System.Drawing.Size(639, 418);
            this.dgvAll.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "MON";
            this.Column1.Name = "Column1";
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TUES";
            this.Column2.Name = "Column2";
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "WED";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "THUR";
            this.Column4.Name = "Column4";
            this.Column4.Width = 85;
            // 
            // FRIDAY
            // 
            this.FRIDAY.HeaderText = "FRI";
            this.FRIDAY.Name = "FRIDAY";
            this.FRIDAY.Width = 85;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SAT";
            this.Column5.Name = "Column5";
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SUN";
            this.Column6.Name = "Column6";
            this.Column6.Width = 85;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(708, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employee 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(708, 684);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Employee 4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(708, 684);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Employee 5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KaizenMain.Properties.Resources.Faded_logo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tabAppointment);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 679);
            this.panel1.TabIndex = 0;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 698);
            this.Controls.Add(this.panel1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.tabAppointment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAppointment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private RoundButton btnAddApp;
        private RoundButton btnAddEmployee;
        private RoundButton btnEdApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRIDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}