using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OblikTovariv1
{
    public partial class FormAddPersonal : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public FormAddPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select [Name] From userlist ", con);
            DataTable dtName = new DataTable();
            dataAdapter.Fill(dtName);

            int c = 0;
            if (dtName.Rows.Count > 0)
            {
                for (int i = 0; i < dtName.Rows.Count; i++)
                {
                    string a = dtName.Rows[i][0].ToString();
                    string b = txtname.Text;
                    if (a == b)
                    {
                            MessageBox.Show("Користувач з таким ім'ям уже є в списку! ", "Помилка!");
                            c = 1;
                            break;
                    }
                    else
                    {
                        c = 0;
                    }
                }
            }


            if (c == 0)
            {
                try
                {
                    c = 0;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO userlist ( Name, [Pass], [Access]) VALUES (@txtname, [@txtpass], [@comboacc])";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@txtname", txtname.Text);
                    cmd.Parameters.AddWithValue("@txtpass", txtpass.Text);
                    cmd.Parameters.AddWithValue("@comboacc", comboacc.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка внесення запису!");
                    c = 1;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    if (c == 0)
                        MessageBox.Show("Користувач " + txtname.Text + " успішно внесений!", "Повідомлення!");
                }
            }

        }
    }
}
