using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace OblikTovariv1
{
    public partial class FormEdit : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        int i;
        public FormEdit(int i)
        {
            InitializeComponent();
            this.i = i;
            LoadData();
            Thread.Sleep(500);
            Load();
        }

        private void LoadData()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "Select * From products WHERE article=" + i + "";
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

        public void Load()
        {
            txtname.Text = dataGridView1[1, 0].Value.ToString();
            txtarticle.Text = dataGridView1[2, 0].Value.ToString();
            txtcount.Text = dataGridView1[3, 0].Value.ToString();
            txtprice.Text = dataGridView1[4, 0].Value.ToString();
            txtposition.Text = dataGridView1[6, 0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = new DialogResult();
            result = MessageBox.Show("Підтвердити редагування?", "Увага!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string name = txtname.Text;
                int article = Convert.ToInt32(txtarticle.Text);
                int count = Convert.ToInt32(txtcount.Text);
                int price = Convert.ToInt32(txtprice.Text);
                int position = Convert.ToInt32(txtposition.Text);
                con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                int c = 0;
                try
                {
                    c = 0;
                    string str = "(UPDATE products SET name='" + name + "', article=" + article + ", [count]=" + count + ", price=" + price + ", [position]=" + position + "  WHERE [article]=" + i + ")";
                    cmd.CommandText = str;
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка редагування запису!");
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    if (c == 0)
                        MessageBox.Show("Успішно збережено!", "Повідомлення!");
                }
                
                Thread.Sleep(500);
                dataGridView1.Rows.Clear();
                if (txtarticle.Text != String.Empty)
                    i = article;
                LoadData();
                Load();
                
            }
        }
    }
}
