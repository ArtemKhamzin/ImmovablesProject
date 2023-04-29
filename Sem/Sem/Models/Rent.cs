using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem.Models
{
    public class Rent
    {
        public int Id { get; set; }
        
        public Immovable Immovable { get; set; }
        
        public User User { get; set; }
        
        public long Price { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime PostingDate { get; set; }
    }
}