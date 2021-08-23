using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<users> UserEntity { get; set; }
        public virtual DbSet<Location> LocationEntity { get; set; }
        public virtual DbSet<User_Xref_Location> UserXrefLocationEntity { get; set; }
        public virtual DbSet<Devices> DeviceEntity { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>().HasKey(UserXrefLocation => UserXrefLocation.UserId);
            modelBuilder.Entity<Location>().HasKey(UserXrefLocation => UserXrefLocation.LocationId);
            modelBuilder.Entity<User_Xref_Location>().HasKey(UserXrefLocation => UserXrefLocation.User_Xref_LocationId);
            modelBuilder.Entity<Devices>().HasKey(UserXrefLocation => UserXrefLocation.DeviceId);

        }
    }
}
