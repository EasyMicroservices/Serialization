using System;
using EasyMicroservices.Serialization.Options;
using EasyMicroservices.Serialization.System.Text.Xml.Providers;

namespace EasyMicroservices.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    public static class SystemTextXmlExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseSystemTextXml(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseTextSerialization(() => new SystemTextXmlProvider());
            return options;
        }
    }
}
