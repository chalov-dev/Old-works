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
    public partial class InsertKas : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public InsertKas()
        {
            InitializeComponent();
        }

        private void InsertKas_Load(object sender, EventArgs e)
        {
            Obsl.SelectedIndex = 0;

            dataAdapter = new SqlDataAdapter("select * from dbo.МодельККТ", ConnectToSql.ConnectionString);
            var table = new DataTable();
            dataAdapter.Fill(table);
            Model.ValueMember = "Код";
            Model.DisplayMember = "Наименование";
            Model.DataSource = table;

            dataAdapter = new SqlDataAdapter("select * from dbo.Контрагенты", ConnectToSql.ConnectionString);
            var table1 = new DataTable();
            dataAdapter.Fill(table1);
            Vladel.ValueMember = "Договор";
            Vladel.DisplayMember = "Наименование";
            Vladel.DataSource = table1;

            dataAdapter = new SqlDataAdapter("select * from dbo.ФН", ConnectToSql.ConnectionString);
            var table2 = new DataTable();
            dataAdapter.Fill(table2);
            FN.ValueMember = "Номер";
            FN.DisplayMember = "Номер";
            FN.DataSource = table2;

            dataAdapter = new SqlDataAdapter("select * from dbo.ОФД", ConnectToSql.ConnectionString);
            var table3 = new DataTable();
            dataAdapter.Fill(table3);
            OFD.ValueMember = "Код";
            OFD.DisplayMember = "Наименование";
            OFD.DataSource = table3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertKass", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@МодельККТ", (int)Model.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@НомерККТ", nKKT.Text));
                        command.Parameters.Add(new SqlParameter("@ДатаВыпуска", dataVup.Value));
                        command.Parameters.Add(new SqlParameter("@ПолноеНаименование", pName.Text));
                        command.Parameters.Add(new SqlParameter("@Обслуживается", Obsl.Text));
                        command.Parameters.Add(new SqlParameter("@Владелец", (int)Vladel.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@РегНомер", regN.Text));
                        command.Parameters.Add(new SqlParameter("@ДатаВвода", dataVv.Value));
                        command.Parameters.Add(new SqlParameter("@ДатаСнятия", dataSn.Value));
                        command.Parameters.Add(new SqlParameter("@АдресУстановки", adrYst.Text));
                        command.Parameters.Add(new SqlParameter("@ФН", (int)FN.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ОФД", (int)OFD.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@СтоимостьОбслуживания", decimal.Parse(price.Text, CultureInfo.InvariantCulture)));
                        command.ExecuteNonQuery();
                        this.Hide();
                    }


                    catch (Exception)
                    {
                        MessageBox.Show("Вы ввели неккоректные данные!");
                    }


                    Sprav main = this.Owner as Sprav;
                    if (main != null)
                    {
                        main.Obnov();
                    }
                   
                   // this.Hide();
                }
            }
        }
    }
}
