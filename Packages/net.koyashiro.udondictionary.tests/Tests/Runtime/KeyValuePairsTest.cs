using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class KeyValuePairsTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = (UdonDictionary<string, int>)(object)(new object[2][] {
                new object[] { new string[] { "first", "second", "third", "fourth", "fifth" }, 5, typeof(string) },
                new object[] { new int[] { 1, 2, 3, 4, 5 }, 5, typeof(int) } });
            var pairs = dic.KeyValuePairs();

            Assert.Equal(5, pairs.Length, this);
            Assert.Equal("first", pairs[0].GetKey(), this);
            Assert.Equal(1, pairs[0].GetValue(), this);
            Assert.Equal("second", pairs[1].GetKey(), this);
            Assert.Equal(2, pairs[1].GetValue(), this);
            Assert.Equal("third", pairs[2].GetKey(), this);
            Assert.Equal(3, pairs[2].GetValue(), this);
            Assert.Equal("fourth", pairs[3].GetKey(), this);
            Assert.Equal(4, pairs[3].GetValue(), this);
            Assert.Equal("fifth", pairs[4].GetKey(), this);
            Assert.Equal(5, pairs[4].GetValue(), this);
        }
    }
}
