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
    public partial class CateDel : Form
    {
        public CateDel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "delete from categoryTbl where Cat_ID='" + lblname1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Has Deleted !");
                // Debug.WriteLine(query);
                con.Close();
                this.Close();
                categories ce = new categories();
                ce.Show();
                // populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CateDel_Load(object sender, EventArgs e)
        {

        }
    }
}
