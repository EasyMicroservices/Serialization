# Serialization
Wrapper for any Serialize package

Install packages:

1. Core package:

    [![NuGet](https://img.shields.io/badge/EasyMicroservices-Serialization-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.DependencyInjection/)


2. Use package:

   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-BinaryGo-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.BinaryGo/) ![Badge](https://img.shields.io/badge/Binary-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-MemoryPack-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.MemoryPack/) ![Badge](https://img.shields.io/badge/Binary-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-MessagePack-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.MessagePack/) ![Badge](https://img.shields.io/badge/Binary-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-NewtonsoftJson-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.Newtonsoft.Json/) ![Badge](https://img.shields.io/badge/Text-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-SystemTextJson-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.System.Text.Json/) ![Badge](https://img.shields.io/badge/Text-8A2BE2) ![Badge](https://img.shields.io/badge/Binary-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-SystemTextXml-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.System.Text.Xml/) ![Badge](https://img.shields.io/badge/Text-8A2BE2)
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-YamlDotNet-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.YamlDotNet/) ![Badge](https://img.shields.io/badge/Text-8A2BE2)

Startup:

```csharp
public class Startup
{
    //...
    
    public void ConfigureServices(IServiceCollection services)
    {
        //configuration
        services.AddSerialization(o => 
        { 
            o.UseBinaryGo(); 
            o.UseNewtonsoftJson(); 
        }); 
    }    
}
```
Usage:

```csharp

using Common.Models;
using EasyMicroservices.Serialization.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
```
[![Line Coverage Status](./src/CSharp/coverage-badge-line.svg)](https://github.com/danpetitt/open-cover-badge-generator-action/)
