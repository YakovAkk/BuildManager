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

        public int Count { get; set; }
        public DateTime DateDeal { get; set; }

        //Navigation Properties

        public int BuildingObjectId { get; set; }
        public BuildingObject BuildingObject { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public DataMaterial()
        {

        }

        public DataMaterial(int buildObject_id, int material_id,int count)
        {
            BuildingObjectId = buildObject_id;
            MaterialId = material_id;
            Count = count;
            DateDeal = DateTime.Now;
        }
    }
}
