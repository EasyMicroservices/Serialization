#if(!NET45)
using System;
using EasyMicroservices.Serialization.Providers;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EasyMicroservices.Serialization.YamlDotNet.Providers
{
    /// <summary>
    ///  use YamlDotNet as text serialization provider 
    /// </summary>
    public class YamlDotNetProvider : BaseTextSerializationProvider
    {
        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(string value)
        {
            var deserializer = new DeserializerBuilder()
            //.WithNamingConvention(PascalCaseNamingConvention.Instance)
            .Build();

            return deserializer.Deserialize<T>(value);
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize(object value)
        {
            var serializer = new SerializerBuilder()
                //.WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return serializer.Serialize(value);
        }
    }
}
#endif
