namespace saper
{
    public partial class Form1 : Form
    {
        int size = 10; 
        int cellSize = 40;
        Random random = new Random();

        public Form1()
        {
            this.Text = "Найпростіший Сапер";
            this.Size = new Size(420, 450);

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(cellSize, cellSize);
                    btn.Location = new Point(x * cellSize, y * cellSize);

                    // Шанс 15%, що в клітинці буде міна (зберігаємо це в Tag)
                    btn.Tag = (random.Next(0, 100) < 15) ? "mine" : "empty";

                    btn.Click += Button_Click;
                    this.Controls.Add(btn);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Tag.ToString() == "mine")
            {
                clickedButton.BackColor = Color.Red;
                clickedButton.Text = "";
                MessageBox.Show("БАБАХ! Ви наступили на міну.");
                Application.Restart(); 
            }
            else
            {
                clickedButton.BackColor = Color.LightGreen;
                clickedButton.Enabled = false; 
                clickedButton.Text = "";
            }
        }
    }
}
