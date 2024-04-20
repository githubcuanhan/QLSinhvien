using Microsoft.EntityFrameworkCore;
using QLSinhVien_CodeFirst.Models;

namespace QLSinhVien_CodeFirst.Data
{
    public class AppDatabaseContext: DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options): base(options) { }  
        
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Khoa>().HasKey(x => x.MaKhoa);
            modelBuilder.Entity<Khoa>().HasData(
                    new Khoa { MaKhoa = 1, TenKhoa = "CNTT" },
                    new Khoa { MaKhoa = 2, TenKhoa = "Dien - Dien tu" },
                    new Khoa { MaKhoa = 3, TenKhoa = "Hoa hoc" },
                    new Khoa { MaKhoa = 4, TenKhoa = "Xay dung" }
                );

            modelBuilder.Entity<Lop>().HasKey(x => x.MaLop);
            modelBuilder.Entity<Lop>().HasData(
                    new Lop { MaLop = "21T3", GVCN = "Nguyen Văn Phát", Siso = 40, MaKhoa = 1 },
                    new Lop { MaLop = "21T2", GVCN = "Nguyễn Thị Hà Quyên", Siso = 40, MaKhoa = 1 },
                    new Lop { MaLop = "21T1", GVCN = "Trần Bửu Dung", Siso = 40, MaKhoa = 1 }
                );

            modelBuilder.Entity<SinhVien>().HasKey(x => x.MaSV);
            modelBuilder.Entity<SinhVien>().HasData(
                    new SinhVien { MaSV = "21115053120326", Hoten = "Nguyễn Hồ Thành Nhân", Diachi = "Đà Nẵng", MaLop = "21T3" },
                    new SinhVien { MaSV = "21115053120333", Hoten = "Hồ Thành Nhân", Diachi = "Quảng Nam", MaLop = "21T3" },
                    new SinhVien { MaSV = "21115053120309", Hoten = "Thành Nhân", Diachi = "Quảng Nam", MaLop = "21T3" },
                    new SinhVien { MaSV = "21115053120312", Hoten = "Nguyễn Nhân", Diachi = "Quảng Nam", MaLop = "21T3" },
                    new SinhVien { MaSV = "21115053120312", Hoten = "Nhân", Diachi = "Quảng Nam", MaLop = "21T3" }
                );
        }
    }
}
