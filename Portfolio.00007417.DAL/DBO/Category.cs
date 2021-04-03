using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio._00007417.DAL.DBO
{
    public class Category
    {
        
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "The field cannot be empty")]
        public string CategoryName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}
