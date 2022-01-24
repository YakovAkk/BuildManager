using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class DataMaterial
    {
        public int Id { get; set; }
        public int BuildObject_id { get; set; }
        public int Material_id { get; set; }
        public int Count { get; set; }
        public DateTime DateDeal { get; set; }

        //public List<BuildingObject> BuildingObjects { get; set; }
        //public List<Material> Materials { get; set; }

        public DataMaterial()
        {

        }

        public DataMaterial(int buildObject_id, int material_id,int count)
        {
            BuildObject_id = buildObject_id;
            Material_id = material_id;
            Count = count;
            DateDeal = DateTime.Now;
        }
    }
}
