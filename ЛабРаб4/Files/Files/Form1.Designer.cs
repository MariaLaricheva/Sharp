﻿namespace Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.FileSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameLabelShown = new System.Windows.Forms.Label();
            this.ElapsedListCreationTimeLabel = new System.Windows.Forms.Label();
            this.ElapsedListCreationTime = new System.Windows.Forms.Label();
            this.WordSearchButton = new System.Windows.Forms.Button();
            this.WordSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ElapsedWordSearchTime = new System.Windows.Forms.Label();
            this.WordListBoxClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileSelectionButton.Location = new System.Drawing.Point(681, 25);
            this.FileSelectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.FileSelectionButton.Size = new System.Drawing.Size(250, 42);
            this.FileSelectionButton.TabIndex = 0;
            this.FileSelectionButton.Text = "Выбрать файл";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // FileSelectionDialog
            // 
            this.FileSelectionDialog.FileName = "openFileDialog1";
            this.FileSelectionDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            this.FileSelectionDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSelectionDialog_FileOk);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(24, 35);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(199, 25);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "Выбранный файл: ";
            // 
            // FileNameLabelShown
            // 
            this.FileNameLabelShown.AutoEllipsis = true;
            this.FileNameLabelShown.Location = new System.Drawing.Point(228, 35);
            this.FileNameLabelShown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabelShown.Name = "FileNameLabelShown";
            this.FileNameLabelShown.Size = new System.Drawing.Size(476, 25);
            this.FileNameLabelShown.TabIndex = 2;
            this.FileNameLabelShown.Text = "Нет";
            // 
            // ElapsedListCreationTimeLabel
            // 
            this.ElapsedListCreationTimeLabel.AutoSize = true;
            this.ElapsedListCreationTimeLabel.Location = new System.Drawing.Point(24, 142);
            this.ElapsedListCreationTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElapsedListCreationTimeLabel.Name = "ElapsedListCreationTimeLabel";
            this.ElapsedListCreationTimeLabel.Size = new System.Drawing.Size(256, 25);
            this.ElapsedListCreationTimeLabel.TabIndex = 4;
            this.ElapsedListCreationTimeLabel.Text = "Время создания списка:";
            // 
            // ElapsedListCreationTime
            // 
            this.ElapsedListCreationTime.AutoSize = true;
            this.ElapsedListCreationTime.Location = new System.Drawing.Point(298, 146);
            this.ElapsedListCreationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElapsedListCreationTime.Name = "ElapsedListCreationTime";
            this.ElapsedListCreationTime.Size = new System.Drawing.Size(0, 25);
            this.ElapsedListCreationTime.TabIndex = 5;
            // 
            // WordSearchButton
            // 
            this.WordSearchButton.Enabled = false;
            this.WordSearchButton.Location = new System.Drawing.Point(681, 79);
            this.WordSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WordSearchButton.Name = "WordSearchButton";
            this.WordSearchButton.Size = new System.Drawing.Size(250, 42);
            this.WordSearchButton.TabIndex = 6;
            this.WordSearchButton.Text = "Найти слово";
            this.WordSearchButton.UseVisualStyleBackColor = true;
            this.WordSearchButton.Click += new System.EventHandler(this.WordSearchButton_Click);
            // 
            // WordSearchBox
            // 
            this.WordSearchBox.Enabled = false;
            this.WordSearchBox.Location = new System.Drawing.Point(30, 83);
            this.WordSearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WordSearchBox.Name = "WordSearchBox";
            this.WordSearchBox.Size = new System.Drawing.Size(529, 31);
            this.WordSearchBox.TabIndex = 7;
            this.WordSearchBox.Text = "Введите слово для поиска";
            this.WordSearchBox.TextChanged += new System.EventHandler(this.WordSearchBox_TextChanged);
            this.WordSearchBox.Enter += new System.EventHandler(this.WordSearchBox_Enter);
            this.WordSearchBox.Leave += new System.EventHandler(this.WordSearchBox_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(733, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Слово не найдено";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WordListBox
            // 
            this.WordListBox.Enabled = false;
            this.WordListBox.FormattingEnabled = true;
            this.WordListBox.ItemHeight = 25;
            this.WordListBox.Location = new System.Drawing.Point(30, 242);
            this.WordListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(901, 429);
            this.WordListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(555, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Статус поиска:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время поиска слова:";
            // 
            // ElapsedWordSearchTime
            // 
            this.ElapsedWordSearchTime.AutoSize = true;
            this.ElapsedWordSearchTime.Location = new System.Drawing.Point(266, 194);
            this.ElapsedWordSearchTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ElapsedWordSearchTime.Name = "ElapsedWordSearchTime";
            this.ElapsedWordSearchTime.Size = new System.Drawing.Size(0, 25);
            this.ElapsedWordSearchTime.TabIndex = 12;
            // 
            // WordListBoxClearButton
            // 
            this.WordListBoxClearButton.Enabled = false;
            this.WordListBoxClearButton.Location = new System.Drawing.Point(681, 133);
            this.WordListBoxClearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WordListBoxClearButton.Name = "WordListBoxClearButton";
            this.WordListBoxClearButton.Size = new System.Drawing.Size(250, 42);
            this.WordListBoxClearButton.TabIndex = 13;
            this.WordListBoxClearButton.Text = "Очистить список";
            this.WordListBoxClearButton.UseVisualStyleBackColor = true;
            this.WordListBoxClearButton.Click += new System.EventHandler(this.WordListBoxClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 691);
            this.Controls.Add(this.WordListBoxClearButton);
            this.Controls.Add(this.ElapsedWordSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WordListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordSearchBox);
            this.Controls.Add(this.WordSearchButton);
            this.Controls.Add(this.ElapsedListCreationTime);
            this.Controls.Add(this.ElapsedListCreationTimeLabel);
            this.Controls.Add(this.FileNameLabelShown);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSelectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Поиск слов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.OpenFileDialog FileSelectionDialog;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileNameLabelShown;
        private System.Windows.Forms.Label ElapsedListCreationTimeLabel;
        private System.Windows.Forms.Label ElapsedListCreationTime;
        private System.Windows.Forms.Button WordSearchButton;
        private System.Windows.Forms.TextBox WordSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox WordListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ElapsedWordSearchTime;
        private System.Windows.Forms.Button WordListBoxClearButton;
    }
}

