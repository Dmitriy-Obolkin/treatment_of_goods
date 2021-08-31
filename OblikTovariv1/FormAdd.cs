using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OblikTovariv1
{
    public partial class FormAdd : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select article From products ", con);
            DataTable dtArticle = new DataTable();
            dataAdapter.Fill(dtArticle);

            int a, b;
            int i1 = (Convert.ToInt32(dtArticle.Rows.Count)) + 1;
            int c = 0;

            if (txtarticle.Text != String.Empty && txtcount.Text != String.Empty)
            {
                if (dtArticle.Rows.Count > 0)
                {
                    for (int i = 0; i < dtArticle.Rows.Count; i++)
                    {
                        a = Convert.ToInt32(dtArticle.Rows[i][0].ToString());
                        b = Convert.ToInt32(txtarticle.Text);

                        if (a != b)
                        {
                            if (txtname.Text != String.Empty && txtposition.Text != String.Empty & txtprice.Text != String.Empty)
                            {
                                if (c == 0)
                                {
                                    try
                                    {
                                        c = 0;
                                        OleDbCommand cmd = new OleDbCommand();
                                        cmd.CommandType = CommandType.Text;
                                        cmd.CommandText = "INSERT INTO products ( name, article, [count], price, [position]) VALUES (@txtname, @txtarticle, [@txtcount], @txtprice, [@txtposition])";
                                        cmd.Connection = con;
                                        cmd.Parameters.AddWithValue("@txtname", txtname.Text);
                                        cmd.Parameters.AddWithValue("@txtarticle", txtarticle.Text);
                                        cmd.Parameters.AddWithValue("@txtcount", txtcount.Text);
                                        cmd.Parameters.AddWithValue("@txtprice", txtprice.Text);
                                        cmd.Parameters.AddWithValue("@txtposition", txtposition.Text);

                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Помилка додавання запису!");
                                        c = 1;
                                    }
                                    finally
                                    {
                                        if (con.State == ConnectionState.Open)
                                        {
                                            con.Close();
                                        }
                                        if (c == 0)
                                            MessageBox.Show("Товар " + txtname.Text + " успішно додано!", "Повідомлення!");
                                    }
                                }
                                c = 1;
                            }
                            else
                            {
                                if (c == 0 && i == (dtArticle.Rows.Count - 1))
                                    MessageBox.Show("Заповніть всі поля! ", "Помилка!");
                            }
                        }
                        else
                        {
                            var result1 = new DialogResult();
                            result1 = MessageBox.Show("Даний товар уже є в переліку! До його кількості буде додано " + (Convert.ToInt32(txtcount.Text)) + "! Продовжити?", "Увага!",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                            if (result1 == DialogResult.Yes)
                            {
                                cmd = new OleDbCommand();
                                con.Open();
                                cmd.Connection = con;
                                OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("SELECT [count] FROM products WHERE article=" + a, con);
                                DataTable result = new DataTable();
                                dataAdapter1.Fill(result);

                                int res = Convert.ToInt32(result.Rows[0][0].ToString());
                                int count = (Convert.ToInt32(txtcount.Text)) + res;

                                string str = "(UPDATE products SET [count]=" + count + " WHERE article=" + a + ")";
                                cmd.CommandText = str;
                                cmd.ExecuteReader();

                                con.Close();
                                MessageBox.Show("Успішно! ", "Повідомлення!");
                                c = 1;
                                break;
                            }
                            else
                                c = 1;
                        }
                    }

                }
            }
            else
                MessageBox.Show("Заповніть необхідні поля! ", "Помилка!");
        }
    }
}
