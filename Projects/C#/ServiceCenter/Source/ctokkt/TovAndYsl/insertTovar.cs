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
    public partial class insertTovar : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public insertTovar()
        {
            InitializeComponent();
        }

        private void insertTovar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsTovar", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@Наименование", nTov.Text));
                        command.Parameters.Add(new SqlParameter("@СерийныйНомер", serN.Text));
                        command.Parameters.Add(new SqlParameter("@ЦенаПрихода", decimal.Parse(priceP.Text, CultureInfo.InvariantCulture)));
                        command.Parameters.Add(new SqlParameter("@ЦенаРозница", decimal.Parse(priceR.Text, CultureInfo.InvariantCulture)));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Товар добавлен!");
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
