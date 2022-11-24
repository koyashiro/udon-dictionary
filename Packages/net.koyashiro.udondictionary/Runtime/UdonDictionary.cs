using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonDictionary
{
    [AddComponentMenu("")]
    public class UdonDictionary : UdonSharpBehaviour
    {
        public static UdonDictionary New()
        {
            return (UdonDictionary)(object)Core.UdonDictionary.New();
        }

        public static UdonDictionary New(int capacity)
        {
            return (UdonDictionary)(object)Core.UdonDictionary.New(capacity);
        }
    }
}
