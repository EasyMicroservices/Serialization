// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.MessagePack.Providers;
using Microsoft.AspNetCore.Mvc;
using WebAPISampleProject.Models;

namespace WebAPISampleProject.Controllers;


    [Route("api/[controller]")]
    [ApiController]
    public class MessagePackController : ControllerBase
    {
        //private readonly IBinarySerialization _binarySerialization;

        /*public MessagePackController(IBinarySerialization binarySerialization)
        {
          //  _binarySerialization = binarySerialization;

        }*/

        [Route("Serialize")]
        [HttpGet]
        public IActionResult Serialize_MessagePack()
        {
            User model = new User() { Age = 51, FirstName = "Elon", LastName = "Musk" };

            MessagePackProvider p = new MessagePackProvider();
            ReadOnlySpan<byte> result = p.Serialize(model);


            //  var resultInterface= _binarySerialization.Serialize(model);

            return Ok(result.ToArray());
        }

        [Route("Deserialize")]
        [HttpPost]
        public IActionResult Deserialize_MessagePack( byte[] input)
        {
            MessagePackProvider p = new MessagePackProvider();
            var result = p.Deserialize<User>(input); // _binarySerialization.Deserialize<User>(input);
            return Ok(result);
        }


    }



