using System.ComponentModel.DataAnnotations;

namespace APISecurity.Models.DTOs.Requests
{
    public class TokenRequestModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
