using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace galery
{
    public partial class Form1 : Form
    {
        private List<string> memePaths = new List<string>();
        // ≤ндекс поточного мему
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            LoadMemes();
            UpdateDisplay();
        }

        private void LoadMemes()
        {
            string folderPath = Path.Combine(Application.StartupPath, "memes");

            if (Directory.Exists(folderPath))
            {
                memePaths.AddRange(Directory.GetFiles(folderPath, "*.jpg"));
                memePaths.AddRange(Directory.GetFiles(folderPath, "*.png"));
                memePaths.AddRange(Directory.GetFiles(folderPath, "*.jpeg"));
            }

            // якщо папка порожн€, додамо перев≥рку
            if (memePaths.Count == 0)
            {
                MessageBox.Show("ƒодай меми у папку 'memes'!");
            }
        }

        private void UpdateDisplay()
        {
            if (memePaths.Count > 0)
            {
                pictureBox1.Image = Image.FromFile(memePaths[currentIndex]);

                // ¬иводимо номер мему в заголовок (опц≥онально)
                this.Text = $"ћем {currentIndex + 1} ≥з {memePaths.Count}";
            }
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (memePaths.Count == 0) return;

            // «меншуЇмо ≥ндекс, €кщо на початку Ч йдемо в к≥нець
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = memePaths.Count - 1;
            }
            UpdateDisplay();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (memePaths.Count == 0) return;

            // «б≥льшуЇмо ≥ндекс, €кщо д≥йшли до к≥нц€ Ч переходимо на початок
            currentIndex++;
            if (currentIndex >= memePaths.Count)
            {
                currentIndex = 0;
            }
            UpdateDisplay();
        }
    }
}
