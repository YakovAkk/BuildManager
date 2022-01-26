using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos
{
    public class MaterialRepos : BaseRepository<Material>
    {
        
        public MaterialRepos() : base()
        {
            
        }
        public async override Task Add(Material item)
        {
           _db.Materials.Add(item);
           _db.SaveChanges();
        }

        public async override Task<List<Material>> GetAll()
        {
            return await _db.Materials.ToListAsync();
        }
        public async Task<string> EditMaterial(Material oldMateral, string newName, string newMesValue,
            int newPrice, Category newCategory)
        {
            string result = "This material does not exist.";

            Material material = (await GetAll()).FirstOrDefault(p => p.Id == oldMateral.Id);

            if (material != null)
            {
                material.Name = newName;
                material.MesurableValue = newMesValue;
                material.Price = newPrice;
                material.CategoryId = newCategory.Id;
                _db.SaveChanges();
                result = "Success! Material " + material.Name + "was changed";
            }
            return result;
        }
    }
}
