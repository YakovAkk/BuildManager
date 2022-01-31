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
    public class DataPersonRepos : BaseRepository<DataPerson>
    {

        public override void Add(DataPerson item)
        {
            _db.Add(item);
            _db.SaveChanges(); 
        }

        public override List<DataPerson> GetAll()
        {
            return _db.DataPeople.ToList();
        }
    }
}
