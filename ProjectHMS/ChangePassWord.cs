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
    public partial class ChangePassWord : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public ChangePassWord()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Dchangepasstbn_Click(object sender, EventArgs e)
        {
            string sql = "select * from login";
            this.Ds = this.Da.ExecuteQuery(sql);


            sql = @"update login
            set password = '" + this.dpasstxt.Text + @"'
            where username= '" +this.dusertxt.Text + "';";

            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("PassWord Change.");
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
