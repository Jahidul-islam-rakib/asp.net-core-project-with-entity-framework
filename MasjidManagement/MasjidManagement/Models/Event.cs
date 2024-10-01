using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
    public class Event
    {
		[Key]
        public int Id { get; set; }

		public String EventName { get; set; }
        public string EventId { get; set; }
        public string Location { get; set; }
    }
}
