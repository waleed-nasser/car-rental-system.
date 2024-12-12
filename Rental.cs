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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SHAHD\Downloads\my-github\open_sourse_Project\car rental systemsol\car rental system\database\carRental.mdf"";Integrated Security=True");
        private void fillcombo()
        {
            con.Open();
            string query = "select  ReGNo from Car";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ReGNo", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "ReGNo";
            CarRegCb.DataSource = dt;
            con.Close();
        }
        private void fillCustomer()
        {
            con.Open();
            string query = "select  ID from Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Load(rdr);
            CustCb.ValueMember = "ID";
            CustCb.DataSource = dt;
            con.Close();
        }
        private void fetchCustName()
        {

        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
