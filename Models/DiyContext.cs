
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Diy_Project.Models
{
    public class DiyContext : DbContext
    {

        public DiyContext(DbContextOptions<DiyContext> options)
            : base(options)
        {
        }

        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
    }
}