using System;
using System.Collections.Generic;

namespace AutoShop.Models;

public partial class Detail
{
    public int NameId { get; set; }

    public string Name { get; set; } = null!;

    public string ModelCar { get; set; } = null!;

    public string YearofreleaseCar { get; set; } = null!;

    public decimal Price { get; set; }

    public int Count { get; set; }

    public string PathImage { get; set; } = null!;

    public int CarId { get; set; }

    public virtual Car Car { get; set; } = null!;

   
}
