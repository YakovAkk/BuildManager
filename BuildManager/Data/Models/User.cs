﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public User()
        {

        }
        public User(string login, string email, string pass)
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }
    }
}
