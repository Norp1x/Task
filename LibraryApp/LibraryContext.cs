using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryApp
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Book>()
                    .Property(b => b.BookId)
                    .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Book>()
                .Property(b => b.Description)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(b => b.Rating)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(13);
            modelBuilder.Entity<Book>()
                .Property(b => b.PublicationDate)
                .IsRequired();

            modelBuilder.Entity<Author>()
                .Property(a => a.AuthorId)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Author>()
                .Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Author>()
                .Property(a => a.BirthDate)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(a => a.Gender)
                .IsRequired();
        }
    }
}
