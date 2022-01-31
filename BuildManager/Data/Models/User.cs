using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        // Navigation Properties
        public List<BuildingObject> buildingObjects { get; set; }
        public User()
        {

        }
        public User(string login, string email, string pass )
        {
            Login = login;
            Email = email;
            Pass = pass;
        }
    }
}
