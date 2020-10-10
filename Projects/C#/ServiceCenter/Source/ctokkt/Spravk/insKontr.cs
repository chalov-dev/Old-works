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
    public partial class insKontr : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public insKontr()
        {
            InitializeComponent();
        }

        private void insKontr_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("select * from dbo.ВидКонтрагента", ConnectToSql.ConnectionString);
            var table = new DataTable();
            dataAdapter.Fill(table);
            VidK.ValueMember = "Номер";
            VidK.DisplayMember = "Наименование";
            VidK.DataSource = table;

            dataAdapter = new SqlDataAdapter("select * from dbo.Сотрудники", ConnectToSql.ConnectionString);
            var table1 = new DataTable();
            dataAdapter.Fill(table1);
            mast.ValueMember = "ТабельныйНомер";
            mast.DisplayMember = "ФИО";
            mast.DataSource = table1;
        }

        private void insertKont_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("insKontr", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Договор", int.Parse(Dogovor.Text)));
                        command.Parameters.Add(new SqlParameter("@ВидКонтрагента", (int)VidK.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@Наименование", nKont.Text));
                        command.Parameters.Add(new SqlParameter("@ПолноеНаименование", fnKont.Text));
                        command.Parameters.Add(new SqlParameter("@ИНН", INN.Text));
                        command.Parameters.Add(new SqlParameter("@КПП", KPP.Text));
                        command.Parameters.Add(new SqlParameter("@ФИОруководителя", FIO.Text));
                        command.Parameters.Add(new SqlParameter("@ФИО_РодПадеж", FIOrp.Text));
                        command.Parameters.Add(new SqlParameter("@Должность_РодПадеж", Dolrp.Text));
                        command.Parameters.Add(new SqlParameter("@Основание_РодПадеж", Ocnrp.Text));
                        command.Parameters.Add(new SqlParameter("@Мастер", (int)mast.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@ПочтовыйАдрес", pAdr.Text));
                        command.Parameters.Add(new SqlParameter("@ЮридическийАдрес", uAdr.Text));
                        command.Parameters.Add(new SqlParameter("@Контакты", kont.Text));
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
