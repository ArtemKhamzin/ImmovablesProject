using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        public Status Status { get; set; }
        
        public string Photo { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Email { get; set; }
        
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Surname { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(32)")]
        public string HashedPassword { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string PhoneNumber { get; set; }
    }
}