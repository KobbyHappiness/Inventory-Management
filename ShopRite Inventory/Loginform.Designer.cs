
namespace ShopRite_Inventory
{
    partial class Loginform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.Upass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.Exit = new System.Windows.Forms.Label();
            this.Rolecb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Shoprite Ghana ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(53, 138);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(211, 20);
            this.Uname.TabIndex = 2;
            // 
            // Upass
            // 
            this.Upass.Location = new System.Drawing.Point(53, 197);
            this.Upass.Name = "Upass";
            this.Upass.Size = new System.Drawing.Size(211, 20);
            this.Upass.TabIndex = 4;
            this.Upass.UseSystemPasswordChar = true;
            this.Upass.TextChanged += new System.EventHandler(this.Upass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Red;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(53, 250);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(211, 29);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpass.Location = new System.Drawing.Point(146, 223);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(118, 21);
            this.checkBoxpass.TabIndex = 7;
            this.checkBoxpass.Text = "Show password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(282, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 18);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.label4_Click);
            // 
            // Rolecb
            // 
            this.Rolecb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolecb.FormattingEnabled = true;
            this.Rolecb.Items.AddRange(new object[] {
            "Admin\t",
            "Attendant"});
            this.Rolecb.Location = new System.Drawing.Point(112, 77);
            this.Rolecb.Name = "Rolecb";
            this.Rolecb.Size = new System.Drawing.Size(86, 25);
            this.Rolecb.TabIndex = 9;
            this.Rolecb.Text = "Role";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 340);
            this.Controls.Add(this.Rolecb);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Upass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Upass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.ComboBox Rolecb;
    }
}

