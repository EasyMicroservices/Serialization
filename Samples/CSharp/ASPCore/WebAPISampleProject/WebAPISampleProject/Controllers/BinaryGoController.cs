// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using EasyMicroservices.Serialization.BinaryGo.Providers;
using Microsoft.AspNetCore.Mvc;
using WebAPISampleProject.Models;

namespace WebAPISampleProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BinaryGoController : ControllerBase
{

    [Route("Serialize")]
    [HttpGet]
    public IActionResult Serialize_MessagePack()
    {
        User model = new User() { Age = 51, FirstName = "Elon", LastName = "Musk" };

        BinaryGoProvider p = new BinaryGoProvider();
        ReadOnlySpan<byte> result = p.Serialize(model);


        //  var resultInterface= _binarySerialization.Serialize(model);

        return Ok(result.ToArray());
    }

    [Route("Deserialize")]
    [HttpPost]
    public IActionResult Deserialize_MessagePack( byte[] input)
    {
        BinaryGoProvider p = new BinaryGoProvider();
        var result = p.Deserialize<User>(input); // _binarySerialization.Deserialize<User>(input);
        return Ok(result);
    }

}
