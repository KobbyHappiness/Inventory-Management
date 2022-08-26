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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void catid_TextChanged(object sender, EventArgs e)
        {

        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void catname_TextChanged(object sender, EventArgs e)
        {

        }

        private void catdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = 0, total = Convert.ToInt32(Pprice.Text) * Convert.ToInt32(quanti.Text);
            int Grdtotal = 0;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(OrderDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = catid.Text;
            newRow.Cells[2].Value = pronname.Text;
            newRow.Cells[3].Value = quanti.Text;
            newRow.Cells[4].Value = Pprice.Text;
            newRow.Cells[5].Value = Convert.ToInt32(Pprice.Text) * Convert.ToInt32(quanti.Text);
            OrderDGV.Rows.Add(newRow);
            Grdtotal = Grdtotal + total;
            amtlbl.Text = "GHS" + Grdtotal;
        }
    }
}
