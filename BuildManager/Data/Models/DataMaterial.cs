using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class DataMaterial
    {
        public int id { get; set; }
        public int User_id { get; set; }
        public int Material_id { get; set; }
        public int Count { get; set; }
        public DateTime dateDeal { get; set; }

        public DataMaterial()
        {

        }

        public DataMaterial(int user_id, int material_id,int count)
        {
            User_id = user_id;
            Material_id = material_id;
            Count = count;
            dateDeal = DateTime.Now;
        }
    }
}
