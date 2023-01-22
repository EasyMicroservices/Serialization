// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace EasyMicroservices.Serialization.Tests.Providers.Models
{
#if (NET7_0)
    [global::MemoryPack.MemoryPackable]
#endif
    public partial class ClassToSerialize
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
