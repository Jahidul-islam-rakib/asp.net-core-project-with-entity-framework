using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Category
	{
		[Key]
		public string Name { get; set; }
		public string Description { get; set; }
		public String CreatedDate {  get; set; }
	}
}
