﻿using System;
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

        SqlConnection con = new SqlConnection(@"Data Source=RATHU;Initial Catalog=kitchenStock;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "insert into Table_kitchen values(" + tb_Uname.Text + ",'" + tb_Password.Text + "','" + comboBox_role.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                con.Close();
                populate();
                tb_Uname.Clear();
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
            tb_Uname.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
            tb_Password.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
            comboBox_role.Text = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
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
    }
}
