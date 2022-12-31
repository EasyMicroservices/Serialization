#if (!NET452)
using MessagePack;

namespace EasyMicroservices.Serialization.Tests.Providers.Models
{
    [MessagePackObject]
    public class ClassToSerialize
    {
        [Key(0)]
        public string Name { get; set; }
        [Key(1)]
        public int Age { get; set; }
        [Key(2)]
        public Gender Gender { get; set; }
    }
}
#else
namespace EasyMicroservices.Serialization.Tests.Providers.Models
{
    public class ClassToSerialize
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
#endif
