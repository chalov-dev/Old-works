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
    public partial class Option : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

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

        public Option()
        {
            InitializeComponent();
        }

        public void Obnov()
        {
            Option_Load(null, null);
        }
       

        private void Option_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Авторизация", bindingSource1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Должности", bindingSource2);
            dataGridView3.DataSource = bindingSource3;
            GetData("select * from Подписанты", bindingSource3);
            dataGridView4.DataSource = bindingSource4;
            GetData("select * from Склады", bindingSource4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var insUser = new InsertUser();
            insUser.Owner = this;
            insUser.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var insDolzh = new InsertDolzh();
            insDolzh.Owner = this;
            insDolzh.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var insPod = new InsertPodp();
            insPod.Owner = this;
            insPod.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            var insSklad = new InsertSklad();
            insSklad.Owner = this;
            insSklad.ShowDialog();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            AdminsSettings menu = new AdminsSettings();
            this.Hide();
            menu.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Delete("DelUser", dataGridView1, 0, bindingSource1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Delete("DelDolzh", dataGridView2, 0, bindingSource2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Delete("DelPodp", dataGridView3, 0, bindingSource3);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Delete("DelCklad", dataGridView4, 0, bindingSource4);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1, dataGridView1, sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search(textBox2, dataGridView2, sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            search(textBox3, dataGridView3, sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search(textBox4, dataGridView4, sender, e);
        }
    }
}
