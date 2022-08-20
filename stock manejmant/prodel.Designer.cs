
namespace stock_manejmant
{
    partial class prodel
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
            this.tb_price2 = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_quntity2 = new System.Windows.Forms.TextBox();
            this.tb_name2 = new System.Windows.Forms.TextBox();
            this.tb_id2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kitchenStockDB_08182022DataSet = new stock_manejmant.KitchenStockDB_08182022DataSet();
            this.kitchenStockDB08182022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTblTableAdapter = new stock_manejmant.KitchenStockDB_08182022DataSetTableAdapters.categoryTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_price2
            // 
            this.tb_price2.Location = new System.Drawing.Point(262, 267);
            this.tb_price2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_price2.Name = "tb_price2";
            this.tb_price2.Size = new System.Drawing.Size(200, 22);
            this.tb_price2.TabIndex = 25;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Tomato;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(323, 320);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 54);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "Delete";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_quntity2
            // 
            this.tb_quntity2.Location = new System.Drawing.Point(262, 209);
            this.tb_quntity2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quntity2.Name = "tb_quntity2";
            this.tb_quntity2.Size = new System.Drawing.Size(200, 22);
            this.tb_quntity2.TabIndex = 20;
            // 
            // tb_name2
            // 
            this.tb_name2.Location = new System.Drawing.Point(262, 105);
            this.tb_name2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name2.Name = "tb_name2";
            this.tb_name2.Size = new System.Drawing.Size(200, 22);
            this.tb_name2.TabIndex = 22;
            // 
            // tb_id2
            // 
            this.tb_id2.Location = new System.Drawing.Point(262, 48);
            this.tb_id2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id2.Name = "tb_id2";
            this.tb_id2.ReadOnly = true;
            this.tb_id2.Size = new System.Drawing.Size(200, 22);
            this.tb_id2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "CETEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryTblBindingSource, "Cat_Name", true));
            this.comboBox2.DataSource = this.categoryTblBindingSource;
            this.comboBox2.DisplayMember = "Cat_Name";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(262, 156);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "Cat_Name";
            // 
            // kitchenStockDB_08182022DataSet
            // 
            this.kitchenStockDB_08182022DataSet.DataSetName = "KitchenStockDB_08182022DataSet";
            this.kitchenStockDB_08182022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitchenStockDB08182022DataSetBindingSource
            // 
            this.kitchenStockDB08182022DataSetBindingSource.DataSource = this.kitchenStockDB_08182022DataSet;
            this.kitchenStockDB08182022DataSetBindingSource.Position = 0;
            // 
            // categoryTblBindingSource
            // 
            this.categoryTblBindingSource.DataMember = "categoryTbl";
            this.categoryTblBindingSource.DataSource = this.kitchenStockDB08182022DataSetBindingSource;
            // 
            // categoryTblTableAdapter
            // 
            this.categoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // prodel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tb_price2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_quntity2);
            this.Controls.Add(this.tb_name2);
            this.Controls.Add(this.tb_id2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "prodel";
            this.Text = "prodel";
            this.Load += new System.EventHandler(this.prodel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_price2;
        private System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.TextBox tb_quntity2;
        public System.Windows.Forms.TextBox tb_name2;
        public System.Windows.Forms.TextBox tb_id2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kitchenStockDB08182022DataSetBindingSource;
        private KitchenStockDB_08182022DataSet kitchenStockDB_08182022DataSet;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
        private KitchenStockDB_08182022DataSetTableAdapters.categoryTblTableAdapter categoryTblTableAdapter;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}