using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.DBO
{
    public class Person
    {
        
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [DisplayName("Category Types")]
        public string LastName { get; set; }
        [MinLength(8)]
        public string ProfessionalInformation { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Location { get; set; }

        public string Website { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}
