using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Data.Entities
{
    public class MailEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string? Subject { get; set; } 
        [MaxLength(8000)]
        public string? Body { get; set; }
        [Required]
        [ForeignKey(nameof(Owner))]
        public int SenderId { get; set; }
        public UserEntity Owner { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Contact))]
        public int RecipientId { get; set; }
        public ContactEntity Contact { get; set;} = null!;
        [Required]
        [ForeignKey(nameof(RBox))]
        public int ReceiverBoxId { get; set; }
        public BoxEntity RBox { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(CBox))]
        public int CurrentBoxId { get; set; }
        public BoxEntity CBox { get; set; } = null!;
        public bool IsRead { get; set; }
        public DateTime DateCreated { get; set; }
    }
}