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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void TextId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPw_TextChanged(object sender, EventArgs e)
        {
            textPw.PasswordChar = '*';
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string userId = textId.Text;
            string userPw = textPw.Text;
            Boolean flag = false;
            if (string.Equals(userId, "User Name") || string.Equals(userPw, "Password"))
            {
                labelMsg.Text = "Enter the user name and password.";
            }
            else
            {
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = FOOTBALL_CLUB; Integrated Security = True; Connect Timeout = 30";
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                String sql = "";
                sql = "select UserName,Password from Users";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if(string.Equals(userId, dataReader.GetValue(0)) && string.Equals(userPw, dataReader.GetValue(1)))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    labelMsg.Text = "Succed!";
                    EnterScreen objForm2 = new EnterScreen();
                    this.Hide();
                    objForm2.Show();
                }
                else
                {
                    labelMsg.Text = "Invalid User Name or Password!";
                }
                cnn.Close();
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
