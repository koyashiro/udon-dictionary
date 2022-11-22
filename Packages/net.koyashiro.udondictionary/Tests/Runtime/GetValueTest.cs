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
            var dic = (UdonDictionary)(object)(new object[] { new object[] { "first", 1, "second", 2, "third", 3, "fourth", 4, "fifth", 5 }, 10 });

            Assert.Equal(1, dic.GetValue("first"));
            Assert.Equal(2, dic.GetValue("second"));
            Assert.Equal(3, dic.GetValue("third"));
            Assert.Equal(4, dic.GetValue("fourth"));
            Assert.Equal(5, dic.GetValue("fifth"));
        }
    }
}
