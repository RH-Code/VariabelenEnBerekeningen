namespace GeefDeTijdWeer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTijdInSec = new System.Windows.Forms.TextBox();
            this.btnZetOm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTijdInSec);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoer tijd in sec.";
            // 
            // txtTijdInSec
            // 
            this.txtTijdInSec.Location = new System.Drawing.Point(6, 19);
            this.txtTijdInSec.Name = "txtTijdInSec";
            this.txtTijdInSec.Size = new System.Drawing.Size(100, 20);
            this.txtTijdInSec.TabIndex = 0;
            this.txtTijdInSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZetOm
            // 
            this.btnZetOm.Location = new System.Drawing.Point(161, 12);
            this.btnZetOm.Name = "btnZetOm";
            this.btnZetOm.Size = new System.Drawing.Size(111, 51);
            this.btnZetOm.TabIndex = 2;
            this.btnZetOm.Text = "Tijd omzetten";
            this.btnZetOm.UseVisualStyleBackColor = true;
            this.btnZetOm.Click += new System.EventHandler(this.btnZetOm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 79);
            this.Controls.Add(this.btnZetOm);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Geef tijd weer in hh:mm:ss";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTijdInSec;
        private System.Windows.Forms.Button btnZetOm;
    }
}

