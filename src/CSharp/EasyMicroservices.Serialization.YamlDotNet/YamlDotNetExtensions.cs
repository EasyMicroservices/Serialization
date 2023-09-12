using System;
using EasyMicroservices.Serialization.Options;
using EasyMicroservices.Serialization.YamlDotNet.Providers;

namespace EasyMicroservices.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    public static class YamlDotNetExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseYamlDotNet(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseTextSerialization(() => new YamlDotNetProvider());
            return options;
        }
    }
}
