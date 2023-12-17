using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class VanBang
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int Year { get; set; }
        public int ChuyenGiaId { get; set; }
        public virtual ChuyenGia? ChuyenGia { get; set; }
    }
}
