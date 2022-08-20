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
    public partial class EditCate : Form
    {
        public EditCate()
        {
            InitializeComponent();
        }
        private void EditCate_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6B9TM0P;Initial Catalog=KitchenStockDB_08182022;Integrated Security=True");
        private void btnCedit_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "update categoryTbl set Cat_Name='" + tb_C_name1.Text + "' ,Cat_Discription='" + tb_C_discription1.Text + "' where Cat_ID='" + tb_C_id1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Category Has Succesfully Updated !");
                // Debug.WriteLine(query);
                con.Close();
                this.Close();

                categories ck = new categories();
                ck.Show();
                // populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
