using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models.Entities
{
    public class Product
    {
        [Key]
        public string ProductID { get; set; } // Khóa chính của sản phẩm

        [Required]
        public string ProductName { get; set; } // Tên sản phẩm

        public float Price { get; set; } // Giá sản phẩm

        public int Quantity { get; set; } // Số lượng sản phẩm

        public string ProductDescription { get; set; } // Mô tả sản phẩm

        [ForeignKey("Category")]
        public string CategoryID { get; set; } // Khóa ngoại đến Category
        public virtual Category Category { get; set; } // Đối tượng Category tương ứng

        [ForeignKey("Manufacturer")]
        public string ManufacturerId { get; set; } // Khóa ngoại đến Manufacturer
        public virtual Manufacturer Manufacturer { get; set; } // Đối tượng Manufacturer tương ứng

        [ForeignKey("Supplier")]
        public string SupplierId { get; set; } // Khóa ngoại đến Supplier
        public virtual Supplier Supplier { get; set; } // Đối tượng Supplier tương ứng

    }
}
