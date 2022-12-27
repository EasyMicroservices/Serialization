namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// serialize to string and visa versa
    /// </summary>
    public interface ITextSerialization : IBaseSerialization
    {
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Serialize(object value);
        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        T Deserialize<T>(string value);
    }
}
