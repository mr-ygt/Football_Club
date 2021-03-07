using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_Club
{
    public partial class FPlayerScreen : Form
    {
        public FPlayerScreen()
        {
            InitializeComponent();
        }

        private void FPlayerScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            String sql = "select FootballPlayerID,UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player";
            doldur(sql);
        }



        void doldur(string sql)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            string[] row = new string[8];
            int i;
            while (dataReader.Read())
            {
                i = 0;
                while (true)
                {
                    if (i == 2)
                    {
                        row[i] = dataReader.GetValue(i).ToString() + " " + dataReader.GetValue(i + 1).ToString();
                        i++;
                        continue;
                    }
                    else if (i == 0 || i == 1)
                    {
                        row[i] = dataReader.GetValue(i).ToString();
                        i++;
                        continue;
                    }
                    row[i] = dataReader.GetValue(i + 1).ToString();
                    i++;
                    if (i == 7) break;
                }
                dataGridView1.Rows.Add(row);


            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        string search_name, search_position, search_uniform, search_nationality;
        private void Text_name_TextChanged(object sender, EventArgs e)
        {
            search_name = text_name.Text;
        }

        private void Text_position_TextChanged(object sender, EventArgs e)
        {
            search_name = text_position.Text;
        }

        private void Text_uniform_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(text_uniform.Text, out parsedValue) || string.IsNullOrEmpty(text_uniform.Text))
            {
                search_uniform = text_uniform.Text;
            }
            else
            {
                MessageBox.Show("Uniform number should be a NUMBER!");
                return;
            }

        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            EnterScreen objForm2 = new EnterScreen();
            this.Hide();
            objForm2.Show();
        }

        private void text_nationality_TextChanged(object sender, EventArgs e)
        {
            search_nationality = text_nationality.Text;
        }
 
        public struct passvalue
        {
            public static string id;
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                passvalue.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                EditPlayer editForm = new EditPlayer(passvalue.id);
                this.Hide();
                editForm.Show();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you confirm deletion?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    int deleting_int;
                    string deleting_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    deleting_int = Convert.ToInt32(deleting_id);

                    try
                    {
                        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
                        SqlConnection cnn;
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        SqlCommand command;

                        string sql = "delete from Football_Player where FootballPlayerID=" + deleting_int;
                        command = new SqlCommand(sql, cnn);
                        //  dataReader = command.ExecuteReader();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data record deleted!", "DB Connection with App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //  dataReader.Close();
                        command.Dispose();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (string.IsNullOrEmpty(search_name) && string.IsNullOrEmpty(search_nationality) && string.IsNullOrEmpty(search_position) && string.IsNullOrEmpty(search_uniform))
            {
                string sql = "select FootballPlayerID, UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player";
                doldur(sql);
            }
            else
            {
                if (!string.IsNullOrEmpty(search_name))
                {
                    string sql = "select FootballPlayerID,UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player where CONCAT(firstname, ' ', lastname) LIKE " + "'" + search_name + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_nationality))
                {
                    string sql = "select FootballPlayerID, UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player where Nationality LIKE " + "'" + search_nationality + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_position))
                {
                    string sql = "select FootballPlayerID,UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player where Position LIKE " + "'" + search_position + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_uniform))
                {
                    string sql = "select FootballPlayerID,UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player where uniformNumber=" + "'" + search_uniform + "'";
                    doldur(sql);
                }
            }
        }

        private void Button_register_Click(object sender, EventArgs e)
        {
            EditPlayer objKisi = new EditPlayer();
            this.Hide();
            objKisi.Show();
        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sql = "select FootballPlayerID,UniformNumber,FirstName,LastName,Age, ContractYear, MarketValue, Nationality from Football_Player";
            doldur(sql);
        }
    }
}