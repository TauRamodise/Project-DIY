
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Diy_Project.Models
{
    public partial class DiyContext : DbContext
    {
        public DiyContext()
        {
        }

        public DiyContext(DbContextOptions<DiyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactDetail> ContactDetails { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}