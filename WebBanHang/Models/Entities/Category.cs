using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; } // Khóa chính của Category

        public string CategoryName { get; set; } // Tên của Category

        public virtual ICollection<Product> Products { get; set; } // Danh sách sản phẩm thuộc Category

    }
}
