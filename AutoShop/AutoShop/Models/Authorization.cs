using System;
using System.Collections.Generic;

namespace AutoShop.Models;

public partial class Authorization
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
