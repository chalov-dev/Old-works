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
    public partial class InsertPodp : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public InsertPodp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertPodp", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@ФИО", FIO.Text));
                        command.Parameters.Add(new SqlParameter("@Основание", Osnov.Text));
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
