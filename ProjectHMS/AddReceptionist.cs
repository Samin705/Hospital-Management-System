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
    

    public partial class AddReceptionist : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private Admin a1;
        public AddReceptionist(Admin a1)
        {
            this.a1 = a1;
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Dsavebtn_Click(object sender, EventArgs e)
        {
            string sql = @"insert into receptionist
                values ('" + this.ridtxt.Text + "', '" + this.rnametxt.Text + "','" + this.gendertxt.Text + "'," + this.rsalarytxt.Text + ");";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

            string sql2 = @"insert into login
                values ('" + this.rusertxt.Text + "',  '" + this.rpasstxt.Text + "','Receptionist');";
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
