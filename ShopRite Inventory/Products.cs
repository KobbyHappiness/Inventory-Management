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
    public partial class Products : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\ShopRitedb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cn = new SqlCommand();
        public Products()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            proname.Clear();
            proprice.Clear();
            proqty.Clear();
            prodesc.Clear();
            procat.Clear();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn = new SqlCommand("insert into ProductsTbl(productname,price,productqty,description,category) values(@productname,@price,@productqty,@description,@category)", Con);
                    cn.Parameters.AddWithValue("@productname", proname.Text);
                    cn.Parameters.AddWithValue("@price", proprice.Text);
                    cn.Parameters.AddWithValue("@productqty", proqty.Text);
                    cn.Parameters.AddWithValue("@description", prodesc.Text);
                    cn.Parameters.AddWithValue("@category", procat.Text);
                    Con.Open();
                    cn.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product has been added successfully");
                    Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attendants atten = new Attendants();
            atten.Show();
            this.Hide();
        }
    }
}
