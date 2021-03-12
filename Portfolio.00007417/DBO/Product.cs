using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.DBO
{
    public class Product
    {
        
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }

        [Required]
        [MinLength(3)]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

    }
}
