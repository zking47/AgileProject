using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProject.Models.Contact.Management
{
       public class ReadAllContacts
    {
        public string? FirstName {get; set; }
        public string? LastName {get; set; }
        public DateTime DateCreated {get; set; }
    }
}