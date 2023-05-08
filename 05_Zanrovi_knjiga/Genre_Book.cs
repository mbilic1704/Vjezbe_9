using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Zanrovi_knjiga
{
    public partial class Genre_Book : Form
    {
        Genre choosenGenre;
        public Genre_Book()
        {
            InitializeComponent();
        }

        private void Genre_Book_Load(object sender, EventArgs e)
        {
            dgvGenre.DataSource = GetGenres();
            dgvGenre.Columns["Books"].Visible = false;

        }

        private List<Genre> GetGenres()
        {
            using(var context = new Database())
            {
                return context.Genres.ToList();
            }
        }

        private List<Book> GetBooks()
        {
            using(var context = new Database())
            {
                context.Genres.Attach(choosenGenre);
                return choosenGenre.Books.ToList();
            }
        }

        private void dgvGenre_SelectionChanged(object sender, EventArgs e)
        {
            RefreshForm();
              
        }

        private void RefreshForm()
        {
            choosenGenre = dgvGenre.CurrentRow.DataBoundItem as Genre;
            dgvBooks.DataSource = GetBooks();
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            using (var context = new Database())
            {
                string title = tbTitle.Text;
                int pages = int.Parse(tbPages.Text);
                string author = tbAuthor.Text;

                Book newBook = new Book()
                {
                    Title = title,
                    NumOfPages = pages,
                    MainAuthor = author,
                    Genre = choosenGenre
                };

                context.Books.Add(newBook);
                context.SaveChanges();
            }

            RefreshForm();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Book choosenBook = dgvBooks.CurrentRow.DataBoundItem as Book;   

            using(var context = new Database())
            {
                context.Books.Attach(choosenBook);
                context.Books.Remove(choosenBook);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
