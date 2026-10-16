using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

    }
}
