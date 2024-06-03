using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVVM_WinForms
{
    public partial class CreateUpdateBookForm : Form
    {
        public event Action<Book> CreateUpdateBook;
        public Book Book { get; set; }
        public CreateUpdateBookForm(Book book = null)
        {
            InitializeComponent();
            Book = book ?? new Book();
            titleTextBox.Text = Book.Title;
            authorTextBox.Text = Book.Author;
            genreTextBox.Text = Book.Genre;
            yearDateTimePicker.Value = Book.YearOfPublication;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Book.Title = titleTextBox.Text;
            Book.Author = authorTextBox.Text;
            Book.Genre = genreTextBox.Text;
            Book.YearOfPublication = yearDateTimePicker.Value;
            CreateUpdateBook?.Invoke(Book);
            Close();
        }
    }
}
