namespace WinFormsTask18_19
{
    partial class FormPublications
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            bookPage = new TabPage();
            buttonBookAdd = new Button();
            labelBookPublisher = new Label();
            textBookPublisher = new TextBox();
            labelBookYear = new Label();
            textBookYear = new TextBox();
            BookAuthor = new Label();
            textBookAuthor = new TextBox();
            labelBookTitle = new Label();
            BookTitle = new TextBox();
            dataGridViewBook = new DataGridView();
            ColumTitle = new DataGridViewTextBoxColumn();
            ColumnAuthor = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnPublisher = new DataGridViewTextBoxColumn();
            buttonBookDelete = new Button();
            textBoxBookSearch = new TextBox();
            buttonBookSearch = new Button();
            articlePage = new TabPage();
            buttonArtAdd = new Button();
            labelArtTitle = new Label();
            ArtTitle = new TextBox();
            labelArtJournal = new Label();
            textArtJournal = new TextBox();
            labelArtNum = new Label();
            textArtNuml = new TextBox();
            labelArtYear = new Label();
            textArtYear = new TextBox();
            labelArtNumber = new Label();
            textArtNumber = new TextBox();
            ArtAuthor = new Label();
            textArtAuthor = new TextBox();
            buttonArtDelete = new Button();
            dataGridViewArt = new DataGridView();
            ColumArtTitle = new DataGridViewTextBoxColumn();
            ColumnArtAuthor = new DataGridViewTextBoxColumn();
            ColumnArtJournal = new DataGridViewTextBoxColumn();
            ColumnArtNum = new DataGridViewTextBoxColumn();
            ColumnArtYear = new DataGridViewTextBoxColumn();
            textBoxArtSearch = new TextBox();
            buttonArtSearch = new Button();
            eresourcePage = new TabPage();
            buttonEResAdd = new Button();
            labelEResTitle = new Label();
            textEResTitle = new TextBox();
            labelEResAuthor = new Label();
            textEResAuthor = new TextBox();
            labelEResLink = new Label();
            textEResLink = new TextBox();
            labelEResAnnotation = new Label();
            textEResAnnotation = new TextBox();
            buttonEResDelete = new Button();
            dataGridViewERes = new DataGridView();
            ColumnEResTitle = new DataGridViewTextBoxColumn();
            ColumnEResAuthor = new DataGridViewTextBoxColumn();
            ColumnEResLink = new DataGridViewTextBoxColumn();
            ColumnEResAnnotation = new DataGridViewTextBoxColumn();
            textBoxEResSearch = new TextBox();
            buttonEResSearch = new Button();
            tabControl1.SuspendLayout();
            bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            articlePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArt).BeginInit();
            eresourcePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewERes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(bookPage);
            tabControl1.Controls.Add(articlePage);
            tabControl1.Controls.Add(eresourcePage);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1066, 449);
            tabControl1.TabIndex = 0;
            // 
            // bookPage
            // 
            bookPage.Controls.Add(buttonBookAdd);
            bookPage.Controls.Add(labelBookPublisher);
            bookPage.Controls.Add(textBookPublisher);
            bookPage.Controls.Add(labelBookYear);
            bookPage.Controls.Add(textBookYear);
            bookPage.Controls.Add(BookAuthor);
            bookPage.Controls.Add(textBookAuthor);
            bookPage.Controls.Add(labelBookTitle);
            bookPage.Controls.Add(BookTitle);
            bookPage.Controls.Add(dataGridViewBook);
            bookPage.Controls.Add(buttonBookDelete);
            bookPage.Controls.Add(textBoxBookSearch);
            bookPage.Controls.Add(buttonBookSearch);
            bookPage.Location = new Point(4, 29);
            bookPage.Name = "bookPage";
            bookPage.Padding = new Padding(3);
            bookPage.Size = new Size(1058, 416);
            bookPage.TabIndex = 0;
            bookPage.Text = "Book";
            bookPage.UseVisualStyleBackColor = true;
            // 
            // buttonBookAdd
            // 
            buttonBookAdd.Location = new Point(34, 267);
            buttonBookAdd.Name = "buttonBookAdd";
            buttonBookAdd.Size = new Size(142, 43);
            buttonBookAdd.TabIndex = 9;
            buttonBookAdd.Text = "Добавить книгу";
            buttonBookAdd.UseVisualStyleBackColor = true;
            buttonBookAdd.Click += buttonBookAdd_Click_1;
            // 
            // labelBookPublisher
            // 
            labelBookPublisher.AutoSize = true;
            labelBookPublisher.Location = new Point(6, 194);
            labelBookPublisher.Name = "labelBookPublisher";
            labelBookPublisher.Size = new Size(205, 20);
            labelBookPublisher.TabIndex = 8;
            labelBookPublisher.Text = "Введите издательство книги";
            // 
            // textBookPublisher
            // 
            textBookPublisher.Location = new Point(9, 213);
            textBookPublisher.Name = "textBookPublisher";
            textBookPublisher.Size = new Size(195, 27);
            textBookPublisher.TabIndex = 7;
            // 
            // labelBookYear
            // 
            labelBookYear.AutoSize = true;
            labelBookYear.Location = new Point(6, 129);
            labelBookYear.Name = "labelBookYear";
            labelBookYear.Size = new Size(198, 20);
            labelBookYear.TabIndex = 6;
            labelBookYear.Text = "Введите год издания книги";
            // 
            // textBookYear
            // 
            textBookYear.Location = new Point(9, 148);
            textBookYear.Name = "textBookYear";
            textBookYear.Size = new Size(195, 27);
            textBookYear.TabIndex = 5;
            // 
            // BookAuthor
            // 
            BookAuthor.AutoSize = true;
            BookAuthor.Location = new Point(6, 65);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(161, 20);
            BookAuthor.TabIndex = 4;
            BookAuthor.Text = "Введите автора книги";
            // 
            // textBookAuthor
            // 
            textBookAuthor.Location = new Point(9, 84);
            textBookAuthor.Name = "textBookAuthor";
            textBookAuthor.Size = new Size(195, 27);
            textBookAuthor.TabIndex = 3;
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Location = new Point(6, 3);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(179, 20);
            labelBookTitle.TabIndex = 2;
            labelBookTitle.Text = "Введите название книги";
            // 
            // BookTitle
            // 
            BookTitle.Location = new Point(9, 22);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(195, 27);
            BookTitle.TabIndex = 1;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.BackgroundColor = Color.Beige;
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Columns.AddRange(new DataGridViewColumn[] { ColumTitle, ColumnAuthor, ColumnYear, ColumnPublisher });
            dataGridViewBook.Location = new Point(240, 0);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.RowTemplate.Height = 24;
            dataGridViewBook.Size = new Size(552, 420);
            dataGridViewBook.TabIndex = 0;
            // 
            // ColumTitle
            // 
            ColumTitle.HeaderText = "Название";
            ColumTitle.MinimumWidth = 6;
            ColumTitle.Name = "ColumTitle";
            ColumTitle.ReadOnly = true;
            ColumTitle.Width = 125;
            // 
            // ColumnAuthor
            // 
            ColumnAuthor.HeaderText = "Автор";
            ColumnAuthor.MinimumWidth = 6;
            ColumnAuthor.Name = "ColumnAuthor";
            ColumnAuthor.ReadOnly = true;
            ColumnAuthor.Width = 125;
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "Год";
            ColumnYear.MinimumWidth = 6;
            ColumnYear.Name = "ColumnYear";
            ColumnYear.ReadOnly = true;
            ColumnYear.Width = 125;
            // 
            // ColumnPublisher
            // 
            ColumnPublisher.HeaderText = "Издательство";
            ColumnPublisher.MinimumWidth = 6;
            ColumnPublisher.Name = "ColumnPublisher";
            ColumnPublisher.ReadOnly = true;
            ColumnPublisher.Width = 125;
            // 
            // buttonBookDelete
            // 
            buttonBookDelete.Location = new Point(861, 367);
            buttonBookDelete.Name = "buttonBookDelete";
            buttonBookDelete.Size = new Size(120, 30);
            buttonBookDelete.TabIndex = 10;
            buttonBookDelete.Text = "Удалить книгу";
            buttonBookDelete.UseVisualStyleBackColor = true;
            buttonBookDelete.Click += buttonBookDelete_Click;
            // 
            // textBoxBookSearch
            // 
            textBoxBookSearch.Location = new Point(829, 8);
            textBoxBookSearch.Name = "textBoxBookSearch";
            textBoxBookSearch.Size = new Size(200, 27);
            textBoxBookSearch.TabIndex = 11;
            // 
            // buttonBookSearch
            // 
            buttonBookSearch.Location = new Point(871, 41);
            buttonBookSearch.Name = "buttonBookSearch";
            buttonBookSearch.Size = new Size(120, 53);
            buttonBookSearch.TabIndex = 12;
            buttonBookSearch.Text = "Поиск по автору";
            buttonBookSearch.Click += buttonBookSearch_Click;
            // 
            // articlePage
            // 
            articlePage.Controls.Add(buttonArtAdd);
            articlePage.Controls.Add(labelArtTitle);
            articlePage.Controls.Add(ArtTitle);
            articlePage.Controls.Add(labelArtJournal);
            articlePage.Controls.Add(textArtJournal);
            articlePage.Controls.Add(labelArtNum);
            articlePage.Controls.Add(textArtNuml);
            articlePage.Controls.Add(labelArtYear);
            articlePage.Controls.Add(textArtYear);
            articlePage.Controls.Add(labelArtNumber);
            articlePage.Controls.Add(textArtNumber);
            articlePage.Controls.Add(ArtAuthor);
            articlePage.Controls.Add(textArtAuthor);
            articlePage.Controls.Add(buttonArtDelete);
            articlePage.Controls.Add(dataGridViewArt);
            articlePage.Controls.Add(textBoxArtSearch);
            articlePage.Controls.Add(buttonArtSearch);
            articlePage.Location = new Point(4, 29);
            articlePage.Name = "articlePage";
            articlePage.Padding = new Padding(3);
            articlePage.Size = new Size(1058, 416);
            articlePage.TabIndex = 1;
            articlePage.Text = "Article";
            articlePage.UseVisualStyleBackColor = true;
            articlePage.Click += articlePage_Click;
            // 
            // buttonArtAdd
            // 
            buttonArtAdd.Location = new Point(26, 336);
            buttonArtAdd.Name = "buttonArtAdd";
            buttonArtAdd.Size = new Size(142, 45);
            buttonArtAdd.TabIndex = 19;
            buttonArtAdd.Text = "Добавить статью";
            buttonArtAdd.UseVisualStyleBackColor = true;
            buttonArtAdd.Click += buttonArtAdd_Click_1;
            // 
            // labelArtTitle
            // 
            labelArtTitle.AutoSize = true;
            labelArtTitle.Location = new Point(3, 3);
            labelArtTitle.Name = "labelArtTitle";
            labelArtTitle.Size = new Size(183, 20);
            labelArtTitle.TabIndex = 12;
            labelArtTitle.Text = "Введите название статьи";
            // 
            // ArtTitle
            // 
            ArtTitle.Location = new Point(6, 22);
            ArtTitle.Name = "ArtTitle";
            ArtTitle.Size = new Size(195, 27);
            ArtTitle.TabIndex = 11;
            // 
            // labelArtJournal
            // 
            labelArtJournal.AutoSize = true;
            labelArtJournal.Location = new Point(6, 123);
            labelArtJournal.Name = "labelArtJournal";
            labelArtJournal.Size = new Size(199, 20);
            labelArtJournal.TabIndex = 18;
            labelArtJournal.Text = "Введите название журнала";
            // 
            // textArtJournal
            // 
            textArtJournal.Location = new Point(9, 146);
            textArtJournal.Name = "textArtJournal";
            textArtJournal.Size = new Size(195, 27);
            textArtJournal.TabIndex = 17;
            // 
            // labelArtNum
            // 
            labelArtNum.Location = new Point(0, 0);
            labelArtNum.Name = "labelArtNum";
            labelArtNum.Size = new Size(100, 23);
            labelArtNum.TabIndex = 20;
            // 
            // textArtNuml
            // 
            textArtNuml.Location = new Point(0, 0);
            textArtNuml.Name = "textArtNuml";
            textArtNuml.Size = new Size(100, 27);
            textArtNuml.TabIndex = 21;
            // 
            // labelArtYear
            // 
            labelArtYear.AutoSize = true;
            labelArtYear.Location = new Point(3, 275);
            labelArtYear.Name = "labelArtYear";
            labelArtYear.Size = new Size(180, 20);
            labelArtYear.TabIndex = 16;
            labelArtYear.Text = "Введите год публикации";
            // 
            // textArtYear
            // 
            textArtYear.Location = new Point(6, 294);
            textArtYear.Name = "textArtYear";
            textArtYear.Size = new Size(195, 27);
            textArtYear.TabIndex = 15;
            // 
            // labelArtNumber
            // 
            labelArtNumber.Location = new Point(9, 194);
            labelArtNumber.Name = "labelArtNumber";
            labelArtNumber.Size = new Size(100, 21);
            labelArtNumber.TabIndex = 22;
            labelArtNumber.Text = "Номер:";
            // 
            // textArtNumber
            // 
            textArtNumber.Location = new Point(9, 226);
            textArtNumber.Name = "textArtNumber";
            textArtNumber.Size = new Size(195, 27);
            textArtNumber.TabIndex = 23;
            // 
            // ArtAuthor
            // 
            ArtAuthor.AutoSize = true;
            ArtAuthor.Location = new Point(3, 65);
            ArtAuthor.Name = "ArtAuthor";
            ArtAuthor.Size = new Size(165, 20);
            ArtAuthor.TabIndex = 14;
            ArtAuthor.Text = "Введите автора статьи";
            // 
            // textArtAuthor
            // 
            textArtAuthor.Location = new Point(6, 84);
            textArtAuthor.Name = "textArtAuthor";
            textArtAuthor.Size = new Size(195, 27);
            textArtAuthor.TabIndex = 13;
            // 
            // buttonArtDelete
            // 
            buttonArtDelete.Location = new Point(917, 367);
            buttonArtDelete.Name = "buttonArtDelete";
            buttonArtDelete.Size = new Size(120, 30);
            buttonArtDelete.TabIndex = 24;
            buttonArtDelete.Text = "Удалить статью";
            buttonArtDelete.UseVisualStyleBackColor = true;
            buttonArtDelete.Click += buttonArtDelete_Click;
            // 
            // dataGridViewArt
            // 
            dataGridViewArt.BackgroundColor = Color.Beige;
            dataGridViewArt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArt.Columns.AddRange(new DataGridViewColumn[] { ColumArtTitle, ColumnArtAuthor, ColumnArtJournal, ColumnArtNum, ColumnArtYear });
            dataGridViewArt.Location = new Point(234, 3);
            dataGridViewArt.Name = "dataGridViewArt";
            dataGridViewArt.ReadOnly = true;
            dataGridViewArt.RowHeadersWidth = 51;
            dataGridViewArt.RowTemplate.Height = 24;
            dataGridViewArt.Size = new Size(651, 420);
            dataGridViewArt.TabIndex = 10;
            // 
            // ColumArtTitle
            // 
            ColumArtTitle.HeaderText = "Название";
            ColumArtTitle.MinimumWidth = 6;
            ColumArtTitle.Name = "ColumArtTitle";
            ColumArtTitle.ReadOnly = true;
            ColumArtTitle.Width = 125;
            // 
            // ColumnArtAuthor
            // 
            ColumnArtAuthor.HeaderText = "Автор";
            ColumnArtAuthor.MinimumWidth = 6;
            ColumnArtAuthor.Name = "ColumnArtAuthor";
            ColumnArtAuthor.ReadOnly = true;
            ColumnArtAuthor.Width = 125;
            // 
            // ColumnArtJournal
            // 
            ColumnArtJournal.HeaderText = "Журнал";
            ColumnArtJournal.MinimumWidth = 6;
            ColumnArtJournal.Name = "ColumnArtJournal";
            ColumnArtJournal.ReadOnly = true;
            ColumnArtJournal.Width = 125;
            // 
            // ColumnArtNum
            // 
            ColumnArtNum.HeaderText = "Номер";
            ColumnArtNum.MinimumWidth = 6;
            ColumnArtNum.Name = "ColumnArtNum";
            ColumnArtNum.ReadOnly = true;
            ColumnArtNum.Width = 125;
            // 
            // ColumnArtYear
            // 
            ColumnArtYear.HeaderText = "Год";
            ColumnArtYear.MinimumWidth = 6;
            ColumnArtYear.Name = "ColumnArtYear";
            ColumnArtYear.ReadOnly = true;
            ColumnArtYear.Width = 125;
            // 
            // textBoxArtSearch
            // 
            textBoxArtSearch.Location = new Point(914, 10);
            textBoxArtSearch.Name = "textBoxArtSearch";
            textBoxArtSearch.Size = new Size(123, 27);
            textBoxArtSearch.TabIndex = 25;
            // 
            // buttonArtSearch
            // 
            buttonArtSearch.Location = new Point(914, 43);
            buttonArtSearch.Name = "buttonArtSearch";
            buttonArtSearch.Size = new Size(120, 58);
            buttonArtSearch.TabIndex = 26;
            buttonArtSearch.Text = "Поиск по автору";
            buttonArtSearch.Click += buttonArtSearch_Click;
            // 
            // eresourcePage
            // 
            eresourcePage.Controls.Add(buttonEResAdd);
            eresourcePage.Controls.Add(labelEResTitle);
            eresourcePage.Controls.Add(textEResTitle);
            eresourcePage.Controls.Add(labelEResAuthor);
            eresourcePage.Controls.Add(textEResAuthor);
            eresourcePage.Controls.Add(labelEResLink);
            eresourcePage.Controls.Add(textEResLink);
            eresourcePage.Controls.Add(labelEResAnnotation);
            eresourcePage.Controls.Add(textEResAnnotation);
            eresourcePage.Controls.Add(buttonEResDelete);
            eresourcePage.Controls.Add(dataGridViewERes);
            eresourcePage.Controls.Add(textBoxEResSearch);
            eresourcePage.Controls.Add(buttonEResSearch);
            eresourcePage.Location = new Point(4, 29);
            eresourcePage.Name = "eresourcePage";
            eresourcePage.Padding = new Padding(3);
            eresourcePage.Size = new Size(1058, 416);
            eresourcePage.TabIndex = 2;
            eresourcePage.Text = "EResource";
            eresourcePage.UseVisualStyleBackColor = true;
            // 
            // buttonEResAdd
            // 
            buttonEResAdd.Location = new Point(25, 325);
            buttonEResAdd.Name = "buttonEResAdd";
            buttonEResAdd.Size = new Size(160, 51);
            buttonEResAdd.TabIndex = 19;
            buttonEResAdd.Text = "Добавить ресурс";
            buttonEResAdd.UseVisualStyleBackColor = true;
            buttonEResAdd.Click += buttonEResAdd_Click_1;
            // 
            // labelEResTitle
            // 
            labelEResTitle.AutoSize = true;
            labelEResTitle.Location = new Point(3, 19);
            labelEResTitle.Name = "labelEResTitle";
            labelEResTitle.Size = new Size(135, 20);
            labelEResTitle.TabIndex = 12;
            labelEResTitle.Text = "Введите название";
            // 
            // textEResTitle
            // 
            textEResTitle.Location = new Point(6, 38);
            textEResTitle.Name = "textEResTitle";
            textEResTitle.Size = new Size(195, 27);
            textEResTitle.TabIndex = 11;
            // 
            // labelEResAuthor
            // 
            labelEResAuthor.AutoSize = true;
            labelEResAuthor.Location = new Point(3, 81);
            labelEResAuthor.Name = "labelEResAuthor";
            labelEResAuthor.Size = new Size(117, 20);
            labelEResAuthor.TabIndex = 14;
            labelEResAuthor.Text = "Введите автора";
            // 
            // textEResAuthor
            // 
            textEResAuthor.Location = new Point(6, 100);
            textEResAuthor.Name = "textEResAuthor";
            textEResAuthor.Size = new Size(195, 27);
            textEResAuthor.TabIndex = 13;
            // 
            // labelEResLink
            // 
            labelEResLink.AutoSize = true;
            labelEResLink.Location = new Point(3, 147);
            labelEResLink.Name = "labelEResLink";
            labelEResLink.Size = new Size(116, 20);
            labelEResLink.TabIndex = 16;
            labelEResLink.Text = "Введите ссылку";
            // 
            // textEResLink
            // 
            textEResLink.Location = new Point(6, 166);
            textEResLink.Name = "textEResLink";
            textEResLink.Size = new Size(195, 27);
            textEResLink.TabIndex = 15;
            // 
            // labelEResAnnotation
            // 
            labelEResAnnotation.AutoSize = true;
            labelEResAnnotation.Location = new Point(3, 211);
            labelEResAnnotation.Name = "labelEResAnnotation";
            labelEResAnnotation.Size = new Size(148, 20);
            labelEResAnnotation.TabIndex = 18;
            labelEResAnnotation.Text = "Введите аннотацию";
            // 
            // textEResAnnotation
            // 
            textEResAnnotation.Location = new Point(6, 230);
            textEResAnnotation.Multiline = true;
            textEResAnnotation.Name = "textEResAnnotation";
            textEResAnnotation.Size = new Size(195, 57);
            textEResAnnotation.TabIndex = 17;
            // 
            // buttonEResDelete
            // 
            buttonEResDelete.Location = new Point(864, 366);
            buttonEResDelete.Name = "buttonEResDelete";
            buttonEResDelete.Size = new Size(120, 30);
            buttonEResDelete.TabIndex = 18;
            buttonEResDelete.Text = "Удалить ресурс";
            buttonEResDelete.UseVisualStyleBackColor = true;
            buttonEResDelete.Click += buttonEResDelete_Click;
            // 
            // dataGridViewERes
            // 
            dataGridViewERes.BackgroundColor = Color.Beige;
            dataGridViewERes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewERes.Columns.AddRange(new DataGridViewColumn[] { ColumnEResTitle, ColumnEResAuthor, ColumnEResLink, ColumnEResAnnotation });
            dataGridViewERes.Location = new Point(237, 0);
            dataGridViewERes.Name = "dataGridViewERes";
            dataGridViewERes.ReadOnly = true;
            dataGridViewERes.RowHeadersWidth = 51;
            dataGridViewERes.RowTemplate.Height = 24;
            dataGridViewERes.Size = new Size(552, 420);
            dataGridViewERes.TabIndex = 10;
            // 
            // ColumnEResTitle
            // 
            ColumnEResTitle.HeaderText = "Название";
            ColumnEResTitle.MinimumWidth = 6;
            ColumnEResTitle.Name = "ColumnEResTitle";
            ColumnEResTitle.ReadOnly = true;
            ColumnEResTitle.Width = 125;
            // 
            // ColumnEResAuthor
            // 
            ColumnEResAuthor.HeaderText = "Автор";
            ColumnEResAuthor.MinimumWidth = 6;
            ColumnEResAuthor.Name = "ColumnEResAuthor";
            ColumnEResAuthor.ReadOnly = true;
            ColumnEResAuthor.Width = 125;
            // 
            // ColumnEResLink
            // 
            ColumnEResLink.HeaderText = "Ссылка";
            ColumnEResLink.MinimumWidth = 6;
            ColumnEResLink.Name = "ColumnEResLink";
            ColumnEResLink.ReadOnly = true;
            ColumnEResLink.Width = 125;
            // 
            // ColumnEResAnnotation
            // 
            ColumnEResAnnotation.HeaderText = "Аннотация";
            ColumnEResAnnotation.MinimumWidth = 6;
            ColumnEResAnnotation.Name = "ColumnEResAnnotation";
            ColumnEResAnnotation.ReadOnly = true;
            ColumnEResAnnotation.Width = 175;
            // 
            // textBoxEResSearch
            // 
            textBoxEResSearch.Location = new Point(814, 19);
            textBoxEResSearch.Name = "textBoxEResSearch";
            textBoxEResSearch.Size = new Size(200, 27);
            textBoxEResSearch.TabIndex = 20;
            // 
            // buttonEResSearch
            // 
            buttonEResSearch.Location = new Point(842, 64);
            buttonEResSearch.Name = "buttonEResSearch";
            buttonEResSearch.Size = new Size(142, 37);
            buttonEResSearch.TabIndex = 21;
            buttonEResSearch.Text = "Поиск по автору";
            buttonEResSearch.Click += buttonEResSearch_Click;
            // 
            // FormPublications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(tabControl1);
            Name = "FormPublications";
            Text = "publications";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            bookPage.ResumeLayout(false);
            bookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            articlePage.ResumeLayout(false);
            articlePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArt).EndInit();
            eresourcePage.ResumeLayout(false);
            eresourcePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewERes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookPage;
        private System.Windows.Forms.TabPage articlePage;
        private System.Windows.Forms.TabPage eresourcePage;

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.Label labelBookPublisher;
        private System.Windows.Forms.TextBox textBookPublisher;
        private System.Windows.Forms.Label labelBookYear;
        private System.Windows.Forms.TextBox textBookYear;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.TextBox textBookAuthor;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Button buttonBookAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookPublisher;

        private System.Windows.Forms.DataGridView dataGridViewArt;
        private System.Windows.Forms.TextBox ArtTitle;
        private System.Windows.Forms.Label labelArtTitle;
        private System.Windows.Forms.Label labelArtJournal;
        private System.Windows.Forms.TextBox textArtJournal;
        private System.Windows.Forms.Label labelArtNum;
        private System.Windows.Forms.TextBox textArtNuml;
        private System.Windows.Forms.Label labelArtYear;
        private System.Windows.Forms.TextBox textArtYear;
        private System.Windows.Forms.Label ArtAuthor;
        private System.Windows.Forms.TextBox textArtAuthor;
        private System.Windows.Forms.Button buttonArtAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumArtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArtJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArtNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArtYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublisher;
        private System.Windows.Forms.TextBox textArtNumber;
        private System.Windows.Forms.Label labelArtNumber;


        private System.Windows.Forms.DataGridView dataGridViewERes;
        private System.Windows.Forms.TextBox textEResTitle;
        private System.Windows.Forms.Label labelEResTitle;
        private System.Windows.Forms.Label labelEResAuthor;
        private System.Windows.Forms.TextBox textEResAuthor;
        private System.Windows.Forms.Label labelEResLink;
        private System.Windows.Forms.TextBox textEResLink;
        private System.Windows.Forms.Label labelEResAnnotation;
        private System.Windows.Forms.TextBox textEResAnnotation;
        private System.Windows.Forms.Button buttonEResAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEResTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEResAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEResLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEResAnnotation;

        private System.Windows.Forms.Button buttonBookDelete;
        private System.Windows.Forms.Button buttonEResDelete;
        private System.Windows.Forms.Button buttonArtDelete;

        private System.Windows.Forms.TextBox textBoxBookSearch;
        private System.Windows.Forms.Button buttonBookSearch;

        private System.Windows.Forms.TextBox textBoxArtSearch;
        private System.Windows.Forms.Button buttonArtSearch;

        private System.Windows.Forms.TextBox textBoxEResSearch;
        private System.Windows.Forms.Button buttonEResSearch;

    }
}
