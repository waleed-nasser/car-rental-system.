using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace car_rental_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\open_sourse_Project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select count(*) from AdminTbl where Name='" + Aname.Text + "' and Password ='" + Apass.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("name or password is not correct");
                Aname.Clear();
                Apass.Clear();
                Aname.Focus();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Aname.Clear();
            Apass.Clear();
        }

        
    }
}
