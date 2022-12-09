using UnityEngine;
using UdonSharp;
using YamlDotNet.Core.Tokens;

namespace Koyashiro.UdonDictionary
{
    [AddComponentMenu("")]
    public class UdonDictionary<TKey, TValue> : UdonSharpBehaviour
    {
        public static UdonDictionary<TKey, TValue> New()
        {
            return (UdonDictionary<TKey, TValue>)(object)Core.UdonDictionary.New<TKey, TValue>();
        }

        public static UdonDictionary<TKey, TValue> New(int capacity)
        {
            return (UdonDictionary<TKey, TValue>)(object)Core.UdonDictionary.New<TKey, TValue>(capacity);
        }
    }
}
