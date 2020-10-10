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
    public partial class InsertSot : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public InsertSot()
        {
            InitializeComponent();
        }

        private void InsertSot_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("select * from dbo.Должности", ConnectToSql.ConnectionString);
            var table = new DataTable();
            dataAdapter.Fill(table);
            dol.ValueMember = "Номер";
            dol.DisplayMember = "Должность";
            dol.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertSot", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Табельныйномер", int.Parse(textBox1.Text)));
                        command.Parameters.Add(new SqlParameter("@ФИО", textBox2.Text));
                        command.Parameters.Add(new SqlParameter("@ФИО_ип", textBox3.Text));
                        command.Parameters.Add(new SqlParameter("@ФИО_Рп", textBox4.Text));
                        command.Parameters.Add(new SqlParameter("@ФИО_дп", textBox5.Text));
                        command.Parameters.Add(new SqlParameter("@Должность", (int)dol.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ДатаРождения", dateB.Value));
                        command.Parameters.Add(new SqlParameter("@ИНН", textBox6.Text));
                        command.Parameters.Add(new SqlParameter("@Контакты", textBox7.Text));
                        command.Parameters.Add(new SqlParameter("@АдресПрописки", textBox8.Text));
                        command.Parameters.Add(new SqlParameter("@ПаспортСерия", int.Parse(textBox9.Text)));
                        command.Parameters.Add(new SqlParameter("@ПаспортНомер", int.Parse(textBox10.Text)));
                        command.Parameters.Add(new SqlParameter("@ПаспортКемВыдан", textBox11.Text));
                        command.Parameters.Add(new SqlParameter("@ПаспортДатаВыдачи", dateOut.Value));
                        command.Parameters.Add(new SqlParameter("@ПаспортКодПодразделения", textBox12.Text));
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
