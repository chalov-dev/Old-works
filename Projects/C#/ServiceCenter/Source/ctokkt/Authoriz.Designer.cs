namespace ctokkt
{
    partial class Authoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authoriz));
            this.autoBD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoBD
            // 
            this.autoBD.BackColor = System.Drawing.Color.PaleGreen;
            this.autoBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoBD.Location = new System.Drawing.Point(17, 126);
            this.autoBD.Name = "autoBD";
            this.autoBD.Size = new System.Drawing.Size(288, 30);
            this.autoBD.TabIndex = 0;
            this.autoBD.Text = "А в т о р и з а ц и я";
            this.autoBD.UseVisualStyleBackColor = false;
            this.autoBD.Click += new System.EventHandler(this.autoBD_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.passw);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.autoBD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 173);
            this.panel1.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(126, 38);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(168, 20);
            this.Login.TabIndex = 2;
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(126, 87);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(168, 20);
            this.passw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ctokkt.Properties.Resources.iconAvt;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Authoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 190);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authoriz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button autoBD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Login;
    }
}