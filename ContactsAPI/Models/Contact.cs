using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Full Name Is Too Long")]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address Is Too Long")]
        public string Address { get; set; }
    }
}
