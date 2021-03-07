using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_Club
{
    public partial class TechnicalCommitteeScreen : Form
    {
        public TechnicalCommitteeScreen()
        {
            InitializeComponent();
        }

        private void TechnicalCommitteeScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            String sql = "select TechnicalID,FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee";
            doldur(sql);
        }



        void doldur(string sql)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnn1;
            cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, cnn1);
            dataReader = command.ExecuteReader();
            string[] row = new string[7];
            int i;
            while (dataReader.Read())
            {
                i = 0;
                while (true)
                {
                    if (i == 1)
                    {
                        row[i] = dataReader.GetValue(i).ToString() + " " + dataReader.GetValue(i + 1).ToString();
                        i++;
                        continue;
                    }
                    else if (i == 0)
                    {
                        row[i] = dataReader.GetValue(i).ToString();
                        i++;
                        continue;
                    }

                    row[i] = dataReader.GetValue(i + 1).ToString();
                    i++;
                    if (i == 6) break;
                }
                dataGridView1.Rows.Add(row);


            }

            dataReader.Close();
            command.Dispose();
            cnn1.Close();
        }

        string search_name, search_title, search_age, search_contract;
        private void Text_name_TextChanged(object sender, EventArgs e)
        {
            search_name = text_name.Text;
        }

        private void Text_title_TextChanged(object sender, EventArgs e)
        {
            search_title = text_title.Text;
        }

        private void Text_age_TextChanged(object sender, EventArgs e)
        {
            search_age = text_age.Text;
        }


        private void Text_contract_TextChanged(object sender, EventArgs e)
        {
            search_contract = text_contract.Text;
        }
 

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void position_label_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            EnterScreen objForm2 = new EnterScreen();
            this.Hide();
            objForm2.Show();
        }

        private void age_label_Click(object sender, EventArgs e)
        {

        }

        private void contract_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
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

                        string sql = "delete from Technical_Committee where TechnicalID=" + deleting_int;
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
            if (string.IsNullOrEmpty(search_name) && string.IsNullOrEmpty(search_contract) && string.IsNullOrEmpty(search_title) && string.IsNullOrEmpty(search_age))
            {
                string sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee";
                doldur(sql);
            }
            else
            {
                if (!string.IsNullOrEmpty(search_name))
                {
                    string sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee where CONCAT(firstname, ' ', lastname) LIKE " + "'" + search_name + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_contract))
                {
                    string sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee where Nationality LIKE " + "'" + search_contract + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_title))
                {
                    string sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee where Title LIKE " + "'" + search_title + "%'";
                    doldur(sql);
                }
                if (!string.IsNullOrEmpty(search_age))
                {
                    string sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee where Age=" + "'" + search_age + "'";
                    doldur(sql);
                }
            }
        }

        private void Button_register_Click(object sender, EventArgs e)
        {

        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            String sql = "select FirstName,LastName,Title,Age, ContractYear, Salary from Technical_Committee";
            doldur(sql);
        }
    }
}