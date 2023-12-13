namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class ChucDanh
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
    }
}