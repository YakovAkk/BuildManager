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
        public int Salary { get; set; }
        public DateTime dateDeal { get; set; }

        public DataPerson()
        {

        }
        public DataPerson(int User_id,int JobPerson_id,int Salary)
        {
            this.User_id = User_id;
            this.JobPerson_id = JobPerson_id;
            this.Salary = Salary;
            dateDeal = DateTime.Now;
        }

    }
}
