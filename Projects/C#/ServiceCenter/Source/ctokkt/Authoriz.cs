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
    public partial class Authoriz : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public Authoriz()
        {
            InitializeComponent();
        }

        private void Authoriz_Load(object sender, EventArgs e)
        {

        }
        private void Avtoriz()
        {
            using (var connection = new SqlConnection(ConnectToSql.ConnectionString))

            {
                bool success = false;
                try
                {
                    const string comand = "Select * From Авторизация WHERE Логин=@Логин AND Пароль=@Пароль";
                    SqlCommand check = new SqlCommand(comand, connection);
                    check.Parameters.AddWithValue("@Логин", Login.Text);
                    check.Parameters.AddWithValue("@Пароль", passw.Text);
                    connection.Open();

                    using (var dataReader = check.ExecuteReader())
                    {
                        success = dataReader.Read();
                    }
                }
                finally
                {
                    connection.Close();
                }

                if (success)
                {
                    if (Login.Text == "Admin")
                    { 
                    AdminsSettings adm = new AdminsSettings();
                    adm.ShowDialog();
                    }
                    else
                    {
                        MenuAdmin sotr = new MenuAdmin();
                        sotr.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void autoBD_Click(object sender, EventArgs e)
        {
            Avtoriz();
        }

    }
}
