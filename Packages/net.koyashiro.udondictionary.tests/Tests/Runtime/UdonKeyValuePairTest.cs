using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class UdonKeyValuePairTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var pair = (UdonKeyValuePair<string, int>)(object)new object[] { "key", 123 };

            Assert.Equal("key", pair.GetKey(), this);
            Assert.Equal(123, pair.GetValue(), this);
        }
    }
}
