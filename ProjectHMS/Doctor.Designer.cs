namespace ProjectHMS
{
    partial class Doctor
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appointtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dshowbtn = new System.Windows.Forms.Button();
            this.dsearchtxt = new System.Windows.Forms.TextBox();
            this.dsearchbtn = new System.Windows.Forms.Button();
            this.dsavebtn = new System.Windows.Forms.Button();
            this.didtxt = new System.Windows.Forms.TextBox();
            this.chargetxt = new System.Windows.Forms.TextBox();
            this.desigtxt = new System.Windows.Forms.TextBox();
            this.dnametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dchangepasstbn = new System.Windows.Forms.Button();
            this.ddgvmain = new System.Windows.Forms.DataGridView();
            this.did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmenttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdgvmain = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pshowbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddgvmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdgvmain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage1.Controls.Add(this.ddgvmain);
            this.tabPage1.Controls.Add(this.dchangepasstbn);
            this.tabPage1.Controls.Add(this.appointtxt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dshowbtn);
            this.tabPage1.Controls.Add(this.dsearchtxt);
            this.tabPage1.Controls.Add(this.dsearchbtn);
            this.tabPage1.Controls.Add(this.dsavebtn);
            this.tabPage1.Controls.Add(this.didtxt);
            this.tabPage1.Controls.Add(this.chargetxt);
            this.tabPage1.Controls.Add(this.desigtxt);
            this.tabPage1.Controls.Add(this.dnametxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doctor Details";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.pshowbtn);
            this.tabPage2.Controls.Add(this.pdgvmain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient Details";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOrchid;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "DOCTOR PANEL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // appointtxt
            // 
            this.appointtxt.Location = new System.Drawing.Point(330, 152);
            this.appointtxt.Name = "appointtxt";
            this.appointtxt.Size = new System.Drawing.Size(100, 20);
            this.appointtxt.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(145, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(145, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "CHARGE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(145, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "DESIGNATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(145, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "APPOINTMENT TIME";
            // 
            // dshowbtn
            // 
            this.dshowbtn.BackColor = System.Drawing.Color.Violet;
            this.dshowbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dshowbtn.Location = new System.Drawing.Point(6, 182);
            this.dshowbtn.Name = "dshowbtn";
            this.dshowbtn.Size = new System.Drawing.Size(102, 34);
            this.dshowbtn.TabIndex = 44;
            this.dshowbtn.Text = "SHOW DETAILS";
            this.dshowbtn.UseVisualStyleBackColor = false;
            this.dshowbtn.Click += new System.EventHandler(this.Dshowbtn_Click);
            // 
            // dsearchtxt
            // 
            this.dsearchtxt.Location = new System.Drawing.Point(549, 186);
            this.dsearchtxt.Name = "dsearchtxt";
            this.dsearchtxt.Size = new System.Drawing.Size(126, 20);
            this.dsearchtxt.TabIndex = 43;
            // 
            // dsearchbtn
            // 
            this.dsearchbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.dsearchbtn.Location = new System.Drawing.Point(444, 178);
            this.dsearchbtn.Name = "dsearchbtn";
            this.dsearchbtn.Size = new System.Drawing.Size(75, 34);
            this.dsearchbtn.TabIndex = 42;
            this.dsearchbtn.Text = "SEARCH";
            this.dsearchbtn.UseVisualStyleBackColor = false;
            // 
            // dsavebtn
            // 
            this.dsavebtn.BackColor = System.Drawing.Color.YellowGreen;
            this.dsavebtn.Location = new System.Drawing.Point(214, 174);
            this.dsavebtn.Name = "dsavebtn";
            this.dsavebtn.Size = new System.Drawing.Size(94, 42);
            this.dsavebtn.TabIndex = 41;
            this.dsavebtn.Text = "SAVE";
            this.dsavebtn.UseVisualStyleBackColor = false;
            this.dsavebtn.Click += new System.EventHandler(this.Dsavebtn_Click);
            // 
            // didtxt
            // 
            this.didtxt.Location = new System.Drawing.Point(330, 15);
            this.didtxt.Name = "didtxt";
            this.didtxt.Size = new System.Drawing.Size(100, 20);
            this.didtxt.TabIndex = 39;
            // 
            // chargetxt
            // 
            this.chargetxt.Enabled = false;
            this.chargetxt.Location = new System.Drawing.Point(330, 84);
            this.chargetxt.Name = "chargetxt";
            this.chargetxt.Size = new System.Drawing.Size(100, 20);
            this.chargetxt.TabIndex = 38;
            // 
            // desigtxt
            // 
            this.desigtxt.Enabled = false;
            this.desigtxt.Location = new System.Drawing.Point(330, 121);
            this.desigtxt.Name = "desigtxt";
            this.desigtxt.Size = new System.Drawing.Size(100, 20);
            this.desigtxt.TabIndex = 37;
            // 
            // dnametxt
            // 
            this.dnametxt.Location = new System.Drawing.Point(330, 50);
            this.dnametxt.Name = "dnametxt";
            this.dnametxt.Size = new System.Drawing.Size(100, 20);
            this.dnametxt.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(145, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID";
            // 
            // dchangepasstbn
            // 
            this.dchangepasstbn.BackColor = System.Drawing.Color.DimGray;
            this.dchangepasstbn.Location = new System.Drawing.Point(563, 78);
            this.dchangepasstbn.Name = "dchangepasstbn";
            this.dchangepasstbn.Size = new System.Drawing.Size(150, 34);
            this.dchangepasstbn.TabIndex = 50;
            this.dchangepasstbn.Text = "CHANGE PASSWORD";
            this.dchangepasstbn.UseVisualStyleBackColor = false;
            this.dchangepasstbn.Click += new System.EventHandler(this.Dchangepasstbn_Click);
            // 
            // ddgvmain
            // 
            this.ddgvmain.AllowUserToAddRows = false;
            this.ddgvmain.AllowUserToDeleteRows = false;
            this.ddgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgvmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.did,
            this.dname,
            this.charge,
            this.designation,
            this.appointmenttime});
            this.ddgvmain.Location = new System.Drawing.Point(-1, 222);
            this.ddgvmain.Name = "ddgvmain";
            this.ddgvmain.ReadOnly = true;
            this.ddgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ddgvmain.Size = new System.Drawing.Size(796, 161);
            this.ddgvmain.TabIndex = 52;
            this.ddgvmain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ddgvmain_CellDoubleClick);
            // 
            // did
            // 
            this.did.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.did.DataPropertyName = "did";
            this.did.HeaderText = "ID";
            this.did.Name = "did";
            this.did.ReadOnly = true;
            // 
            // dname
            // 
            this.dname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dname.DataPropertyName = "dname";
            this.dname.HeaderText = "NAME";
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
            // 
            // charge
            // 
            this.charge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.charge.DataPropertyName = "charge";
            this.charge.HeaderText = "CHARGE";
            this.charge.Name = "charge";
            this.charge.ReadOnly = true;
            // 
            // designation
            // 
            this.designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.designation.DataPropertyName = "designation";
            this.designation.HeaderText = "DESIGNATION";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // appointmenttime
            // 
            this.appointmenttime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointmenttime.DataPropertyName = "appointmenttime";
            this.appointmenttime.HeaderText = "APPOINTMENT TIME";
            this.appointmenttime.Name = "appointmenttime";
            this.appointmenttime.ReadOnly = true;
            // 
            // pdgvmain
            // 
            this.pdgvmain.AllowUserToAddRows = false;
            this.pdgvmain.AllowUserToDeleteRows = false;
            this.pdgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdgvmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.contactno,
            this.dob,
            this.bloodgroup,
            this.appointment});
            this.pdgvmain.Location = new System.Drawing.Point(0, 121);
            this.pdgvmain.Name = "pdgvmain";
            this.pdgvmain.ReadOnly = true;
            this.pdgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pdgvmain.Size = new System.Drawing.Size(795, 257);
            this.pdgvmain.TabIndex = 46;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "ID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "NAME";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            // 
            // contactno
            // 
            this.contactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactno.DataPropertyName = "contactno";
            this.contactno.HeaderText = "CONTACT NO.";
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DATE OF BIRTH";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BLOOD GROUP";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // appointment
            // 
            this.appointment.DataPropertyName = "appointment";
            this.appointment.HeaderText = "APPOINTMENT";
            this.appointment.Name = "appointment";
            this.appointment.ReadOnly = true;
            // 
            // pshowbtn
            // 
            this.pshowbtn.BackColor = System.Drawing.Color.Indigo;
            this.pshowbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pshowbtn.Location = new System.Drawing.Point(0, 73);
            this.pshowbtn.Name = "pshowbtn";
            this.pshowbtn.Size = new System.Drawing.Size(143, 42);
            this.pshowbtn.TabIndex = 47;
            this.pshowbtn.Text = "Show Details";
            this.pshowbtn.UseVisualStyleBackColor = false;
            this.pshowbtn.Click += new System.EventHandler(this.Pshowbtn_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddgvmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdgvmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dchangepasstbn;
        private System.Windows.Forms.TextBox appointtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dshowbtn;
        private System.Windows.Forms.TextBox dsearchtxt;
        private System.Windows.Forms.Button dsearchbtn;
        private System.Windows.Forms.Button dsavebtn;
        private System.Windows.Forms.TextBox didtxt;
        private System.Windows.Forms.TextBox chargetxt;
        private System.Windows.Forms.TextBox desigtxt;
        private System.Windows.Forms.TextBox dnametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ddgvmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn did;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmenttime;
        private System.Windows.Forms.DataGridView pdgvmain;
        private System.Windows.Forms.Button pshowbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment;
    }
}