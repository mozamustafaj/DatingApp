using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] //anotations
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}