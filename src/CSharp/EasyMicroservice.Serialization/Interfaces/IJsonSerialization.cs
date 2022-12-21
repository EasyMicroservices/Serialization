namespace EasyMicroservice.Serialization.Interfaces
{
    public interface IJsonSerialization: IBaseSerialization
    {
       
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);
    

    }
  
}
