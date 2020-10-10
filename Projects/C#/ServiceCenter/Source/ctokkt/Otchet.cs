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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }
    }
}
