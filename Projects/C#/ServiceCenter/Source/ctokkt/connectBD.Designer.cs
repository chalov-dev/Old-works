namespace ctokkt
{
    partial class connectBD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectBD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Servertxt = new System.Windows.Forms.TextBox();
            this.BDtxt = new System.Windows.Forms.TextBox();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.BtnCon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя БД";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // Servertxt
            // 
            this.Servertxt.BackColor = System.Drawing.SystemColors.Window;
            this.Servertxt.Location = new System.Drawing.Point(128, 33);
            this.Servertxt.Name = "Servertxt";
            this.Servertxt.Size = new System.Drawing.Size(100, 20);
            this.Servertxt.TabIndex = 4;
            this.Servertxt.Text = "(local)";
            // 
            // BDtxt
            // 
            this.BDtxt.Location = new System.Drawing.Point(128, 57);
            this.BDtxt.Name = "BDtxt";
            this.BDtxt.Size = new System.Drawing.Size(100, 20);
            this.BDtxt.TabIndex = 5;
            this.BDtxt.Text = "CTOBD";
            this.BDtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(128, 83);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(100, 20);
            this.logintxt.TabIndex = 6;
            this.logintxt.Text = "User";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(128, 109);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 7;
            this.passtxt.Text = "fgYe23qwe1";
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BtnCon
            // 
            this.BtnCon.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCon.Location = new System.Drawing.Point(8, 148);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(215, 37);
            this.BtnCon.TabIndex = 8;
            this.BtnCon.Text = "П о д к л ю ч и т ь с я";
            this.BtnCon.UseVisualStyleBackColor = false;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 198);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ctokkt.Properties.Resources.podkl;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // connectBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 198);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.BDtxt);
            this.Controls.Add(this.Servertxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "connectBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Servertxt;
        private System.Windows.Forms.TextBox BDtxt;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

