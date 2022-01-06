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
        public int user_id { get; set; }
        public User user { get; set; }
        public int material_id { get; set; }
        public Material material { get; set; }
    }
}
