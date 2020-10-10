namespace ctokkt.AdmMenu
{
    partial class InsertPodp
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
            this.FIO = new System.Windows.Forms.TextBox();
            this.Osnov = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Основание:";
            // 
            // Kod
            // 
            this.Kod.Location = new System.Drawing.Point(104, 20);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(116, 20);
            this.Kod.TabIndex = 1;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(104, 45);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(116, 20);
            this.FIO.TabIndex = 1;
            // 
            // Osnov
            // 
            this.Osnov.Location = new System.Drawing.Point(104, 69);
            this.Osnov.Name = "Osnov";
            this.Osnov.Size = new System.Drawing.Size(116, 20);
            this.Osnov.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertPodp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Osnov);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertPodp";
            this.Text = "Добавление подписанта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox Osnov;
        private System.Windows.Forms.Button button1;
    }
}