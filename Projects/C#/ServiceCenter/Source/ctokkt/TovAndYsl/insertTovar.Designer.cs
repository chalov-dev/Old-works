namespace ctokkt.TovAndYsl
{
    partial class insertTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertTovar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nTov = new System.Windows.Forms.TextBox();
            this.priceR = new System.Windows.Forms.TextBox();
            this.priceP = new System.Windows.Forms.TextBox();
            this.serN = new System.Windows.Forms.TextBox();
            this.Kod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nTov);
            this.panel1.Controls.Add(this.priceR);
            this.panel1.Controls.Add(this.priceP);
            this.panel1.Controls.Add(this.serN);
            this.panel1.Controls.Add(this.Kod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 212);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nTov
            // 
            this.nTov.Location = new System.Drawing.Point(133, 31);
            this.nTov.Name = "nTov";
            this.nTov.Size = new System.Drawing.Size(122, 20);
            this.nTov.TabIndex = 1;
            // 
            // priceR
            // 
            this.priceR.Location = new System.Drawing.Point(133, 111);
            this.priceR.Name = "priceR";
            this.priceR.Size = new System.Drawing.Size(122, 20);
            this.priceR.TabIndex = 1;
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(133, 84);
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(122, 20);
            this.priceP.TabIndex = 1;
            // 
            // serN
            // 
            this.serN.Location = new System.Drawing.Point(133, 57);
            this.serN.Name = "serN";
            this.serN.Size = new System.Drawing.Size(122, 20);
            this.serN.TabIndex = 1;
            // 
            // Kod
            // 
            this.Kod.Location = new System.Drawing.Point(133, 8);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(122, 20);
            this.Kod.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Цена розница:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цена прихода:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Серийный номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // insertTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 237);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.insertTovar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nTov;
        private System.Windows.Forms.TextBox priceR;
        private System.Windows.Forms.TextBox priceP;
        private System.Windows.Forms.TextBox serN;
        private System.Windows.Forms.TextBox Kod;
    }
}