using Challenge1.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Repository
{
    public class AppDbContext:IdentityDbContext<User,Role,int>
    {
        public AppDbContext()
        {

        }
        //configuration from settings
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=LAPTOP-8VH34DE5; initial catalog=ChallengeDb;persist security info=True;user id=sa;password=developer; MultipleActiveResultSets=True; App=EntityFramework");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
