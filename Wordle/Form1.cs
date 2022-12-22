using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form1 : Form
    {
        private string word = "";
        private static string[] words = Properties.Resources.words.Replace("\r","").ToUpper().Split('\n');
        private string currWord = "";
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            GetNewWord();
        }
        private void GetNewWord() => word = words[rand.Next(words.Length - 1)];
        private void CheckWord()
        {
            currWord = maskedTextBox1.Text.ToUpper();
            var entry = dataGridView1.Rows.Add(currWord[0], currWord[1], currWord[2], currWord[3], currWord[4]);
            for (int i = 0; i < 5; i++)
            {
                if (word[i] == currWord[i])
                    dataGridView1.Rows[entry].Cells[i].Style.BackColor = Color.Green;
                else if (!word.Contains(currWord[i]))
                    dataGridView1.Rows[entry].Cells[i].Style.BackColor = Color.Gray;
                else
                {
                    int count = word.Count(t => t == currWord[i]);
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridView1.Rows[entry].Cells[i].Style.BackColor = Color.Yellow;
                        if (dataGridView1.Rows[entry].Cells[j].Style.BackColor == Color.Green && dataGridView1.Rows[entry].Cells[j].Value.ToString() == currWord[i].ToString())
                        {
                            count--;
                        }
                    }
                    if (count <= 0)
                        dataGridView1.Rows[entry].Cells[i].Style.BackColor = Color.Gray;
                }
            }
            if (currWord == word)
            {
                MessageBox.Show("CORRECT!");
                dataGridView1.Rows.Clear();
            }
            else if (entry == 5)
            {
                MessageBox.Show($"FAILED!\nWord: {word}");
                GetNewWord();
                dataGridView1.Rows.Clear();
            }
            maskedTextBox1.Text = "";
        }
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckWord();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) => dataGridView1.ClearSelection();
    }
}
