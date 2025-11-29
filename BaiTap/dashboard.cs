namespace WinFormsApp1
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bt1 = new Bai1();
            bt1.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bt2 = new Bai2();
            bt2.Show();
            this.Hide();
        }
     

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bai3 bt3 = new Bai3();
            bt3.Show();
            this.Hide();
        }
    }
}
