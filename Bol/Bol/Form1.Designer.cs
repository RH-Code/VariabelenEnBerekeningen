namespace Bol
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStraal = new System.Windows.Forms.TextBox();
            this.btnOmtrek = new System.Windows.Forms.Button();
            this.btnOppervlakte = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOppervlakteBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Straal van cirkel:";
            // 
            // txtStraal
            // 
            this.txtStraal.Location = new System.Drawing.Point(114, 23);
            this.txtStraal.Name = "txtStraal";
            this.txtStraal.Size = new System.Drawing.Size(100, 20);
            this.txtStraal.TabIndex = 1;
            this.txtStraal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOmtrek
            // 
            this.btnOmtrek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOmtrek.Location = new System.Drawing.Point(25, 75);
            this.btnOmtrek.Name = "btnOmtrek";
            this.btnOmtrek.Size = new System.Drawing.Size(111, 35);
            this.btnOmtrek.TabIndex = 2;
            this.btnOmtrek.Text = "Bereken omtrek cirkel";
            this.btnOmtrek.UseVisualStyleBackColor = false;
            this.btnOmtrek.Click += new System.EventHandler(this.btnOmtrek_Click);
            // 
            // btnOppervlakte
            // 
            this.btnOppervlakte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOppervlakte.Location = new System.Drawing.Point(142, 75);
            this.btnOppervlakte.Name = "btnOppervlakte";
            this.btnOppervlakte.Size = new System.Drawing.Size(111, 35);
            this.btnOppervlakte.TabIndex = 3;
            this.btnOppervlakte.Text = "Bereken oppervlakte cirkel";
            this.btnOppervlakte.UseVisualStyleBackColor = false;
            this.btnOppervlakte.Click += new System.EventHandler(this.btnOppervlakte_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolume.Location = new System.Drawing.Point(259, 75);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(111, 35);
            this.btnVolume.TabIndex = 4;
            this.btnVolume.Text = "Bereken volume bol";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(25, 189);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(345, 20);
            this.txtResultaat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultaat:";
            // 
            // btnOppervlakteBol
            // 
            this.btnOppervlakteBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOppervlakteBol.Location = new System.Drawing.Point(142, 116);
            this.btnOppervlakteBol.Name = "btnOppervlakteBol";
            this.btnOppervlakteBol.Size = new System.Drawing.Size(111, 35);
            this.btnOppervlakteBol.TabIndex = 7;
            this.btnOppervlakteBol.Text = "Bereken oppervlakte bol";
            this.btnOppervlakteBol.UseVisualStyleBackColor = false;
            this.btnOppervlakteBol.Click += new System.EventHandler(this.btnOppervlakteBol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 233);
            this.Controls.Add(this.btnOppervlakteBol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnOppervlakte);
            this.Controls.Add(this.btnOmtrek);
            this.Controls.Add(this.txtStraal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bereken omtrek, oppervlakte en volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStraal;
        private System.Windows.Forms.Button btnOmtrek;
        private System.Windows.Forms.Button btnOppervlakte;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOppervlakteBol;
    }
}

