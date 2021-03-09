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
           

        }
            
    }
}
