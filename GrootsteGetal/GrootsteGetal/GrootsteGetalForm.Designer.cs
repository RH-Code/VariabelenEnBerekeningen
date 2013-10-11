namespace GrootsteGetal
{
    partial class GrootsteGetalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.btnGrootsteGetal = new System.Windows.Forms.Button();
            this.lblGrootsteGetal = new System.Windows.Forms.Label();
            this.btnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal 2:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(40, 42);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 0;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(189, 42);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 1;
            // 
            // btnGrootsteGetal
            // 
            this.btnGrootsteGetal.Location = new System.Drawing.Point(40, 82);
            this.btnGrootsteGetal.Name = "btnGrootsteGetal";
            this.btnGrootsteGetal.Size = new System.Drawing.Size(100, 33);
            this.btnGrootsteGetal.TabIndex = 2;
            this.btnGrootsteGetal.Text = "Grootste getal";
            this.btnGrootsteGetal.UseVisualStyleBackColor = true;
            this.btnGrootsteGetal.Click += new System.EventHandler(this.btnGrootsteGetal_Click);
            // 
            // lblGrootsteGetal
            // 
            this.lblGrootsteGetal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrootsteGetal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrootsteGetal.Location = new System.Drawing.Point(40, 134);
            this.lblGrootsteGetal.Name = "lblGrootsteGetal";
            this.lblGrootsteGetal.Size = new System.Drawing.Size(249, 22);
            this.lblGrootsteGetal.TabIndex = 3;
            this.lblGrootsteGetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(189, 82);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(100, 33);
            this.btnWissen.TabIndex = 4;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // GrootsteGetalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 176);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.lblGrootsteGetal);
            this.Controls.Add(this.btnGrootsteGetal);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GrootsteGetalForm";
            this.Text = "Grootste getal van 2 getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Button btnGrootsteGetal;
        private System.Windows.Forms.Label lblGrootsteGetal;
        private System.Windows.Forms.Button btnWissen;
    }
}

