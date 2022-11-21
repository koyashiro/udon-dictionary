using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonDictionary
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonDictionary : UdonSharpBehaviour
    {
        public static UdonDictionary New()
        {
            return New(0);
        }

        public static UdonDictionary New(int capacity)
        {
            return (UdonDictionary)(object)UdonList.New(capacity);
        }
    }
}
