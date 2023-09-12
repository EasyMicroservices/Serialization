// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Common.Models;
using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace WebAPISampleProject.BinaryGo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DIController : ControllerBase
{
    private readonly IBinarySerializationProvider _binarySerialization;
    private readonly ITextSerializationProvider _textSerialization;

    public DIController(IBinarySerializationProvider binarySerialization, ITextSerializationProvider textSerialization)
    {
        _binarySerialization = binarySerialization;
        _textSerialization = textSerialization;
    }

    [Route("Serialize")]
    [HttpGet]
    public IActionResult Serialize()
    {
        Customer model = new Customer() { Age = 51, FirstName = "Elon", LastName = "Musk" };
        var result = _textSerialization.Serialize(model);
        var binary = _binarySerialization.Serialize(model);
        return Ok(result);
    }
}
