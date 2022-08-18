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
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RATHU;Initial Catalog=kitchenStock;Integrated Security=True");
       //add
        private void button1_Click(object sender, EventArgs e)
        {

            
            try
            {
                 
                con.Open();
                string query = "insert into categoryTbl values(" +tb_C_id.Text+ ",'" +tb_C_name.Text+ "','" +tb_C_discription.Text  + "')";
                SqlCommand cmd = new SqlCommand(query,con);
                 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
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
            string query = "select * from categoryTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Ceregories.DataSource = ds.Tables[0];
            con.Close();
        }
        private void cetegorys_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgv_Ceregories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
            tb_C_id.Text = dgv_Ceregories.SelectedRows[0].Cells[0].Value.ToString();
            tb_C_name.Text = dgv_Ceregories.SelectedRows[0].Cells[1].Value.ToString();
            tb_C_discription.Text = dgv_Ceregories.SelectedRows[0].Cells[2].Value.ToString();
            
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_C_id.Text=="")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from categoryTbl where Cat_ID=" + tb_C_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //edit 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_C_id.Text == "" || tb_C_name.Text == "" || tb_C_discription.Text == "") 
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update cetegory set Cat_Name='" + tb_C_name.Text + "',Cat_Discription='" + tb_C_discription.Text + "'where Cat_ID" + tb_C_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updadted");
                    con.Close();
                    populate();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnc_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StoKeeperHome log = new StoKeeperHome();
            log.Show();
        }
    }
}
