using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    public class SetValueTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = UdonDictionary.New();

            dic.SetValue("first", 1);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1 }, null, null, null }, 1 }, dic);

            dic.SetValue("second", 2);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, null, null }, 2 }, dic);

            dic.SetValue("third", 3);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, new object[] { "third", 3 }, null }, 3 }, dic);

            dic.SetValue("fourth", 4);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, new object[] { "third", 3 }, new object[] { "fourth", 4 } }, 4 }, dic);

            dic.SetValue("fifth", 5);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1 }, new object[] { "second", 2 }, new object[] { "third", 3 }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 }, dic);

            dic.SetValue("first", 1f);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1f }, new object[] { "second", 2 }, new object[] { "third", 3 }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 }, dic);

            dic.SetValue("second", 2f);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1f }, new object[] { "second", 2f }, new object[] { "third", 3 }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 }, dic);

            dic.SetValue("third", 3f);
            Assert.Equal(new object[] { new object[] { new object[] { "first", 1f }, new object[] { "second", 2f }, new object[] { "third", 3f }, new object[] { "fourth", 4 }, new object[] { "fifth", 5 }, null, null, null }, 5 }, dic);
        }
    }
}
