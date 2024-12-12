namespace car_rental_system
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            splash_prbar.Increment(2);
            if (splash_prbar.Value == 100)
            {
                timer1.Enabled = false;
                Login Lg = new Login();
                Lg.Show();
                this.Hide();
            }
        }

    }
}
