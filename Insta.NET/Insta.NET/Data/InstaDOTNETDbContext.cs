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

        public DbSet<Image> Images { get; set; }
    }
}
