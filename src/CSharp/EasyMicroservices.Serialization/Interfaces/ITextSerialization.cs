namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITextSerialization : IBaseSerialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Serialize(object value);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        T Deserialize<T>(string value);
    }
}
