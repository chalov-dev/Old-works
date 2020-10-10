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
    public partial class Sprav : Form
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
            SpravLoad(null, null);
        }


        public Sprav()
        {
            InitializeComponent();
        }

        private void SpravLoad(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select Сотрудники.ТабельныйНомер as [Табельный номер], Сотрудники.ФИО, Сотрудники.ФИО_ип as [ФИО И.п.], Должности.Должность, Сотрудники.ДатаРождения as [Дата рождения], Сотрудники.ИНН, Сотрудники.Контакты, Сотрудники.АдресПрописки, Сотрудники.ПаспортСерия, Сотрудники.ПаспортНомер, Сотрудники.ПаспортКемВыдан, Сотрудники.ПаспортДатаВыдачи, Сотрудники.ПаспортКодПодразделения from Сотрудники inner join Должности on Сотрудники.Должность = Должности.Номер", bindingSource1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select Кассы.Код, МодельККТ.Наименование as [Модель ККТ], Кассы.НомерККТ, Кассы.ДатаВыпуска, Кассы.ПолноеНаименование, Кассы.Обслуживается, Контрагенты.Договор as Владелец, Кассы.РегНомер, Кассы.ДатаВвода, Кассы.ДатаСнятия, Кассы.АдресУстановки, ФН.Номер as ФН, ОФД.Наименование as Наименование, Кассы.СтоимостьОбслуживания from Кассы inner join МодельККТ on Кассы.МодельККТ=МодельККТ.Код inner join ОФД on Кассы.ОФД=ОФД.Код inner join ФН on Кассы.ФН=ФН.Номер inner join Контрагенты on Кассы.Владелец=Контрагенты.Договор", bindingSource2);
            dataGridView3.DataSource = bindingSource3;
            GetData("select Контрагенты.Договор, ВидКонтрагента.Наименование, Контрагенты.Наименование, Контрагенты.ПолноеНаименование, Контрагенты.ИНН, Контрагенты.КПП, Контрагенты.ФИОруководителя, Контрагенты.ФИО_РодПадеж, Контрагенты.Должность_РодПадеж, Контрагенты.Основание_РодПадеж, Сотрудники.ФИО as Мастер, Контрагенты.ПочтовыйАдрес, Контрагенты.ЮридическийАдрес, Контрагенты.Контакты from Контрагенты inner join ВидКонтрагента on Контрагенты.ВидКонтрагента=ВидКонтрагента.Номер inner join Сотрудники on Контрагенты.Мастер=Сотрудники.ТабельныйНомер", bindingSource3);
            dataGridView4.DataSource = bindingSource4;
            GetData("select * from ФН", bindingSource4);
            dataGridView5.DataSource = bindingSource5;
            GetData("select * from МодельККТ", bindingSource5);
            dataGridView6.DataSource = bindingSource6;
            GetData("select * from ТиповыеНеисправности", bindingSource6);
            dataGridView7.DataSource = bindingSource7;
            GetData("select * from ОФД", bindingSource7);
        }

        public void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView1);
        }

  
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertSot insert = new InsertSot();
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var insFN = new InsertFN();
            insFN.Owner = this;
            insFN.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var insModel = new InsertModel();
            insModel.Owner = this;
            insModel.ShowDialog();

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bback_Click(object sender, EventArgs e)
        {
            var back = new MenuAdmin();
            back.Show();
            this.Hide();
        }

        private void bmenu_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            var insertKas = new InsertKas();
            insertKas.Owner=this;
            insertKas.ShowDialog();
           
        }

        private void button56_Click(object sender, EventArgs e)
        {
            var insertOFD = new InsertOFD();
            insertOFD.Owner = this;
            insertOFD.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search(textBox4, dataGridView4, sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search(textBox2, dataGridView2, sender, e);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bObnov_Click(object sender, EventArgs e)
        {
            SpravLoad(null, null);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete("DelSot", dataGridView1, 0, bindingSource1);
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView1);
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView2);
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView3);
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView4);
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView5);
        }

        private void dataGridView6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView6);
        }

        private void dataGridView7_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView7);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Delete("DelFN", dataGridView4, 0, bindingSource4);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            var insNeisp = new InsertNeispr();
            insNeisp.Owner = this;
            insNeisp.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var insKontr= new insKontr();
            insKontr.Owner = this;
            insKontr.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Delete("DelCash", dataGridView2, 0, bindingSource2);
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Delete("DelModel", dataGridView5, 0, bindingSource5);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Delete("DelNeisp", dataGridView6, 0, bindingSource6);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Delete("DelOFD", dataGridView7, 0, bindingSource7);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1, dataGridView1, sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            search(textBox3, dataGridView3, sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            search(textBox5, dataGridView5, sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            search(textBox6, dataGridView6, sender, e);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            search(textBox7, dataGridView7, sender, e);
        }
    }
}
