using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_Club
{
    public partial class HotelScreen : Form
    {
        public HotelScreen()
        {
            InitializeComponent();
        }

        private void HotelScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            doldur();
        }



        void doldur()
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnn1;
            cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";
            sql = "select HotelName,HotelAddress,NumberOfRoom,Payment from Hotel";
            command = new SqlCommand(sql, cnn1);
            dataReader = command.ExecuteReader();
            string[] row = new string[6];
            int i;
            while (dataReader.Read())
            {
                i = 0;
                while (true)
                {
                    row[i] = dataReader.GetValue(i).ToString();
                    i++;
                    if (i == 4) break;
                }
                dataGridView1.Rows.Add(row);


            }

            dataReader.Close();
            command.Dispose();
            cnn1.Close();
        }



        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void position_label_Click(object sender, EventArgs e)
        {

        }

        private void Button_search_Click(object sender, EventArgs e)
        {

        }

        private void Button_register_Click(object sender, EventArgs e)
        {

        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            doldur();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            EnterScreen objForm2 = new EnterScreen();
            this.Hide();
            objForm2.Show();
        }
    }
}