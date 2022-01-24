using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos
{
    public class BuildingObjectRepos : IRepository<BuildingObject>
    {
        private readonly AppDBContent _db;
        public BuildingObjectRepos()
        {
            _db = new AppDBContent();
        }

        public void Add(BuildingObject item)
        {
            _db.BuildingObjects.Add(item);
            _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.BuildingObjects ON;");
            _db.SaveChanges();
            _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.BuildingObjects OFF;");
        }

        public void Dispose()
        {
           _db.Dispose();
        }

        public List<BuildingObject> GetAll()
        {
            return _db.BuildingObjects.ToList();
        }
    }
}
