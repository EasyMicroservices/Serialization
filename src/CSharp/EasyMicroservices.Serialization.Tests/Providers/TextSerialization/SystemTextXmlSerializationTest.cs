﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EasyMicroservices.Serialization.System.Text.Xml.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class SystemTextXmlSerializationTest : BaseTextSerializationTest
    {
        public SystemTextXmlSerializationTest() : base(new SystemTextXmlProvider())
        {
        }

#if(NETCOREAPP2_1_OR_GREATER)
        [InlineData("Mahdi", 30, Gender.Male, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>Mahdi</Name><Age>30</Age><Gender>Male</Gender></ClassToSerialize>")]
        [InlineData("Maryam", 15, Gender.Female, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>Maryam</Name><Age>15</Age><Gender>Female</Gender></ClassToSerialize>")]
        [InlineData("ali", 15, Gender.None, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>ali</Name><Age>15</Age><Gender>None</Gender></ClassToSerialize>")]
#else
        [InlineData("Mahdi", 30, Gender.Male, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><Name>Mahdi</Name><Age>30</Age><Gender>Male</Gender></ClassToSerialize>")]
        [InlineData("Maryam", 15, Gender.Female, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><Name>Maryam</Name><Age>15</Age><Gender>Female</Gender></ClassToSerialize>")]
        [InlineData("ali", 15, Gender.None, "<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><Name>ali</Name><Age>15</Age><Gender>None</Gender></ClassToSerialize>")]
#endif
        [Theory]
        public override Task Serialize(string name, int age, Gender gender, string expected)
        {
            return base.Serialize(name, age, gender, expected);
        }

        [InlineData("<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize><Name>Mahdi</Name><Age>30</Age><Gender>Male</Gender></ClassToSerialize>", "Mahdi", 30, Gender.Male)]
        [InlineData("<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>Maryam</Name><Age>15</Age><Gender>Female</Gender></ClassToSerialize>", "Maryam", 15, Gender.Female)]
        [InlineData("<?xml version=\"1.0\" encoding=\"utf-16\"?><ClassToSerialize xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>ali</Name><Age>15</Age><Gender>None</Gender></ClassToSerialize>", "ali", 15, Gender.None)]
        [Theory]
        public override Task Deserialize(string xml, string name, int age, Gender gender)
        {
            return base.Deserialize(xml, name, age, gender);
        }
    }
}
