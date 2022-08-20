
namespace stock_manejmant
{
    partial class proedit
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
            this.components = new System.ComponentModel.Container();
            this.tb_quntity1 = new System.Windows.Forms.TextBox();
            this.tb_price1 = new System.Windows.Forms.TextBox();
            this.tb_name1 = new System.Windows.Forms.TextBox();
            this.tb_id1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenStockDB08182022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenStockDB_08182022DataSet = new stock_manejmant.KitchenStockDB_08182022DataSet();
            this.categoryTblTableAdapter = new stock_manejmant.KitchenStockDB_08182022DataSetTableAdapters.categoryTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_quntity1
            // 
            this.tb_quntity1.Location = new System.Drawing.Point(262, 222);
            this.tb_quntity1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quntity1.Name = "tb_quntity1";
            this.tb_quntity1.Size = new System.Drawing.Size(200, 22);
            this.tb_quntity1.TabIndex = 8;
            // 
            // tb_price1
            // 
            this.tb_price1.Location = new System.Drawing.Point(262, 281);
            this.tb_price1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_price1.Name = "tb_price1";
            this.tb_price1.Size = new System.Drawing.Size(200, 22);
            this.tb_price1.TabIndex = 9;
            // 
            // tb_name1
            // 
            this.tb_name1.Location = new System.Drawing.Point(262, 118);
            this.tb_name1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name1.Name = "tb_name1";
            this.tb_name1.Size = new System.Drawing.Size(200, 22);
            this.tb_name1.TabIndex = 10;
            // 
            // tb_id1
            // 
            this.tb_id1.Location = new System.Drawing.Point(262, 61);
            this.tb_id1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id1.Name = "tb_id1";
            this.tb_id1.ReadOnly = true;
            this.tb_id1.Size = new System.Drawing.Size(200, 22);
            this.tb_id1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "CETEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Tomato;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(354, 337);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 54);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryTblBindingSource, "Cat_Name", true));
            this.comboBox1.DataSource = this.categoryTblBindingSource;
            this.comboBox1.DisplayMember = "Cat_Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Cat_Name";
            // 
            // categoryTblBindingSource
            // 
            this.categoryTblBindingSource.DataMember = "categoryTbl";
            this.categoryTblBindingSource.DataSource = this.kitchenStockDB08182022DataSetBindingSource;
            // 
            // kitchenStockDB08182022DataSetBindingSource
            // 
            this.kitchenStockDB08182022DataSetBindingSource.DataSource = this.kitchenStockDB_08182022DataSet;
            this.kitchenStockDB08182022DataSetBindingSource.Position = 0;
            // 
            // kitchenStockDB_08182022DataSet
            // 
            this.kitchenStockDB_08182022DataSet.DataSetName = "KitchenStockDB_08182022DataSet";
            this.kitchenStockDB_08182022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTblTableAdapter
            // 
            this.categoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // proedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_quntity1);
            this.Controls.Add(this.tb_price1);
            this.Controls.Add(this.tb_name1);
            this.Controls.Add(this.tb_id1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "proedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proedit";
            this.Load += new System.EventHandler(this.proedit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.TextBox tb_quntity1;
        public System.Windows.Forms.TextBox tb_price1;
        public System.Windows.Forms.TextBox tb_name1;
        public System.Windows.Forms.TextBox tb_id1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource kitchenStockDB08182022DataSetBindingSource;
        private KitchenStockDB_08182022DataSet kitchenStockDB_08182022DataSet;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
        private KitchenStockDB_08182022DataSetTableAdapters.categoryTblTableAdapter categoryTblTableAdapter;
    }
}