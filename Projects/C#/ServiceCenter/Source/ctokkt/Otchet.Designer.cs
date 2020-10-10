namespace ctokkt
{
    partial class Otchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otchet));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.JornalObsl1 = new ctokkt.JornalObsl();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.JornalObsl1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(797, 387);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Image = global::ctokkt.Properties.Resources.exitd;
            this.button10.Location = new System.Drawing.Point(747, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(41, 40);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::ctokkt.Properties.Resources.back2;
            this.button9.Location = new System.Drawing.Point(629, 398);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 40);
            this.button9.TabIndex = 11;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::ctokkt.Properties.Resources.menu;
            this.button8.Location = new System.Drawing.Point(689, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 40);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Otchet";
            this.Text = "Журнал обслуживания";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private JornalObsl JornalObsl1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}