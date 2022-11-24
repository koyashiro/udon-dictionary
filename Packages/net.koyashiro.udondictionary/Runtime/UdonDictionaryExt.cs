namespace Koyashiro.UdonDictionary
{
    using Koyashiro.UdonDictionary.Core;

    public static class UdonDictionaryExt
    {
        public static object[] GetKeyValuePair(this UdonDictionary dic, int index)
        {
            return Core.UdonDictionary.GetKeyValuePair<object, object>((object[])(object)dic, index);
        }

        public static object GetKey(this UdonDictionary dic, int index)
        {
            return Core.UdonDictionary.GetKey<object>((object[])(object)dic, index);
        }

        public static object GetValue(this UdonDictionary dic, object key)
        {
            return Core.UdonDictionary.GetValue<object, object>((object[])(object)dic, key);
        }

        public static void SetValue(this UdonDictionary dic, object key, object value)
        {
            Core.UdonDictionary.SetValue((object[])(object)dic, key, value);
        }

        public static int Count(this UdonDictionary dic)
        {
            return Core.UdonDictionary.Count((object[])(object)dic);
        }

        public static object[] Values(this UdonDictionary dic)
        {
            return Core.UdonDictionary.Values<object>((object[])(object)dic);
        }

        public static object[] Keys(this UdonDictionary dic)
        {
            return Core.UdonDictionary.Keys<object>((object[])(object)dic);
        }

        public static void Add(this UdonDictionary dic, object key, object value)
        {
            Core.UdonDictionary.Add((object[])(object)dic, key, value);
        }

        public static void Clear(this UdonDictionary dic)
        {
            Core.UdonDictionary.Clear((object[])(object)dic);
        }

        public static bool ContainsKey(this UdonDictionary dic, object key)
        {
            return Core.UdonDictionary.ContainsKey((object[])(object)dic, key);
        }

        public static bool ContainsValue(this UdonDictionary dic, object value)
        {
            return Core.UdonDictionary.ContainsValue((object[])(object)dic, value);
        }

        public static bool Remove(this UdonDictionary dic, object key)
        {
            return Core.UdonDictionary.Remove((object[])(object)dic, key);
        }

        public static bool TryGetValue(this UdonDictionary dic, object key, out object value)
        {
            return Core.UdonDictionary.TryGetValue((object[])(object)dic, key, out value);
        }
    }
}
