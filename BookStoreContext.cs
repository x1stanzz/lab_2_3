using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("BookStore")
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithRequired(b => b.Author)
                .HasForeignKey(b => b.AuthorId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Books)
                .WithRequired(b => b.Genre)
                .HasForeignKey(b => b.GenreId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Publisher>()
                .HasMany(p => p.Books)
                .WithRequired(b => b.Publisher)
                .HasForeignKey(b => b.PublisherId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Reviews)
                .WithRequired(r => r.Book)
                .HasForeignKey(r => r.BookId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
