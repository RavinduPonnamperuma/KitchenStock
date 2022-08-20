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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
              
               string query = "insert into Table_kitchen values(" + txtusername.Text + ",'" + tb_Password.Text + "','" + comboBox_role.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                con.Close();
                populate();
                txtusername.Clear();
                tb_Password.Clear();
                comboBox_role.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Table_kitchen ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_users.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dgv_Ceregories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string colName = dgv_users.Columns[e.ColumnIndex].Name;
            if (colName=="edit")
            {
                
                    Editfrm nw = new Editfrm();
                    nw.Show();
                //Editfrm frm =new  Editfrm();
              nw.txtusername1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
               nw. tb_Password1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                nw.comboBox_role1.Text= dgv_users.Rows[(int)e.RowIndex].Cells[4].Value.ToString();

                //MessageBox.Show(dgv_users.Rows[(int)e.RowIndex].Cells[2].Value.ToString() + " " + dgv_users.Rows[(int)e.RowIndex].Cells[3].Value.ToString());


                //con.Open();
                // txtusername.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();

                //   tb_Password.Text = dgv_users[2, e.RowIndex].Value.ToString();
                //comboBox_role.Text = dgv_users.Rows[e.RowIndex].Cells[3].Value.ToString();

                this.Close();
            }
            else if(colName=="delete")
            {
                Delfrm del = new Delfrm();
                del.Show();
                del.lblname.Text = dgv_users.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                del.lblpass.Text = dgv_users.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                del.lblrole.Text = dgv_users.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                this.Close();
            }



        }

        private void btnc_back_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminHome log = new AdminHome();
            log.Show();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            tb_Password.Clear();
            comboBox_role.SelectedItem = null;
        }

        private void dgv_users_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
