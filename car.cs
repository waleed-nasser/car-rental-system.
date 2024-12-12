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
using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using System.Xml.Linq;


namespace car_rental_system
{
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\open_sourse_Project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "Select * from Car";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDVG.DataSource = ds.Tables[0];
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ReGNo_.Text == "" || Brand_.Text == "" || Model_.Text == "" || Price_.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "insert into Car values('" + ReGNo_.Text + "','" + Brand_.Text + "','" + Model_.Text + "','" + Price_.Text + "','" + Avaliable.SelectedItem.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }


        private void car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void CarDVG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CarDVG.Rows[e.RowIndex];

                ReGNo_.Text = row.Cells[0].Value.ToString();
                Brand_.Text = row.Cells[1].Value.ToString();
                Model_.Text = row.Cells[2].Value.ToString();
                Price_.Text = row.Cells[3].Value.ToString();
                Avaliable.Text = row.Cells[4].Value.ToString();
            }
        }


        private void delete_Click_1(object sender, EventArgs e)
        {
            if (ReGNo_.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Car where ReGNo= '" + ReGNo_.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Deleted");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (ReGNo_.Text == "" || Brand_.Text == "" || Model_.Text == "" || Price_.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Car set Brand='" + Brand_.Text + "', Model='" + Model_.Text + "', Available='" + Avaliable.SelectedItem.ToString() + "', Price="+ Price_.Text + "  where ReGNo= '" + ReGNo_.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
