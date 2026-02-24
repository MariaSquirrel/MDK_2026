using System;
using System.Collections.Generic;

namespace AvaloniaShoe.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string FullAddress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
