using AngularWCore2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWCore2.ContextFiles
{
    public class AppDbContext : DbContext
    {

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}
