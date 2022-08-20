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
    public partial class StoKeeperHome : Form
    {
        public StoKeeperHome()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            categories categories = new categories();
            categories.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_manage frm_manage = new frm_manage();
            frm_manage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            IssueProduct issu = new IssueProduct();
            issu.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            suppliers suppliers = new suppliers();
            suppliers.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_log log = new frm_log();
            log.Show();
        }

        private void StoKeeperHome_Load(object sender, EventArgs e)
        {

        }
    }
}
