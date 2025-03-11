using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Persons
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public string IdNumber { get; set; }
    }
}
