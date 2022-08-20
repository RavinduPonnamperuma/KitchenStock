namespace stock_manejmant
{
    partial class IssuedItemReport
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
            this.btnIssued_back = new System.Windows.Forms.Button();
            this.dgv_IssuedItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssuedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIssued_back
            // 
            this.btnIssued_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssued_back.Location = new System.Drawing.Point(13, 568);
            this.btnIssued_back.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssued_back.Name = "btnIssued_back";
            this.btnIssued_back.Size = new System.Drawing.Size(100, 58);
            this.btnIssued_back.TabIndex = 62;
            this.btnIssued_back.Text = "Back";
            this.btnIssued_back.UseVisualStyleBackColor = true;
            this.btnIssued_back.Click += new System.EventHandler(this.btnIssued_back_Click);
            // 
            // dgv_IssuedItems
            // 
            this.dgv_IssuedItems.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_IssuedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IssuedItems.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_IssuedItems.Location = new System.Drawing.Point(13, 77);
            this.dgv_IssuedItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_IssuedItems.Name = "dgv_IssuedItems";
            this.dgv_IssuedItems.RowHeadersWidth = 51;
            this.dgv_IssuedItems.RowTemplate.Height = 25;
            this.dgv_IssuedItems.Size = new System.Drawing.Size(942, 483);
            this.dgv_IssuedItems.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(335, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 38);
            this.label6.TabIndex = 57;
            this.label6.Text = "ISSUED ITEMS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // IssuedItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(971, 629);
            this.Controls.Add(this.btnIssued_back);
            this.Controls.Add(this.dgv_IssuedItems);
            this.Controls.Add(this.label6);
            this.Name = "IssuedItemReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuedItemReport";
            this.Load += new System.EventHandler(this.IssuedItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssuedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssued_back;
        private System.Windows.Forms.DataGridView dgv_IssuedItems;
        private System.Windows.Forms.Label label6;
    }
}