using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Zanrovi_knjige_2
{
    public partial class Form1 : Form
    {
        Genre choosenGenre;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenre.DataSource = GetGenres();
        }

        private List<Book> GetBooksByGenre()
        {
            using (var context = new Databse())
            {
                context.Genres.Attach(choosenGenre);
                return choosenGenre.Books.ToList();
            }
        }

        private List<Genre> GetGenres()
        {
            using (var context = new Databse())
            {
                return context.Genres.ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int pages = int.Parse(txtPages.Text);
            string author = TxtAuthor.Text;

            using(var context = new Databse())
            {
                Book book = new Book()
                {
                    Title = title,
                    NumOfPages = pages,
                    MainAuthor = author,
                    Genre = choosenGenre,
                };

                context.Books.Add(book);
                context.SaveChanges();
            }

            RefreshForm();
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
           RefreshForm();

        }

        private void RefreshForm()
        {
            choosenGenre = cmbGenre.SelectedItem as Genre;
            dgvBooks.DataSource = GetBooksByGenre();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Book choosenBook = dgvBooks.CurrentRow.DataBoundItem as Book;

            using(var context = new Databse())
            {
                context.Books.Attach(choosenBook);
                context.Books.Remove(choosenBook);
                context.SaveChanges();
            }

            RefreshForm();
        }
    }
}
