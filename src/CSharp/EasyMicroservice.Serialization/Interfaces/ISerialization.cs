namespace EasyMicroservice.Serialization.Interfaces
{
    public interface ISerialization : IBaseSerialization
    {
        string TextSerializeObject(object value);
        T TextDeserializeObject<T>(string value);

        ReadOnlySpan<byte> ByteSerializeObject(object value);
        T ByteDeserializeObject<T>(ReadOnlySpan<byte> value);

    }  
}
