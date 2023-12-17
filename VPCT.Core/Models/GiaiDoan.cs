using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models
{
    public class GiaiDoan
    {
        public int Id { get; set; }
        [Required]
        public int Start { get; set; }
        [Required]
        public int End { get; set; }
        public bool Default { get; set; } = false;
    }
}
