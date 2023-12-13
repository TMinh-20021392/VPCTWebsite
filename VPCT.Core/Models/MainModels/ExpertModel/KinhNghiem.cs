using System.ComponentModel.DataAnnotations;

namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class KinhNghiem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CoQuan { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public double? KinhPhi { get; set; }
        public LoaiKinhNghiem Type { get; set; }
        public int ChuyenGiaId { get; set; }
        public virtual ChuyenGia? ChuyenGia { get; set; }

        public enum LoaiKinhNghiem
        {
            [Display(Name = "Chủ trì")] Presidency,
            [Display(Name = "Tham gia")] Participation
        }
    }
}
