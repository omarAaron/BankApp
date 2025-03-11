using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace BankingApp.Models
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; } 
        [Required]
        public decimal Balance { get; set; }
        [Required]
        [StringLength(100)]
        public string AccountNumber { get; set; }
        [Required]
        public string Status { get; set; }
        public int PersonId { get; set; }  
        public Persons Person { get; set; } 
    }
}
