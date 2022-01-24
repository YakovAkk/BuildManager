using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class JobPerson
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public JobPerson()
        {

        }
    }
}
