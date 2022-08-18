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
            this.btnc_back_Issue = new System.Windows.Forms.Button();
            this.dgv_Ceregories = new System.Windows.Forms.DataGridView();
            this.btn_issue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Issue_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.comBox_IssueTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ceregories)).BeginInit();
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
            // dgv_Ceregories
            // 
            this.dgv_Ceregories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ceregories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ceregories.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Ceregories.Location = new System.Drawing.Point(489, 100);
            this.dgv_Ceregories.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ceregories.Name = "dgv_Ceregories";
            this.dgv_Ceregories.RowTemplate.Height = 25;
            this.dgv_Ceregories.Size = new System.Drawing.Size(644, 506);
            this.dgv_Ceregories.TabIndex = 49;
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = System.Drawing.Color.White;
            this.btn_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ForeColor = System.Drawing.Color.Red;
            this.btn_issue.Location = new System.Drawing.Point(158, 351);
            this.btn_issue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(193, 54);
            this.btn_issue.TabIndex = 46;
            this.btn_issue.Text = "ISSUE";
            this.btn_issue.UseVisualStyleBackColor = false;
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
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(235, 211);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(200, 24);
            this.comBox_Product.TabIndex = 51;
            // 
            // comBox_IssueTo
            // 
            this.comBox_IssueTo.FormattingEnabled = true;
            this.comBox_IssueTo.Location = new System.Drawing.Point(235, 161);
            this.comBox_IssueTo.Name = "comBox_IssueTo";
            this.comBox_IssueTo.Size = new System.Drawing.Size(200, 24);
            this.comBox_IssueTo.TabIndex = 52;
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
            // IssueProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBox_IssueTo);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.btnc_back_Issue);
            this.Controls.Add(this.dgv_Ceregories);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ceregories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnc_back_Issue;
        private System.Windows.Forms.DataGridView dgv_Ceregories;
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
    }
}