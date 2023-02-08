﻿using Northwind.Model;

namespace Northwind.UI.Internet.ViewModels
{
    public class CartViewModel
    {
        public List<Product> Items { get; set; } = new List<Product>();
        public int Count => Items.Count;
        public decimal Total => Items.Sum(p => p.UnitPrice ?? 0);
    }
}
