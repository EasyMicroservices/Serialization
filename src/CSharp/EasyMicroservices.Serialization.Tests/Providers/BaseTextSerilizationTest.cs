using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Tests.Providers
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
    }
}
