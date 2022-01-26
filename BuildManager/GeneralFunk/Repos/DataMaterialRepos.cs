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

        public async override Task Add(DataMaterial item)
        {
            await Task.Run(() => _db.DataMaterials.Add(item));
            _db.SaveChanges();
        }

        public async override Task<List<DataMaterial>> GetAll()
        {
            return await Task.Run(() => _db.DataMaterials.ToList());
        }
    }
}
