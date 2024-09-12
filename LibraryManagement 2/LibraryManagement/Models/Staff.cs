using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Staff
	{
		[Key]
		public string StaffId { get; set; }
		public string StaffName { get; set; }
		public string StaffPosition { get; set; }
	}
}
