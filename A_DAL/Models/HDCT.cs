using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Hdct
{
    public int Id { get; set; }

    public int? IdHd { get; set; }

    public int? IdSp { get; set; }

    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public int? Trangthai { get; set; }

    public virtual HoaDon? IdHdNavigation { get; set; }

    public virtual SanPham? IdSpNavigation { get; set; }
}
