namespace VPCT.Core.Models.MainModels.ProgramModel
{
    public class LoaiChuongTrinh
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsPeriodic { get; set; } = false;
        public virtual ICollection<ChuongTrinh>? ChuongTrinh { get; set; }
    }
}
