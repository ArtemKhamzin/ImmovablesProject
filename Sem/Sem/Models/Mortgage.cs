using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem.Models
{
    public class Mortgage
    {
        [Key]
        public int MortgageId { get; set; }
        
        public User User { get; set; }
        
        public string Bank { get; set; }
        
        public int MortgageRate { get; set; }
        
        public int MonthlyPayment { get; set; }
        
        public byte Term { get; set; }
    }
}