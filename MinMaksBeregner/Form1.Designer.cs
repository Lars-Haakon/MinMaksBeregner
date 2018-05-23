namespace MinMaksBeregner
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAntallSkudd = new System.Windows.Forms.TextBox();
            this.txtAntallTreff = new System.Windows.Forms.TextBox();
            this.txtAntallInnertreff = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMaks = new System.Windows.Forms.Label();
            this.radInnledende = new System.Windows.Forms.RadioButton();
            this.radFinale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Beregn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maksimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Antall skudd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Antall treff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Antall innertreff";
            // 
            // txtAntallSkudd
            // 
            this.txtAntallSkudd.Location = new System.Drawing.Point(36, 90);
            this.txtAntallSkudd.Name = "txtAntallSkudd";
            this.txtAntallSkudd.Size = new System.Drawing.Size(40, 20);
            this.txtAntallSkudd.TabIndex = 0;
            this.txtAntallSkudd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntallTreff
            // 
            this.txtAntallTreff.Location = new System.Drawing.Point(122, 90);
            this.txtAntallTreff.Name = "txtAntallTreff";
            this.txtAntallTreff.Size = new System.Drawing.Size(40, 20);
            this.txtAntallTreff.TabIndex = 1;
            this.txtAntallTreff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntallInnertreff
            // 
            this.txtAntallInnertreff.Location = new System.Drawing.Point(206, 90);
            this.txtAntallInnertreff.Name = "txtAntallInnertreff";
            this.txtAntallInnertreff.Size = new System.Drawing.Size(40, 20);
            this.txtAntallInnertreff.TabIndex = 2;
            this.txtAntallInnertreff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMin.Location = new System.Drawing.Point(63, 217);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(60, 20);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "-/-";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMaks
            // 
            this.lblMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaks.Location = new System.Drawing.Point(150, 217);
            this.lblMaks.Name = "lblMaks";
            this.lblMaks.Size = new System.Drawing.Size(60, 20);
            this.lblMaks.TabIndex = 10;
            this.lblMaks.Text = "-/-";
            this.lblMaks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radInnledende
            // 
            this.radInnledende.AutoSize = true;
            this.radInnledende.Checked = true;
            this.radInnledende.Location = new System.Drawing.Point(28, 29);
            this.radInnledende.Name = "radInnledende";
            this.radInnledende.Size = new System.Drawing.Size(125, 17);
            this.radInnledende.TabIndex = 4;
            this.radInnledende.TabStop = true;
            this.radInnledende.Text = "Innledende (6 skudd)";
            this.radInnledende.UseVisualStyleBackColor = true;
            // 
            // radFinale
            // 
            this.radFinale.AutoSize = true;
            this.radFinale.Location = new System.Drawing.Point(159, 29);
            this.radFinale.Name = "radFinale";
            this.radFinale.Size = new System.Drawing.Size(106, 17);
            this.radFinale.TabIndex = 5;
            this.radFinale.Text = "Finale (12 skudd)";
            this.radFinale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.radFinale);
            this.Controls.Add(this.radInnledende);
            this.Controls.Add(this.lblMaks);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtAntallInnertreff);
            this.Controls.Add(this.txtAntallTreff);
            this.Controls.Add(this.txtAntallSkudd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAntallSkudd;
        private System.Windows.Forms.TextBox txtAntallTreff;
        private System.Windows.Forms.TextBox txtAntallInnertreff;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMaks;
        private System.Windows.Forms.RadioButton radInnledende;
        private System.Windows.Forms.RadioButton radFinale;
    }
}

