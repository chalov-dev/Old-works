namespace ctokkt
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.Sprav = new System.Windows.Forms.Button();
            this.Doc = new System.Windows.Forms.Button();
            this.tovarysl = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sprav
            // 
            this.Sprav.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sprav.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sprav.Location = new System.Drawing.Point(12, 12);
            this.Sprav.Name = "Sprav";
            this.Sprav.Size = new System.Drawing.Size(156, 43);
            this.Sprav.TabIndex = 0;
            this.Sprav.Text = "Справочники";
            this.Sprav.UseVisualStyleBackColor = true;
            this.Sprav.Click += new System.EventHandler(this.Sprav_Click);
            // 
            // Doc
            // 
            this.Doc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Doc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Doc.Location = new System.Drawing.Point(12, 73);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(156, 43);
            this.Doc.TabIndex = 1;
            this.Doc.Text = "Документы";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // tovarysl
            // 
            this.tovarysl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tovarysl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tovarysl.Location = new System.Drawing.Point(12, 134);
            this.tovarysl.Name = "tovarysl";
            this.tovarysl.Size = new System.Drawing.Size(156, 43);
            this.tovarysl.TabIndex = 2;
            this.tovarysl.Text = "Товары и услуги";
            this.tovarysl.UseVisualStyleBackColor = true;
            this.tovarysl.Click += new System.EventHandler(this.tovarysl_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.exit.Location = new System.Drawing.Point(12, 255);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(156, 43);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // option
            // 
            this.option.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.option.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.option.Location = new System.Drawing.Point(12, 195);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(156, 43);
            this.option.TabIndex = 4;
            this.option.Text = "Отчёты";
            this.option.UseVisualStyleBackColor = true;
            this.option.Click += new System.EventHandler(this.option_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ctokkt.Properties.Resources.dFon1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 320);
            this.Controls.Add(this.option);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Sprav);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.tovarysl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sprav;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button tovarysl;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button option;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}