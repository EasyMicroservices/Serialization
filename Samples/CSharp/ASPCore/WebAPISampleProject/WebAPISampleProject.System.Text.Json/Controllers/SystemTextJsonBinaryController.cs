// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Common.Models;
using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISampleProject.System.Text.Json.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemTextJsonBinaryController : ControllerBase
    {
        private readonly IBinarySerialization _binarySerialization;

        public SystemTextJsonBinaryController(IBinarySerialization binarySerialization)
        {
            _binarySerialization = binarySerialization;
        }

        [Route("Serialize")]
        [HttpGet]
        public IActionResult Serialize()
        {
            Customer model = new Customer() { Age = 51, FirstName = "Elon", LastName = "Musk" };
            var result = _binarySerialization.Serialize(model);
            return Ok(result.ToArray());
        }

        [Route("Deserialize")]
        [HttpPost]
        public IActionResult Deserialize(byte[] input)
        {
            var result = _binarySerialization.Deserialize<Customer>(input);
            return Ok(result);
        }

    }
}
