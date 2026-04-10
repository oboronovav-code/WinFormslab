namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 20, label1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
        }
    }
}
