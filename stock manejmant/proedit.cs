using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manejmant
{
    public partial class proedit : Form
    {
        public proedit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void proedit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenStockDB_08182022DataSet.categoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.kitchenStockDB_08182022DataSet.categoryTbl);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "update productTbl set prodName='" + tb_name1.Text + "', prodQut="+tb_quntity1.Text +", prodCat='"+ comboBox1.Text+"', prodPrice="+tb_price1.Text + " where prodID=" + tb_id1.Text;
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully Deleted !","Warning",MessageBoxButtons.OK);
                 //Debug.WriteLine(query);
                con.Close();
                this.Close();
                frm_manage fm = new frm_manage();
                fm.Show();
               // populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
