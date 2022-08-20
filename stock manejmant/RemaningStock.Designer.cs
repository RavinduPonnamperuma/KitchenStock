namespace stock_manejmant
{
    partial class RemaningStock
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
            this.btnRemaning_back = new System.Windows.Forms.Button();
            this.dgv_RemaningStock = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RemaningStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemaning_back
            // 
            this.btnRemaning_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemaning_back.Location = new System.Drawing.Point(10, 553);
            this.btnRemaning_back.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemaning_back.Name = "btnRemaning_back";
            this.btnRemaning_back.Size = new System.Drawing.Size(100, 58);
            this.btnRemaning_back.TabIndex = 65;
            this.btnRemaning_back.Text = "Back";
            this.btnRemaning_back.UseVisualStyleBackColor = true;
            this.btnRemaning_back.Click += new System.EventHandler(this.btnRemaning_back_Click);
            // 
            // dgv_RemaningStock
            // 
            this.dgv_RemaningStock.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_RemaningStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RemaningStock.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_RemaningStock.Location = new System.Drawing.Point(10, 62);
            this.dgv_RemaningStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_RemaningStock.Name = "dgv_RemaningStock";
            this.dgv_RemaningStock.RowHeadersWidth = 51;
            this.dgv_RemaningStock.RowTemplate.Height = 25;
            this.dgv_RemaningStock.Size = new System.Drawing.Size(942, 483);
            this.dgv_RemaningStock.TabIndex = 64;
            this.dgv_RemaningStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RemaningStock_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(322, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 38);
            this.label6.TabIndex = 63;
            this.label6.Text = "REMANING STOCK";
            // 
            // RemaningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(963, 615);
            this.Controls.Add(this.btnRemaning_back);
            this.Controls.Add(this.dgv_RemaningStock);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "RemaningStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemaningStock";
            this.Load += new System.EventHandler(this.RemaningStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RemaningStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemaning_back;
        private System.Windows.Forms.DataGridView dgv_RemaningStock;
        private System.Windows.Forms.Label label6;
    }
}