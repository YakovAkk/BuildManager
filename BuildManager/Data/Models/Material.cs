using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class Material
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mesurableValue { get; set; }
        public int price { get; set; }
        public int CategoryId { get; set; }

        public Material()
        {

        }
    }
}
