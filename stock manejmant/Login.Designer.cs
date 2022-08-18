namespace stock_manejmant
{
    partial class frm_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_log));
            this.home_label1 = new System.Windows.Forms.Label();
            this.home_label2 = new System.Windows.Forms.Label();
            this.home_label3 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.home_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_label1
            // 
            this.home_label1.BackColor = System.Drawing.Color.Tomato;
            this.home_label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label1.ForeColor = System.Drawing.Color.White;
            this.home_label1.Location = new System.Drawing.Point(24, 5);
            this.home_label1.Name = "home_label1";
            this.home_label1.Size = new System.Drawing.Size(577, 34);
            this.home_label1.TabIndex = 0;
            this.home_label1.Text = "KITCHEN STOCK MANAGEMENT SYSTEM  \r\n";
            // 
            // home_label2
            // 
            this.home_label2.AutoSize = true;
            this.home_label2.BackColor = System.Drawing.Color.MistyRose;
            this.home_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label2.ForeColor = System.Drawing.Color.Maroon;
            this.home_label2.Location = new System.Drawing.Point(270, 197);
            this.home_label2.Name = "home_label2";
            this.home_label2.Size = new System.Drawing.Size(106, 18);
            this.home_label2.TabIndex = 3;
            this.home_label2.Text = "USER NAME";
            // 
            // home_label3
            // 
            this.home_label3.AutoSize = true;
            this.home_label3.BackColor = System.Drawing.Color.MistyRose;
            this.home_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label3.ForeColor = System.Drawing.Color.Maroon;
            this.home_label3.Location = new System.Drawing.Point(272, 240);
            this.home_label3.Name = "home_label3";
            this.home_label3.Size = new System.Drawing.Size(104, 18);
            this.home_label3.TabIndex = 4;
            this.home_label3.Text = "PASSWORD";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(389, 195);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(221, 20);
            this.tb_userName.TabIndex = 5;
            this.tb_userName.TextChanged += new System.EventHandler(this.tb_userName_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(389, 238);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(221, 20);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(514, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 48);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AllowDrop = true;
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(3, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 48);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.home_label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 50);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.home_pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tb_userName);
            this.panel3.Controls.Add(this.home_label2);
            this.panel3.Controls.Add(this.tb_password);
            this.panel3.Controls.Add(this.home_label3);
            this.panel3.Location = new System.Drawing.Point(5, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 283);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // home_pictureBox1
            // 
            this.home_pictureBox1.BackColor = System.Drawing.Color.DeepPink;
            this.home_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("home_pictureBox1.Image")));
            this.home_pictureBox1.Location = new System.Drawing.Point(271, 15);
            this.home_pictureBox1.Name = "home_pictureBox1";
            this.home_pictureBox1.Size = new System.Drawing.Size(342, 166);
            this.home_pictureBox1.TabIndex = 2;
            this.home_pictureBox1.TabStop = false;
            this.home_pictureBox1.UseWaitCursor = true;
            this.home_pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(7, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 255);
            this.panel4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Lime;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(247, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 48);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.Controls.Add(this.btn_exit);
            this.panel5.Controls.Add(this.btn_clear);
            this.panel5.Controls.Add(this.btn_login);
            this.panel5.Location = new System.Drawing.Point(5, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(623, 56);
            this.panel5.TabIndex = 12;
            // 
            // frm_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(634, 409);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label home_label1;
        private System.Windows.Forms.PictureBox home_pictureBox1;
        private System.Windows.Forms.Label home_label2;
        private System.Windows.Forms.Label home_label3;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel5;
    }
}

