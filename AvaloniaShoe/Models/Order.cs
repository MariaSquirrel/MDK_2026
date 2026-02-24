using System;
using System.Collections.Generic;

namespace AvaloniaShoe.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public int AddressId { get; set; }

    public string PickupCode { get; set; } = null!;

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual OrderStatus Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
