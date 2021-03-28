using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.DBO
{
    public class Category
    {
        
        public int Id { get; set; }

        [Required]
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
