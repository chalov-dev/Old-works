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

namespace ctokkt.TovAndYsl
{
    public partial class insertYsl : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public insertYsl()
        {
            InitializeComponent();
        }

        private void insertYsl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsYsl", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Наименование", nYsl.Text));
                        command.Parameters.Add(new SqlParameter("@Стоимость", decimal.Parse(priceY.Text, CultureInfo.InstalledUICulture)));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Услуга добавлена!");
                        this.Hide();
                    }


                    catch (Exception)
                    {
                        MessageBox.Show("Введите корректные данные");
                    }


                    TY main = this.Owner as TY;
                    if (main != null)
                    {
                        main.Obnov();
                    }
                }
            }
        }
    }
}
