using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Sem.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public Immovable Immovable { get; set; }
        
        public User User { get; set; }
        
        public long Price { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime PostingDate { get; set; }
    }
}