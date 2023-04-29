using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Sem.Models;

namespace Sem.Models
{
    public class Immovable
    {
        public int Id { get; set; }

        public string Photo { get; set; }
        
        public string SchemeImage { get; set; }

        public byte NumberOfRooms { get; set; }
        
        [Column(TypeName = "varchar(30)")]
        public string TypeOfImmovable { get; set; }
        
        public string RoomArea { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string Street { get; set; }
        
        public int House { get; set; }
        
        public byte Building  { get; set; }

        public int Apartment  { get; set; }
    }
}