using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FUUniversity.models
{
    public partial class FPTUniversityDBContext : DbContext
    {
        public FPTUniversityDBContext()
        {
        }

        public FPTUniversityDBContext(DbContextOptions<FPTUniversityDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DangKyMonHoc> DangKyMonHocs { get; set; } = null!;
        public virtual DbSet<Diem> Diems { get; set; } = null!;
        public virtual DbSet<GiangVien> GiangViens { get; set; } = null!;
        public virtual DbSet<LopHoc> LopHocs { get; set; } = null!;
        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=FPTUniversityDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKyMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaDangKy)
                    .HasName("PK__DangKyMo__BA90F02D3DA6B81B");

                entity.ToTable("DangKyMonHoc");

                entity.HasIndex(e => new { e.MaSinhVien, e.MaMonHoc }, "UQ__DangKyMo__77889043C12F944D")
                    .IsUnique();

                entity.Property(e => e.NgayDangKy)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaMonHocNavigation)
                    .WithMany(p => p.DangKyMonHocs)
                    .HasForeignKey(d => d.MaMonHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DangKyMon__MaMon__36B12243");

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany(p => p.DangKyMonHocs)
                    .HasForeignKey(d => d.MaSinhVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DangKyMon__MaSin__35BCFE0A");
            });

            modelBuilder.Entity<Diem>(entity =>
            {
                entity.HasKey(e => e.MaDiem)
                    .HasName("PK__Diem__33326025914C5CD9");

                entity.ToTable("Diem");

                entity.HasIndex(e => new { e.MaSinhVien, e.MaMonHoc }, "UQ__Diem__77889043BFA37C7B")
                    .IsUnique();

                entity.Property(e => e.DiemGiuaKy).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.DiemThi).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.DiemTrungBinh)
                    .HasColumnType("numeric(6, 3)")
                    .HasComputedColumnSql("(case when [DiemGiuaKy] IS NOT NULL AND [DiemThi] IS NOT NULL then [DiemGiuaKy]*(0.4)+[DiemThi]*(0.6)  end)", false);

                entity.HasOne(d => d.MaMonHocNavigation)
                    .WithMany(p => p.Diems)
                    .HasForeignKey(d => d.MaMonHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Diem__MaMonHoc__3B75D760");

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany(p => p.Diems)
                    .HasForeignKey(d => d.MaSinhVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Diem__MaSinhVien__3A81B327");
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.MaGiangVien)
                    .HasName("PK__GiangVie__C03BEEBA652A9490");

                entity.ToTable("GiangVien");

                entity.Property(e => e.ChuyenNganh).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasMany(d => d.MaMonHocs)
                    .WithMany(p => p.MaGiangViens)
                    .UsingEntity<Dictionary<string, object>>(
                        "GiangVienMonHoc",
                        l => l.HasOne<MonHoc>().WithMany().HasForeignKey("MaMonHoc").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__GiangVien__MaMon__3F466844"),
                        r => r.HasOne<GiangVien>().WithMany().HasForeignKey("MaGiangVien").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__GiangVien__MaGia__3E52440B"),
                        j =>
                        {
                            j.HasKey("MaGiangVien", "MaMonHoc").HasName("PK__GiangVie__2429998D7CDABCE7");

                            j.ToTable("GiangVien_MonHoc");
                        });
            });

            modelBuilder.Entity<LopHoc>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__LopHoc__3B98D27384F82C5E");

                entity.ToTable("LopHoc");

                entity.HasOne(d => d.MaGiangVienNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.MaGiangVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHoc__MaGiangV__2D27B809");

                entity.HasOne(d => d.MaMonHocNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.MaMonHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHoc__MaMonHoc__2C3393D0");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMonHoc)
                    .HasName("PK__MonHoc__4127737F32E74F34");

                entity.ToTable("MonHoc");

                entity.Property(e => e.ChuyenNganh).HasMaxLength(100);

                entity.Property(e => e.TenMonHoc).HasMaxLength(100);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSinhVien)
                    .HasName("PK__SinhVien__939AE775D35A6890");

                entity.ToTable("SinhVien");

                entity.Property(e => e.DiemTrungBinh)
                    .HasColumnType("decimal(3, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Khoa).HasMaxLength(100);

                entity.Property(e => e.Lop).HasMaxLength(50);

                entity.Property(e => e.SoLuongMonHoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasMany(d => d.MaLops)
                    .WithMany(p => p.MaSinhViens)
                    .UsingEntity<Dictionary<string, object>>(
                        "SinhVienLopHoc",
                        l => l.HasOne<LopHoc>().WithMany().HasForeignKey("MaLop").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__SinhVien___MaLop__30F848ED"),
                        r => r.HasOne<SinhVien>().WithMany().HasForeignKey("MaSinhVien").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__SinhVien___MaSin__300424B4"),
                        j =>
                        {
                            j.HasKey("MaSinhVien", "MaLop").HasName("PK__SinhVien__B0236A52E6D9BCD2");

                            j.ToTable("SinhVien_LopHoc");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
