using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class Result
    {
        [Key]
        public string ResultId { get; set; }
        public string ResultName { get; set; }
        public string ResultDate { get; set; }
        




    }
}
