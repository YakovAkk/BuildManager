using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class DataPerson
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public DateTime DateDeal { get; set; }

        // Navigation Properties

        public int BuildingObjectId { get; set; }
        public BuildingObject BuildingObject { get; set; }
        public int JobPersonId { get; set; }
        public JobPerson JobPerson { get; set; }

        public DataPerson()
        {

        }
        public DataPerson(int BuildObject_id, int JobPerson_id,int Salary)
        {
            this.BuildingObjectId = BuildObject_id;
            this.JobPersonId = JobPerson_id;
            this.Salary = Salary;
            DateDeal = DateTime.Now;
        }

    }
}
