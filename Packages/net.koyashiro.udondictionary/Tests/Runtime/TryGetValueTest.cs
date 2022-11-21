using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class TryGetValueTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = (UdonDictionary)(object)(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, new object[] { "third", 3 }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 });
            object value;

            Assert.True(dic.TryGetValue("first", out value));
            Assert.Equal(1, value);

            Assert.True(dic.TryGetValue("second", out value));
            Assert.Equal(2, value);

            Assert.True(dic.TryGetValue("third", out value));
            Assert.Equal(3, value);

            Assert.True(dic.TryGetValue("fourth", out value));
            Assert.Equal(4, value);

            Assert.True(dic.TryGetValue("fifth", out value));
            Assert.Equal(5, value);
        }
    }
}
