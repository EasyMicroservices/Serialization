using MemoryPack;

namespace EasyMicroservice.MemoryPack;

[MemoryPackable]
public partial class Sample
{
    public string FirstProperty { get; set; } = null!;
    public string SecondProperty { get; set; } = null!;
}

public class UsageMemortPack
{
    internal Sample Sample;

    public UsageMemortPack()
    {
        Sample = new Sample() { FirstProperty = "Test 1" , SecondProperty = "Test 2"};
    }

    public byte[] Serialize() => MemoryPackSerializer.Serialize(Sample);

    public static void Deserialize(byte[] bytes) => MemoryPackSerializer.Deserialize<Sample>(bytes);
}

/* 
 * Read more about " Memory Pack "
 * 
 * https://neuecc.medium.com/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516
 * 
 */