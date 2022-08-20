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
    public partial class supedit : Form
    {
        public supedit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        private void btn_S_edit_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "update supplierTbl set supplierName='" + tb_S_name1.Text + "', supplierAge=" + tb_S_age1.Text + ", supplierPhone='" + tb_S_phone1.Text + "', supplierPassword='" + tb_S_password1.Text + "' where supplierID=" + tb_S_id1.Text;
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Updated Succesfully !", "Warning", MessageBoxButtons.OK);
                //Debug.WriteLine(query);
                con.Close();
                this.Close();
                suppliers sm = new suppliers();
                sm.Show();
                // populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void supedit_Load(object sender, EventArgs e)
        {

        }
    }
}
