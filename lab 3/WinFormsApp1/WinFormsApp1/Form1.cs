namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснули button4");

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            MessageBox.Show("Написано не натискай, читати не вмієш?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснули button1");

            MessageBox.Show("Привіт");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснули button2");

            label1.Text = "І що ти хотів ?";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснули button3");

            textBox1.Text = "подобаєтья?";
        }
    }
}