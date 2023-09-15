# Serialization
Wrapper for any Serialize package
 Example:

```csharp
            builder.Services.AddSerialization(o => 
             { 
                 o.UseBinaryGo(); 
                 o.UseNewtonsoftJson(); 
             });
```

[![Line Coverage Status](./src/CSharp/coverage-badge-line.svg)](https://github.com/danpetitt/open-cover-badge-generator-action/)
