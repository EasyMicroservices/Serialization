using EasyMicroservices.Serialization.Providers;
using MemoryPack;
using System;

namespace EasyMicroservices.Serialization.MemoryPack.Providers;

/// <summary>
/// use memory pack package for fastest Serialization and deserialization
/// </summary>
/// <remarks>
/// read more about memory pack 
/// <br/>
/// https://neuecc.medium.com/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516
/// </remarks>
public class MemoryPackProvider : BaseBinarySerializationProvider
{
    public override T Deserialize<T>(ReadOnlySpan<byte> reader)
    {
        return MemoryPackSerializer.Deserialize<T>(reader);
    }

    public override ReadOnlySpan<byte> Serialize(object value)
    {
        return MemoryPackSerializer.Serialize(value);
    }
}
