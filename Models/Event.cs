using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class Event
    {
        [Key]
        public string EventId { get; set; }
       
        public string EventName { get; set; }
        public string EventDescription { get; set; }

    }
}
