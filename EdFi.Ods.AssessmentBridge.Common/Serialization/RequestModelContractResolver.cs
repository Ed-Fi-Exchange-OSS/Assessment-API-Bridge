using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EdFi.Ods.AssessmentBridge.Common.Serialization
{
    public class RequestModelContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            //Resolves only strings and value types
            if (property.PropertyType != typeof(string) && !property.PropertyType.IsValueType)
            {
                property.ShouldSerialize = instance => false;
            }

            return property;
        }
    }
}
