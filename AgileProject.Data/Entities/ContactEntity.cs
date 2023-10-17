using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Data.Entities
{
    public class ContactEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Owner))]
        public int UserId { get; set; }
        public UserEntity Owner { get; set; } = null!;
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Email { get; set; }
        [Required]
        [MaxLength(14)]
        public string? PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }
}