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

namespace ctokkt.AdmMenu
{
    public partial class InsertSklad : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public InsertSklad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertSklad", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Наименование", nSklad.Text));
                        command.Parameters.Add(new SqlParameter("@Ответственный", Otvet.Text));
                        command.ExecuteNonQuery();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введите корректные данные");
                    }


                    Option main = this.Owner as Option;
                    if (main != null)
                    {
                        main.Obnov();
                    }
                }
            }
        }
    }
}
