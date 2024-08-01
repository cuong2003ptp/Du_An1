using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Khachhang
{
    public string IdKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public bool? Gioitinh { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
