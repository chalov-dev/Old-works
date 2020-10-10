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
    public partial class InsertOFD : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public InsertOFD()
        {
            InitializeComponent();
        }


        private void InsertOFD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertOFD", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Наименование", nOFD.Text));
                        command.Parameters.Add(new SqlParameter("@ИНН", INN.Text));
                        command.Parameters.Add(new SqlParameter("@Хост", Host.Text));
                        command.Parameters.Add(new SqlParameter("@Порт", int.Parse(Port.Text)));
                        command.ExecuteNonQuery();
                     //   this.Hide();
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
