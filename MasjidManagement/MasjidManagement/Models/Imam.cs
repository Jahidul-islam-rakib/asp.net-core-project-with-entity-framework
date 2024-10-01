using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasjidManagement.Models
{
	public class Imam
	{
		[Key] public int Id { get; set; }
		public int ImamId { get; set; }
		public String ImamName { get; set; }
		public String Qualification { get; set; }
		public String HireDate {  get; set; }
	}
}
