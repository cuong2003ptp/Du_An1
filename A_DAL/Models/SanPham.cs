using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class SanPham
{
    public int Id { get; set; }

    public string? TenSp { get; set; }

    public string? LoaiSp { get; set; }

    public decimal? DonGia { get; set; }

    public int? SoLuongTon { get; set; }

    public string? IdNcc { get; set; }

    public virtual ICollection<Hdct> Hdcts { get; set; } = new List<Hdct>();

    public virtual Nhacungcap? IdNccNavigation { get; set; }
}
