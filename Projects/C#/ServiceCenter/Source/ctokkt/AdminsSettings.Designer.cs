namespace ctokkt
{
    partial class AdminsSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsSettings));
            this.option = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Sprav = new System.Windows.Forms.Button();
            this.Doc = new System.Windows.Forms.Button();
            this.tovarysl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // option
            // 
            this.option.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.option.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.option.Location = new System.Drawing.Point(12, 198);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(156, 43);
            this.option.TabIndex = 10;
            this.option.Text = "Отчёты";
            this.option.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.exit.Location = new System.Drawing.Point(12, 258);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(156, 43);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Sprav
            // 
            this.Sprav.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sprav.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sprav.Location = new System.Drawing.Point(12, 15);
            this.Sprav.Name = "Sprav";
            this.Sprav.Size = new System.Drawing.Size(156, 43);
            this.Sprav.TabIndex = 6;
            this.Sprav.Text = "Справочники";
            this.Sprav.UseVisualStyleBackColor = true;
            // 
            // Doc
            // 
            this.Doc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Doc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Doc.Location = new System.Drawing.Point(12, 76);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(156, 43);
            this.Doc.TabIndex = 7;
            this.Doc.Text = "Документы";
            this.Doc.UseVisualStyleBackColor = true;
            // 
            // tovarysl
            // 
            this.tovarysl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tovarysl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tovarysl.Location = new System.Drawing.Point(12, 137);
            this.tovarysl.Name = "tovarysl";
            this.tovarysl.Size = new System.Drawing.Size(156, 43);
            this.tovarysl.TabIndex = 8;
            this.tovarysl.Text = "Товары и услуги";
            this.tovarysl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.BackgroundImage = global::ctokkt.Properties.Resources.fon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ctokkt.Properties.Resources.knop_verh__04;
            this.button1.Location = new System.Drawing.Point(494, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 64);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ctokkt.Properties.Resources.dFon1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AdminsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.option);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Sprav);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.tovarysl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminsSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Sprav;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button tovarysl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}