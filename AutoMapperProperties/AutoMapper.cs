using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperProperties
{
    //Mapping 2 class have the same propperties
    public static class AutoMapper<Destiny, Source> where Destiny : class
                                             where Source : class
    {
        public static Destiny Map(Destiny destiny, Source source)
        {
            var sourceProperties = source.GetType().GetProperties().OrderBy(x=>x.Name).ToArray();
            var destinyProperties = destiny.GetType().GetProperties().OrderBy(x => x.Name).ToArray();

            foreach (var sourceProperty in sourceProperties)
            {
                foreach (var destinyProperty in destinyProperties)
                {
                    if (sourceProperty.Name == destinyProperty.Name && sourceProperty.PropertyType == destinyProperty.PropertyType)
                    {
                        destinyProperty.SetValue(destiny, sourceProperty.GetValue(source));
                        break;
                    }
                }
            }
            return destiny;
        }
    }
}
