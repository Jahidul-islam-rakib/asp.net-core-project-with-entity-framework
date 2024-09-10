using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
	public class Hotel
	{
		[Key]
		public int ClientId { get; set; }
		public string Name { get; set; }
		public string NID {  get; set; }
		public string Address {  get; set; }
	}
}
