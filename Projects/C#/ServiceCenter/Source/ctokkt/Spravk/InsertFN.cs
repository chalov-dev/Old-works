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
    public partial class InsertFN : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public InsertFN()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertFN", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Номер", int.Parse(nFN.Text)));
                        command.Parameters.Add(new SqlParameter("@ДатаАктивации", dateActiv.Value));
                        command.Parameters.Add(new SqlParameter("@ДатаЗакрытияАрхива", dateClose.Value));
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
