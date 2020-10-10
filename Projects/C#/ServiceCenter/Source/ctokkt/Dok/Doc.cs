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

    public partial class Doc : Form
    {
         
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        private void GetData(string selectCommand, BindingSource bindingSource)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, ConnectToSql.ConnectionString);
                var table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public void Obnov()
        {
            DokLoad(null, null);
        }

        public Doc()
        {
            InitializeComponent();
        }

        private void DokLoad(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select ЖурналДокументов.Код, ВидДокументов.ТипДокумента as [Тип документа], ЖурналДокументов.ДатаДокумента as [Дата документа], ЖурналДокументов.СуммаДокумента as [Сумма документа], Товары.Наименование as Товар, Услуги.Наименование as Услуга, ТиповыеНеисправности.СтандартныеНеисправность as Неисправность, ЖурналДокументов.Комментарий, Сотрудники.ТабельныйНомер as [Номер сотрудника], ЖурналДокументов.СтатусДокумента as [Статус документа], Контрагенты.Договор as [Код контрагента], Склады.Наименование as Отдел, Склады.Наименование as Склад, Контрагенты.ПолноеНаименование as Грузополучатель, Контрагенты.Наименование as Плательщик, Сотрудники.ФИО as Исполнитель, ЖурналДокументов.ЗаМесяц, ЖурналДокументов.Скидка, ЖурналДокументов.ИтоговаяЦена, Подписанты.ФИО as Подписант from ЖурналДокументов inner join ВидДокументов on ЖурналДокументов.ВидДокумента = ВидДокументов.Код inner join Склады on ЖурналДокументов.Отдел = Склады.Код inner join Сотрудники on ЖурналДокументов.НомерПользователя = Сотрудники.ТабельныйНомер inner join Подписанты on ЖурналДокументов.Подписант = Подписанты.Код inner join Контрагенты on ЖурналДокументов.КодКонтрагента=Контрагенты.Договор inner join Товары on ЖурналДокументов.Товар=Товары.Код inner join Услуги on ЖурналДокументов.Услуга = Услуги.Код inner join ТиповыеНеисправности on ЖурналДокументов.Неисправность = ТиповыеНеисправности.Код", bindingSource1);
        }

        public void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var insDok = new Dok.insertDok();
            insDok.Owner = this;
            insDok.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void search(TextBox tb, DataGridView dg, object sender, EventArgs e)
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {

                dg.CurrentCell = null;
                bool isVisible = false;
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg[j, i].Value.ToString().IndexOf(tb.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        isVisible = true;
                    }
                }
                dg.Rows[i].Visible = isVisible;
            }
        }

        private void Delete(string storedProcedure, DataGridView dataGrid, int x, BindingSource bs)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try

                {
                    var selected = int.Parse(dataGrid.SelectedRows[0].Cells[x].FormattedValue.ToString());
                    dataGrid.DataSource = bs;
                    GetData(storedProcedure + " " + selected, bs);
                    Obnov();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete("DelDok", dataGridView1, 0, bindingSource1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1, dataGridView1, sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var back = new MenuAdmin();
            this.Hide();
            back.Show();
        }
    }
}