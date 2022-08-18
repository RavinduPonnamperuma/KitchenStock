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
    public partial class IssueProduct : Form
    {
        public IssueProduct()
        {
            InitializeComponent();
        }

        private void btnc_back_Issue_Click(object sender, EventArgs e)
        {
            this.Close();
            StoKeeperHome log = new StoKeeperHome();
            log.Show();
        }
    }
}
