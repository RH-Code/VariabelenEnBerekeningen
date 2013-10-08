namespace Eindsaldo_rekening
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
            this.groupBoxBeginsaldo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeginsaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAantalJaren = new System.Windows.Forms.TextBox();
            this.txtRente = new System.Windows.Forms.TextBox();
            this.groupBoxEindsaldo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEindsaldo = new System.Windows.Forms.Label();
            this.groupBoxBeginsaldo.SuspendLayout();
            this.groupBoxEindsaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBeginsaldo
            // 
            this.groupBoxBeginsaldo.Controls.Add(this.txtRente);
            this.groupBoxBeginsaldo.Controls.Add(this.txtAantalJaren);
            this.groupBoxBeginsaldo.Controls.Add(this.label3);
            this.groupBoxBeginsaldo.Controls.Add(this.label2);
            this.groupBoxBeginsaldo.Controls.Add(this.txtBeginsaldo);
            this.groupBoxBeginsaldo.Controls.Add(this.label1);
            this.groupBoxBeginsaldo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxBeginsaldo.Location = new System.Drawing.Point(19, 19);
            this.groupBoxBeginsaldo.Name = "groupBoxBeginsaldo";
            this.groupBoxBeginsaldo.Size = new System.Drawing.Size(243, 138);
            this.groupBoxBeginsaldo.TabIndex = 0;
            this.groupBoxBeginsaldo.TabStop = false;
            this.groupBoxBeginsaldo.Text = "Beginsaldo rekening (€)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beginsaldo:";
            // 
            // txtBeginsaldo
            // 
            this.txtBeginsaldo.Location = new System.Drawing.Point(120, 26);
            this.txtBeginsaldo.Name = "txtBeginsaldo";
            this.txtBeginsaldo.Size = new System.Drawing.Size(100, 20);
            this.txtBeginsaldo.TabIndex = 1;
            this.txtBeginsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aantal jaren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rente/jaar:";
            // 
            // txtAantalJaren
            // 
            this.txtAantalJaren.Location = new System.Drawing.Point(120, 60);
            this.txtAantalJaren.Name = "txtAantalJaren";
            this.txtAantalJaren.Size = new System.Drawing.Size(100, 20);
            this.txtAantalJaren.TabIndex = 4;
            this.txtAantalJaren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRente
            // 
            this.txtRente.Location = new System.Drawing.Point(120, 95);
            this.txtRente.Name = "txtRente";
            this.txtRente.Size = new System.Drawing.Size(100, 20);
            this.txtRente.TabIndex = 5;
            this.txtRente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxEindsaldo
            // 
            this.groupBoxEindsaldo.Controls.Add(this.lblEindsaldo);
            this.groupBoxEindsaldo.Controls.Add(this.label4);
            this.groupBoxEindsaldo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxEindsaldo.Location = new System.Drawing.Point(324, 19);
            this.groupBoxEindsaldo.Name = "groupBoxEindsaldo";
            this.groupBoxEindsaldo.Size = new System.Drawing.Size(218, 76);
            this.groupBoxEindsaldo.TabIndex = 1;
            this.groupBoxEindsaldo.TabStop = false;
            this.groupBoxEindsaldo.Text = "Eindsaldo (€)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eindsaldo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 128);
            this.button1.TabIndex = 2;
            this.button1.Text = "B\r\ne\r\nr\r\ne\r\nk\r\ne\r\nn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEindsaldo
            // 
            this.lblEindsaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEindsaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEindsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEindsaldo.ForeColor = System.Drawing.Color.Red;
            this.lblEindsaldo.Location = new System.Drawing.Point(103, 26);
            this.lblEindsaldo.Name = "lblEindsaldo";
            this.lblEindsaldo.Size = new System.Drawing.Size(100, 20);
            this.lblEindsaldo.TabIndex = 3;
            this.lblEindsaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEindsaldo);
            this.Controls.Add(this.groupBoxBeginsaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eindsaldo rekening";
            this.groupBoxBeginsaldo.ResumeLayout(false);
            this.groupBoxBeginsaldo.PerformLayout();
            this.groupBoxEindsaldo.ResumeLayout(false);
            this.groupBoxEindsaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBeginsaldo;
        private System.Windows.Forms.TextBox txtRente;
        private System.Windows.Forms.TextBox txtAantalJaren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeginsaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEindsaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEindsaldo;
    }
}

