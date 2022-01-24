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
    public class CategoryRepos : IRepository<Category>
    {
        private readonly AppDBContent _db;
        public CategoryRepos()
        {
            _db = new AppDBContent();
        }

        public void Add(Category item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }
    }
}
