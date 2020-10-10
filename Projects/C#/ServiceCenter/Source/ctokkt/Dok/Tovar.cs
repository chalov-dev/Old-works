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
    public partial class Tovar : Form
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

        public Tovar()
        {
            InitializeComponent();
        }

        private void bback_Click(object sender, EventArgs e)
        {
            var exitProduct = new Tovar();
            this.Hide();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Товары", bindingSource1);
        }
    }
}
