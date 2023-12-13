[![Line Coverage Status](./src/CSharp/coverage-badge-line.svg)](https://github.com/danpetitt/open-cover-badge-generator-action/)

Introduction
-------------

In the increasingly digitized realm of software development, the need for efficient serialization mechanisms is paramount for applications that transmit data across different systems or persist data to storage mediums. Serialization is the process of converting an object into a format that can be stored or transmitted and reconstructed later. The interfaces "ITextSerializationProvider" and "IBinarySerializationProvider" serve critical roles in this context by defining contracts for serialization and deserialization of objects into textual and binary formats, respectively.

These interfaces are essential because different use cases and environments require diverse serialization formats. Textual serialization, often used for human-readable formats like JSON, XML, and YAML, is necessary for configurations, web communications, and more, where readability and standardization are beneficial. Binary serialization, conversely, is optimized for performance-critical contexts, where compactness and speed are essential, such as in high-performance computing, real-time systems, and large-scale data processing.

Summary
--------

The "ITextSerializationProvider" and "IBinarySerializationProvider" interfaces extend "IBaseSerializationProvider" with two primary methods: Serialize and Deserialize. For ITextSerializationProvider, Serialize converts an object to a string, whereas Deserialize reconstructs the object from the string format. This pattern is primarily used for formats like JSON, XML, and YAML.

On the other hand, the "IBinarySerializationProvider" leverages the efficiency of byte arrays for its operations, making it more suitable for performance-intensive use-cases. Serialize converts the object into a ReadOnlySpan<byte>, facilitating a low-allocation environment, while Deserialize builds the object back from the byte array.

Several packages have been implemented for these interfaces, catering to different serialization needs:

- BinaryGo, MemoryPack, and MessagePack offer binary serialization.
- Newtonsoft.Json, System.Text.Json, and System.Text.Xml provide textual serialization specifically for JSON and XML.
- YamlDotNet is dedicated to YAML serialization.

By utilizing the Serialization.DependencyInjection package and integrating it into an ASP.NET Core application's startup configuration, users can seamlessly plug in their preferred serialization method, ensuring that their applications can easily interchange data representations as needed.

Details
-------

### Textual Serialization 

- **ITextSerializationProvider Interface**: This interface encapsulates the functionality for handling text-serialization tasks. It ensures that any class implementing this interface provides mechanisms to serialize objects into string representations and vice versa, aiming to support various text-based formats.

### Binary Serialization

- **IBinarySerializationProvider Interface**: Contrast to textual serialization, this interface is strictly for handling serialization in binary formats, designed to work directly with byte arrays for high performance and efficiency.

### Implementation Packages

Each of the following packages implements the interfaces to support a specific format:

- **BinaryGo**, **MemoryPack**, **MessagePack**: These packages provide binary serialization techniques useful in scenarios where the serialized object's footprint needs to be as small as possible.
  
- **Newtonsoft.Json**, **System.Text.Json**: These libraries are geared towards JSON serialization, with System.Text.Json being the newer, high-performance package directly supported by Microsoft.
  
- **System.Text.Xml**: Reserved for XML serialization, it offers integration with .NET's System.Text mechanisms, aiming to align with modern runtime optimizations.

- **YamlDotNet**: Specializes in the YAML format, frequently used for configuration files due to its human-friendly syntax.

### ASP.NET Core Integration

- The `Startup` class demonstrates how an ASP.NET Core application can incorporate these serialization providers. By invoking `AddSerialization` within the `ConfigureServices` method and specifying the desired packages like `o.UseBinaryGo()` or `o.UseNewtonsoftJson()`, developers can quickly hook up the required serialization methods to their application's dependency injection container.

This document elaborates on each interface's purpose and the comprehensive use of the serialization packages, offering developers insight and guidance on effectively managing data persistence and transmission in their applications. Through these interfaces and their relevant packages, developers can cater to various serialization requirements, ensuring that their software is up to the task in a multitude of scenarios ranging from simple web APIs to complex, distributed systems.


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

3. ِDependency injection package:
   
   [![NuGet](https://img.shields.io/badge/EasyMicroservicesSerialization-DependencyInjection-orange.svg)](https://www.nuget.org/packages/EasyMicroservices.Serialization.DependencyInjection/)
   
Example:

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
            //etc
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
        //for json or any text
        var result = _textSerialization.Serialize(model);
        // or for binary:
        var binary = _binarySerialization.Serialize(model);
        return Ok(result);
    }
}
```
