using System;
using System.Collections.Generic;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    /// general serialization method defines here
    /// </summary>
    public abstract class BaseProvider : IBaseSerializationProvider
    {
        /// <summary>
        /// can convert check which type is supported for serialization
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public virtual bool CanConvert(Type objectType)
        {
            return true;
        }

        static Dictionary<Type, Type> ReplacedWithARuntimeType { get; set; } = new Dictionary<Type, Type>();

        /// <summary>
        /// get replaced Type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected Type GetReplacedType(Type type)
        {
            if (ReplacedWithARuntimeType.TryGetValue(type, out Type replacedType))
                return replacedType ?? type;
            if (CanReplaceType(type))
            {
                replacedType = ReplaceType(type);
                ReplacedWithARuntimeType.Add(type, replacedType);
                return replacedType;
            }
            ReplacedWithARuntimeType.Add(type, null);
            return type;
        }

        /// <summary>
        /// Check if type needs replace
        /// </summary>
        /// <returns></returns>
        protected virtual bool CanReplaceType(Type type)
        {
            return false;
        }

        /// <summary>
        /// replace a type to a proxy type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected virtual Type ReplaceType(Type type)
        {
            return type;
        }
    }
}
