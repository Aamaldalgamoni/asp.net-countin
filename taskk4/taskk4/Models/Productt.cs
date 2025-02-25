using System;
using System.Collections.Generic;

namespace taskk4.Models;

public partial class Productt
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
