using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCRUD
{
    static class Dictionary
    {
        public static Dictionary<Object, Object> CreateDict()
        {
            return new Dictionary<object, object>();
        }

        public static void ReadDict(Dictionary<Object, Object> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }

        public static void UpdateDict(Dictionary<Object, Object> dict, object key, object value)
        {
            dict[key] = value;
        }


        public static void DeleteDict(Dictionary<Object, Object> dict, object key)
        {
            dict.Remove(key);
        }
    }
}
