namespace ctokkt
{
    partial class InsertFN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertFN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nFN = new System.Windows.Forms.TextBox();
            this.dateActiv = new System.Windows.Forms.DateTimePicker();
            this.dateClose = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата активации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата закрытия архива";
            // 
            // nFN
            // 
            this.nFN.Location = new System.Drawing.Point(175, 17);
            this.nFN.Name = "nFN";
            this.nFN.Size = new System.Drawing.Size(100, 20);
            this.nFN.TabIndex = 3;
            // 
            // dateActiv
            // 
            this.dateActiv.Location = new System.Drawing.Point(175, 50);
            this.dateActiv.Name = "dateActiv";
            this.dateActiv.Size = new System.Drawing.Size(144, 20);
            this.dateActiv.TabIndex = 4;
            // 
            // dateClose
            // 
            this.dateClose.Location = new System.Drawing.Point(175, 81);
            this.dateClose.Name = "dateClose";
            this.dateClose.Size = new System.Drawing.Size(144, 20);
            this.dateClose.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateClose);
            this.Controls.Add(this.dateActiv);
            this.Controls.Add(this.nFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertFN";
            this.Text = "Добавление ФН";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nFN;
        private System.Windows.Forms.DateTimePicker dateActiv;
        private System.Windows.Forms.DateTimePicker dateClose;
        private System.Windows.Forms.Button button1;
    }
}