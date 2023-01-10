// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPISampleProject.Models;

namespace WebAPISampleProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BinaryGoController : ControllerBase
{
    readonly IBinarySerialization _binarySerialization;
    public BinaryGoController(IBinarySerialization binarySerialization)
    {
        _binarySerialization = binarySerialization;
    }

    [Route("Serialize")]
    [HttpGet]
    public IActionResult Serialize_BinaryGo()
    {
        User model = new User() { Age = 51, FirstName = "Elon", LastName = "Musk" };
        var result = _binarySerialization.Serialize(model);
        return Ok(result.ToArray());
    }

    [Route("Deserialize")]
    [HttpPost]
    public IActionResult Deserialize_BinaryGo(byte[] input)
    {
        var result = _binarySerialization.Deserialize<User>(input);
        return Ok(result);
    }
}
