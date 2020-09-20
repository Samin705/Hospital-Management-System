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
    
    public partial class Doctor : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }


        public Doctor()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public void dPopulateGridView(string sql = "select * from doctor;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.ddgvmain.AutoGenerateColumns = false;
            this.ddgvmain.DataSource = this.Ds.Tables[0];
        }

        public void pPopolateGridView(string sql = "select * from patient;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.pdgvmain.AutoGenerateColumns = false;
            this.pdgvmain.DataSource = this.Ds.Tables[0];
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

        private void Dshowbtn_Click(object sender, EventArgs e)
        {
            this.dPopulateGridView();
        }

        private void Ddgvmain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.didtxt.Text = this.ddgvmain.CurrentRow.Cells["did"].Value.ToString();
            this.dnametxt.Text = this.ddgvmain.CurrentRow.Cells["dname"].Value.ToString();
            this.chargetxt.Text = this.ddgvmain.CurrentRow.Cells["charge"].Value.ToString();
            this.desigtxt.Text = this.ddgvmain.CurrentRow.Cells["designation"].Value.ToString();
            this.appointtxt.Text = this.ddgvmain.CurrentRow.Cells["appointmenttime"].Value.ToString();
           
        }

        private void Dchangepasstbn_Click(object sender, EventArgs e)
        {
            ChangePassWord cp = new ChangePassWord();
            cp.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Pshowbtn_Click(object sender, EventArgs e)
        {
            this.pPopolateGridView();
        }
    }
}
