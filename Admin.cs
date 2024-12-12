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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\open_sourse_Project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");

        private void populate()
        {
            con.Open();
            string query = "Select * from AdminTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AdminDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "" || Aname.Text == "" || Apass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AdminTbl values(" + Aid.Text + ",'" + Aname.Text + "','" + Apass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Successfully Added");
                    con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            populate();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from AdminTbl where id =" + Aid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Successfully Deleted");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "" || Aname.Text == "" || Apass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update AdminTbl set Name='" + Aname.Text + "',Password='" + Apass.Text + "' where id = " + Aid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Successfully Updated");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home main = new Home();
            main.Show();


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDVG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AdminDVG.Rows[e.RowIndex];

                Aid.Text = row.Cells[0].Value.ToString();
                Aname.Text = row.Cells[1].Value.ToString();
                Apass.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}

