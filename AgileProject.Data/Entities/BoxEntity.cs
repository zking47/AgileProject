using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Data.Entities
{
    public class BoxEntity
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? EmailAddress { get; set; }
        [Required]
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }  
        public UserEntity Owner { get; set; } = null!;
        [Required]  
        public string? Type { get; set; }
        public DateTime DateCreated { get; set; }
    }
}