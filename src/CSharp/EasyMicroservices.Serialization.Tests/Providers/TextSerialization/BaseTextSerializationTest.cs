using System.Threading.Tasks;
using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    /// <summary>
    /// base class for test
    /// </summary>
    public abstract class BaseTextSerializationTest
    {
        /// <summary>
        /// text serilaze provider
        /// </summary>
        public ITextSerialization _provider { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        public BaseTextSerializationTest(ITextSerialization provider)
        {
            _provider = provider;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        public virtual async Task Serialize(string name, int age, Gender gender, string expected)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            var result = _provider.Serialize(request);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public virtual async Task Deserialize(string json, string name, int age, Gender gender)
        {
            var result = _provider.Deserialize<ClassToSerialize>(json);

            Assert.True(result.Name == name && result.Age == age && result.Gender == gender);
        }

    }
}
