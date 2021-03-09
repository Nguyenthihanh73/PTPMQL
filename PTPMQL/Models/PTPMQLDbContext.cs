using System.Data.Entity;

namespace PTPMQL.Models
{
    public partial class PTPMQLDbContext : DbContext
    {
        public PTPMQLDbContext()
            : base("name=PTPMQLDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);
            {
            }
            
             public virtual DbSet<NhanVien> NhanViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)


        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);
            {
            }
            public virtual DbSet<NhanVien> DanhMucs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<DanhMuc>()
                    .Property(e => e.PhanLoaiDanhMuc )
                    .IsUnicode(false);

                modelBuilder.Entity<DanhMuc >()
                    .Property(e => e.MaDanhMuc )
                    .IsUnicode(false);
            }
            

        }
            
    }
}
