using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class User
    {
        [Key]
<<<<<<< HEAD
=======
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69
=======
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69
=======
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69

        public string UserId { get; set; } 
        public string UserName { get; set; } 
        public string UserEmail { get; set; } 
        public string UserPhone { get; set; } 
        public string UserPassword { get; set; }

        
    }
}
