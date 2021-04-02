using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Portfolio._00007417.DAL.DBO
{
    public class Category
    {
        
        public int Id { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [DisplayName("Category Types")]
        [Required]
        public CategoryType CategoryTypes { get; set; }
    }

    public enum CategoryType
    {
        [EnumMember(Value = "Interior")]
        Interior,
        [EnumMember(Value = "Characters")]
        Characters,
        [EnumMember(Value = "Animals")]
        Animals,
        [EnumMember(Value = "Food")]
        Food,
        [EnumMember(Value = "Furniture")]
        Furniture,
        [EnumMember(Value = "Plant")]
        Plant,
        [EnumMember(Value = "Vehicles")]
        Vehicles,
        [EnumMember(Value = "Technology")]
        Technology
    }
}
