using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


class Utils
{
    public static void AddRangeDictionary<K,V>(Dictionary<K,V> dictionary, List<KeyValuePair<K,V>> elements)
    {
        foreach(var keyValue in elements)
        {
            dictionary.Add(keyValue.Key, keyValue.Value);
        }
    }


    public static void AddRange<K,V>(this Dictionary<K,V> dictionary, List<KeyValuePair<K,V>> elements)
    {
        foreach(var keyValue in elements)
        {
            dictionary.Add(keyValue.Key, keyValue.Value);
        }

    }
}