namespace EasyMicroservice.Serialization.Interfaces
{
    public interface IXmlSerialization : IBaseSerialization
    {
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);

    }
  
}
