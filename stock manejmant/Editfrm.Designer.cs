
namespace stock_manejmant
{
    partial class Editfrm
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
            this.txtusername1 = new System.Windows.Forms.TextBox();
            this.comboBox_role1 = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.tb_Password1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername1
            // 
            this.txtusername1.Location = new System.Drawing.Point(215, 29);
            this.txtusername1.Name = "txtusername1";
            this.txtusername1.ReadOnly = true;
            this.txtusername1.Size = new System.Drawing.Size(200, 22);
            this.txtusername1.TabIndex = 59;
            // 
            // comboBox_role1
            // 
            this.comboBox_role1.FormattingEnabled = true;
            this.comboBox_role1.Items.AddRange(new object[] {
            "ADMIN",
            "STORE_KEEPER",
            "KITCHEN_STAFF"});
            this.comboBox_role1.Location = new System.Drawing.Point(215, 143);
            this.comboBox_role1.Name = "comboBox_role1";
            this.comboBox_role1.Size = new System.Drawing.Size(200, 24);
            this.comboBox_role1.TabIndex = 58;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(48, 139);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(69, 25);
            this.lbl_role.TabIndex = 57;
            this.lbl_role.Text = "ROLE";
            // 
            // tb_Password1
            // 
            this.tb_Password1.Location = new System.Drawing.Point(215, 83);
            this.tb_Password1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password1.Name = "tb_Password1";
            this.tb_Password1.Size = new System.Drawing.Size(200, 22);
            this.tb_Password1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = " USER NAME";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Red;
            this.btnupdate.Location = new System.Drawing.Point(307, 196);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 54);
            this.btnupdate.TabIndex = 60;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Editfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 304);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtusername1);
            this.Controls.Add(this.comboBox_role1);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.tb_Password1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Editfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editfrm";
            this.Load += new System.EventHandler(this.Editfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.TextBox txtusername1;
        public System.Windows.Forms.ComboBox comboBox_role1;
        public System.Windows.Forms.TextBox tb_Password1;
    }
}