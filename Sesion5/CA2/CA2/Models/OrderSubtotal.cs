﻿using System;
using System.Collections.Generic;

namespace CA2.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
