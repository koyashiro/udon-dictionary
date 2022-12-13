using UdonSharp;
using UnityEngine;
using Koyashiro.UdonDictionary;

public class UdonDictionarySample : UdonSharpBehaviour
{
    public void Start()
    {
        var dic = UdonDictionary<string, int>.New(); // {}

        dic.Set("first", 1); // { first: 1 }
        dic.Set("second", 2); // { first: 1, second: 2 }
        dic.Set("third", 3); // { first: 1, second: 2, third: 3 }

        Debug.Log(dic.Get("first")); // 1
        Debug.Log(dic.Get("second")); // 2
        Debug.Log(dic.Get("third")); // 3
    }
}
