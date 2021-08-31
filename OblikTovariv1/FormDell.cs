using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace OblikTovariv1
{
    public partial class FormDell : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        public FormDell()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "Select * From products";
            cmd.CommandText = str;

            reader = cmd.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Введіть  кількість товару!", "Помилка!");
            }
            else
            {


                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int count = (Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString())) - (Convert.ToInt32(textBox1.Text));

                int a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
                string tovar = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                if (count > 0)
                {
                    var result = new DialogResult();
                    result = MessageBox.Show("Видалити " + textBox1.Text + " одиниць " + tovar + " ?", "Увага!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string str = "(UPDATE products SET [count]=" + count + " WHERE article=" + a + ")";
                        cmd.CommandText = str;
                        cmd.ExecuteReader();

                        con.Close();
                        Thread.Sleep(500);
                        dataGridView1.Rows.Clear();
                        LoadData();
                        MessageBox.Show("Кількість товару " + tovar + " успішно змінено!", "Повідомлення!");
                    }
                }
                else
                {
                    if (count == 0)
                    {

                        var result = new DialogResult();
                        result = MessageBox.Show("Видалити повністю з обліку " + tovar + " ?", "Увага!",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string str = "(DELETE FROM products WHERE article=" + a + ")";
                            cmd.CommandText = str;
                            cmd.ExecuteReader();

                            con.Close();
                            Thread.Sleep(500);
                            dataGridView1.Rows.Clear();
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Відсутня вказана кількість товару!", "Відмова!");
                    }
                }
                //MessageBox.Show(kol.ToString());
            }
        }
    }
}
