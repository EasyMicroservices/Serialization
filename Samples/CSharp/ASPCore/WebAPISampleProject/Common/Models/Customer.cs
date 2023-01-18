// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using MessagePack;
//using MemoryPack;

namespace Common.Models;

[MessagePackObject]
//[MemoryPackable]
public partial class  Customer
{
    [Key(0)]
    public string FirstName { get; set; }
    [Key(1)]
    public string LastName { get; set; }
    [Key(2)]
    public int Age { get; set; }

    public Address Address { get; set; }
}

//[MemoryPackable]
 public partial class Address
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}
