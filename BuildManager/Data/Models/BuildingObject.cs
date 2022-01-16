using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class BuildingObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int User_id { get; set; }

        public BuildingObject()
        {

        }
    }
}
