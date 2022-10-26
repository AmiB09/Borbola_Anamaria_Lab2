using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borbola_Anamaria_Lab2.Models;

namespace Borbola_Anamaria_Lab2.Data
{
    public class Borbola_Anamaria_Lab2Context : DbContext
    {
        public Borbola_Anamaria_Lab2Context (DbContextOptions<Borbola_Anamaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Borbola_Anamaria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Borbola_Anamaria_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Borbola_Anamaria_Lab2.Models.Author> Author { get; set; }
    }
}
