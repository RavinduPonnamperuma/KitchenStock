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
    public partial class frm_log : Form
    {
        public frm_log()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=RATHU;Initial Catalog=kitchenStock;Integrated Security=True");
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to EXIT..!!");
             
            this.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username,user_password;

            username = tb_userName.Text;
            user_password = tb_password.Text;

            try
            {
                conn.Open();
                String querry="SELECT role FROM Table_kitchen WHERE username ='"+tb_userName.Text+"'AND password ='"+tb_password.Text+"'";
                //SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                SqlCommand cm = new SqlCommand(querry, conn);
                SqlDataReader DR = cm.ExecuteReader();
                DR.Read();
                if (DR.HasRows) 
                {
                    string role = DR["role"].ToString();
                    if (role == "ADMIN")
                    {
                        //page that need to be load
                        this.Hide();
                        AdminHome adminHome = new AdminHome();
                        adminHome.Show();
                    }
                    else if (role == "STORE KEEPER")
                    {
                        //page that need to be load
                        this.Hide();
                        StoKeeperHome stoKeeperHome = new StoKeeperHome();
                        stoKeeperHome.Show();
                    }
                    else if (role == "KITCHEN STAFF")
                    {
                        //page that need to be load
                        this.Hide();
                        StaffHome staffHome = new StaffHome();
                        staffHome.Show();
                    } else
                    {
                        MessageBox.Show("Invalid Loging details...........!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_userName.Clear();
                        tb_password.Clear();
                        //to Focus username 
                        tb_userName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Loging details...........!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_userName.Clear();
                    tb_password.Clear();

                    //to Focus username 
                    tb_userName.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Error.........!!!!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_userName.Clear();
            tb_password.Clear();

            tb_userName.Focus();    
        }

        private void tb_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
