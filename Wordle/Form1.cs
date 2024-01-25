namespace Wordle
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string word = "";
        private static readonly string[] words = Properties.Resources.words.Replace("\r","").ToUpper().Split('\n');
        public Form1()
        {
            InitializeComponent();
            GetNewWord();
        }
        // private void GetNewWord() => word = words[new System.Random().Next(words.Length - 1)];
        private void GetNewWord() => word = "LAVAS";
        private void CheckWord()
        {
            string input = mtxtInput.Text.ToUpper();
            var entry = dgvWords.Rows.Add(input[0], input[1], input[2], input[3], input[4]);
            for (int i = 0; i < 5; i++)
                dgvWords.Rows[entry].Cells[i].Style.BackColor = GetColor(input, i);
            if ((input == word && System.Windows.Forms.MessageBox.Show("CORRECT!") == System.Windows.Forms.DialogResult.OK) || (entry == 5 && System.Windows.Forms.MessageBox.Show($"FAILED!\nWord: {word}") == System.Windows.Forms.DialogResult.OK))
                dgvWords.Rows.Clear();
            mtxtInput.Text = "";
        }
        private System.Drawing.Color GetColor(string input, int i)
        {
            if (word.Contains(input[i].ToString()))
            {
                if (word[i] == input[i])
                    return System.Drawing.Color.Green;
                int count = word.Length - word.Replace(input[i].ToString(), "").Length;
                if (count == 1 && input.Length - input.Replace(input[i].ToString(), "").Length == 1)
                    return System.Drawing.Color.Yellow;
                for (int j = 0; j < 5; j++)
                {
                    if (word[j] == input[i])
                    {
                        for (int k = 0; k < 5; k++)
                            if (word[k] == input[k] && word[k] == input[i])
                                count--;
                        for (int k = 0; k < i; k++)
                            if (word[k] == input[i] && word[k] != input[k])
                                count--;
                        return count-- > 0 ? System.Drawing.Color.Yellow : System.Drawing.Color.Gray;
                    }
                }
                return count > 0 ? System.Drawing.Color.Yellow : System.Drawing.Color.Gray;
            }
            else return System.Drawing.Color.Gray;
        }
        private void maskedTextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && mtxtInput.Text.Length == 5)
                CheckWord();
        }
        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e) => dgvWords.ClearSelection();
    }
}
