namespace text_analizator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.labelCharCount = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelSentenceCount = new System.Windows.Forms.Label();
            this.labelUniqueWordCount = new System.Windows.Forms.Label();
            this.labelLongestWord = new System.Windows.Forms.Label();
            this.labelShortestWord = new System.Windows.Forms.Label();
            this.listBoxWordCounts = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(134, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(12, 38);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(134, 23);
            this.buttonAnalyze.TabIndex = 1;
            this.buttonAnalyze.Text = "запуск анализа";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // labelCharCount
            // 
            this.labelCharCount.AutoSize = true;
            this.labelCharCount.Location = new System.Drawing.Point(9, 132);
            this.labelCharCount.Name = "labelCharCount";
            this.labelCharCount.Size = new System.Drawing.Size(212, 13);
            this.labelCharCount.TabIndex = 2;
            this.labelCharCount.Text = " для отображения количества символов";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Location = new System.Drawing.Point(9, 155);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(35, 13);
            this.labelWordCount.TabIndex = 3;
            this.labelWordCount.Text = "label2";
            // 
            // labelSentenceCount
            // 
            this.labelSentenceCount.AutoSize = true;
            this.labelSentenceCount.Location = new System.Drawing.Point(9, 177);
            this.labelSentenceCount.Name = "labelSentenceCount";
            this.labelSentenceCount.Size = new System.Drawing.Size(35, 13);
            this.labelSentenceCount.TabIndex = 4;
            this.labelSentenceCount.Text = "label3";
            // 
            // labelUniqueWordCount
            // 
            this.labelUniqueWordCount.AutoSize = true;
            this.labelUniqueWordCount.Location = new System.Drawing.Point(9, 199);
            this.labelUniqueWordCount.Name = "labelUniqueWordCount";
            this.labelUniqueWordCount.Size = new System.Drawing.Size(35, 13);
            this.labelUniqueWordCount.TabIndex = 5;
            this.labelUniqueWordCount.Text = "label4";
            // 
            // labelLongestWord
            // 
            this.labelLongestWord.AutoSize = true;
            this.labelLongestWord.Location = new System.Drawing.Point(9, 223);
            this.labelLongestWord.Name = "labelLongestWord";
            this.labelLongestWord.Size = new System.Drawing.Size(35, 13);
            this.labelLongestWord.TabIndex = 6;
            this.labelLongestWord.Text = "label5";
            // 
            // labelShortestWord
            // 
            this.labelShortestWord.AutoSize = true;
            this.labelShortestWord.Location = new System.Drawing.Point(9, 251);
            this.labelShortestWord.Name = "labelShortestWord";
            this.labelShortestWord.Size = new System.Drawing.Size(35, 13);
            this.labelShortestWord.TabIndex = 7;
            this.labelShortestWord.Text = "label6";
            // 
            // listBoxWordCounts
            // 
            this.listBoxWordCounts.FormattingEnabled = true;
            this.listBoxWordCounts.Location = new System.Drawing.Point(152, 12);
            this.listBoxWordCounts.Name = "listBoxWordCounts";
            this.listBoxWordCounts.Size = new System.Drawing.Size(120, 95);
            this.listBoxWordCounts.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 67);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(134, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "очистка ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxWordCounts);
            this.Controls.Add(this.labelShortestWord);
            this.Controls.Add(this.labelLongestWord);
            this.Controls.Add(this.labelUniqueWordCount);
            this.Controls.Add(this.labelSentenceCount);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelCharCount);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.buttonClear_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label labelCharCount;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelSentenceCount;
        private System.Windows.Forms.Label labelUniqueWordCount;
        private System.Windows.Forms.Label labelLongestWord;
        private System.Windows.Forms.Label labelShortestWord;
        private System.Windows.Forms.ListBox listBoxWordCounts;
        private System.Windows.Forms.Button buttonClear;
    }
}

