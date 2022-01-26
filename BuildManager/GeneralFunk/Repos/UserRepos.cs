using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos
{
    public class UserRepos : BaseRepository<User>
    {
        private readonly AppDBContent _db;
        public UserRepos()
        {
            _db = new AppDBContent();
        }
        public async override Task Add(User item)
        {
            await _db.Users.AddAsync(item);
            _db.SaveChanges();
        }
        public async override Task<List<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
        public async Task<User> FindUserWithActive()
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.IsActive);    
        }
        public async Task ChangeActiveOnTrue(string UserLogin , string UserPassword)
        {
            var user = (await GetAll()).Where(u => u.Login == UserLogin && u.Pass == UserPassword).FirstOrDefault();
            if(user != null)
            {
                user.IsActive = true;
                _db.SaveChanges();
            }
        }
        public async Task ChangeAllActiveFalse()
        {
            foreach (var item in await GetAll())
            {
                item.IsActive = false;
            }
            _db.SaveChanges();
        }
    }
}
