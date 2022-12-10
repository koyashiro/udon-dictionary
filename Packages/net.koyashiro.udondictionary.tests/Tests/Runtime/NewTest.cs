using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonDictionary.Tests
{
    [AddComponentMenu("")]
    public class NewTest : UdonSharpBehaviour
    {
        public void Start()
        {
            Assert.Equal(new object[2] {
                    new object[]{ new object[0], 0, typeof(object) },
                    new object[]{ new int[0], 0, typeof(int) } },
                UdonDictionary<object, int>.New(), this);

            Assert.Equal(new object[2] {
                    new object[]{ new object[1], 0, typeof(object) },
                    new object[]{ new int[1], 0, typeof(int) } },
                UdonDictionary<object, int>.New(1), this);

            Assert.Equal(new object[2] {
                    new object[]{ new object[2], 0, typeof(object) },
                    new object[]{ new int[2], 0, typeof(int) } },
                UdonDictionary<object, int>.New(2), this);

            Assert.Equal(new object[2] {
                    new object[]{ new object[3], 0, typeof(object) },
                    new object[]{ new int[3], 0, typeof(int) } },
                UdonDictionary<object, int>.New(3), this);

            Assert.Equal(new object[2] {
                    new object[]{ new object[4], 0, typeof(object) },
                    new object[]{ new int[4], 0, typeof(int) } },
                UdonDictionary<object, int>.New(4), this);

            Assert.Equal(new object[2] {
                    new object[]{ new object[5], 0, typeof(object) },
                    new object[]{ new int[5], 0, typeof(int) } },
                UdonDictionary<object, int>.New(5), this);
        }
    }
}
