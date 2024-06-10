namespace Lab4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai.Bai1 bai1 = new Bai.Bai1();
            bai1.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            Bai.Bai2 bai2 = new Bai.Bai2();
            bai2.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            Bai.Bai3 bai3 = new Bai.Bai3();
            bai3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai.BAI4 bai4 = new Bai.BAI4();
            bai4.Show();
        }
    }
}
