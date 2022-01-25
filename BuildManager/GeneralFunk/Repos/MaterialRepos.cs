using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using System.Collections.Generic;
using System.Linq;

namespace BuildManager.GeneralFunk.Repos
{
    public class MaterialRepos : BaseRepository<Material>
    {
        private readonly AppDBContent _db;
        public MaterialRepos()
        {
            _db = new AppDBContent();
        }
        public override void Add(Material item)
        {
           _db.Materials.Add(item);
           _db.SaveChanges();
        }

        public override List<Material> GetAll()
        {
            return _db.Materials.ToList();
        }
    }
}
