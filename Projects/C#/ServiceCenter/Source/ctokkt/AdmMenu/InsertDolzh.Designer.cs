namespace ctokkt.AdmMenu
{
    partial class InsertDolzh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDolzh));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nDolzh = new System.Windows.Forms.TextBox();
            this.Dolzh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Должность:";
            // 
            // nDolzh
            // 
            this.nDolzh.Location = new System.Drawing.Point(105, 25);
            this.nDolzh.Name = "nDolzh";
            this.nDolzh.Size = new System.Drawing.Size(140, 20);
            this.nDolzh.TabIndex = 1;
            // 
            // Dolzh
            // 
            this.Dolzh.Location = new System.Drawing.Point(105, 50);
            this.Dolzh.Name = "Dolzh";
            this.Dolzh.Size = new System.Drawing.Size(140, 20);
            this.Dolzh.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertDolzh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dolzh);
            this.Controls.Add(this.nDolzh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertDolzh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление должности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nDolzh;
        private System.Windows.Forms.TextBox Dolzh;
        private System.Windows.Forms.Button button1;
    }
}