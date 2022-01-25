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
    public class JobPersonRepos : BaseRepository<JobPerson>
    {
        private readonly AppDBContent _db;
        public JobPersonRepos()
        {
            _db = new AppDBContent();
        }
        public override void Add(JobPerson item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }
        public override List<JobPerson> GetAll()
        {
            return _db.JobPeople.ToList();
        }
    }
}
