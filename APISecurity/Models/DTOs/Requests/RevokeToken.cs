using System.ComponentModel.DataAnnotations;

namespace APISecurity.Models.DTOs.Requests
{
    public class RevokeToken
    {
        //? cookie || manual
        [Required]
        public string refreshToken { get; set; }
    }
}
