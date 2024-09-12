using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
    public class Event
    {
        public String EventName { get; set; }
        [Key]
        public string EventId { get; set; }
        public string Location { get; set; }
    }
}
