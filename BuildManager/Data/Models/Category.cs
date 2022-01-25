using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Navigation Properties
        List<Material> materials { get; set; }
        public Category()
        {

        }
    }
}
