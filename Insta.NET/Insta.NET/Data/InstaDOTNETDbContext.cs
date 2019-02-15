using InstaDOTNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Data
{
    public class InstaDOTNETDbContext : DbContext
    {
        public InstaDOTNETDbContext(DbContextOptions<InstaDOTNETDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    ID = 1,
                    Name = "Image One",
                    Author = "Mike F.",
                    Caption = "This is the first test image",
                    URL = "https://via.placeholder.com/200"
                },
                new Image
                {
                    ID = 2,
                    Name = "Image Two",
                    Author = "Mike F.",
                    Caption = "This is the second test image",
                    URL = "https://via.placeholder.com/200"
                },
                new Image
                {
                    ID = 3,
                    Name = "Image Three",
                    Author = "Mike F.",
                    Caption = "This is the third test image",
                    URL = "https://via.placeholder.com/200"
                },
                new Image
                {
                    ID = 4,
                    Name = "Image Four",
                    Author = "Mike F.",
                    Caption = "This is the fourth test image",
                    URL = "https://via.placeholder.com/200"
                },
                new Image
                {
                    ID = 5,
                    Name = "Image Five",
                    Author = "Mike F.",
                    Caption = "This is the fifth test image",
                    URL = "https://via.placeholder.com/200"
                }
                );
        }

        public DbSet<Image> Images { get; set; }
        //public DbSet<Comment> Comments { get; set; }
    }
}
