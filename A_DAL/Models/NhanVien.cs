using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Nhanvien
{
    public string IdNv { get; set; } = null!;

    public string TenNv { get; set; } = null!;

    public int Tuoi { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public bool? Gioitinh { get; set; }

    public string Chucvu { get; set; } = null!;

    public string Taikhoan { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
