namespace ctokkt
{
    partial class InsertNeispr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNeispr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kod = new System.Windows.Forms.TextBox();
            this.stNei = new System.Windows.Forms.TextBox();
            this.bNeis = new System.Windows.Forms.Button();
            this.bizm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стандартная неисправность:";
            // 
            // Kod
            // 
            this.Kod.Location = new System.Drawing.Point(206, 29);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(121, 20);
            this.Kod.TabIndex = 1;
            // 
            // stNei
            // 
            this.stNei.Location = new System.Drawing.Point(206, 61);
            this.stNei.Name = "stNei";
            this.stNei.Size = new System.Drawing.Size(121, 20);
            this.stNei.TabIndex = 1;
            // 
            // bNeis
            // 
            this.bNeis.Location = new System.Drawing.Point(206, 99);
            this.bNeis.Name = "bNeis";
            this.bNeis.Size = new System.Drawing.Size(88, 29);
            this.bNeis.TabIndex = 2;
            this.bNeis.Text = "Добавить";
            this.bNeis.UseVisualStyleBackColor = true;
            this.bNeis.Click += new System.EventHandler(this.bNeis_Click);
            // 
            // bizm
            // 
            this.bizm.Location = new System.Drawing.Point(78, 99);
            this.bizm.Name = "bizm";
            this.bizm.Size = new System.Drawing.Size(88, 29);
            this.bizm.TabIndex = 2;
            this.bizm.Text = "Изменить";
            this.bizm.UseVisualStyleBackColor = true;
            this.bizm.Click += new System.EventHandler(this.bizm_Click);
            // 
            // InsertNeispr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 156);
            this.Controls.Add(this.bizm);
            this.Controls.Add(this.bNeis);
            this.Controls.Add(this.stNei);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertNeispr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление неисправности";
            this.Load += new System.EventHandler(this.InsertNeispr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.TextBox stNei;
        private System.Windows.Forms.Button bNeis;
        private System.Windows.Forms.Button bizm;
    }
}