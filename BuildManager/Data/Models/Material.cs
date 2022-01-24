using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MesurableValue { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        public Material()
        {

        }
    }
}
