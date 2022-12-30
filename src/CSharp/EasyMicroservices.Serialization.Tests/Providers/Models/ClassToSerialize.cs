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
