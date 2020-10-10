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

namespace ctokkt.Dok
{
    public partial class insertDok : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public insertDok()
        {
            InitializeComponent();
        }

        private void insertDok_Load(object sender, EventArgs e)
        {
            StatusD.SelectedIndex = 0;
            monthZ.SelectedIndex = 0;

            dataAdapter = new SqlDataAdapter("select * from dbo.ВидДокументов", ConnectToSql.ConnectionString);
            var table = new DataTable();
            dataAdapter.Fill(table);
            vidD.ValueMember = "Код";
            vidD.DisplayMember = "ТипДокумента";
            vidD.DataSource = table;

            dataAdapter = new SqlDataAdapter("select * from dbo.Товары", ConnectToSql.ConnectionString);
            var table1 = new DataTable();
            dataAdapter.Fill(table1);
            tovar.ValueMember = "Код";
            tovar.DisplayMember = "Наименование";
            tovar.DataSource = table1;

            dataAdapter = new SqlDataAdapter("select * from dbo.Услуги", ConnectToSql.ConnectionString);
            var table2 = new DataTable();
            dataAdapter.Fill(table2);
            ysl.ValueMember = "Код";
            ysl.DisplayMember = "Наименование";
            ysl.DataSource = table2;

            dataAdapter = new SqlDataAdapter("select * from dbo.ТиповыеНеисправности", ConnectToSql.ConnectionString);
            var table3 = new DataTable();
            dataAdapter.Fill(table3);
            neisp.ValueMember = "Код";
            neisp.DisplayMember = "СтандартныеНеисправность";
            neisp.DataSource = table3;

            dataAdapter = new SqlDataAdapter("select * from dbo.Сотрудники", ConnectToSql.ConnectionString);
            var table4 = new DataTable();
            dataAdapter.Fill(table4);
            polz.ValueMember = "ТабельныйНомер";
            polz.DisplayMember = "ФИО";
            polz.DataSource = table4;

            dataAdapter = new SqlDataAdapter("select * from dbo.Контрагенты", ConnectToSql.ConnectionString);
            var table5 = new DataTable();
            dataAdapter.Fill(table5);
            kontr.ValueMember = "Договор";
            kontr.DisplayMember = "Наименование";
            kontr.DataSource = table5;

            dataAdapter = new SqlDataAdapter("select * from dbo.Склады", ConnectToSql.ConnectionString);
            var table6 = new DataTable();
            dataAdapter.Fill(table6);
            otdel.ValueMember = "Код";
            otdel.DisplayMember = "Наименование";
            otdel.DataSource = table6;

            dataAdapter = new SqlDataAdapter("select * from dbo.Склады", ConnectToSql.ConnectionString);
            var table7 = new DataTable();
            dataAdapter.Fill(table7);
            otdel2.ValueMember = "Код";
            otdel2.DisplayMember = "Наименование";
            otdel2.DataSource = table7;

            dataAdapter = new SqlDataAdapter("select * from dbo.Контрагенты", ConnectToSql.ConnectionString);
            var table8 = new DataTable();
            dataAdapter.Fill(table8);
            grPol.ValueMember = "Договор";
            grPol.DisplayMember = "Наименование";
            grPol.DataSource = table8;

            dataAdapter = new SqlDataAdapter("select * from dbo.Контрагенты", ConnectToSql.ConnectionString);
            var table9 = new DataTable();
            dataAdapter.Fill(table9);
            plat.ValueMember = "Договор";
            plat.DisplayMember = "Наименование";
            plat.DataSource = table9;

            dataAdapter = new SqlDataAdapter("select * from dbo.Сотрудники", ConnectToSql.ConnectionString);
            var table10 = new DataTable();
            dataAdapter.Fill(table10);
            ispol.ValueMember = "ТабельныйНомер";
            ispol.DisplayMember = "ФИО";
            ispol.DataSource = table10;

            dataAdapter = new SqlDataAdapter("select * from dbo.Подписанты", ConnectToSql.ConnectionString);
            var table11 = new DataTable();
            dataAdapter.Fill(table11);
            podp.ValueMember = "Код";
            podp.DisplayMember = "ФИО";
            podp.DataSource = table11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var prtovar = new Tovar();
            prtovar.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsDok", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Код", int.Parse(Kod.Text)));
                        command.Parameters.Add(new SqlParameter("@ВидДокумента", (int)vidD.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ДатаДокумента", dataT.Value));
                        command.Parameters.Add(new SqlParameter("@СуммаДокумента", decimal.Parse(sumD.Text, CultureInfo.InvariantCulture)));
                        command.Parameters.Add(new SqlParameter("@Товар", (int)tovar.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Услуга", (int)ysl.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Неисправность", (int)neisp.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Комментарий", comm.Text));
                        command.Parameters.Add(new SqlParameter("@НомерПользователя", (int)polz.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@СтатусДокумента", StatusD.Text));
                        command.Parameters.Add(new SqlParameter("@КодКонтрагента", (int)kontr.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Отдел", (int)otdel.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@КодВторогоСклада", (int)otdel2.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Грузополучатель", (int)grPol.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Плательщик", (int)plat.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ИсполнительКод", (int)ispol.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ЗаМесяц", monthZ.Text));
                        command.Parameters.Add(new SqlParameter("@Скидка", decimal.Parse(skid.Text, CultureInfo.InvariantCulture)));
                        command.Parameters.Add(new SqlParameter("@ИтоговаяЦена", (decimal.Parse(sumD.Text, CultureInfo.InvariantCulture)-(((decimal.Parse(sumD.Text, CultureInfo.InvariantCulture))*(decimal.Parse(skid.Text, CultureInfo.InstalledUICulture)))/100))));
                        command.Parameters.Add(new SqlParameter("@Подписант", (int)podp.SelectedValue));
                        command.ExecuteNonQuery();

                        MessageBox.Show("Данные добавлены!");
                        this.Hide();
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); //"Введите корректные данные");
                    }


                    Doc main = this.Owner as Doc;
                    if (main != null)
                    {
                        main.Obnov();
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var service = new Ysluga();
            service.ShowDialog();
        }

        private void bback_Click(object sender, EventArgs e)
        {
            var exitDoc = new insertDok();
            if (dataT.Value != null)
            {
                DialogResult dialogResult = MessageBox.Show("У вас остались несохраненённые данные!\nВы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                }

                else if (dialogResult == DialogResult.No)
                {

                }
            }


        }
    }
}
