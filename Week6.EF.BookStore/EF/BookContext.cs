using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.EF.BookStore.Core.Models;
using Week6.EF.BookStore.EF.Configurations;

namespace Week6.EF.BookStore.EF
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Shelf> Shelves { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		Database=LibraryStorage;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Shelf>().ToTable("Shelves"); //potrei passare un altro nome per tabella
            //modelBuilder.Entity<Shelf>().HasKey(s => s.Id); //chiave primaria
            //modelBuilder.Entity<Shelf>().Property(s => s.Code)
            //    .IsRequired()
            //    .HasMaxLength(6);

            modelBuilder.ApplyConfiguration<Shelf>(new ShelfConfiguration());
        }
    }
}
