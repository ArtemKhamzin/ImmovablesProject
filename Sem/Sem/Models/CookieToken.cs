using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem.Models
{
    public class CookieToken
    {
        public int Id { get; set; }
        
        [Required]
        public User User { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Token { get; set; }
    }
}