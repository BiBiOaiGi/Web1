using Microsoft.EntityFrameworkCore;
using WebBanHang.Models.Entities;

namespace WebBanHang.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; } // Bảng Products trong cơ sở dữ liệu
        public DbSet<Category> Categories { get; set; } // Bảng Categories trong cơ sở dữ liệu
        public DbSet<Manufacturer> Manufacturers { get; set; } // Bảng Manufacturers trong cơ sở dữ liệu
        public DbSet<Supplier> Suppliers { get; set; } // Bảng Suppliers trong cơ sở dữ liệu

    }
}
