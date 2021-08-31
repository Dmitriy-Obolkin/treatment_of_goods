using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OblikTovariv1
{
    public partial class FormProducts : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        public FormProducts()
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
            FormAdd fa = new FormAdd();
            fa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDell fd = new FormDell();
            fd.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            FormEdit fe = new FormEdit(i);
            fe.Show();
        }
    }
}
