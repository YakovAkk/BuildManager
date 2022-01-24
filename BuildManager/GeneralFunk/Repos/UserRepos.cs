using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk.Repos.Base;
using BuildManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos
{
    public class UserRepos : IRepository<User>
    {
        private readonly AppDBContent _db;
        public UserRepos()
        {
            _db = new AppDBContent();
        }
        public void Add(User item)
        {
            _db.Users.Add(item);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();  
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public User FindByLogin(string usersLogin)
        {
            return _db.Users.Where(u => u.Login == usersLogin).FirstOrDefault();
        }


    }
}
