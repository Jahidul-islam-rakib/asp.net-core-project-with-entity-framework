using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
	public class Volunteer
	{
		[Key] public int Id { get; set; }
		public String VId { get; set; }
		public String VName { get; set; }
		public String VRole { get; set; }
		public String VContactNumber {  get; set; }
	}
}
