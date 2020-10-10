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
using System.Drawing.Printing;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace ctokkt
{
    public partial class TY : Form
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

        public TY()
        {
            InitializeComponent();
        }

        public void Obnov()
        {
            TYLoad(null, null);
        }

        private void TYLoad(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Товары", bindingSource1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Услуги", bindingSource2);
            dataGridView3.DataSource = bindingSource3;
            GetData("select * from JornalT", bindingSource3);
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

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView2);
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetRowNumber(dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var insTovar = new TovAndYsl.insertTovar();
            insTovar.Owner = this;
            insTovar.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var insYsl = new TovAndYsl.insertYsl();
            insYsl.Owner = this;
            insYsl.ShowDialog();
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
            Delete("DelTovar", dataGridView1, 0, bindingSource1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Delete("DelYsl", dataGridView2, 0, bindingSource2);
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

        private void button23_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += (s, q) =>
            {
                var bmp = new Bitmap(dataGridView3.Width, dataGridView3.Height);
                dataGridView3.DrawToBitmap(bmp, dataGridView3.ClientRectangle);
                q.Graphics.DrawImage(bmp, new Point(100, 100));
            };
            pd.Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += (s, q) =>
            {
                var bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bmp, dataGridView1.ClientRectangle);
                q.Graphics.DrawImage(bmp, new Point(100, 100));
            };
            pd.Print();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += (s, q) =>
            {
                var bmp = new Bitmap(dataGridView2.Width, dataGridView2.Height);
                dataGridView2.DrawToBitmap(bmp, dataGridView2.ClientRectangle);
                q.Graphics.DrawImage(bmp, new Point(100, 100));
            };
            pd.Print();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var back = new MenuAdmin();
            this.Hide();
            back.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Экспорт завершён");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
