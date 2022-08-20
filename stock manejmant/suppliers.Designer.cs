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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Suppliers
            // 
            this.dgv_Suppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgv_Suppliers.Location = new System.Drawing.Point(437, 91);
            this.dgv_Suppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Suppliers.Name = "dgv_Suppliers";
            this.dgv_Suppliers.RowHeadersWidth = 51;
            this.dgv_Suppliers.Size = new System.Drawing.Size(644, 518);
            this.dgv_Suppliers.TabIndex = 22;
            this.dgv_Suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Suppliers_CellContentClick);
            // 
            // btn_S_delete
            // 
            this.btn_S_delete.BackColor = System.Drawing.Color.White;
            this.btn_S_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_S_delete.Location = new System.Drawing.Point(250, 407);
            this.btn_S_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_S_delete.Name = "btn_S_delete";
            this.btn_S_delete.Size = new System.Drawing.Size(108, 54);
            this.btn_S_delete.TabIndex = 21;
            this.btn_S_delete.Text = "Clear";
            this.btn_S_delete.UseVisualStyleBackColor = false;
            this.btn_S_delete.Click += new System.EventHandler(this.btn_S_delete_Click);
            // 
            // btn_S_add
            // 
            this.btn_S_add.BackColor = System.Drawing.Color.Blue;
            this.btn_S_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_S_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_S_add.Location = new System.Drawing.Point(21, 407);
            this.btn_S_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_S_add.Name = "btn_S_add";
            this.btn_S_add.Size = new System.Drawing.Size(108, 54);
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
            this.label6.Location = new System.Drawing.Point(379, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "MANAGE SUPPLIERS";
            // 
            // tb_S_password
            // 
            this.tb_S_password.Location = new System.Drawing.Point(183, 322);
            this.tb_S_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_S_password.Name = "tb_S_password";
            this.tb_S_password.Size = new System.Drawing.Size(200, 22);
            this.tb_S_password.TabIndex = 14;
            // 
            // tb_S_age
            // 
            this.tb_S_age.Location = new System.Drawing.Point(183, 214);
            this.tb_S_age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_S_age.Name = "tb_S_age";
            this.tb_S_age.Size = new System.Drawing.Size(200, 22);
            this.tb_S_age.TabIndex = 13;
            // 
            // tb_S_name
            // 
            this.tb_S_name.Location = new System.Drawing.Point(183, 160);
            this.tb_S_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_S_name.Name = "tb_S_name";
            this.tb_S_name.Size = new System.Drawing.Size(200, 22);
            this.tb_S_name.TabIndex = 12;
            // 
            // tb_S_id
            // 
            this.tb_S_id.Location = new System.Drawing.Point(183, 103);
            this.tb_S_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_S_id.Name = "tb_S_id";
            this.tb_S_id.Size = new System.Drawing.Size(200, 22);
            this.tb_S_id.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "AGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "PHONE";
            // 
            // tb_S_phone
            // 
            this.tb_S_phone.Location = new System.Drawing.Point(183, 267);
            this.tb_S_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_S_phone.Name = "tb_S_phone";
            this.tb_S_phone.Size = new System.Drawing.Size(200, 22);
            this.tb_S_phone.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Maroon;
            this.btn_back.Location = new System.Drawing.Point(29, 20);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 60);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 61;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 78;
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1097, 628);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_Suppliers);
            this.Controls.Add(this.btn_S_delete);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}