﻿using System.ComponentModel.DataAnnotations;

namespace MasjidManagement.Models
{
    public class Donation
    {
        [Key] public int Id { get; set; }
        public String DonorId { get; set; }
        public String DonorName { get; set; }
        public int Amount { get; set; }
        public string DonationDate {  get; set; }
    }
}
