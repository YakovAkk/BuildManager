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
        public int BuildObject_id { get; set; }
        public int JobPerson_id { get; set; }
        public int Salary { get; set; }
        public DateTime DateDeal { get; set; }

        public DataPerson()
        {

        }
        public DataPerson(int BuildObject_id, int JobPerson_id,int Salary)
        {
            this.BuildObject_id = BuildObject_id;
            this.JobPerson_id = JobPerson_id;
            this.Salary = Salary;
            DateDeal = DateTime.Now;
        }

    }
}
