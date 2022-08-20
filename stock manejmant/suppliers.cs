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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

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
                tb_S_id.Clear();
                tb_S_name.Clear();
                tb_S_age.Clear();
                tb_S_password.Clear();
                tb_S_phone.Clear();

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
            string colName = dgv_Suppliers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

                supedit se = new supedit();
                se.Show();
                //Editfrm frm =new  Editfrm();
                se.tb_S_id1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                se.tb_S_name1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                se.tb_S_age1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                se.tb_S_phone1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                se.tb_S_password1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[6].Value.ToString();



                this.Hide();
            }
            else if (colName=="Delete")
            {
                supdel sd = new supdel();
                sd.Show();
                sd.lbl1.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                sd.lbl2.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                sd.lbl3.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                sd.lbl4.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                sd.lbl5.Text = dgv_Suppliers.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                this.Hide();
            }

        }

        private void btn_S_delete_Click(object sender, EventArgs e)
        {
            tb_S_id.Clear();
            tb_S_name.Clear();
            tb_S_age.Clear();
            tb_S_password.Clear();
            tb_S_phone.Clear();

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
