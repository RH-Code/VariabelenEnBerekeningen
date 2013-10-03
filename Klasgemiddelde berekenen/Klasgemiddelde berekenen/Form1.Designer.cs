namespace Gemiddelde_berekenen
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
            this.ResultatengroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leerlingAtextBox = new System.Windows.Forms.TextBox();
            this.leerlingBtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berekenGemiddeldebutton = new System.Windows.Forms.Button();
            this.txtGemiddelde = new System.Windows.Forms.TextBox();
            this.ResultatengroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultatengroupBox
            // 
            this.ResultatengroupBox.Controls.Add(this.leerlingBtextBox);
            this.ResultatengroupBox.Controls.Add(this.leerlingAtextBox);
            this.ResultatengroupBox.Controls.Add(this.label2);
            this.ResultatengroupBox.Controls.Add(this.label1);
            this.ResultatengroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatengroupBox.Location = new System.Drawing.Point(12, 12);
            this.ResultatengroupBox.Name = "ResultatengroupBox";
            this.ResultatengroupBox.Size = new System.Drawing.Size(199, 102);
            this.ResultatengroupBox.TabIndex = 1;
            this.ResultatengroupBox.TabStop = false;
            this.ResultatengroupBox.Text = "Resultaten C# examen (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leerling A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leerling B:";
            // 
            // leerlingAtextBox
            // 
            this.leerlingAtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerlingAtextBox.Location = new System.Drawing.Point(79, 25);
            this.leerlingAtextBox.Name = "leerlingAtextBox";
            this.leerlingAtextBox.Size = new System.Drawing.Size(100, 20);
            this.leerlingAtextBox.TabIndex = 2;
            this.leerlingAtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // leerlingBtextBox
            // 
            this.leerlingBtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerlingBtextBox.Location = new System.Drawing.Point(79, 66);
            this.leerlingBtextBox.Name = "leerlingBtextBox";
            this.leerlingBtextBox.Size = new System.Drawing.Size(100, 20);
            this.leerlingBtextBox.TabIndex = 3;
            this.leerlingBtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGemiddelde);
            this.groupBox1.Controls.Add(this.berekenGemiddeldebutton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasgemiddelde";
            // 
            // berekenGemiddeldebutton
            // 
            this.berekenGemiddeldebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.berekenGemiddeldebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berekenGemiddeldebutton.Location = new System.Drawing.Point(189, 19);
            this.berekenGemiddeldebutton.Name = "berekenGemiddeldebutton";
            this.berekenGemiddeldebutton.Size = new System.Drawing.Size(141, 23);
            this.berekenGemiddeldebutton.TabIndex = 0;
            this.berekenGemiddeldebutton.Text = "Bereken gemiddelde";
            this.berekenGemiddeldebutton.UseVisualStyleBackColor = false;
            this.berekenGemiddeldebutton.Click += new System.EventHandler(this.berekenGemiddeldebutton_Click);
            // 
            // txtGemiddelde
            // 
            this.txtGemiddelde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGemiddelde.Location = new System.Drawing.Point(6, 59);
            this.txtGemiddelde.Name = "txtGemiddelde";
            this.txtGemiddelde.Size = new System.Drawing.Size(324, 20);
            this.txtGemiddelde.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultatengroupBox);
            this.Name = "Form1";
            this.Text = "Klasgemiddelde berekenen";
            this.ResultatengroupBox.ResumeLayout(false);
            this.ResultatengroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultatengroupBox;
        private System.Windows.Forms.TextBox leerlingBtextBox;
        private System.Windows.Forms.TextBox leerlingAtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGemiddelde;
        private System.Windows.Forms.Button berekenGemiddeldebutton;
    }
}

