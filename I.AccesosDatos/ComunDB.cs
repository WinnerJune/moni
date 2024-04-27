using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using O.EN;

namespace O.DAL
{
    public class ComunDB : DbContext
    {

        public DbSet<Personao> PersonaO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PLHV39O\\SQLEXPRESS;Initial Catalog=BDI;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}

