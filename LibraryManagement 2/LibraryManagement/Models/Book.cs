using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Book
	{
		public String Title { get; set; }
		public String Auther { get; set; }

		[Key]
		public String ISBN {  get; set; }
	}
}
