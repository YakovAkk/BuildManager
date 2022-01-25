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

        // Navigations Prop
        public int? UserId { get; set; }
        public User User { get; set; }

        public List<DataMaterial> dataMaterials { get; set; }
        public List<DataPerson> dataPeople { get; set; }

        public BuildingObject()
        {

        }
    }
}
