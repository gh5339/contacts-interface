using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsInterface.Models
{
    public class Contact
    {
        public Contact()
        {
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "First name cannot exceed 250 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Last name cannot exceed 250 characters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Phone Number name cannot exceed 15 characters.")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
