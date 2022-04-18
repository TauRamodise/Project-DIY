using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Diy_Project.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
      
        }

        public DbSet<User> Users { get; set; } = null!;

        public static string GetRDSConnectionString()
        {

            string dbname = "diyDB";
            string username = "diy";
            string password = "Db123456";
            string hostname = "diydb.cszopbtc5jh8.us-east-1.rds.amazonaws.com";
    

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
