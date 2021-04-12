using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Helpers
{
    public class EnumValueGenerator
    {

        public static Enum GenerateRace<T>() where T : Enum
        {
            Random rnd = new Random();
            var enums = Enum.GetValues(typeof(T));
            return (T)enums.GetValue(rnd.Next(enums.Length));
        }
    }
}
