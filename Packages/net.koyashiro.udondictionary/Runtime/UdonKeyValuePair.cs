using UdonSharp;

namespace Koyashiro.UdonDictionary
{
    public class UdonKeyValuePair : UdonSharpBehaviour
    {
        public static UdonKeyValuePair New(object key, object value)
        {
            return (UdonKeyValuePair)(object)(new object[] { key, value });
        }
    }
}
