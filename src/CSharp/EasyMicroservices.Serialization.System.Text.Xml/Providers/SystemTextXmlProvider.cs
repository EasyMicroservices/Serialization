using System.IO;
using System.Xml;
using System.Xml.Serialization;
using EasyMicroservices.Serialization.Providers;

namespace EasyMicroservices.Serialization.System.Text.Xml.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as text serialization provider 
    /// </summary>
    public class SystemTextXmlProvider : BaseTextSerializationProvider
    {
        /// <summary>
        /// Deserialize from string        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(string value)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(new StringReader(value));
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize(object value)
        {
            XmlSerializer xsSubmit = new XmlSerializer(value.GetType());
            using (var sww = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sww))
                {
                    xsSubmit.Serialize(writer, value);
                    return sww.ToString();
                }
            }
        }
    }
}
