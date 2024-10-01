using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Loan
	{
		[Key] public int Id { get; set; }

		public int BookId { get; set; }
		public string MemberId { get; set; }
		public string DueDate { get; set; }
	}
}
