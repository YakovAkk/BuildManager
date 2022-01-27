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
    public class DataPersonRepos : BaseRepository<DataPerson>
    {
        
        public DataPersonRepos() : base()
        {
            
        }

        public async override Task Add(DataPerson item)
        {
           await _db.AddAsync(item);
            _db.SaveChanges(); 
        }

        public async override Task<List<DataPerson>> GetAll()
        {
            return await _db.DataPeople.ToListAsync();
        }
    }
}
