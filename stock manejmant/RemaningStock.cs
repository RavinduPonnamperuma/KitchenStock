using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");


        private void btnRemaning_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffHome log = new StaffHome();
            log.Show();
        }

        private void RemaningStock_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from productTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_RemaningStock.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dgv_RemaningStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
