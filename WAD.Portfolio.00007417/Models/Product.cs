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

        public int? CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        public int? PersonId { get; set; }

        public virtual Person Customer { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

    }
}
