// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Common.Models;
using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISampleProject.System.YamlDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class YamlDotNetController : ControllerBase
{
    private readonly ITextSerialization _textSerialization;

    public YamlDotNetController(ITextSerialization textSerialization)
    {
        _textSerialization = textSerialization;
    }

    [Route("Serialize")]
    [HttpGet]
    public IActionResult Serialize()
    {
        var model = Get_Sample_Data();
        var result = _textSerialization.Serialize(model);
        return Ok(result);
    }

    [Route("Deserialize")]
    [HttpPost]
    public IActionResult Deserialize(string input)
    {
        var result = _textSerialization.Deserialize<Order>(input);
        return Ok(result);
    }

    [Route("Get_Sample_Data")]
    [HttpGet]
    public Order Get_Sample_Data()
    {
        var order = new Order()
        {
            Customer = new Customer()
            {
                Age = 51, FirstName = "Elon", LastName = "Musk" ,
                Address = new Address()
                {
                    city = "Robert Robertson" ,
                    street = "St. Robert",
                    state = "M"
                }
            },
            Items = new List<Item>()
            {
                new Item() { description = "SampleItem1", price = 1000, quantity = 5 },
                new Item() { description = "SampleItem2", price = 2000, quantity = 25 },
                new Item() { description = "SampleItem3", price = 300, quantity = 50 }
            },
            OrderDate = DateTime.Now

        };

        return order;
    }
}
