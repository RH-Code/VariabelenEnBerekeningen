namespace VolumeBerekenen
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
            this.btnBerekenVolume = new System.Windows.Forms.Button();
            this.textBoxLengte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBreedte = new System.Windows.Forms.TextBox();
            this.textBoxHoogte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerekenVolume
            // 
            this.btnBerekenVolume.Location = new System.Drawing.Point(225, 27);
            this.btnBerekenVolume.Name = "btnBerekenVolume";
            this.btnBerekenVolume.Size = new System.Drawing.Size(118, 31);
            this.btnBerekenVolume.TabIndex = 0;
            this.btnBerekenVolume.Text = "Bereken Volume";
            this.btnBerekenVolume.UseVisualStyleBackColor = true;
            this.btnBerekenVolume.Click += new System.EventHandler(this.btnBerekenVolume_Click);
            // 
            // textBoxLengte
            // 
            this.textBoxLengte.Location = new System.Drawing.Point(104, 27);
            this.textBoxLengte.Name = "textBoxLengte";
            this.textBoxLengte.Size = new System.Drawing.Size(94, 20);
            this.textBoxLengte.TabIndex = 1;
            this.textBoxLengte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lengte (in cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breedte (in cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hoogte (in cm):";
            // 
            // textBoxBreedte
            // 
            this.textBoxBreedte.Location = new System.Drawing.Point(104, 69);
            this.textBoxBreedte.Name = "textBoxBreedte";
            this.textBoxBreedte.Size = new System.Drawing.Size(94, 20);
            this.textBoxBreedte.TabIndex = 5;
            this.textBoxBreedte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHoogte
            // 
            this.textBoxHoogte.Location = new System.Drawing.Point(104, 112);
            this.textBoxHoogte.Name = "textBoxHoogte";
            this.textBoxHoogte.Size = new System.Drawing.Size(94, 20);
            this.textBoxHoogte.TabIndex = 6;
            this.textBoxHoogte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 157);
            this.Controls.Add(this.textBoxHoogte);
            this.Controls.Add(this.textBoxBreedte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLengte);
            this.Controls.Add(this.btnBerekenVolume);
            this.Name = "Form1";
            this.Text = "Volume berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerekenVolume;
        private System.Windows.Forms.TextBox textBoxLengte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBreedte;
        private System.Windows.Forms.TextBox textBoxHoogte;
    }
}

