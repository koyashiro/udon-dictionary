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
            var dic = (UdonDictionary<string, int>)(object)(new object[2][] {
                new object[] { new string[] { "first", "second", "third", "fourth", "fifth" }, 5, typeof(string) },
                new object[] { new int[] { 1, 2, 3, 4, 5 }, 5, typeof(int) } });

            int value;

            Assert.True(dic.TryGetValue("first", out value), this);
            Assert.Equal(1, value, this);

            Assert.True(dic.TryGetValue("second", out value), this);
            Assert.Equal(2, value, this);

            Assert.True(dic.TryGetValue("third", out value), this);
            Assert.Equal(3, value, this);

            Assert.True(dic.TryGetValue("fourth", out value), this);
            Assert.Equal(4, value, this);

            Assert.True(dic.TryGetValue("fifth", out value), this);
            Assert.Equal(5, value, this);

            Assert.False(dic.TryGetValue("sixth", out value), this);
        }
    }
}
