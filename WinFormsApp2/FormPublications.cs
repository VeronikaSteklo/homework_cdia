using Task18_19.DataAccessLayer.DataTransferObjects;
using Task18_19.DataAccessLayer.Entities;
using Task18_19.DataAccessLayer.Entities.Enum;
using Task18_19.Service;
using Task18_19.Service.Interfaces;
namespace WinFormsTask18_19
{
    public partial class FormPublications : Form
    {
        private readonly IPublicationService _publicationService;

        public FormPublications(IPublicationService service)
        {
            _publicationService = service;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillBooks();
            FillArticles();
            FillEResources();
        }

        private IPublicationService Get_service()
        {
            return _publicationService;
        }

        private void FillBooks()
        {
            var publications = _publicationService.GetAll();
            dataGridViewBook.Rows.Clear();

            foreach (var publication in publications)
            {
                if (publication is Book book)
                {
                    dataGridViewBook.Rows.Add(
                        book.Title,
                        book.Author,
                        book.Year.ToString(),
                        book.Publisher
                    );
                }
            }
        }

        private void FillArticles()
        {
            var publications = _publicationService.GetAll();
            dataGridViewArt.Rows.Clear();

            foreach (var publication in publications)
            {
                if (publication is Article article)
                {
                    dataGridViewArt.Rows.Add(
                        article.Title,
                        article.Author,
                        article.Journal,
                        article.Issue,
                        article.Year
                    );
                }
            }
        }

        private void FillEResources()
        {
            var publications = _publicationService.GetAll();
            dataGridViewERes.Rows.Clear();

            foreach (var publication in publications)
            {
                if (publication is EResource eres)
                {
                    dataGridViewERes.Rows.Add(
                        eres.Title,
                        eres.Author,
                        eres.Link,
                        eres.Annotation
                    );
                }
            }
        }


        private void buttonBookAdd_Click_1(object sender, EventArgs e)
        {
            // Чтение данных из TextBox
            string title = BookTitle.Text.Trim();
            string author = textBookAuthor.Text.Trim();
            string yearText = textBookYear.Text.Trim();
            string publisher = textBookPublisher.Text.Trim();

            // Проверка на валидность
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(yearText) || string.IsNullOrEmpty(publisher))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yearText, out int year))
            {
                MessageBox.Show("Год издания должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание объекта книги
            var book = new BookDTO
            {
                Title = title,
                Author = author,
                Year = year,
                Publisher = publisher
            };

            // Добавление через сервис
            _publicationService.AddPublication(
                PublicationType.Book,
                book.Title,
                book.Author,
                book.Year.ToString(),
                book.Publisher
            );


            // Обновление таблицы
            dataGridViewBook.Rows.Add(book.Title, book.Author, book.Year.ToString(), book.Publisher);

            // Очистка полей ввода
            BookTitle.Text = "";
            textBookAuthor.Text = "";
            textBookYear.Text = "";
            textBookPublisher.Text = "";
        }

        private void buttonArtAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var title = ArtTitle.Text.Trim();
                var author = textArtAuthor.Text.Trim();
                var journal = textArtJournal.Text.Trim();
                var numberText = textArtNumber.Text.Trim();
                var yearText = textArtYear.Text.Trim();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                    string.IsNullOrWhiteSpace(journal) || string.IsNullOrWhiteSpace(numberText) || string.IsNullOrWhiteSpace(yearText))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для статьи.");
                    return;
                }

                if (!int.TryParse(numberText, out int issue))
                {
                    MessageBox.Show("Номер должен быть числом.");
                    return;
                }

                if (!int.TryParse(yearText, out int year))
                {
                    MessageBox.Show("Год должен быть числом.");
                    return;
                }

                var article = new ArticleDTO
                {
                    Title = title,
                    Author = author,
                    Journal = journal,
                    Issue = issue,
                    Year = year
                };

                _publicationService.AddPublication(
                    PublicationType.Article,
                    article.Title,
                    article.Author,
                    article.Journal,
                    article.Issue.ToString(),
                    article.Year.ToString()
                );

                dataGridViewArt.Rows.Add(article.Title, article.Author, article.Journal, article.Issue, article.Year);

                // Очистка полей
                ArtTitle.Text = "";
                textArtAuthor.Text = "";
                textArtJournal.Text = "";
                textArtNumber.Text = "";
                textArtYear.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении статьи: {ex.Message}");
            }
        }



        private void buttonEResAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var title = textEResTitle.Text.Trim();
                var author = textEResAuthor.Text.Trim();
                var link = textEResLink.Text.Trim();
                var annotation = textEResAnnotation.Text.Trim();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                    string.IsNullOrWhiteSpace(link) || string.IsNullOrWhiteSpace(annotation))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для электронного ресурса.");
                    return;
                }

                var eresource = new EResourceDTO
                {
                    Title = title,
                    Author = author,
                    Link = link,
                    Annotation = annotation
                };

                _publicationService.AddPublication(
                    PublicationType.EResource,
                    eresource.Title,
                    eresource.Author,
                    eresource.Link,
                    eresource.Annotation
                );

                dataGridViewERes.Rows.Add(eresource.Title, eresource.Author, eresource.Link, eresource.Annotation);

                // Очистка полей
                textEResTitle.Text = "";
                textEResAuthor.Text = "";
                textEResLink.Text = "";
                textEResAnnotation.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении ресурса: {ex.Message}");
            }
        }

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            var selectedRow = dataGridViewBook.SelectedRows[0];
            string title = selectedRow.Cells[0].Value.ToString();

            _publicationService.DeletePublicationByTitle(PublicationType.Book, title);
            dataGridViewBook.Rows.Remove(selectedRow);
        }

        private void buttonArtDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewArt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            var selectedRow = dataGridViewArt.SelectedRows[0];
            string title = selectedRow.Cells[0].Value.ToString();

            _publicationService.DeletePublicationByTitle(PublicationType.Article, title);
            dataGridViewArt.Rows.Remove(selectedRow);
        }

        private void buttonEResDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewERes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            var selectedRow = dataGridViewERes.SelectedRows[0];
            string title = selectedRow.Cells[0].Value.ToString();

            _publicationService.DeletePublicationByTitle(PublicationType.EResource, title);
            dataGridViewERes.Rows.Remove(selectedRow);
        }

        private void buttonBookSearch_Click(object sender, EventArgs e)
        {
            string author = textBoxBookSearch.Text.Trim();
            var results = _publicationService.GetAll()
                .OfType<Book>()
                .Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewBook.Rows.Clear();
            foreach (var book in results)
            {
                dataGridViewBook.Rows.Add(book.Title, book.Author, book.Year.ToString(), book.Publisher);
            }
        }

        private void buttonArtSearch_Click(object sender, EventArgs e)
        {
            string author = textBoxArtSearch.Text.Trim();
            var results = _publicationService.GetAll()
                .OfType<Article>()
                .Where(a => a.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewArt.Rows.Clear();
            foreach (var article in results)
            {
                dataGridViewArt.Rows.Add(article.Title, article.Author, article.Journal, article.Issue, article.Year);
            }
        }

        private void buttonEResSearch_Click(object sender, EventArgs e)
        {
            string author = textBoxEResSearch.Text.Trim();
            var results = _publicationService.GetAll()
                .OfType<EResource>()
                .Where(r => r.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewERes.Rows.Clear();
            foreach (var res in results)
            {
                dataGridViewERes.Rows.Add(res.Title, res.Author, res.Link, res.Annotation);
            }
        }




        private void articlePage_Click(object sender, EventArgs e)
        {

        }
    }
}
