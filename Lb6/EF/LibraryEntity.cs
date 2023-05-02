using Lb6.Models;
using System;
using System.Data.Entity;

namespace Lb6.EF
{
    public class LibraryEntity : DbContext
    {
        public LibraryEntity() : base("DbConnectionString") { }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}