namespace stock_manejmant
{
    partial class suppliers
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
            this.dgv_Suppliers = new System.Windows.Forms.DataGridView();
            this.btn_S_delete = new System.Windows.Forms.Button();
            this.btn_S_edit = new System.Windows.Forms.Button();
            this.btn_S_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_S_password = new System.Windows.Forms.TextBox();
            this.tb_S_age = new System.Windows.Forms.TextBox();
            this.tb_S_name = new System.Windows.Forms.TextBox();
            this.tb_S_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_S_phone = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Suppliers
            // 
            this.dgv_Suppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suppliers.Location = new System.Drawing.Point(328, 74);
            this.dgv_Suppliers.Name = "dgv_Suppliers";
            this.dgv_Suppliers.Size = new System.Drawing.Size(483, 421);
            this.dgv_Suppliers.TabIndex = 22;
            this.dgv_Suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Suppliers_CellContentClick);
            // 
            // btn_S_delete
            // 
            this.btn_S_delete.BackColor = System.Drawing.Color.White;
            this.btn_S_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_S_delete.Location = new System.Drawing.Point(207, 331);
            this.btn_S_delete.Name = "btn_S_delete";
            this.btn_S_delete.Size = new System.Drawing.Size(81, 44);
            this.btn_S_delete.TabIndex = 21;
            this.btn_S_delete.Text = "DELETE";
            this.btn_S_delete.UseVisualStyleBackColor = false;
            this.btn_S_delete.Click += new System.EventHandler(this.btn_S_delete_Click);
            // 
            // btn_S_edit
            // 
            this.btn_S_edit.BackColor = System.Drawing.Color.White;
            this.btn_S_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S_edit.ForeColor = System.Drawing.Color.Red;
            this.btn_S_edit.Location = new System.Drawing.Point(112, 331);
            this.btn_S_edit.Name = "btn_S_edit";
            this.btn_S_edit.Size = new System.Drawing.Size(81, 44);
            this.btn_S_edit.TabIndex = 20;
            this.btn_S_edit.Text = "EDIT";
            this.btn_S_edit.UseVisualStyleBackColor = false;
            this.btn_S_edit.Click += new System.EventHandler(this.btn_S_edit_Click);
            // 
            // btn_S_add
            // 
            this.btn_S_add.BackColor = System.Drawing.Color.White;
            this.btn_S_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S_add.ForeColor = System.Drawing.Color.Red;
            this.btn_S_add.Location = new System.Drawing.Point(16, 331);
            this.btn_S_add.Name = "btn_S_add";
            this.btn_S_add.Size = new System.Drawing.Size(81, 44);
            this.btn_S_add.TabIndex = 18;
            this.btn_S_add.Text = "ADD";
            this.btn_S_add.UseVisualStyleBackColor = false;
            this.btn_S_add.Click += new System.EventHandler(this.btn_S_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(284, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "MANAGE SUPPLIERS";
            // 
            // tb_S_password
            // 
            this.tb_S_password.Location = new System.Drawing.Point(137, 262);
            this.tb_S_password.Name = "tb_S_password";
            this.tb_S_password.Size = new System.Drawing.Size(151, 20);
            this.tb_S_password.TabIndex = 14;
            // 
            // tb_S_age
            // 
            this.tb_S_age.Location = new System.Drawing.Point(137, 174);
            this.tb_S_age.Name = "tb_S_age";
            this.tb_S_age.Size = new System.Drawing.Size(151, 20);
            this.tb_S_age.TabIndex = 13;
            // 
            // tb_S_name
            // 
            this.tb_S_name.Location = new System.Drawing.Point(137, 130);
            this.tb_S_name.Name = "tb_S_name";
            this.tb_S_name.Size = new System.Drawing.Size(151, 20);
            this.tb_S_name.TabIndex = 12;
            // 
            // tb_S_id
            // 
            this.tb_S_id.Location = new System.Drawing.Point(137, 84);
            this.tb_S_id.Name = "tb_S_id";
            this.tb_S_id.Size = new System.Drawing.Size(151, 20);
            this.tb_S_id.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "AGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "PHONE";
            // 
            // tb_S_phone
            // 
            this.tb_S_phone.Location = new System.Drawing.Point(137, 217);
            this.tb_S_phone.Name = "tb_S_phone";
            this.tb_S_phone.Size = new System.Drawing.Size(151, 20);
            this.tb_S_phone.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Maroon;
            this.btn_back.Location = new System.Drawing.Point(22, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 49);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(823, 510);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_Suppliers);
            this.Controls.Add(this.btn_S_delete);
            this.Controls.Add(this.btn_S_edit);
            this.Controls.Add(this.btn_S_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_S_phone);
            this.Controls.Add(this.tb_S_password);
            this.Controls.Add(this.tb_S_age);
            this.Controls.Add(this.tb_S_name);
            this.Controls.Add(this.tb_S_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppliers";
            this.Load += new System.EventHandler(this.suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Suppliers;
        private System.Windows.Forms.Button btn_S_delete;
        private System.Windows.Forms.Button btn_S_edit;
        private System.Windows.Forms.Button btn_S_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_S_password;
        private System.Windows.Forms.TextBox tb_S_age;
        private System.Windows.Forms.TextBox tb_S_name;
        private System.Windows.Forms.TextBox tb_S_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_S_phone;
        private System.Windows.Forms.Button btn_back;
    }
}