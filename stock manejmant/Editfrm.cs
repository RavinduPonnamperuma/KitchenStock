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
    public partial class Editfrm : Form
    {
        public Editfrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        private void Editfrm_Load(object sender, EventArgs e)
        {

        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "update Table_kitchen set password='" + tb_Password1.Text + "' ,role='" + comboBox_role1.Text + "' where username='"+ txtusername1.Text +"'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
               MessageBox.Show("Succesfully");
               // Debug.WriteLine(query);
                con.Close();
                this.Close();
                AddUser ad = new AddUser();
                ad.Show();
                // populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           // this.
        }
    }
}
