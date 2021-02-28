using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Portfolio._00007417.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public Category ProductCategory { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public List<Object> Images { get; set; }
    }
}
