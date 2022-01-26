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
    public class BuildingObjectRepos : BaseRepository<BuildingObject>
    {
        private readonly AppDBContent _db;
        public BuildingObjectRepos()
        {
            _db = new AppDBContent();
        }

        public async override Task Add(BuildingObject item)
        {
            await _db.BuildingObjects.AddAsync(item);
            _db.SaveChanges();
        }

        public async override Task<List<BuildingObject>> GetAll()
        {
            return await _db.BuildingObjects.ToListAsync();
        }

        public async Task<List<BuildingObject>> GetBuildingObjectsForUser(User user)
        {
            return await _db.BuildingObjects.Where(o => o.UserId == user.Id).ToListAsync();
        }
    }
}
