namespace stock_manejmant
{
    partial class categories
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
            this.dgv_Ceregories = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_C_discription = new System.Windows.Forms.TextBox();
            this.tb_C_name = new System.Windows.Forms.TextBox();
            this.tb_C_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnc_back = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ceregories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Ceregories
            // 
            this.dgv_Ceregories.AllowUserToAddRows = false;
            this.dgv_Ceregories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ceregories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ceregories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.Delete});
            this.dgv_Ceregories.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Ceregories.Location = new System.Drawing.Point(437, 103);
            this.dgv_Ceregories.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ceregories.Name = "dgv_Ceregories";
            this.dgv_Ceregories.RowHeadersWidth = 51;
            this.dgv_Ceregories.RowTemplate.Height = 25;
            this.dgv_Ceregories.Size = new System.Drawing.Size(644, 506);
            this.dgv_Ceregories.TabIndex = 37;
            this.dgv_Ceregories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ceregories_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(215, 292);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 54);
            this.button3.TabIndex = 36;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(20, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 54);
            this.button1.TabIndex = 34;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 38);
            this.label6.TabIndex = 33;
            this.label6.Text = "MANAGE CATEGORIES";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_C_discription
            // 
            this.tb_C_discription.Location = new System.Drawing.Point(183, 214);
            this.tb_C_discription.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_discription.Name = "tb_C_discription";
            this.tb_C_discription.Size = new System.Drawing.Size(200, 22);
            this.tb_C_discription.TabIndex = 30;
            // 
            // tb_C_name
            // 
            this.tb_C_name.Location = new System.Drawing.Point(183, 160);
            this.tb_C_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_name.Name = "tb_C_name";
            this.tb_C_name.Size = new System.Drawing.Size(200, 22);
            this.tb_C_name.TabIndex = 29;
            // 
            // tb_C_id
            // 
            this.tb_C_id.Location = new System.Drawing.Point(183, 103);
            this.tb_C_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_id.Name = "tb_C_id";
            this.tb_C_id.Size = new System.Drawing.Size(200, 22);
            this.tb_C_id.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "DISCRIPTION";
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
            this.label2.TabIndex = 27;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // btnc_back
            // 
            this.btnc_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_back.Location = new System.Drawing.Point(16, 551);
            this.btnc_back.Margin = new System.Windows.Forms.Padding(4);
            this.btnc_back.Name = "btnc_back";
            this.btnc_back.Size = new System.Drawing.Size(100, 58);
            this.btnc_back.TabIndex = 38;
            this.btnc_back.Text = "Back";
            this.btnc_back.UseVisualStyleBackColor = true;
            this.btnc_back.Click += new System.EventHandler(this.btnc_back_Click);
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "edit";
            this.edit.Image = global::stock_manejmant.Properties.Resources.services_20px1;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 60;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "delete";
            this.Delete.Image = global::stock_manejmant.Properties.Resources.cancel_20px1;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 76;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1097, 628);
            this.Controls.Add(this.btnc_back);
            this.Controls.Add(this.dgv_Ceregories);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_C_discription);
            this.Controls.Add(this.tb_C_name);
            this.Controls.Add(this.tb_C_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cetegorys";
            this.Load += new System.EventHandler(this.cetegorys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ceregories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ceregories;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_C_discription;
        private System.Windows.Forms.TextBox tb_C_name;
        private System.Windows.Forms.TextBox tb_C_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnc_back;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}