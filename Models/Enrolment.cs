using System.ComponentModel.DataAnnotations;

namespace sports_events.Models
{
    public class Enrolment
    {
        [Key] 
        public int EnrolmentId { get; set; }

        public string EnrolmentName { get; set; }

        public string EnrolmentType { get; set; }

       



    }
}
