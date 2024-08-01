using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Nhacungcap
{
    public string IdNcc { get; set; } = null!;

    public string TenNcc { get; set; } = null!;

    public string? Diachi { get; set; }

    public string? SdtNcc { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
