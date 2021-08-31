using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OblikTovariv1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;
            string psw = txtPass.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select access From userlist where Name ='" + usr + "' and Pass ='" + psw + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            // Проверяем, что количество строк из БД больше нуля
            if (dt.Rows.Count > 0)
            {
                string access = dt.Rows[0][0].ToString();
                if (access == "admin")
                {
                    this.Hide();
                    FormProducts___Admin fpa = new FormProducts___Admin();
                    fpa.Show();
                }
                else
                {
                    this.Hide();
                    FormProducts fp = new FormProducts();
                    fp.Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль!");
            }

            con.Close();
        }
    }
}
