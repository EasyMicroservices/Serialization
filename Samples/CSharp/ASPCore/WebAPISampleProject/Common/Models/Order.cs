// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Common.Models;

public class Order
{
    public List<Item> Items { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer Customer { get; set; }
}

public class Item
{
    public string description { get; set; }
    public decimal price { get; set; }
    public int quantity { get; set; }
}
