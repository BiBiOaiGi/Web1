namespace WebBanHang.Models.Entities
{
    public class Supplier
    {
        public string SupplierId { get; set; } // Khóa chính của Supplier
        public string SupplierName { get; set; } // Tên của Supplier
        public string Address { get; set; } // Địa chỉ của Supplier
        public string ContactNumber { get; set; }

        // Danh sách các sản phẩm do Supplier này cung cấp
        public virtual ICollection<Product> Products { get; set; }
    }
}
