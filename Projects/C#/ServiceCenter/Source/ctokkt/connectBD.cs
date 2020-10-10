using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ctokkt
{
    public partial class connectBD : Form
    {
        public connectBD()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            var cbd = @"Data Source=" + Servertxt.Text + ";Initial Catalog=" + BDtxt.Text + ";User ID = "
                + logintxt.Text + "; Password =" + passtxt.Text;
            var connection = new SqlConnection(cbd);
            try
            {
                connection.Open();
                ConnectToSql.ConnectionString = cbd;
                var mainForm = new Authoriz();
                MessageBox.Show("Успешное подключение");
                mainForm.Show();
                Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
