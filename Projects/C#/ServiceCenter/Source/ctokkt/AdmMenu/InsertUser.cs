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
    public partial class InsertUser : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public InsertUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertUser", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Логин", login.Text));
                        command.Parameters.Add(new SqlParameter("@Пароль", password.Text));
                        command.ExecuteNonQuery();
                        this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("upUser", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Логин", login.Text));
                        command.Parameters.Add(new SqlParameter("@Пароль", password.Text));
                        command.ExecuteNonQuery();
                        this.Hide();
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
