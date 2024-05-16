using Scm.Common.Domain.Shared.Exceptions;
using System;
using System.Linq;
using System.Reflection;

namespace Scm.Common.Domain.Shared.Attributes
{
    public static class StringToEnumByStringValueAttribute<T>
        where T : struct
    {
        public static T Parse(string str)
        {
            var type = typeof(T);

            var enumMembers = type.GetMembers(BindingFlags.Public | BindingFlags.Static);

            var enumMembersCollection = enumMembers
                .Select(enumMember => new
                {
                    enumMember,
                    attributes = enumMember.GetCustomAttributes(typeof(StringValueAttribute), false),
                })
                .Select(t1 => new
                {
                    t1,
                    value = ((StringValueAttribute)t1.attributes[0]).StringValue,
                })
                .Select(t1 => new Tuple<string, string>(t1.value, t1.t1.enumMember.Name))
                .ToList();
            var currentMember = enumMembersCollection.FirstOrDefault(item => item.Item1 == str);
            if (currentMember == null)
            {
                throw new ConverterException("Can not convert string to Enum");
            }

            T t;
            if (Enum.TryParse(currentMember.Item2, out t))
            {
                return t;
            }

            throw new ConverterException();
        }

        public static bool HasStringValueAttribute()
        {
            var type = typeof(T);
            var attributes = type.GetCustomAttributes(typeof(StringValueAttribute), false);
            return attributes.Length > 0;
        }

        public static bool HasStringValueAttribute(T destination)
        {
            var type = typeof(T);
            var memInfo = type.GetMember(destination.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(StringValueAttribute), false);
            return attributes.Length > 0;
        }
    }
}
