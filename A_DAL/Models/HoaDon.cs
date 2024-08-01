using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public DateOnly? NgayLap { get; set; }

    public decimal? TongTien { get; set; }

    public int? TrangThai { get; set; }

    public string? IdNv { get; set; }

    public int? Idvoucher { get; set; }

    public string? Idkh { get; set; }

    public virtual ICollection<Hdct> Hdcts { get; set; } = new List<Hdct>();

    public virtual Nhanvien? IdNvNavigation { get; set; }

    public virtual Khachhang? IdkhNavigation { get; set; }

    public virtual Voucher? IdvoucherNavigation { get; set; }
}
