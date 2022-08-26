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
    public partial class Category : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\ShopRitedb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cn = new SqlCommand();
        public Category()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn = new SqlCommand("insert into CategoryTbl(CatId,CatName,CatDesc) values(@CatId,@CatName,@CatDesc)", Con);
                    cn.Parameters.AddWithValue("@CatId", catid.Text);
                    cn.Parameters.AddWithValue("@CatName", catname.Text);
                    cn.Parameters.AddWithValue("@CatDesc", catdesc.Text);
                    Con.Open();
                    cn.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Category has been added successfully");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                catid.Clear();
                catname.Clear();
                catdesc.Clear();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attendants atten = new Attendants();
            atten.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(catid.Text== "" || catname.Text==""|| catdesc.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTbl set CatId='" + catid.Text + "', CatName=" + catname.Text + ", CatDesc=" + catdesc + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully updated");
                    Con.Close();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 }

