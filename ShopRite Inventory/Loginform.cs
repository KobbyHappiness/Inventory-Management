using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite_Inventory
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked == false)
                Upass.UseSystemPasswordChar = true;
            else
                Upass.UseSystemPasswordChar = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            if ((Uname.Text==username) && (Upass.Text==password))
            {
                this.Visible = false;
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void Upass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
