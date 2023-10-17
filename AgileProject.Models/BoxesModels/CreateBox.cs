using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Models.BoxesModels
{
    public class CreateBox
    {
        [Required]
        public string? Name { get; set; }
        [Required]  
        public string? Type { get; set; }
    }
}