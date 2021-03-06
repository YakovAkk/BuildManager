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

        public override void Add(JobPerson item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }
        public override List<JobPerson> GetAll()
        {
            return _db.JobPeople.ToList();
        }

        public string EditMaterial(JobPerson oldJobber, string jobberName, string jobberSurname, string jobberPhone)
        {
            string result = "This employee does not exist.";

            JobPerson person = GetAll().FirstOrDefault(p => p.Id == oldJobber.Id);
            if (person != null)
            {
                person.Name = jobberName;
                person.SurName = jobberSurname;
                person.Phone = jobberPhone;
                _db.SaveChanges();

                result = "Success! Jobber " + person.Name + "was changed";
            }

            return result;
        }
    }
}
