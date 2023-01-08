using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.MessagePack.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISampleProject.Models;


namespace WebAPISampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryController : ControllerBase
    {
        private readonly IBinarySerialization _binarySerialization;

        public BinaryController(IBinarySerialization binarySerialization)
        {
            _binarySerialization = binarySerialization;

        }

        [Route("Serialize")]
        [HttpGet]
        public IActionResult Serialize()
        {
            User model = new User() { Age = 51, FirstName = "Elon", LastName = "Musk" };

            MessagePackProvider p = new MessagePackProvider();
            ReadOnlySpan<byte> result = p.Serialize(model);


           //  var resultInterface= _binarySerialization.Serialize(model);

            return Ok(result.ToArray());
        }

        [Route("Deserialize")]
        [HttpPost]
        public IActionResult Deserialize( byte[] input)
        {
            MessagePackProvider p = new MessagePackProvider();
            var result = p.Deserialize<User>(input); // _binarySerialization.Deserialize<User>(input);
            return Ok(result);
        }


    }
}
