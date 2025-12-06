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
            this.Hide();
            Bai1 bt1 = new Bai1();
            bt1.ShowDialog();
            this.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 bt2 = new Bai2();
            bt2.ShowDialog();
            this.Show();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 bt3 = new Bai3();
            bt3.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 bt4 = new Bai04();
            bt4.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login bt7 = new Login();
            bt7.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 bt5 = new Bai5();
            bt5.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai6 bt6 = new Bai6();
            bt6.ShowDialog();
            this.Show();
        }
    }
}
