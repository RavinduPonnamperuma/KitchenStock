
namespace stock_manejmant
{
    partial class Delfrm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(122, 35);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(144, 25);
            this.lblname.TabIndex = 42;
            this.lblname.Text = " USER NAME";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.White;
            this.lblpass.Location = new System.Drawing.Point(122, 82);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(144, 25);
            this.lblpass.TabIndex = 43;
            this.lblpass.Text = " USER NAME";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.ForeColor = System.Drawing.Color.White;
            this.lblrole.Location = new System.Drawing.Point(122, 132);
            this.lblrole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(144, 25);
            this.lblrole.TabIndex = 44;
            this.lblrole.Text = " USER NAME";
            this.lblrole.Click += new System.EventHandler(this.lblrole_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Red;
            this.btndel.Location = new System.Drawing.Point(144, 193);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(108, 54);
            this.btndel.TabIndex = 49;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Delfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.MaximizeBox = false;
            this.Name = "Delfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delfrm";
            this.Load += new System.EventHandler(this.Delfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndel;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Label lblpass;
        public System.Windows.Forms.Label lblrole;
    }
}