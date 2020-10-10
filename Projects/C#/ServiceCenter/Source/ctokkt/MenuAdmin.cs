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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Sprav_Click(object sender, EventArgs e)
        {
            Sprav spr = new Sprav();
            spr.Show();
            this.Hide();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            Doc doc = new Doc();
            doc.Show();
            this.Hide();
        }

        private void tovarysl_Click(object sender, EventArgs e)
        {
            TY ty = new TY();
            ty.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void option_Click(object sender, EventArgs e)
        {
            var otchet = new Otchet();
            otchet.Show();
            this.Hide();
        }
    }
}
