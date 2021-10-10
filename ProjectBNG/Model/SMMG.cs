namespace ProjectBNG.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SMMG : DbContext
    {
        public SMMG()
            : base("name=SMMG")
        {
        }

        public virtual DbSet<BiThu> BiThu { get; set; }
        public virtual DbSet<CoSo> CoSo { get; set; }
        public virtual DbSet<DienMat> DienMat { get; set; }
        public virtual DbSet<DienMatTemp> DienMatTemp { get; set; }
        public virtual DbSet<FileDinhKemDienMat> FileDinhKemDienMat { get; set; }
        public virtual DbSet<KiemChungDien> KiemChungDien { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<NoiGui> NoiGui { get; set; }
        public virtual DbSet<NoiNhan> NoiNhan { get; set; }
        public virtual DbSet<NoiNhanTemp> NoiNhanTemp { get; set; }
        public virtual DbSet<NguoiDuyet> NguoiDuyet { get; set; }
        public virtual DbSet<NguoiKy> NguoiKy { get; set; }
        public virtual DbSet<Nhom> Nhom { get; set; }
        public virtual DbSet<PemisionDetail> PemisionDetail { get; set; }
        public virtual DbSet<Permision> Permision { get; set; }
        public virtual DbSet<PhanLoaiNoiNhan> PhanLoaiNoiNhan { get; set; }
        public virtual DbSet<TuyChinh> TuyChinh { get; set; }
        public virtual DbSet<TuyChinhCombobox> TuyChinhCombobox { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<DienMatDaPhanPhoi> DienMatDaPhanPhoi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DienMat>()
                .Property(e => e.DoMatFile)
                .IsFixedLength();

            modelBuilder.Entity<DienMat>()
                .Property(e => e.NguoiIn)
                .IsUnicode(false);

            modelBuilder.Entity<NoiGui>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<PemisionDetail>()
                .Property(e => e.Per_Action)
                .IsUnicode(false);

            modelBuilder.Entity<PemisionDetail>()
                .Property(e => e.Per)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DienMat)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.idUsername);

            modelBuilder.Entity<DienMatDaPhanPhoi>()
                .Property(e => e.DoMatFile)
                .IsFixedLength();
        }
    }
}
