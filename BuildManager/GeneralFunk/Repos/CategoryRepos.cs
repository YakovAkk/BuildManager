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
    public class CategoryRepos : BaseRepository<Category>
    {
       
        public CategoryRepos() : base()
        {
            
        }

        public async override Task Add(Category item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public async override Task<List<Category>> GetAll()
        {
            return await _db.Categories.ToListAsync();
        }
    }
}
