using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First name should contain only letters and spaces.")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name must be at most {1} characters long.")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Middle name should contain only letters and spaces.")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last name should contain only letters and spaces.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(\+?\d{2})?[789]\d{9}$", ErrorMessage = "Please enter a valid Indian phone number.")]
        public string PhoneNo { get; set; }
    }
}
