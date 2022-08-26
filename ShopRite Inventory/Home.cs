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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Show();
            this.Hide();
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void attendantsbtn_Click(object sender, EventArgs e)
        {
            Attendants atten = new Attendants();
            atten.Show();
            this.Hide();
        }
    }
}
