using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Datcu_Ioan_Lab6.Models;

namespace Datcu_Ioan_Lab6.Data
{
    public class Datcu_Ioan_Lab6Context : DbContext
    {
        public Datcu_Ioan_Lab6Context (DbContextOptions<Datcu_Ioan_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Datcu_Ioan_Lab6.Models.Book> Book { get; set; }
    }
}
