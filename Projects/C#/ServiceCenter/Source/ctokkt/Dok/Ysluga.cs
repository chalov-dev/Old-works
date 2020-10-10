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

namespace ctokkt.Dok
{
    public partial class Ysluga : Form
    {
        public Ysluga()
        {
            InitializeComponent();
        }
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

        private void bback_Click(object sender, EventArgs e)
        {
            var exitYsl = new Ysluga();
            this.Hide();
        }

        private void Ysluga_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Услуги", bindingSource1);
        }
    }
}
