using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
	public class PrayerTime
	{
		[Key]
		public String PrayerName {  get; set; }
		public String PrayerStart { get;set; }
		public String PrayerEnd { get; set; }
	}
}
