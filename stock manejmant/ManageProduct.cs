using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace stock_manejmant
{
    public partial class frm_manage : Form
    {
        public frm_manage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void fillcombo()

        {
            
        }

        private void frm_manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenStockDB_08182022DataSet.categoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.kitchenStockDB_08182022DataSet.categoryTbl);
            populate();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "insert into productTbl values(" + tb_id.Text + ",'" + tb_name.Text + "'," + tb_quntity.Text + ",'" + comboBox1.Text + "'," +tb_price.Text+")";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                populate();
                tb_id.Clear();
                tb_name.Clear();
                tb_price.Clear();
                tb_quntity.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select * from productTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Stocks.DataSource = ds.Tables[0];
            con.Close();
        }
        /*private void cetegorys_Load(object sender, EventArgs e)
        {
           populate();
        }
        */
        private void dgv_Stocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgv_Stocks.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

                proedit pe = new proedit();
                pe.Show();
               
                pe.tb_id1.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                pe.tb_name1.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                pe.tb_quntity1.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                pe.tb_price1.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                pe.comboBox1.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[5].Value.ToString();

                

                this.Hide();
            }
            else if (colName == "Delete")
            {
                prodel pd = new prodel();
                pd.Show();
                pd.tb_id2.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                pd.tb_name2.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                pd.tb_price2.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                pd.tb_quntity2.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                pd.comboBox2.Text = dgv_Stocks.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                this.Hide();

            }


            // tb_id.Text = dgv_Stocks.SelectedRows[0].Cells[0].Value.ToString();
            //  tb_name.Text = dgv_Stocks.SelectedRows[0].Cells[1].Value.ToString();
            //  tb_price.Text = dgv_Stocks.SelectedRows[0].Cells[2].Value.ToString();
            //  tb_quntity.Text = dgv_Stocks.SelectedRows[0].Cells[3].Value.ToString();
            //  comboBox1.SelectedValue = dgv_Stocks.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_id.Text == "" || tb_name.Text == "" || tb_price.Text == "" || tb_quntity.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update product set prodName='" + tb_name.Text + "',prodQut='" + tb_quntity.Text +"'prodCat'"+comboBox1.Text+"'prodPrice'"+tb_price.Text+ "'where prodID" + tb_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updadted");
                    con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_name.Clear();
            tb_price.Clear();
            tb_quntity.Clear();
        }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcombo();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StoKeeperHome log = new StoKeeperHome();
            log.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
