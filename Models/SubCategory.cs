﻿using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class SubCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
