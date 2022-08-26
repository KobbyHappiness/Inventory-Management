
namespace ShopRite_Inventory
{
    partial class Products
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
            this.Exit = new System.Windows.Forms.Label();
            this.proname = new System.Windows.Forms.TextBox();
            this.prodname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proprice = new System.Windows.Forms.TextBox();
            this.proqty = new System.Windows.Forms.TextBox();
            this.prodesc = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.prodcat = new System.Windows.Forms.Label();
            this.proddesc = new System.Windows.Forms.Label();
            this.prodqty = new System.Windows.Forms.Label();
            this.prodprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.procat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Exit.TabIndex = 46;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // proname
            // 
            this.proname.Location = new System.Drawing.Point(258, 93);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(179, 20);
            this.proname.TabIndex = 45;
            // 
            // prodname
            // 
            this.prodname.AutoSize = true;
            this.prodname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodname.Location = new System.Drawing.Point(131, 92);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(124, 21);
            this.prodname.TabIndex = 44;
            this.prodname.Text = "Product Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 277);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proprice
            // 
            this.proprice.Location = new System.Drawing.Point(258, 137);
            this.proprice.Name = "proprice";
            this.proprice.Size = new System.Drawing.Size(179, 20);
            this.proprice.TabIndex = 42;
            // 
            // proqty
            // 
            this.proqty.Location = new System.Drawing.Point(258, 180);
            this.proqty.Name = "proqty";
            this.proqty.Size = new System.Drawing.Size(179, 20);
            this.proqty.TabIndex = 38;
            // 
            // prodesc
            // 
            this.prodesc.Location = new System.Drawing.Point(258, 232);
            this.prodesc.Name = "prodesc";
            this.prodesc.Size = new System.Drawing.Size(179, 20);
            this.prodesc.TabIndex = 37;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Red;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(135, 342);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(74, 27);
            this.addbtn.TabIndex = 36;
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
            this.deletebtn.Location = new System.Drawing.Point(349, 342);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(74, 27);
            this.deletebtn.TabIndex = 35;
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
            this.updatebtn.Location = new System.Drawing.Point(244, 342);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(74, 27);
            this.updatebtn.TabIndex = 34;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // prodcat
            // 
            this.prodcat.AutoSize = true;
            this.prodcat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodcat.Location = new System.Drawing.Point(131, 269);
            this.prodcat.Name = "prodcat";
            this.prodcat.Size = new System.Drawing.Size(85, 21);
            this.prodcat.TabIndex = 31;
            this.prodcat.Text = "Category";
            // 
            // proddesc
            // 
            this.proddesc.AutoSize = true;
            this.proddesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proddesc.Location = new System.Drawing.Point(131, 229);
            this.proddesc.Name = "proddesc";
            this.proddesc.Size = new System.Drawing.Size(97, 21);
            this.proddesc.TabIndex = 30;
            this.proddesc.Text = "Description";
            // 
            // prodqty
            // 
            this.prodqty.AutoSize = true;
            this.prodqty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodqty.Location = new System.Drawing.Point(131, 177);
            this.prodqty.Name = "prodqty";
            this.prodqty.Size = new System.Drawing.Size(80, 21);
            this.prodqty.TabIndex = 29;
            this.prodqty.Text = "Quantity";
            // 
            // prodprice
            // 
            this.prodprice.AutoSize = true;
            this.prodprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodprice.Location = new System.Drawing.Point(131, 137);
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(47, 21);
            this.prodprice.TabIndex = 28;
            this.prodprice.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(364, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "WELCOME TO SHOPRITE GHANA";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 27);
            this.button5.TabIndex = 23;
            this.button5.Text = "ATTENDANTS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "CATEGORIES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 384);
            this.panel1.TabIndex = 25;
            // 
            // procat
            // 
            this.procat.Location = new System.Drawing.Point(258, 272);
            this.procat.Name = "procat";
            this.procat.Size = new System.Drawing.Size(179, 20);
            this.procat.TabIndex = 39;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.proname);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.proprice);
            this.Controls.Add(this.procat);
            this.Controls.Add(this.proqty);
            this.Controls.Add(this.prodesc);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.prodcat);
            this.Controls.Add(this.proddesc);
            this.Controls.Add(this.prodqty);
            this.Controls.Add(this.prodprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox proname;
        private System.Windows.Forms.Label prodname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox proprice;
        private System.Windows.Forms.TextBox proqty;
        private System.Windows.Forms.TextBox prodesc;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label prodcat;
        private System.Windows.Forms.Label proddesc;
        private System.Windows.Forms.Label prodqty;
        private System.Windows.Forms.Label prodprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox procat;
    }
}