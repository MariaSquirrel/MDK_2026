using System;
using System.Collections.Generic;

namespace AvaloniaShoe.Models;

public partial class Category
{
    public int CategorieId { get; set; }

    public string CategorieName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
