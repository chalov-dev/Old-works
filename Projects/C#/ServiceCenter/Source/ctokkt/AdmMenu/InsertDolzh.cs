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
    public partial class InsertDolzh : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public InsertDolzh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                    using (var command = new SqlCommand("InsertDolzh", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@Номер", int.Parse(nDolzh.Text)));
                            command.Parameters.Add(new SqlParameter("@Должность", Dolzh.Text));
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
