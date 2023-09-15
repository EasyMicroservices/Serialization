# Serialization
Wrapper for any Serialize package

Install packages:

```
Core package:

EasyMicroservices.Serialization.DependencyInjection

Use package:
    1. EasyMicroservices.Serialization.BinaryGo

    2. EasyMicroservices.Serialization.Newtonsoft.Json
```

 Example:

```csharp
            builder.Services.AddSerialization(o => 
             { 
                 o.UseBinaryGo(); 
                 o.UseNewtonsoftJson(); 
             });
```

[![Line Coverage Status](./src/CSharp/coverage-badge-line.svg)](https://github.com/danpetitt/open-cover-badge-generator-action/)
