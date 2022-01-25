using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos
{
    public class DataMaterialRepos : BaseRepository<DataMaterial>
    {
        private readonly AppDBContent _db;
        public DataMaterialRepos()
        {
            _db = new AppDBContent();
        }

        public override void Add(DataMaterial item)
        {
            _db.DataMaterials.Add(item);
        }

        public override List<DataMaterial> GetAll()
        {
            return _db.DataMaterials.ToList();
        }
    }
}
