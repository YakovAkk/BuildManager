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
    public class JobPersonRepos : BaseRepository<JobPerson>
    {
        private readonly AppDBContent _db;
        public JobPersonRepos()
        {
            _db = new AppDBContent();
        }
        public async override Task Add(JobPerson item)
        {
            await _db.AddAsync(item);
            _db.SaveChanges();
        }
        public async override Task<List<JobPerson>> GetAll()
        {
            return await _db.JobPeople.ToListAsync();
        }
        public async Task<string> EditMaterial(JobPerson oldJobber, string jobberName, string jobberSurname, string jobberPhone)
        {
            string result = "This employee does not exist.";

            JobPerson person = (await GetAll()).FirstOrDefault(p => p.Id == oldJobber.Id);
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
