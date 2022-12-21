namespace EasyMicroservice.Serialization.Interfaces
{
    public interface IBinerySerialization: IBaseSerialization
    {      
        ReadOnlySpan<byte> SerializeToBytes(object value);
        T Deserialize<T>(ReadOnlySpan<byte> reader);

    }
  
}
