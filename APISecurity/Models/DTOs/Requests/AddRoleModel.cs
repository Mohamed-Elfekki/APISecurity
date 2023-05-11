using System.ComponentModel.DataAnnotations;

namespace APISecurity.Models.DTOs.Requests
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
