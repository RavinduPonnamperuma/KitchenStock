
namespace stock_manejmant
{
    partial class CateDel
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
            this.btndel = new System.Windows.Forms.Button();
            this.lblrole1 = new System.Windows.Forms.Label();
            this.lblpass1 = new System.Windows.Forms.Label();
            this.lblname1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Red;
            this.btndel.Location = new System.Drawing.Point(144, 201);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(108, 54);
            this.btndel.TabIndex = 53;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lblrole1
            // 
            this.lblrole1.AutoSize = true;
            this.lblrole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole1.ForeColor = System.Drawing.Color.White;
            this.lblrole1.Location = new System.Drawing.Point(122, 140);
            this.lblrole1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrole1.Name = "lblrole1";
            this.lblrole1.Size = new System.Drawing.Size(144, 25);
            this.lblrole1.TabIndex = 52;
            this.lblrole1.Text = " USER NAME";
            // 
            // lblpass1
            // 
            this.lblpass1.AutoSize = true;
            this.lblpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass1.ForeColor = System.Drawing.Color.White;
            this.lblpass1.Location = new System.Drawing.Point(122, 90);
            this.lblpass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass1.Name = "lblpass1";
            this.lblpass1.Size = new System.Drawing.Size(144, 25);
            this.lblpass1.TabIndex = 51;
            this.lblpass1.Text = " USER NAME";
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.ForeColor = System.Drawing.Color.White;
            this.lblname1.Location = new System.Drawing.Point(122, 43);
            this.lblname1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(144, 25);
            this.lblname1.TabIndex = 50;
            this.lblname1.Text = " USER NAME";
            // 
            // CateDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(381, 334);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lblrole1);
            this.Controls.Add(this.lblpass1);
            this.Controls.Add(this.lblname1);
            this.Name = "CateDel";
            this.Text = "CateDel";
            this.Load += new System.EventHandler(this.CateDel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndel;
        public System.Windows.Forms.Label lblrole1;
        public System.Windows.Forms.Label lblpass1;
        public System.Windows.Forms.Label lblname1;
    }
}