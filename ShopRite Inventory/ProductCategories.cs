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
    public partial class ProductCategories : Form
    {
        public ProductCategories()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendants atten = new Attendants();
            atten.Show();
            this.Hide();
        }
    }
}
