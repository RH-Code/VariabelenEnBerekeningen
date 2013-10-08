namespace Omzetten_naar_Binair
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
            this.groupBoxGeheelGetal = new System.Windows.Forms.GroupBox();
            this.txtGeheelGetal = new System.Windows.Forms.TextBox();
            this.groupBoxBinair = new System.Windows.Forms.GroupBox();
            this.btnOmzetten = new System.Windows.Forms.Button();
            this.lblBinair = new System.Windows.Forms.Label();
            this.groupBoxGeheelGetal.SuspendLayout();
            this.groupBoxBinair.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGeheelGetal
            // 
            this.groupBoxGeheelGetal.Controls.Add(this.txtGeheelGetal);
            this.groupBoxGeheelGetal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxGeheelGetal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGeheelGetal.Name = "groupBoxGeheelGetal";
            this.groupBoxGeheelGetal.Size = new System.Drawing.Size(191, 74);
            this.groupBoxGeheelGetal.TabIndex = 0;
            this.groupBoxGeheelGetal.TabStop = false;
            this.groupBoxGeheelGetal.Text = "Invoer geheel getal";
            // 
            // txtGeheelGetal
            // 
            this.txtGeheelGetal.Location = new System.Drawing.Point(16, 28);
            this.txtGeheelGetal.Name = "txtGeheelGetal";
            this.txtGeheelGetal.Size = new System.Drawing.Size(156, 20);
            this.txtGeheelGetal.TabIndex = 0;
            this.txtGeheelGetal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxBinair
            // 
            this.groupBoxBinair.Controls.Add(this.lblBinair);
            this.groupBoxBinair.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxBinair.Location = new System.Drawing.Point(12, 149);
            this.groupBoxBinair.Name = "groupBoxBinair";
            this.groupBoxBinair.Size = new System.Drawing.Size(191, 74);
            this.groupBoxBinair.TabIndex = 1;
            this.groupBoxBinair.TabStop = false;
            this.groupBoxBinair.Text = "Uitvoer binair getal";
            // 
            // btnOmzetten
            // 
            this.btnOmzetten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmzetten.Location = new System.Drawing.Point(12, 99);
            this.btnOmzetten.Name = "btnOmzetten";
            this.btnOmzetten.Size = new System.Drawing.Size(191, 36);
            this.btnOmzetten.TabIndex = 2;
            this.btnOmzetten.Text = "Omzetten";
            this.btnOmzetten.UseVisualStyleBackColor = true;
            this.btnOmzetten.Click += new System.EventHandler(this.btnOmzetten_Click);
            // 
            // lblBinair
            // 
            this.lblBinair.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBinair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinair.Location = new System.Drawing.Point(13, 27);
            this.lblBinair.Name = "lblBinair";
            this.lblBinair.Size = new System.Drawing.Size(156, 20);
            this.lblBinair.TabIndex = 1;
            this.lblBinair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 239);
            this.Controls.Add(this.btnOmzetten);
            this.Controls.Add(this.groupBoxBinair);
            this.Controls.Add(this.groupBoxGeheelGetal);
            this.Name = "Form1";
            this.Text = "Omzetten naar binair";
            this.groupBoxGeheelGetal.ResumeLayout(false);
            this.groupBoxGeheelGetal.PerformLayout();
            this.groupBoxBinair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeheelGetal;
        private System.Windows.Forms.TextBox txtGeheelGetal;
        private System.Windows.Forms.GroupBox groupBoxBinair;
        private System.Windows.Forms.Label lblBinair;
        private System.Windows.Forms.Button btnOmzetten;
    }
}

