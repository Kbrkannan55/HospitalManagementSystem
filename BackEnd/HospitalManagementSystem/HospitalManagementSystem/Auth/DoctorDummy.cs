using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class DoctorDummys
    {
        [Required]
        public string? Names { get; set; }
        [Key]
        public string? User { get; set; }
        [Required]
        public string? EmailId { get; set; }
        [Required]
        public string? Role { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}
