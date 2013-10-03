namespace WeerstandBerekenen
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
            this.txtWeerstand2 = new System.Windows.Forms.TextBox();
            this.txtWeerstand1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblParallel = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeerstand2);
            this.groupBox1.Controls.Add(this.txtWeerstand1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weerstanden (Ohm)";
            // 
            // txtWeerstand2
            // 
            this.txtWeerstand2.Location = new System.Drawing.Point(83, 54);
            this.txtWeerstand2.Name = "txtWeerstand2";
            this.txtWeerstand2.Size = new System.Drawing.Size(100, 20);
            this.txtWeerstand2.TabIndex = 1;
            this.txtWeerstand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeerstand1
            // 
            this.txtWeerstand1.Location = new System.Drawing.Point(83, 23);
            this.txtWeerstand1.Name = "txtWeerstand1";
            this.txtWeerstand1.Size = new System.Drawing.Size(100, 20);
            this.txtWeerstand1.TabIndex = 0;
            this.txtWeerstand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weerstand 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weerstand 1:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(12, 118);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(200, 27);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblParallel);
            this.groupBox2.Controls.Add(this.lblSerie);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serie- en parallelweerstand (Ohm)";
            // 
            // lblParallel
            // 
            this.lblParallel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParallel.ForeColor = System.Drawing.Color.Red;
            this.lblParallel.Location = new System.Drawing.Point(83, 53);
            this.lblParallel.Name = "lblParallel";
            this.lblParallel.Size = new System.Drawing.Size(100, 20);
            this.lblParallel.TabIndex = 5;
            this.lblParallel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSerie
            // 
            this.lblSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSerie.ForeColor = System.Drawing.Color.Red;
            this.lblSerie.Location = new System.Drawing.Point(83, 22);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(100, 20);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parallel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Serie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weerstand berekenen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWeerstand2;
        private System.Windows.Forms.TextBox txtWeerstand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblParallel;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

