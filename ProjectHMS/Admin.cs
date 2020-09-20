using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHMS
{
    public partial class Admin : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           
        }

        public Admin(string role)
        {

        }

        public void aPopulateGridView(string sql = "select * from admin;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.adgvMain.AutoGenerateColumns = false;
            this.adgvMain.DataSource = this.Ds.Tables[0];
        }

        public void dPopulateGridView(string sql = "select * from doctor;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.ddgvmain.AutoGenerateColumns = false;
            this.ddgvmain.DataSource = this.Ds.Tables[0];
        }

        public void rPopulateGridView(string sql = "select * from receptionist;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.rdgvmain.AutoGenerateColumns = false;
            this.rdgvmain.DataSource = this.Ds.Tables[0];
        }



        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void AdgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.aidtxt.Text = this.adgvMain.CurrentRow.Cells["aid"].Value.ToString();
            this.anametxt.Text = this.adgvMain.CurrentRow.Cells["aname"].Value.ToString();
            this.asalarytxt.Text = this.adgvMain.CurrentRow.Cells["asalary"].Value.ToString();
            this.maritalststxt.Text = this.adgvMain.CurrentRow.Cells["maritalstatus"].Value.ToString();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Dshowbtn_Click(object sender, EventArgs e)
        {
            this.dPopulateGridView();
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            this.aPopulateGridView();
        }

        private void Rshowbtn_Click(object sender, EventArgs e)
        {
            this.rPopulateGridView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddDoctor ad = new AddDoctor(this);
            ad.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddReceptionist ar = new AddReceptionist(this);
            ar.Visible = true;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string aid = this.adgvMain.CurrentRow.Cells["aid"].Value.ToString();
            string sql = "delete from admin where aid = '" + aid + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.aPopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin where aid = '" + this.asearchtxt.Text + "';";
            this.aPopulateGridView(sql);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin where aid ='" + this.aidtxt.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update admin
               set aname = '" + this.anametxt.Text + @"',
                asalary = " + this.asalarytxt.Text + @",
                maritalstatus = '" + this.maritalststxt.Text + @"'
                where aid = '" + this.aidtxt.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.aPopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else { }
        }

        private void Ddeletebtn_Click(object sender, EventArgs e)
        {
            string did = this.ddgvmain.CurrentRow.Cells["did"].Value.ToString();
            string sql = "delete from doctor where did = '" + didtxt + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.aPopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void Dsearchbtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from doctor where did = '" + this.dsearchtxt.Text + "';";
            this.dPopulateGridView(sql);
        }

        private void Dsavebtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from doctor where did ='" + this.didtxt.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update doctor
               set dname = '" + this.dnametxt.Text + @"',
                charge = " + this.chargetxt.Text + @",
                designation = '" + this.desigtxt.Text + @"',
                appointmenttime = '" + this.appointtxt.Text + @"'
                where did = '" + this.didtxt.Text + "';";
               
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.dPopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else { }
        }

        private void Ddgvmain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.didtxt.Text = this.ddgvmain.CurrentRow.Cells["did"].Value.ToString();
            this.dnametxt.Text = this.ddgvmain.CurrentRow.Cells["dname"].Value.ToString();
            this.chargetxt.Text = this.ddgvmain.CurrentRow.Cells["charge"].Value.ToString();
            this.desigtxt.Text = this.ddgvmain.CurrentRow.Cells["designation"].Value.ToString();
            this.appointtxt.Text = this.ddgvmain.CurrentRow.Cells["appointmenttime"].Value.ToString();
        }

        private void Rdgvmain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ridtxt.Text = this.rdgvmain.CurrentRow.Cells["rid"].Value.ToString();
            this.rnametxt.Text = this.rdgvmain.CurrentRow.Cells["rname"].Value.ToString();
            this.rsalarytxt.Text = this.rdgvmain.CurrentRow.Cells["rsalary"].Value.ToString();
            this.gendertxt.Text = this.rdgvmain.CurrentRow.Cells["rgender"].Value.ToString();

        }

        private void Rdeletebtn_Click(object sender, EventArgs e)
        {
            string rid = this.rdgvmain.CurrentRow.Cells["rid"].Value.ToString();
            string sql = "delete from receptionist where rid = '" + rid + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.rPopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void Rsearchbtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from receptionist where rid = '" + this.rsearchtxt.Text + "';";
            this.rPopulateGridView(sql);
        }

        private void Rsavebtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from receptionist where rid ='" + this.ridtxt.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update receptionist
               set rname = '" + this.rnametxt.Text + @"',
                rsalary = " + this.rsalarytxt.Text + @",
                rgender = '" + this.gendertxt.Text + @"'
                where rid = '" + this.ridtxt.Text + "';";
                
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.aPopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else { }
        }

        private void Dchangepasstbn_Click(object sender, EventArgs e)
        {
            ChangePassWord cp = new ChangePassWord();
            cp.Visible = true;
        }
    }
}
