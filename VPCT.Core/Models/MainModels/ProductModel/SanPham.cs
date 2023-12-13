namespace VPCT.Core.Models.MainModels.ProductModel
{
    public abstract class SanPham
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsRegistered { get; set; } = false;
        public bool IsSucceeded { get; set; } = false;
        public bool IsOutstanding { get; set; } = false;
    }
}
