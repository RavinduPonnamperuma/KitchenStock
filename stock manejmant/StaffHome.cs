using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manejmant
{
    public partial class StaffHome : Form
    {
        public StaffHome()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            IssuedItemReport report = new IssuedItemReport();
            report.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RemaningStock remaning = new  RemaningStock();
            remaning.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_log log = new frm_log();
            log.Show();
        }
    }
}
