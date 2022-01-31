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
        public override void Add(BuildingObject item)
        {
            _db.BuildingObjects.Add(item);
            _db.SaveChanges();
        }

        public override List<BuildingObject> GetAll()
        {
            return _db.BuildingObjects.ToList();
        }

        public List<BuildingObject> GetBuildingObjectsForUser(User user)
        {
            return _db.BuildingObjects.Where(o => o.UserId == user.Id).ToList();
        }
    }
}
