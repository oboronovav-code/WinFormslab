namespace WinFormsApp1_variant_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number1))
            {
                if (number1 < 1 || number1 > 12)
                {
                    MessageBox.Show("The number is out of range.");
                }
            }
            if (int.TryParse(textBox2.Text, out int number2))
            {
                if (number2 < 1 || number2 > 12)
                {
                    MessageBox.Show("The number is out of range.");
                }
            }
            if (int.TryParse(textBox3.Text, out int number3))
            {
                if (number3 < 1 || number3 > 12)
                {
                    MessageBox.Show("The number is out of range.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }

            int seredniy = (number1 + number2 + number3) / 3;
            int max = Math.Max(number1, Math.Max(number2, number3));
            int min = Math.Min(number1, Math.Min(number2, number3));

            if (seredniy < 4)
            { MessageBox.Show("Максималний бал: " + max + "\n" + "Мінімальний бал: " + min + "\n" + "Рівень: початковий"); }
            else if (seredniy >= 4 && seredniy < 7)
            { MessageBox.Show("Максималний бал: " + max + "\n" + "Мінімальний бал: " + min + "\n" + "Рівень: середній"); }
            else if ( seredniy >= 7 && seredniy < 10)
            { MessageBox.Show("Максималний бал: " + max + "\n" + "Мінімальний бал: " + min + "\n" + "Рівень: достатній"); }
            else if (seredniy >= 10)
            { MessageBox.Show("Максималний бал: " + max + "\n" + "Мінімальний бал: " + min + "\n" + "Рівень: високий"); }

        }
    }
}
