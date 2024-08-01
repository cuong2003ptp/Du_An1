using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class QuanLyBanNuocContext : DbContext
{
    public QuanLyBanNuocContext()
    {
    }

    public QuanLyBanNuocContext(DbContextOptions<QuanLyBanNuocContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hdct> Hdcts { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DuyDuc;Database=QuanLyBanNuoc;Trusted_Connection=True;TrustServerCertificate=True;\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hdct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HDCT__3213E83FB499C59A");

            entity.ToTable("HDCT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.IdHd).HasColumnName("idHD");
            entity.Property(e => e.IdSp).HasColumnName("idSP");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");

            entity.HasOne(d => d.IdHdNavigation).WithMany(p => p.Hdcts)
                .HasForeignKey(d => d.IdHd)
                .HasConstraintName("FK__HDCT__idHD__628FA481");

            entity.HasOne(d => d.IdSpNavigation).WithMany(p => p.Hdcts)
                .HasForeignKey(d => d.IdSp)
                .HasConstraintName("FK__HDCT__idSP__6383C8BA");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDon__3213E83F23FDE726");

            entity.ToTable("HoaDon");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idNV");
            entity.Property(e => e.Idkh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idkh");
            entity.Property(e => e.Idvoucher).HasColumnName("idvoucher");
            entity.Property(e => e.TongTien).HasColumnType("money");
            entity.Property(e => e.TrangThai).HasColumnName("trangThai");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__HoaDon__idNV__5FB337D6");

            entity.HasOne(d => d.IdkhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.Idkh)
                .HasConstraintName("FK_HoaDon_KH");

            entity.HasOne(d => d.IdvoucherNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.Idvoucher)
                .HasConstraintName("FK__HoaDon__idvouche__5EBF139D");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.IdKh).HasName("PK__khachhan__9DB8717443AE8CB8");

            entity.ToTable("khachhang");

            entity.Property(e => e.IdKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idKH");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TenKh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tenKH");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.IdNcc).HasName("PK__Nhacungc__3FFD068C1601F664");

            entity.ToTable("Nhacungcap");

            entity.Property(e => e.IdNcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idNCC");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.SdtNcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdtNCC");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tenNCC");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.IdNv).HasName("PK__Nhanvien__9DB8791CF7617928");

            entity.ToTable("Nhanvien");

            entity.Property(e => e.IdNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idNV");
            entity.Property(e => e.Chucvu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("chucvu");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matkhau");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Taikhoan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("taikhoan");
            entity.Property(e => e.TenNv)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tenNV");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3213E83FCA8D5DF6");

            entity.ToTable("SanPham");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.IdNcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idNCC");
            entity.Property(e => e.LoaiSp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoaiSP");
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdNcc)
                .HasConstraintName("FK__SanPham__idNCC__52593CB8");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.IdVoucher).HasName("PK__voucher__BD9AA6BEF2FD1B26");

            entity.ToTable("voucher");

            entity.Property(e => e.IdVoucher).HasColumnName("idVoucher");
            entity.Property(e => e.NgayKetThuc).HasColumnName("ngayKetThuc");
            entity.Property(e => e.NgayTao).HasColumnName("ngayTao");
            entity.Property(e => e.PtGiam).HasColumnName("ptGiam");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
