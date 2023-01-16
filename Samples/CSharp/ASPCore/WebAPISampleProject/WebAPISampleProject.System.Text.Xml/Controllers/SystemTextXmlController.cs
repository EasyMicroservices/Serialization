// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Common.Models;
using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISampleProject.System.Text.Xml.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SystemTextXmlController : ControllerBase
{
    private readonly ITextSerialization _textSerialization;

    public SystemTextXmlController(ITextSerialization textSerialization)
    {
        _textSerialization = textSerialization;
    }
    [Route("Serialize")]
    [HttpGet]
    public IActionResult Serialize()
    {
        Customer model = new Customer() { Age = 51, FirstName = "Elon", LastName = "Musk" };
        var result = _textSerialization.Serialize(model);
        return Ok(result);
    }

    [Route("Deserialize")]
    [HttpPost]
    public IActionResult Deserialize(string input)
    {
        var result = _textSerialization.Deserialize<Customer>(input);
        return Ok(result);
    }
}
