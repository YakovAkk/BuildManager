using BuildManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data
{
    public class ResMaterial
    {
        public Material material { get; set; }
        public int Count { get; set; }

        public int FullPrice { get; set; }
        public ResMaterial()
        {

        }
    }
}
