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
    public class UserRepos : BaseRepository<User>
    {
        private readonly AppDBContent _db;
        public UserRepos()
        {
            _db = new AppDBContent();
        }
        public override void Add(User item)
        {
            _db.Users.Add(item);
            _db.SaveChanges();
        }
        public override List<User> GetAll()
        {
            return _db.Users.ToList();
        }
        public User FindUserWithActive()
        {
            return GetAll().Where(x => x.IsActive).FirstOrDefault();    
        }
        public void ChangeActiveOnTrue(string UserLogin , string UserPassword)
        {
            var user = GetAll().Where(u => u.Login == UserLogin && u.Pass == UserPassword).FirstOrDefault();
            if(user != null)
            {
                user.IsActive = true;
                _db.SaveChanges();
            }
        }
        public void ChangeAllActiveFalse()
        {
            foreach (var item in GetAll())
            {
                item.IsActive = false;
            }
            _db.SaveChanges();
        }
    }
}
