using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace OblikTovariv1
{
    public partial class FormPersonal : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        public FormPersonal()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "Select * From userlist";
            cmd.CommandText = str;

            reader = cmd.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddPersonal fa = new FormAddPersonal();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;

            string a = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            string str = "(DELETE FROM userlist WHERE Name='" + a + "')";
            cmd.CommandText = str;
            cmd.ExecuteReader();

            con.Close();
            Thread.Sleep(500);
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }
    }
}
