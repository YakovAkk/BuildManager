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
    public class DataPersonRepos : IRepository<DataPerson>
    {
        private readonly AppDBContent _db;
        public DataPersonRepos()
        {
            _db = new AppDBContent();
        }

        public void Add(DataPerson item)
        {
            _db.Add(item);
            _db.SaveChanges(); 
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<DataPerson> GetAll()
        {
            return _db.DataPeople.ToList();
        }
    }
}
