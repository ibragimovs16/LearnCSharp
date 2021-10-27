using System;
using System.Linq;

namespace LearnCSharp.AttributesAndReflection
{
    public class AttributesAndReflectionEntryPoint
    {
        public AttributesAndReflectionEntryPoint()
        {
            var photo = new Photo("test")
            {
                Path = @"home/ibragimovs16"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properies = type.GetProperties();
            foreach (var property in properies)
            {
                var attrs = property.GetCustomAttributes(false);
                
                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(property.PropertyType + " " + property.Name);
                }
            }
        }
    }
}