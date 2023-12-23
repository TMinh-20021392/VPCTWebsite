using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VPCT.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? ImageName { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        public string? ImageSrc { get; set; }

    }
}
