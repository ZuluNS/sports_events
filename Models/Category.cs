

using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }


    }
}
