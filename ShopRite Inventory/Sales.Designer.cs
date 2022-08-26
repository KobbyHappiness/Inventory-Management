
namespace ShopRite_Inventory
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Datelbl;
            this.Exit = new System.Windows.Forms.Label();
            this.catid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.catDGV = new System.Windows.Forms.DataGridView();
            this.quanti = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.amtlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.Pprice = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronname = new System.Windows.Forms.TextBox();
            Datelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Datelbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            Datelbl.Location = new System.Drawing.Point(671, 9);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new System.Drawing.Size(43, 18);
            Datelbl.TabIndex = 49;
            Datelbl.Text = "Date";
            Datelbl.Click += new System.EventHandler(this.date_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(766, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 19);
            this.Exit.TabIndex = 60;
            this.Exit.Text = "Exit";
            // 
            // catid
            // 
            this.catid.Location = new System.Drawing.Point(251, 59);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(179, 20);
            this.catid.TabIndex = 59;
            this.catid.TextChanged += new System.EventHandler(this.catid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(131, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 58;
            this.label9.Text = "Bill ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // catDGV
            // 
            this.catDGV.BackgroundColor = System.Drawing.Color.White;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDGV.Location = new System.Drawing.Point(456, 226);
            this.catDGV.Name = "catDGV";
            this.catDGV.Size = new System.Drawing.Size(332, 155);
            this.catDGV.TabIndex = 57;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
            // 
            // quanti
            // 
            this.quanti.Location = new System.Drawing.Point(251, 128);
            this.quanti.Name = "quanti";
            this.quanti.Size = new System.Drawing.Size(179, 20);
            this.quanti.TabIndex = 55;
            this.quanti.TextChanged += new System.EventHandler(this.catdesc_TextChanged);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Red;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(474, 411);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(74, 27);
            this.addbtn.TabIndex = 54;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(687, 411);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(74, 27);
            this.deletebtn.TabIndex = 53;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Red;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(579, 411);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(74, 27);
            this.updatebtn.TabIndex = 52;
            this.updatebtn.Text = "PRINT";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "SALES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 450);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(131, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.Text = "Select Category";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(351, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 64;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 211);
            this.dataGridView1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "AMOUNT:";
            // 
            // amtlbl
            // 
            this.amtlbl.AutoSize = true;
            this.amtlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtlbl.Location = new System.Drawing.Point(614, 389);
            this.amtlbl.Name = "amtlbl";
            this.amtlbl.Size = new System.Drawing.Size(41, 19);
            this.amtlbl.TabIndex = 67;
            this.amtlbl.Text = "GHS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 68;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product_Name,
            this.Quantity,
            this.Total});
            this.OrderDGV.Location = new System.Drawing.Point(456, 59);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.Size = new System.Drawing.Size(332, 155);
            this.OrderDGV.TabIndex = 69;
            // 
            // Pprice
            // 
            this.Pprice.Location = new System.Drawing.Point(251, 165);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(179, 20);
            this.Pprice.TabIndex = 70;
            // 
            // ID
            // 
            this.ID.HeaderText = "Bill ID";
            this.ID.Name = "ID";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // pronname
            // 
            this.pronname.Location = new System.Drawing.Point(251, 92);
            this.pronname.Name = "pronname";
            this.pronname.Size = new System.Drawing.Size(179, 20);
            this.pronname.TabIndex = 71;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pronname);
            this.Controls.Add(this.Pprice);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amtlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.catid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.catDGV);
            this.Controls.Add(this.quanti);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(Datelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox catid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView catDGV;
        private System.Windows.Forms.TextBox quanti;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amtlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.TextBox Pprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox pronname;
    }
}