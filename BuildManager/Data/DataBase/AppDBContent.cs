using BuildManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuildManager.Data.DataBase
{
    public class AppDBContent : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BuildingObject> BuildingObjects { get; set; }
        public DbSet<DataMaterial> DataMaterials { get; set; }
        public DbSet<DataPerson> DataPeople { get; set; }
        public DbSet<JobPerson> JobPeople { get; set;  }
        public DbSet<Category> Categories { get; set; }
        public AppDBContent()   
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProjectDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
