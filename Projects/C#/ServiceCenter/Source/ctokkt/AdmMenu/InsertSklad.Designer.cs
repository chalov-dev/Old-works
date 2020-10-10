namespace ctokkt.AdmMenu
{
    partial class InsertSklad
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
            this.label3 = new System.Windows.Forms.Label();
            this.Kod = new System.Windows.Forms.TextBox();
            this.nSklad = new System.Windows.Forms.TextBox();
            this.Otvet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ответственный:";
            // 
            // Kod
            // 
            this.Kod.Location = new System.Drawing.Point(125, 17);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(130, 20);
            this.Kod.TabIndex = 1;
            // 
            // nSklad
            // 
            this.nSklad.Location = new System.Drawing.Point(125, 42);
            this.nSklad.Name = "nSklad";
            this.nSklad.Size = new System.Drawing.Size(130, 20);
            this.nSklad.TabIndex = 1;
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(125, 68);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(130, 20);
            this.Otvet.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertSklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.nSklad);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertSklad";
            this.Text = "Добавление склада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.TextBox nSklad;
        private System.Windows.Forms.TextBox Otvet;
        private System.Windows.Forms.Button button1;
    }
}