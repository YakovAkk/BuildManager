using BuildManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.SingletonForActiveUser
{
    public class SingletonActiveUser
    {
        private User _activeUser;

        public void SetUser(User user)
        {
            if (user == null)
            {
                //log user is null
                return;
            }
            _activeUser = user;
        }

        public User GetUser()
        {
            return _activeUser;
        }

        private static SingletonActiveUser _singleton;
        private SingletonActiveUser()
        {
            
        }

        public static SingletonActiveUser GetInstance()
        {
            if(_singleton == null)
            {
                _singleton = new SingletonActiveUser();
            }
            return _singleton;
        }

    }
}
