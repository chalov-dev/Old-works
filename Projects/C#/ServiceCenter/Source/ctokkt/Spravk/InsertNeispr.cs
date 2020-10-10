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
using System.Globalization;


namespace ctokkt
{
    public partial class InsertNeispr : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public InsertNeispr()
        {
            InitializeComponent();
        }

        private void InsertNeispr_Load(object sender, EventArgs e)
        {

        }

        private void bNeis_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertNeisp", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@СтандартныеНеисправность", stNei.Text));
                        command.ExecuteNonQuery();
                        this.Hide();
                    }


                    catch (Exception)
                    {
                        MessageBox.Show("Введите корректные данные");
                    }


                    Sprav main = this.Owner as Sprav;
                    if (main != null)
                    {
                        main.Obnov();
                    }


                }
            }
        }

        private void bizm_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("upNeisp", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@СтандартныеНеисправность", stNei.Text));
                        command.ExecuteNonQuery();
                        this.Hide();
                    }


                    catch (Exception)
                    {
                        MessageBox.Show("Введите корректные данные");
                    }


                    Sprav main = this.Owner as Sprav;
                    if (main != null)
                    {
                        main.Obnov();
                    }


                }
            }
        }
    }
}
