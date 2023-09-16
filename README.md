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

 Example:

```csharp
            builder.Services.AddSerialization(o => 
             { 
                 o.UseBinaryGo(); 
                 o.UseNewtonsoftJson(); 
             });
```

[![Line Coverage Status](./src/CSharp/coverage-badge-line.svg)](https://github.com/danpetitt/open-cover-badge-generator-action/)
