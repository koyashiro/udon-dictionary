using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    public class GetValueTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = (UdonDictionary)(object)(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, new object[] { "third", 3 }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 });

            Assert.Equal(1, dic.GetValue("first"));
            Assert.Equal(2, dic.GetValue("second"));
            Assert.Equal(3, dic.GetValue("third"));
            Assert.Equal(4, dic.GetValue("fourth"));
            Assert.Equal(5, dic.GetValue("fifth"));
        }
    }
}
