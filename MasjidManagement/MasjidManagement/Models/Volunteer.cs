using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
	public class Volunteer
	{
		[Key]
		public String VId { get; set; }
		public String VName { get; set; }
		public String VRole { get; set; }
		public String VContactNumber {  get; set; }
	}
}
