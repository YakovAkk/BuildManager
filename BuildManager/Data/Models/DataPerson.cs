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
        public int User_id { get; set; }
        public int JobPerson_id { get; set; }
        public DateTime dateDeal { get; set; }
    }
}
