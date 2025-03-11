using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; } 
        public DateTime CaptureDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; } 
        public Accounts Account { get; set; } 
    }
}
