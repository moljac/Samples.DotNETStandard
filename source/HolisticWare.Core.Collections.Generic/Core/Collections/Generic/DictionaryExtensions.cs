using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Collections.Generic.Core.Collections.Generic
{
    public static class DictionaryExtensions
    {
        public static string ToString<K, V>(this Dictionary<K, V> d, string format)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }        

        public static Dictionary<K, V>  Merge<K, V>(this Dictionary<K, V> d, Dictionary<K, V> d_merged)
        {
            Dictionary<K, V> d_result = new Dictionary<K, V>(d); 

            return d_result;
        }        
    }
}
