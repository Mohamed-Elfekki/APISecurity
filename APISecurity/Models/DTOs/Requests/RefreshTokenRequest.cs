using Microsoft.Build.Framework;

namespace APISecurity.Models.DTOs.Requests
{
    public class RefreshTokenRequest
    {
        [Required]
        public string refreshToken { get; set; }
    }
}
