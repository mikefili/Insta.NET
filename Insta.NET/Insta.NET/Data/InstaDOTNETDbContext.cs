using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insta.NET.Data
{
    public class InstaDOTNETDbContext : DbContext
    {
        public InstaDOTNETDbContext(DbContextOptions<InstaDOTNETDbContext> options):base(options)
        {

        }
    }
}
