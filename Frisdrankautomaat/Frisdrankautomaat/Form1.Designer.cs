namespace Frisdrankenautomaat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInworp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.btnBetalen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingeworpen bedrag (cent):";
            // 
            // txtInworp
            // 
            this.txtInworp.Location = new System.Drawing.Point(155, 19);
            this.txtInworp.Name = "txtInworp";
            this.txtInworp.Size = new System.Drawing.Size(100, 20);
            this.txtInworp.TabIndex = 1;
            this.txtInworp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijs frisdrank (cent):";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(155, 59);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 3;
            this.txtPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBetalen
            // 
            this.btnBetalen.Location = new System.Drawing.Point(50, 99);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(171, 23);
            this.btnBetalen.TabIndex = 4;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            this.btnBetalen.Click += new System.EventHandler(this.btnBetalen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 134);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInworp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Frisdrankautomaat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInworp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Button btnBetalen;
    }
}

