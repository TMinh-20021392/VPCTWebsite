﻿namespace VPCT.Core.Models.MainModels.ExpertModel
{
    public class ChucVu
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<ChuyenGia>? ChuyenGia { get; set; }
    }
}