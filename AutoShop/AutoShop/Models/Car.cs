using System;
using System.Collections.Generic;

namespace AutoShop.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Detail> Details { get; } = new List<Detail>();
}
