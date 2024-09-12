using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Library
	{
		[Key]
        public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
    }
}
