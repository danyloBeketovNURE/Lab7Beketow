using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using Lb6.EF;
using Lb6.Models;
using System.Threading;

namespace Lb6
{
    public partial class Form1 : Form
    {
        private LibraryEntity context = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();/////////
        }

        private void AuthorGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) /////////
        {
            try
            {
                int i = AuthorsGridView.CurrentRow.Index;/////////
                Author a = AuthorsGridView.Rows[i].DataBoundItem as Author;/////////
                context.authors.AddOrUpdate(a);
                context.Entry(a).State = EntityState.Modified;
                context.SaveChanges();
                UpdateGrid();/////////
            }
            catch { UpdateGrid(); }/////////
        }

        private void UpdateGrid()/////////
        {
            context = new LibraryEntity();
            AuthorsGridView.DataSource = context.authors.ToList();/////////
            AuthorsGridView.Columns.Remove("Books");/////////
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)/////////
        {
            AddAuthorForm form = new AddAuthorForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            Author d = new Author
            {
                Name = form.textBox1.Text
            };
            context = new LibraryEntity();
            context.authors.Add(d);
            context.SaveChanges();
            UpdateGrid();/////////
        }

        private void RemoveAuthor_Click(object sender, EventArgs e)/////////
        {
            if (AuthorsGridView.SelectedRows.Count == 0 | AuthorsGridView.SelectedRows.Count > 1)/////////
                return;
            Author a = (Author)AuthorsGridView.SelectedRows[0].DataBoundItem;/////////
            foreach (Book b in context.books)
            {
                if (b.author == a)
                    b.author = null;
            }
            context.authors.Remove(a);
            context.SaveChanges();
            UpdateGrid();/////////
        }

        private void BooksGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)/////////
        {
            try
            {
                int i = BooksGridView.CurrentRow.Index;/////////
                Book b = BooksGridView.Rows[i].DataBoundItem as Book;/////////
                context.books.AddOrUpdate(b);
                context.Entry(b).State = EntityState.Modified;
                context.SaveChanges();
                UpdateGrid();/////////
            }
            catch { UpdateGrid(); }  /////////     
        }

        private void AuthorGridView_SelectionChanged(object sender, EventArgs e)
        {
            Author a = (Author)AuthorsGridView.CurrentRow.DataBoundItem;/////////
            BooksGridView.DataSource = context.books.Where(b => b.author.Id == a.Id).ToList();
            BooksGridView.Columns.Remove("author");/////////
        }

        private void AddBook_Click(object sender, EventArgs e)/////////
        {
            AddWorkerForm form = new AddWorkerForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            UpdateGrid();/////////
        }
        private void BooksGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }/////////

        private void RemoveWorker_Click(object sender, EventArgs e)
        {
            if (BooksGridView.CurrentRow == null)/////////
                return;
            int i = BooksGridView.CurrentRow.Index;/////////
            Book selectedBook = BooksGridView.Rows[i].DataBoundItem as Book;/////////
            context = new LibraryEntity();
            Book b = context.books.Find(selectedBook.Id);
            context.books.Remove(b);
            context.SaveChanges();
            UpdateGrid();/////////
            return;
        }
    }
}
