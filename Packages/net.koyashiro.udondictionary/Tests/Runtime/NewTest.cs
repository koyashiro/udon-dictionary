using UdonSharp;
using Koyashiro.UdonList.Tests;

namespace Koyashiro.UdonDictionary.Tests
{
    public class NewTest : UdonSharpBehaviour
    {
        public void Start()
        {
            Assert.Equal(new object[] { new object[0], 0 }, UdonDictionary.New());
            Assert.Equal(new object[] { new object[1], 0 }, UdonDictionary.New(1));
            Assert.Equal(new object[] { new object[2], 0 }, UdonDictionary.New(2));
            Assert.Equal(new object[] { new object[3], 0 }, UdonDictionary.New(3));
            Assert.Equal(new object[] { new object[4], 0 }, UdonDictionary.New(4));
        }
    }
}
