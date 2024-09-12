using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
	public class Imam
	{
		[Key]
		public int ImamId { get; set; }
		public String ImamName { get; set; }
		public String Qualification { get; set; }
		public String HireDate {  get; set; }
	}
}
