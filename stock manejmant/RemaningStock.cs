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
    public partial class RemaningStock : Form
    {
        public RemaningStock()
        {
            InitializeComponent();
        }

        private void btnRemaning_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffHome log = new StaffHome();
            log.Show();
        }
    }
}
