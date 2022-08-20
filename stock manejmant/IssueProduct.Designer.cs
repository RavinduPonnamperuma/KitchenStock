namespace stock_manejmant
{
    partial class IssueProduct
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
            this.btnc_back_Issue = new System.Windows.Forms.Button();
            this.dgv_issue = new System.Windows.Forms.DataGridView();
            this.btn_issue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Issue_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.productTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenStockDB_08182022DataSet2 = new stock_manejmant.KitchenStockDB_08182022DataSet2();
            this.comBox_IssueTo = new System.Windows.Forms.ComboBox();
            this.supplierTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenStockDB_08182022DataSet1 = new stock_manejmant.KitchenStockDB_08182022DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.kitchenStockDB_08182022DataSet = new stock_manejmant.KitchenStockDB_08182022DataSet();
            this.kitchenStockDB08182022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenStockDB08182022DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTblTableAdapter = new stock_manejmant.KitchenStockDB_08182022DataSet1TableAdapters.supplierTblTableAdapter();
            this.productTblTableAdapter = new stock_manejmant.KitchenStockDB_08182022DataSet2TableAdapters.productTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_issue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnc_back_Issue
            // 
            this.btnc_back_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_back_Issue.Location = new System.Drawing.Point(68, 548);
            this.btnc_back_Issue.Margin = new System.Windows.Forms.Padding(4);
            this.btnc_back_Issue.Name = "btnc_back_Issue";
            this.btnc_back_Issue.Size = new System.Drawing.Size(100, 58);
            this.btnc_back_Issue.TabIndex = 50;
            this.btnc_back_Issue.Text = "Back";
            this.btnc_back_Issue.UseVisualStyleBackColor = true;
            this.btnc_back_Issue.Click += new System.EventHandler(this.btnc_back_Issue_Click);
            // 
            // dgv_issue
            // 
            this.dgv_issue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_issue.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_issue.Location = new System.Drawing.Point(489, 100);
            this.dgv_issue.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_issue.Name = "dgv_issue";
            this.dgv_issue.RowHeadersWidth = 51;
            this.dgv_issue.RowTemplate.Height = 25;
            this.dgv_issue.Size = new System.Drawing.Size(644, 506);
            this.dgv_issue.TabIndex = 49;
            this.dgv_issue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_issue_CellContentClick);
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = System.Drawing.Color.White;
            this.btn_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ForeColor = System.Drawing.Color.Red;
            this.btn_issue.Location = new System.Drawing.Point(31, 348);
            this.btn_issue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(193, 54);
            this.btn_issue.TabIndex = 46;
            this.btn_issue.Text = "ISSUE";
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 38);
            this.label6.TabIndex = 45;
            this.label6.Text = "ISSUE PRODUCT";
            // 
            // tb_Issue_id
            // 
            this.tb_Issue_id.Location = new System.Drawing.Point(235, 100);
            this.tb_Issue_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Issue_id.Name = "tb_Issue_id";
            this.tb_Issue_id.Size = new System.Drawing.Size(200, 22);
            this.tb_Issue_id.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "PRODUCT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "ISSUED TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // comBox_Product
            // 
            this.comBox_Product.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productTblBindingSource, "prodName", true));
            this.comBox_Product.DataSource = this.productTblBindingSource;
            this.comBox_Product.DisplayMember = "prodName";
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(235, 211);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(200, 24);
            this.comBox_Product.TabIndex = 51;
            this.comBox_Product.ValueMember = "prodName";
            // 
            // productTblBindingSource
            // 
            this.productTblBindingSource.DataMember = "productTbl";
            this.productTblBindingSource.DataSource = this.kitchenStockDB_08182022DataSet2;
            // 
            // kitchenStockDB_08182022DataSet2
            // 
            this.kitchenStockDB_08182022DataSet2.DataSetName = "KitchenStockDB_08182022DataSet2";
            this.kitchenStockDB_08182022DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comBox_IssueTo
            // 
            this.comBox_IssueTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierTblBindingSource, "supplierName", true));
            this.comBox_IssueTo.DataSource = this.supplierTblBindingSource;
            this.comBox_IssueTo.DisplayMember = "supplierName";
            this.comBox_IssueTo.FormattingEnabled = true;
            this.comBox_IssueTo.Location = new System.Drawing.Point(235, 161);
            this.comBox_IssueTo.Name = "comBox_IssueTo";
            this.comBox_IssueTo.Size = new System.Drawing.Size(200, 24);
            this.comBox_IssueTo.TabIndex = 52;
            this.comBox_IssueTo.ValueMember = "supplierName";
            // 
            // supplierTblBindingSource
            // 
            this.supplierTblBindingSource.DataMember = "supplierTbl";
            this.supplierTblBindingSource.DataSource = this.kitchenStockDB_08182022DataSet1;
            // 
            // kitchenStockDB_08182022DataSet1
            // 
            this.kitchenStockDB_08182022DataSet1.DataSetName = "KitchenStockDB_08182022DataSet1";
            this.kitchenStockDB_08182022DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "QUANTITY";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(235, 268);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(200, 22);
            this.tb_quantity.TabIndex = 54;
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
            // kitchenStockDB08182022DataSetBindingSource1
            // 
            this.kitchenStockDB08182022DataSetBindingSource1.DataSource = this.kitchenStockDB_08182022DataSet;
            this.kitchenStockDB08182022DataSetBindingSource1.Position = 0;
            // 
            // supplierTblTableAdapter
            // 
            this.supplierTblTableAdapter.ClearBeforeFill = true;
            // 
            // productTblTableAdapter
            // 
            this.productTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 55;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBox_IssueTo);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.btnc_back_Issue);
            this.Controls.Add(this.dgv_issue);
            this.Controls.Add(this.btn_issue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Issue_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "IssueProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueProduct";
            this.Load += new System.EventHandler(this.IssueProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_issue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB_08182022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenStockDB08182022DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnc_back_Issue;
        private System.Windows.Forms.DataGridView dgv_issue;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Issue_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBox_Product;
        private System.Windows.Forms.ComboBox comBox_IssueTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.BindingSource kitchenStockDB08182022DataSetBindingSource1;
        private KitchenStockDB_08182022DataSet kitchenStockDB_08182022DataSet;
        private System.Windows.Forms.BindingSource kitchenStockDB08182022DataSetBindingSource;
        private KitchenStockDB_08182022DataSet1 kitchenStockDB_08182022DataSet1;
        private System.Windows.Forms.BindingSource supplierTblBindingSource;
        private KitchenStockDB_08182022DataSet1TableAdapters.supplierTblTableAdapter supplierTblTableAdapter;
        private KitchenStockDB_08182022DataSet2 kitchenStockDB_08182022DataSet2;
        private System.Windows.Forms.BindingSource productTblBindingSource;
        private KitchenStockDB_08182022DataSet2TableAdapters.productTblTableAdapter productTblTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}