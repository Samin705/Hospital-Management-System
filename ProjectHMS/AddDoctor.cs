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
    public partial class AddDoctor : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private Admin a1;
        public AddDoctor(Admin a1)
        {
            this.a1 = a1;
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void Dsavebtn_Click(object sender, EventArgs e)
        {
           
           string sql = @"insert into doctor
                values ('" + this.didtxt.Text + "', '" + this.dnametxt.Text + "', " + this.dchargetxt.Text + ", '" + this.desigtxt.Text + "', '" + this.appointtxt.Text + "');";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

          string   sql2 = @"insert into login
                values ('" + this.dusertxt.Text + "',  '" + this.dpasstxt.Text + "','Doctor');";
            try
            {
                this.Da.ExecuteUpdateQuery(sql2);
                MessageBox.Show("Insertion Done.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
