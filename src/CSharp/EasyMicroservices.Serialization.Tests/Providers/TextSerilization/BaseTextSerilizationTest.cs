using EasyMicroservices.Serialization.Interfaces;
using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerilization
{
    /// <summary>
    /// base class for test
    /// </summary>
    public abstract class BaseTextSerilizationTest
    {
        /// <summary>
        /// text serilaze provider
        /// </summary>
        public ITextSerialization _provider { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        public BaseTextSerilizationTest(ITextSerialization provider)
        {
            _provider = provider;
        }

        [Theory]
        [InlineData("Mahdi", 30, Gender.Male)]
        [InlineData("Maryam", 15, Gender.Female)]
        public async Task Serilize(string name, int age, Gender gender)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            var result = _provider.Serialize(request);
            Assert.Equal(result, "{\"Name\":\"" + name + "\",\"Age\":" + age + "\",\"Gender\":" + (int)gender + "}");
        }
        /// <summary>
        /// میخواهیم یک متن جیسون را به کلاس تبدیل کنیم
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        [InlineData("Mahdi", 30, Gender.Male)]
        [InlineData("Maryam", 15, Gender.Female)]
        [Theory]
        public async Task Deserilize(string name, int age, Gender gender)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            var json = _provider.Serialize(request);
            var result = _provider.Deserialize<ClassToSerialize>(json);

            Assert.True(result.Name == request.Name && result.Age == request.Age && result.Gender == request.Gender);
        }

    }

    public class ClassToSerialize
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender
    {
        None = 0,
        Male = 1,
        Female = 2
    }
}
