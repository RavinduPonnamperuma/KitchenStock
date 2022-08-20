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
    public partial class IssueProduct : Form
    {
        public IssueProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        private void btnc_back_Issue_Click(object sender, EventArgs e)
        {
            this.Close();
            StoKeeperHome log = new StoKeeperHome();
            log.Show();
        }

        private void IssueProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenStockDB_08182022DataSet2.productTbl' table. You can move, or remove it, as needed.
            this.productTblTableAdapter.Fill(this.kitchenStockDB_08182022DataSet2.productTbl);
            // TODO: This line of code loads data into the 'kitchenStockDB_08182022DataSet1.supplierTbl' table. You can move, or remove it, as needed.
            this.supplierTblTableAdapter.Fill(this.kitchenStockDB_08182022DataSet1.supplierTbl);
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
            dgv_issue.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                

                int CurentQty = 0;
                string selctquery = "SELECT prodQut FROM productTbl WHERE prodName ='" + comBox_Product.Text + "'";
                SqlCommand cm = new SqlCommand(selctquery, con);
                SqlDataReader DR = cm.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {
                   CurentQty = (int)DR["prodQut"];
                }
                con.Close();
                int reqQty = int.Parse(tb_quantity.Text);
                if ( reqQty <= CurentQty)
                {
                    con2.Open();
                    string query = "insert into Stockissue values('" + comBox_IssueTo.Text + "','" + comBox_Product.Text + "'," + tb_quantity.Text + "," + tb_Issue_id.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con2);
                    cmd.ExecuteNonQuery();
                    con2.Close();
                    int remQty = CurentQty - reqQty;

                    con3.Open();
                    string updquery = "update productTbl set prodQut=" + remQty + " where prodName='" + comBox_Product.Text + "'";
                    Debug.WriteLine(updquery);
                    SqlCommand cmdt = new SqlCommand(updquery, con3);
                    cmdt.ExecuteNonQuery();
                    MessageBox.Show("Stock Issued Successfully !");
                    con3.Close();
                    populate();
                    tb_Issue_id.Clear();
                    tb_quantity.Clear();
                    comBox_Product.SelectedItem = null;
                    comBox_IssueTo.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Sorry We don't have enogh stocks !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Issue_id.Clear();
            tb_quantity.Clear();
            comBox_Product.SelectedItem = null;
            comBox_IssueTo.SelectedItem = null;
        }

        private void dgv_issue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
