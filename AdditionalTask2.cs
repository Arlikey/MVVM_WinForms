using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVVM_WinForms
{
    public partial class AdditionalTask2 : Form
    {
        public AdditionalTask2()
        {
            InitializeComponent();

            DataContext = new BookViewModel();

            booksListBox.DataBindings.Add(new Binding("DataSource", DataContext, "Books"));
            booksListBox.DataBindings.Add(new Binding("SelectedItem", DataContext, "SelectedBook", true));
            
            addButton.DataBindings.Add(new Binding("Command", DataContext, "AddCommand", true));
            editButton.DataBindings.Add(new Binding("Command", DataContext, "EditCommand", true));
            aboutButton.DataBindings.Add(new Binding("Command", DataContext, "AboutCommand", true));
            deleteButton.DataBindings.Add(new Binding("Command", DataContext, "DeleteCommand", true));
        }
    }
    public class BookViewModel : INotifyPropertyChanged
    {
        public BindingList<Book> Books { get; } = new BindingList<Book>();

        public string _title;
        public string _author;
        public string _genre;
        public DateTime _yearOfPublication;
        public Book _selectedBook;
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand AboutCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public BookViewModel()
        {
            AddCommand = new MainCommand(_ =>
            {
                CreateUpdateBookForm createUpdateBookForm = new CreateUpdateBookForm();
                createUpdateBookForm.CreateUpdateBook += CreateUpdateBookForm_CreateUpdateBook;
                createUpdateBookForm.ShowDialog();
            });
            DeleteCommand = new MainCommand(_ =>
            {
                if (SelectedBook != null)
                {
                    Books.Remove(SelectedBook);
                }
            });
            EditCommand = new MainCommand(_ =>
            {
                if (SelectedBook != null)
                {
                    CreateUpdateBookForm createUpdateBookForm = new CreateUpdateBookForm(SelectedBook);
                    createUpdateBookForm.CreateUpdateBook += CreateUpdateBookForm_CreateUpdateBook;
                    createUpdateBookForm.ShowDialog();
                }
            });
            AboutCommand = new MainCommand(_ =>
            {
                if (SelectedBook != null)
                {
                    MessageBox.Show($"Название : {SelectedBook.Title}\n\nАвтор : {SelectedBook.Author}\n\nЖанр : {SelectedBook.Genre}\n\n" +
                        $"Год издания : {SelectedBook.YearOfPublication.Year}", "Книга", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            });
        }

        private void CreateUpdateBookForm_CreateUpdateBook(Book obj)
        {
            if (obj != null)
            {
                var existingBook = Books.FirstOrDefault(b => b.Id == obj.Id);
                if (existingBook != null)
                {
                    existingBook.Title = obj.Title;
                    existingBook.Author = obj.Author;
                    existingBook.Genre = obj.Genre;
                    existingBook.YearOfPublication = obj.YearOfPublication;
                }
                else
                {
                    Books.Add(obj);
                }
                OnPropertyChanged(nameof(Books));
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        public string Author
        {
            get => _author;
            set
            {
                if (_author != value)
                {
                    _author = value;
                    OnPropertyChanged(nameof(Author));
                }
            }
        }
        public string Genre
        {
            get => _genre;
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChanged(nameof(Genre));
                }
            }
        }
        public DateTime YearOfPublication
        {
            get => _yearOfPublication;
            set
            {
                if (_yearOfPublication != value)
                {
                    _yearOfPublication = value;
                    OnPropertyChanged(nameof(YearOfPublication));
                }
            }
        }
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Book
    {
        public Book()
        {
            Title = "";
            Author = "";
            Genre = "";
            YearOfPublication = DateTime.Now;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime YearOfPublication { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }

}
