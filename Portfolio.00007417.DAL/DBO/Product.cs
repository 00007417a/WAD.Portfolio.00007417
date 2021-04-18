using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.DBO
{
    public class Product
    {
        #region Properties

        public int Id { get; set; }

        [Required(ErrorMessage = "Product name cannot be empty")]
        [MinLength(2, ErrorMessage = "Product name should have at least 2 characters")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        // category id cannot be empty
        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Description cannot be empty")]
        [MinLength(3, ErrorMessage = "Description should have at least 3 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price cannot be empty")]
        [Range(0, int.MaxValue, ErrorMessage = "Price cannot be negative value")]
        public float Price { get; set; }

        #endregion Properties
    }
}
