
namespace ShopRite_Inventory
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.productbtn = new System.Windows.Forms.Button();
            this.categoriesbtn = new System.Windows.Forms.Button();
            this.attendantsbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // productbtn
            // 
            this.productbtn.BackColor = System.Drawing.Color.Red;
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.Color.White;
            this.productbtn.Location = new System.Drawing.Point(1, 60);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(100, 27);
            this.productbtn.TabIndex = 22;
            this.productbtn.Text = "PRODUCTS";
            this.productbtn.UseVisualStyleBackColor = false;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // categoriesbtn
            // 
            this.categoriesbtn.BackColor = System.Drawing.Color.Red;
            this.categoriesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesbtn.ForeColor = System.Drawing.Color.White;
            this.categoriesbtn.Location = new System.Drawing.Point(1, 136);
            this.categoriesbtn.Name = "categoriesbtn";
            this.categoriesbtn.Size = new System.Drawing.Size(100, 27);
            this.categoriesbtn.TabIndex = 23;
            this.categoriesbtn.Text = "CATEGORIES";
            this.categoriesbtn.UseVisualStyleBackColor = false;
            this.categoriesbtn.Click += new System.EventHandler(this.categoriesbtn_Click);
            // 
            // attendantsbtn
            // 
            this.attendantsbtn.BackColor = System.Drawing.Color.Red;
            this.attendantsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendantsbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantsbtn.ForeColor = System.Drawing.Color.White;
            this.attendantsbtn.Location = new System.Drawing.Point(1, 208);
            this.attendantsbtn.Name = "attendantsbtn";
            this.attendantsbtn.Size = new System.Drawing.Size(100, 27);
            this.attendantsbtn.TabIndex = 24;
            this.attendantsbtn.Text = "ATTENDANTS";
            this.attendantsbtn.UseVisualStyleBackColor = false;
            this.attendantsbtn.Click += new System.EventHandler(this.attendantsbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.attendantsbtn);
            this.panel2.Controls.Add(this.productbtn);
            this.panel2.Controls.Add(this.categoriesbtn);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 391);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.Button categoriesbtn;
        private System.Windows.Forms.Button attendantsbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}