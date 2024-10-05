using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_analizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите текст для анализа");
                return;
            }

            int charCount = text.Length;
            int wordCount = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int sentenceCount = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

            var uniqueWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .Distinct()
                .ToList();

            int uniqueWordCount = uniqueWords.Count;

            string longestWord = uniqueWords.OrderByDescending(w => w.Length).First();
            string shortestWord = uniqueWords.OrderBy(w => w.Length).First();

            labelCharCount.Text = $"Количество символов: {charCount}";
            labelWordCount.Text = $"Количество слов: {wordCount}";
            labelSentenceCount.Text = $"Количество предложений: {sentenceCount}";
            labelUniqueWordCount.Text = $"Количество уникальных слов: {uniqueWordCount}";
            labelLongestWord.Text = $"Самое длинное слово: {longestWord}";
            labelShortestWord.Text = $"Самое короткое слово: {shortestWord}";

            // Подсчет количества каждого уникального слова
            var wordCounts = uniqueWords.ToDictionary(w => w, w => text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count(t => t.ToLower() == w));
            listBoxWordCounts.DataSource = wordCounts.ToList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            labelCharCount.Text = string.Empty;
            labelWordCount.Text = string.Empty;
            labelSentenceCount.Text = string.Empty;
            labelUniqueWordCount.Text = string.Empty;
            labelLongestWord.Text = string.Empty;
            labelShortestWord.Text = string.Empty;
            listBoxWordCounts.DataSource = null;
        }
    }
}