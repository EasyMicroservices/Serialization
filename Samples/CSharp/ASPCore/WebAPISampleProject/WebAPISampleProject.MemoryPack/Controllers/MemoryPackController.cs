// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using MemoryPack;

namespace WebAPISampleProject.MemoryPack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemoryPackController : ControllerBase
    {

       /* [Route("Serialize")]
        [HttpGet]
        public IActionResult Serialize()
        {
            Customer model = new Customer() { Age = 51, FirstName = "Elon", LastName = "Musk" };
            var result = MemoryPackSerializer.Serialize(model);
            return Ok(result);
        }*/

    }




}
