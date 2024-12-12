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


namespace car_rental_system
{

    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\open_sourse_Project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "Select * from Customer ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            customerDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Userid.Text == "" || name.Text == "" || address.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Customer values(" + Userid.Text + ",'" + name.Text + "','" + address.Text + "','" + phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            if (Userid.Text == "" || name.Text == "" || address.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Customer set Name='" + name.Text + "',Address='" + address.Text + "',Phone='" + phone.Text + "' where ID = " + Userid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Userid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Customer where ID=" + Userid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Deleted");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void customerDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerDVG.Rows[e.RowIndex];
       
            Userid.Text = row.Cells[0].Value.ToString();
            name.Text = row.Cells[1].Value.ToString();
            address.Text = row.Cells[2].Value.ToString();
            phone.Text = row.Cells[3].Value.ToString();
            }
        }

        
    }
}










