﻿using System;
using System.Collections.Generic;

namespace ConnectSQL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public short UnitslnStock { get; set; }

    public int CategoryId { get; set; }
}
