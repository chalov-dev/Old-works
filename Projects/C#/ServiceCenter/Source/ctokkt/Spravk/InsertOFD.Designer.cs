namespace ctokkt
{
    partial class InsertOFD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertOFD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kod = new System.Windows.Forms.TextBox();
            this.nOFD = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ИНН:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Хост:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Порт:";
            // 
            // Kod
            // 
            this.Kod.Location = new System.Drawing.Point(153, 25);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(100, 20);
            this.Kod.TabIndex = 1;
            // 
            // nOFD
            // 
            this.nOFD.Location = new System.Drawing.Point(153, 50);
            this.nOFD.Name = "nOFD";
            this.nOFD.Size = new System.Drawing.Size(100, 20);
            this.nOFD.TabIndex = 1;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(153, 73);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(100, 20);
            this.INN.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(153, 96);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(100, 20);
            this.Host.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(153, 121);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertOFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.nOFD);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertOFD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ОФД";
            this.Load += new System.EventHandler(this.InsertOFD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.TextBox nOFD;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button button1;
    }
}