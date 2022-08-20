using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_manejmant
{
    public partial class Delfrm : Form
    {
        public Delfrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "delete from Table_kitchen where username='" + lblname.Text + "'";
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
        }

        private void lblrole_Click(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void Delfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
