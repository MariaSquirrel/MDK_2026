using System;
using System.Collections.Generic;

namespace AvaloniaShoe.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductArticl { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductUnit { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public int SupplierId { get; set; }

    public int ManufacturerId { get; set; }

    public int CategorieId { get; set; }

    public decimal? ProductDiscount { get; set; }

    public int? ProductQuantity { get; set; }

    public string? Description { get; set; }

    public string? PhotoPath { get; set; }

    public virtual Category Categorie { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Supplier Supplier { get; set; } = null!;
}
