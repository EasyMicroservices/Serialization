using EasyMicroservice.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservice.Serialization.Tests.Providers
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
