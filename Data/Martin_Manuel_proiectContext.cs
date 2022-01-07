using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_proiect.Models;

namespace Martin_Manuel_proiect.Data
{
    public class Martin_Manuel_proiectContext : DbContext
    {
        public Martin_Manuel_proiectContext (DbContextOptions<Martin_Manuel_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<Martin_Manuel_proiect.Models.Phone> Phone { get; set; }

        public DbSet<Martin_Manuel_proiect.Models.Supplier> Supplier { get; set; }
    }
}
