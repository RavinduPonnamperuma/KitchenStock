
namespace stock_manejmant
{
    partial class EditCate
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
            this.tb_C_discription1 = new System.Windows.Forms.TextBox();
            this.tb_C_name1 = new System.Windows.Forms.TextBox();
            this.tb_C_id1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_C_discription1
            // 
            this.tb_C_discription1.Location = new System.Drawing.Point(247, 180);
            this.tb_C_discription1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_discription1.Name = "tb_C_discription1";
            this.tb_C_discription1.Size = new System.Drawing.Size(200, 22);
            this.tb_C_discription1.TabIndex = 36;
            // 
            // tb_C_name1
            // 
            this.tb_C_name1.Location = new System.Drawing.Point(247, 126);
            this.tb_C_name1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_name1.Name = "tb_C_name1";
            this.tb_C_name1.Size = new System.Drawing.Size(200, 22);
            this.tb_C_name1.TabIndex = 35;
            // 
            // tb_C_id1
            // 
            this.tb_C_id1.Location = new System.Drawing.Point(247, 69);
            this.tb_C_id1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_id1.Name = "tb_C_id1";
            this.tb_C_id1.ReadOnly = true;
            this.tb_C_id1.Size = new System.Drawing.Size(200, 22);
            this.tb_C_id1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "DISCRIPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // btnCedit
            // 
            this.btnCedit.BackColor = System.Drawing.Color.White;
            this.btnCedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCedit.ForeColor = System.Drawing.Color.Red;
            this.btnCedit.Location = new System.Drawing.Point(277, 234);
            this.btnCedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCedit.Name = "btnCedit";
            this.btnCedit.Size = new System.Drawing.Size(108, 54);
            this.btnCedit.TabIndex = 37;
            this.btnCedit.Text = "UPDATE";
            this.btnCedit.UseVisualStyleBackColor = false;
            this.btnCedit.Click += new System.EventHandler(this.btnCedit_Click);
            // 
            // EditCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(533, 344);
            this.Controls.Add(this.btnCedit);
            this.Controls.Add(this.tb_C_discription1);
            this.Controls.Add(this.tb_C_name1);
            this.Controls.Add(this.tb_C_id1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCate";
            this.Text = "EditCate";
            this.Load += new System.EventHandler(this.EditCate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCedit;
        public System.Windows.Forms.TextBox tb_C_discription1;
        public System.Windows.Forms.TextBox tb_C_name1;
        public System.Windows.Forms.TextBox tb_C_id1;
    }
}