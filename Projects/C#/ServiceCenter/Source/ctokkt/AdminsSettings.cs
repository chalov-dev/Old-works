using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctokkt
{
    public partial class AdminsSettings : Form
    {
        public AdminsSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opt = new AdmMenu.Option();
            this.Hide();
            opt.ShowDialog();
            
        }
    }
}
