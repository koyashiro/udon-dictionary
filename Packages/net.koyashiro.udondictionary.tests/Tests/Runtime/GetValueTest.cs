using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class GetValueTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = (UdonDictionary<string, int>)(object)(new object[2][] {
                new object[] { new string[] { "first", "second", "third", "fourth", "fifth" }, 5, typeof(string) },
                new object[] { new int[] { 1, 2, 3, 4, 5 }, 5, typeof(int) } });

            Assert.Equal(1, dic.Get("first"), this);
            Assert.Equal(2, dic.Get("second"), this);
            Assert.Equal(3, dic.Get("third"), this);
            Assert.Equal(4, dic.Get("fourth"), this);
            Assert.Equal(5, dic.Get("fifth"), this);
        }
    }
}
