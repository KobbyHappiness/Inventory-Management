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

namespace ShopRite_Inventory
{
    public partial class Attendants : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\ShopRitedb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cn = new SqlCommand();
        public Attendants()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to add this attendant?","Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn = new SqlCommand("insert into AttendantsTbl(username,firstname,lastname,dateofbirth,email,phone,password) values(@username,@firstname,@lastname,@dateofbirth,@email,@phone,@password)", Con);
                    cn.Parameters.AddWithValue("@username", auname.Text);
                    cn.Parameters.AddWithValue("@firstname", afname.Text);
                    cn.Parameters.AddWithValue("@lastname", alname.Text);
                    cn.Parameters.AddWithValue("@dateofbirth", adob.Text);
                    cn.Parameters.AddWithValue("@email", aemail.Text);
                    cn.Parameters.AddWithValue("@phone", aphone.Text);
                    cn.Parameters.AddWithValue("@password", apassword.Text);
                    Con.Open();
                    cn.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Attendant has been added successfully");
                    Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
            {
            Clear();
            }

        public void Clear()
        { 
            auname.Clear();
            afname.Clear();
            alname.Clear();
            adob.Clear();
            aemail.Clear();
            aphone.Clear();
            apassword.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }
    }
}

