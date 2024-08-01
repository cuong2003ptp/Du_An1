using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Voucher
{
    public int IdVoucher { get; set; }

    public int? PtGiam { get; set; }

    public DateOnly? NgayTao { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
