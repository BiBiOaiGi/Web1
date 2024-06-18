using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class Manufacturer
    {
        [Key]
        public string ManufacturerId { get; set; } // Khóa chính của Manufacturer
        public string ManufacturerName { get; set; } // Tên của Manufacturer
        public string Address { get; set; } // Địa chỉ của Manufacturer
        public string ContactNumber { get; set; }

        // Danh sách các sản phẩm do Manufacturer này sản xuất
        public virtual ICollection<Product> Products { get; set; }

    }
}
