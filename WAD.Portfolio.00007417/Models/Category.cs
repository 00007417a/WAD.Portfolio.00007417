using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Portfolio._00007417.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        public CategoryType CategoryTypes { get; set; }
    }

    public enum CategoryType
    {
        Interior,
        Characters,
        Animals,
        Food,
        Furniture,
        Plant,
        Vehicles,
        Technology
    }
}
