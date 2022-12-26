using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Tests.Providers
{
    public abstract class BaseTextSerilizationTest
    {
        public ITextSerialization _provider { get; }
        public BaseTextSerilizationTest(ITextSerialization provider)
        {
            _provider = provider;
        }
    }
}
