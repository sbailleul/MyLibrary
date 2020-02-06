using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    public class AuthorForUpdate
    {
        [Required] [MaxLength(250)] public string FirstName { get; set; }

        [Required] [MaxLength(250)] public string LastName { get; set; }
    }
}