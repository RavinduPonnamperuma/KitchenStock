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

namespace stock_manejmant
{
    public partial class frm_manage : Form
    {
        public frm_manage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RATHU;Initial Catalog=kitchenStock;Integrated Security=True");

        private void fillcombo()

        {
            // this method will bind the combobox with the data base
            con.Open();
            SqlCommand cmd = new SqlCommand("select prodName from ProductTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("prodName", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "prodName";
            comboBox1.DataSource = dt;

            con.Close();
        }
        private void frm_manage_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "insert into productTbl values(" + tb_id.Text + ",'" + tb_name.Text + "'," + tb_quntity.Text + ","+tb_price.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select*from productTbl ";
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
            tb_id.Text = dgv_Stocks.SelectedRows[0].Cells[0].Value.ToString();
            tb_name.Text = dgv_Stocks.SelectedRows[0].Cells[1].Value.ToString();
            tb_price.Text = dgv_Stocks.SelectedRows[0].Cells[2].Value.ToString();
            tb_quntity.Text = dgv_Stocks.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.SelectedValue = dgv_Stocks.SelectedRows[0].Cells[4].Value.ToString();
            
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
            try
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from productTbl where prodID=" + tb_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
    }
}
