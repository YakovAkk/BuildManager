using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using System.Collections.Generic;
using System.Linq;

namespace BuildManager.GeneralFunk.Repos
{
    public class MaterialRepos : BaseRepository<Material>
    {

        public override void Add(Material item)
        {
           _db.Materials.Add(item);
           _db.SaveChanges();
        }

        public override List<Material> GetAll()
        {
            return _db.Materials.ToList();
        }

        public string EditMaterial(Material oldMateral, string newName, string newMesValue, int newPrice, Category newCategory)
        {
            string result = "This material does not exist.";
            Material material = GetAll().FirstOrDefault(p => p.Id == oldMateral.Id);
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
