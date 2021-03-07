using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Club
{
    public partial class EditPlayer : Form
    {
        public struct passvalue
        {
            public static string edit_id;
            public static Boolean flag = false;
        }
        public EditPlayer()
        {
            InitializeComponent();

            textFirstName.GotFocus += textFirstName_Click;
            textFirstName.Leave += textFirstName_leave;
            textLastName.GotFocus += textLastName_Click;
            textLastName.Leave += textLastName_leave;
            textPosition.GotFocus += textPosition_Click;
            textPosition.Leave += textPosition_leave;
            textBirthYear.GotFocus += textBirthYear_Click;
            textBirthYear.Leave += textBirthYear_leave;
            textMarketValue.GotFocus += textMarketValue_Click;
            textMarketValue.Leave += textMarketValue_leave;
            textContractYear.GotFocus += textContractYear_Click;
            textContractYear.Leave += textContractYear_leave;
            textSalary.GotFocus += textSalary_Click;
            textSalary.Leave += textSalary_leave;
            textUniform.GotFocus += textUniform_Click;
            textUniform.Leave += textUniform_leave;
            textNationality.GotFocus += textNationality_Click;
            textNationality.Leave += textNationality_leave;
            passvalue.flag = true;
        }
        public EditPlayer(string id)
        {
            InitializeComponent();
            passvalue.edit_id = id;
            passvalue.flag = false;


        }
        string search_name, search_position, search_uniform, search_nationality;
        private void textFirstName_Click(object sender, EventArgs e)
        {
            if (string.Equals(textFirstName.Text, "Please enter the first name."))
                textFirstName.Text = "";
        }
        private void textFirstName_leave(object sender, EventArgs e)
        {
            if (string.Equals(textFirstName.Text, ""))
                textFirstName.Text += "Please enter the first name.";
        }


        private void textLastName_Click(object sender, EventArgs e)
        {
            if (string.Equals(textLastName.Text, "Please enter the last name."))
                textLastName.Clear();
        }
        private void textLastName_leave(object sender, EventArgs e)
        {
            if (string.Equals(textLastName.Text, ""))
                textLastName.Text += "Please enter the last name.";
        }


        private void textPosition_Click(object sender, EventArgs e)
        {
            if (string.Equals(textPosition.Text, "Please enter the position."))
                textPosition.Clear();
        }
        private void textPosition_leave(object sender, EventArgs e)
        {
            if (string.Equals(textPosition.Text, ""))
                textPosition.Text += "Please enter the position.";
        }


        private void textBirthYear_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBirthYear.Text, "Please enter the birth year."))
                textBirthYear.Clear();
        }
        private void textBirthYear_leave(object sender, EventArgs e)
        {
            if (string.Equals(textBirthYear.Text, ""))
                textBirthYear.Text += "Please enter the birth year.";
        }


        private void textMarketValue_Click(object sender, EventArgs e)
        {
            if (string.Equals(textMarketValue.Text, "Please enter the market value."))
                textMarketValue.Clear();
        }
        private void textMarketValue_leave(object sender, EventArgs e)
        {
            if (string.Equals(textMarketValue.Text, ""))
                textMarketValue.Text += "Please enter the market value.";
        }


        private void textContractYear_Click(object sender, EventArgs e)
        {
            if (string.Equals(textContractYear.Text, "Please enter the contract year."))
                textContractYear.Clear();
        }
        private void textContractYear_leave(object sender, EventArgs e)
        {
            if (string.Equals(textContractYear.Text, ""))
                textContractYear.Text += "Please enter the contract year.";
        }


        private void textSalary_Click(object sender, EventArgs e)
        {
            if (string.Equals(textSalary.Text, "Please enter the salary."))
                textSalary.Clear();
        }
        private void textSalary_leave(object sender, EventArgs e)
        {
            if (string.Equals(textSalary.Text, ""))
                textSalary.Text += "Please enter the salary.";
        }


        private void textUniform_Click(object sender, EventArgs e)
        {
            if (string.Equals(textUniform.Text, "Please enter the uniform number."))
                textUniform.Clear();
        }
        private void textUniform_leave(object sender, EventArgs e)
        {
            if (string.Equals(textUniform.Text, ""))
                textUniform.Text += "Please enter the uniform number.";
        }


        private void textNationality_Click(object sender, EventArgs e)
        {
            if (string.Equals(textNationality.Text, "Please enter the nationality."))
                textNationality.Clear();
        }
        private void textNationality_leave(object sender, EventArgs e)
        {
            if (string.Equals(textNationality.Text, ""))
                textNationality.Text += "Please enter the nationality.";
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            if (passvalue.flag != true)
            {
                int edit_id = Convert.ToInt32(passvalue.edit_id);

                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                string sql = "select FirstName,LastName,Position, BirthYear,MarketValue, ContractYear,Salary,UniformNumber, Nationality from Football_Player where FootballPlayerID=" + edit_id;
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();

                textFirstName.Text = dataReader.GetValue(0).ToString();
                textLastName.Text = dataReader.GetValue(1).ToString();
                textPosition.Text = dataReader.GetValue(2).ToString();
                textBirthYear.Text = dataReader.GetValue(3).ToString();
                textMarketValue.Text = dataReader.GetValue(4).ToString();
                textContractYear.Text = dataReader.GetValue(5).ToString();
                textSalary.Text = dataReader.GetValue(6).ToString();
                textUniform.Text = dataReader.GetValue(7).ToString();
                textNationality.Text = dataReader.GetValue(8).ToString();

                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }



        }

        private void Button_list_Click(object sender, EventArgs e)
        {
            FPlayerScreen objForm2 = new FPlayerScreen();
            this.Hide();
            objForm2.Show();
        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            textFirstName.Text = "Please enter the first name.";
            textLastName.Text = "Please enter the last name.";
            textPosition.Text = "Please enter the position.";
            textBirthYear.Text = "Please enter the birth year.";
            textMarketValue.Text = "Please enter the market value.";
            textContractYear.Text = "Please enter the contract year.";
            textSalary.Text = "Please enter the salary.";
            textUniform.Text = "Please enter the uniform number.";
            textNationality.Text = "Please enter the nationality.";

        }
        private void TextUniform_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(textUniform.Text, out parsedValue) || string.IsNullOrEmpty(textUniform.Text))
            {
                search_uniform = textUniform.Text;
            }
            else
            {
                MessageBox.Show("Uniform number should be a NUMBER!");
                return;
            }
        }
        private void Button_save_Click(object sender, EventArgs e)
        {

            if (passvalue.flag != true)
            {
                string insert;
                if (textFirstName.Text != "Please enter the first name." && textLastName.Text != "Please enter the last name." && textUniform.Text != "Please enter the uniform number")
                {
                    // insert = "('" + textFirstName.Text + "','" + textLastName + "','" + ((textPosition.Text != "Please enter the position.") ? textPosition.Text : " ") + "'," + ((textBirthYear.Text != "Please enter the birth year.") ? textBirthYear.Text : "") + "," + ((textMarketValue.Text != "Please enter the market value.") ? textMarketValue.Text : "") + "," + ((textContractYear.Text != "Please enter the contract year.") ? textContractYear.Text : "") + "," + ((textSalary.Text != "Please enter the salary.") ? textSalary.Text : "") + "," + textUniform.Text + ",'" + ((textNationality.Text != "Please enter the nationality.") ? textNationality.Text : " ") + "');";
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
                    SqlConnection cnn;
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    SqlCommand command;
                    int deleting_int = Convert.ToInt32(passvalue.edit_id);
                    // string sql = "insert into [dbo].[Football_Player] ([FirstName],[LastName],[Position],[BirthYear],[MarketValue],[ContractYear],[Salary],[UniformNumber],[Nationality]) values " + insert;
                    string sql = "update Football_Player set FirstName ='" + textFirstName.Text + "', LastName = '" + textLastName.Text + "',Position='" + ((textPosition.Text != "Please enter the position.") ? textPosition.Text : " ") + "',BirthYear=" + ((textBirthYear.Text != "Please enter the birth year.") ? textBirthYear.Text : "") + ",MarketValue=" + ((textMarketValue.Text != "Please enter the market value.") ? textMarketValue.Text : "") + ",ContractYear=" + ((textContractYear.Text != "Please enter the contract year.") ? textContractYear.Text : "") + ",Salary=" + ((textSalary.Text != "Please enter the salary.") ? textSalary.Text : "") + ",UniformNumber=" + textUniform.Text + ",Nationality='" + ((textNationality.Text != "Please enter the nationality.") ? textNationality.Text : " ") + "' where FootballPlayerID=" + deleting_int;
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Successfully Changed!");
                }
                else MessageBox.Show("Enter the FIRST NAME, LAST NAME and the UNIFORM NUMBER!");
                FPlayerScreen objForm2 = new FPlayerScreen();
                this.Hide();
                objForm2.Show();
            }
            else
            {
                string insert;
                if (textFirstName.Text != "Please enter the first name." && textLastName.Text != "Please enter the last name." && search_uniform != "Please enter the uniform number")
                {
                    insert = "('" + textFirstName.Text + "','" + textLastName + "','" + ((textPosition.Text != "Please enter the position.") ? textPosition.Text : " ") + "'," + ((textBirthYear.Text != "Please enter the birth year.") ? textBirthYear.Text : " ") + "," + ((textMarketValue.Text != "Please enter the market value.") ? textMarketValue.Text : " ") + "," + ((textContractYear.Text != "Please enter the contract year.") ? textContractYear.Text : " ") + "," + ((textSalary.Text != "Please enter the salary.") ? textSalary.Text : " ") + "," + search_uniform + ",'" + ((textNationality.Text != "Please enter the nationality.") ? textNationality.Text : " ") + "')";
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
                    SqlConnection cnn;
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    SqlCommand command;
                    int deleting_int = Convert.ToInt32(passvalue.edit_id);
                    string sql = "insert into [dbo].[Football_Player] ([FirstName],[LastName],[Position],[BirthYear],[MarketValue],[ContractYear],[Salary],[UniformNumber],[Nationality]) values " + insert;
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Successfully Saved!");
                }
                else MessageBox.Show("Enter the FIRST NAME, LAST NAME and the UNIFORM NUMBER!");
                FPlayerScreen objForm2 = new FPlayerScreen();
                this.Hide();
                objForm2.Show();
            }
        }

        private void TextFirstName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
