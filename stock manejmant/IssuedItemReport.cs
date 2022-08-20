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
    public partial class IssuedItemReport : Form
    {
        public IssuedItemReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnIssued_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffHome log = new StaffHome();
            log.Show();
        }

        private void IssuedItemReport_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Stockissue ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_IssuedItems.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dgv_IssuedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
