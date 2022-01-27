using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class JobPerson
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }

        // Navigation Properties

        public List<DataPerson> dataPeople { get; set; }

        public JobPerson()
        {

        }
    }
}
