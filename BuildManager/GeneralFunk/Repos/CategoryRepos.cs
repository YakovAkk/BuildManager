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
    public class CategoryRepos : BaseRepository<Category>
    {


        public override void Add(Category item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public override List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }
    }
}
