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
    public partial class EnterScreen : Form
    {
        public EnterScreen()
        {
            InitializeComponent();

        }

        private void EnterScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FootbalPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPlayerScreen objForm3 = new FPlayerScreen();
            this.Hide();
            objForm3.Show();
        }
        /*
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=FOOTBALL_CLUB;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into Employee (EmployeeType,EFootballClubID) values ('F',(SELECT FootBallClubID FROM Football_Club WHERE ClubName= 'ANKARAGÜCÜ')) ";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            sql = " Insert into Football_Player (FirstName,LastName,BirthYear,UniformNumber,FEmployeeID) values (variable1,variable2 , ,89,23)";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            cnn.Close();


        }

    */
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TechnicalCommiteeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalCommitteeScreen objForm4 = new TechnicalCommitteeScreen();
            this.Hide();
            objForm4.Show();
        }

        private void AchievementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AchievementsScreen objForm5 = new AchievementsScreen();
            this.Hide();
            objForm5.Show(); 
        }

        private void SponsorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SponsorScreen objForm6 = new SponsorScreen();
            this.Hide();
            objForm6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TheBoardOfDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsScreen objForm7 = new DirectorsScreen();
            this.Hide();
            objForm7.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void StoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreScreen objForm8 = new StoreScreen();
            this.Hide();
            objForm8.Show();
        }

        private void SFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SportFacilityScreen objForm9 = new SportFacilityScreen();
            this.Hide();
            objForm9.Show();
        }

        private void HotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelScreen objForm10 = new HotelScreen();
            this.Hide();
            objForm10.Show();
        }

        private void VehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleScreen objForm11 = new VehicleScreen();
            this.Hide();
            objForm11.Show();
        }

        private void StadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StadiumScreen objForm12 = new StadiumScreen();
            this.Hide();
            objForm12.Show();
        }
    }
}
