using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string UserPassword { get; set; }

    }
}
