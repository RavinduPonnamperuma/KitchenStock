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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser AddUser = new AddUser();
            AddUser.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_log log = new frm_log();
            log.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
