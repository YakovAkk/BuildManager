using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class DataPerson
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public User user { get; set; }
        public int person_id { get; set; }
        public JobPerson person { get; set; }
    }
}
