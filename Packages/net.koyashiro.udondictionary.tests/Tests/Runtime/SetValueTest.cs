using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class SetValueTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var dic = UdonDictionary<string, object>.New();

            dic.Set("first", 1);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", null, null, null }, 1, typeof(string) },
                    new object[] { new object[] { 1, null, null, null }, 1, typeof(object) } },
                dic, this);

            dic.Set("second", 2);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", null, null }, 2, typeof(string) },
                    new object[] { new object[] { 1, 2, null, null }, 2, typeof(object) } },
                dic, this);

            dic.Set("third", 3);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", null }, 3, typeof(string) },
                    new object[] { new object[] { 1, 2, 3, null }, 3, typeof(object) } },
                dic, this);

            dic.Set("fourth", 4);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", "fourth" }, 4, typeof(string) },
                    new object[] { new object[] { 1, 2, 3, 4 }, 4, typeof(object) } },
                dic, this);

            dic.Set("fifth", 5);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", "fourth", "fifth", null, null, null }, 5, typeof(string) },
                    new object[] { new object[] { 1, 2, 3, 4, 5, null, null, null }, 5, typeof(object) } },
                dic, this);

            dic.Set("first", 1f);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", "fourth", "fifth", null, null, null }, 5, typeof(string) },
                    new object[] { new object[] { 1f, 2, 3, 4, 5, null, null, null }, 5, typeof(object) } },
                dic, this);

            dic.Set("second", 2f);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", "fourth", "fifth", null, null, null }, 5, typeof(string) },
                    new object[] { new object[] { 1f, 2f, 3, 4, 5, null, null, null }, 5, typeof(object) } },
                dic, this);

            dic.Set("third", 3f);
            Assert.Equal(new object[2] {
                    new object[] { new string[] { "first", "second", "third", "fourth", "fifth", null, null, null }, 5, typeof(string) },
                    new object[] { new object[] { 1f, 2f, 3f, 4, 5, null, null, null }, 5, typeof(object) } },
                dic, this);
        }
    }
}
