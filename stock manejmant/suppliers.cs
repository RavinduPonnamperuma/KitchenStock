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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RATHU;Initial Catalog=kitchenStock;Integrated Security=True");

        private void btn_S_add_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "insert into supplierTbl values(" + tb_S_id.Text + ",'" + tb_S_name.Text + "','" +tb_S_age.Text + "','"+tb_S_phone.Text+"','"+tb_S_password.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("supplier Added Successfully");
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
            string query = "select*from supplierTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Suppliers.DataSource = ds.Tables[0];
            con.Close();
        }
        private void suppliers_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void dgv_Suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_S_id.Text = dgv_Suppliers.SelectedRows[0].Cells[0].Value.ToString();
            tb_S_name.Text = dgv_Suppliers.SelectedRows[0].Cells[1].Value.ToString();
            tb_S_age.Text = dgv_Suppliers.SelectedRows[0].Cells[2].Value.ToString();
            tb_S_phone.Text = dgv_Suppliers.SelectedRows[0].Cells[3].Value.ToString();
            tb_S_password.Text = dgv_Suppliers.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btn_S_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_S_id.Text == "")
                {
                    MessageBox.Show("Select The Supplier to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from supplierTbl where Cat_ID=" + tb_S_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suplier Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btn_S_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_S_id.Text == "" || tb_S_name.Text == "" || tb_S_age.Text == ""||tb_S_phone.Text==""||tb_S_password.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update suplier set supplierName ='" + tb_S_name.Text + "',supplierAge='" + tb_S_age.Text + "',supplierPhone='" + tb_S_phone.Text +"',supplierPassword='"+tb_S_password.Text+ "";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StoKeeperHome log = new StoKeeperHome();
            log.Show();
        }
    }
}
