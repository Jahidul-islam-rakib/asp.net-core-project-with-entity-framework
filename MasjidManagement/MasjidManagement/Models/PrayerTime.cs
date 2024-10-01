using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
	public class PrayerTime
	{
		[Key] public int Id { get; set; }
		public String PrayerName {  get; set; }
		public String PrayerStart { get;set; }
		public String PrayerEnd { get; set; }
	}
}
