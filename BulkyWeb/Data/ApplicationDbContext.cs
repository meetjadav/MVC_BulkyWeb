using BulkyWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Art", DisplayOrder = 3 });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
                    ISBN = "9780545791878",
                    Description = "The Hunger Games is a dystopian novel by Suzanne Collins where teenagers are forced to participate in a deadly televised competition in a totalitarian society.",
                    Price = 499.00,
                    CategoryId = 1,
                    ImgURL = "/pics/the-hunger-games.jpg"  // Add the relative path to the image
                },
                new Product
                {
                    Id = 2,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    ISBN = "9780425027066",
                    Description = "Dune by Frank Herbert is a science fiction epic set on a desert planet, exploring themes of politics, religion,and ecological survival.",
                    Price = 799.00,
                    CategoryId = 2,
                    ImgURL = "/pics/dune.jpg"  // Add the relative path to the image
                },
                new Product
                {
                    Id = 3,
                    Title = "The Da Vinci Code",
                    Author = "Dan Brown",
                    ISBN = "9780385513227",
                    Description = "The Da Vinci Code by Dan Brown is a mystery-thriller that follows a symbologist as he uncovers a hidden religious secret through a series of historical and cryptic clues.",
                    Price = 399.00,
                    CategoryId = 3,
                    ImgURL = "/pics/the-da-vinci-code.jpg"  // Add the relative path to the image
                });
        }

    }
}
