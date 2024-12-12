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

namespace car_rental_system
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\openSourse_project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");
        private void DashBoard_Load(object sender, EventArgs e)   // Event handler called when the form loads
        {
            // Count the number of cars in the CarTbl table
            string querycar = "Select Count(*) from CarTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CarLbl.Text = dt.Rows[0][0].ToString();

            // Count the number of customers in the CarTbl table
            string querycust = "Select Count(*) from CarTbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CustLbl.Text = dt1.Rows[0][0].ToString();

            // Count the number of users in the CarTbl table
            string queryuser = "Select Count(*) from CarTbl";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            userLbl.Text = dt2.Rows[0][0].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LGlabel1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home main = new Home();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
