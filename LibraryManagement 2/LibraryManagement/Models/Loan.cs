using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Loan
	{
		public int BookId { get; set; }

		[Key]
		public string MemberId { get; set; }
		public string DueDate { get; set; }
	}
}
