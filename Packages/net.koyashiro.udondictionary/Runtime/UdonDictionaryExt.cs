namespace Koyashiro.UdonDictionary
{
    public static class UdonDictionaryExt
    {
        //public static object[] GetKeyValuePair<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, int index)
        //{
        //    return Core.UdonDictionary.GetKeyValuePair<TKey, TValue>(dic.AsObjectArrays(), index);
        //}

        //public static TKey GetKey<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, int index)
        //{
        //    return Core.UdonDictionary.GetKey<TKey>(dic.AsObjectArrays(), index);
        //}

        public static TValue GetValue<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key)
        {
            return Core.UdonDictionary.GetValue<TKey, TValue>(dic.AsObjectArrays(), key);
        }

        public static void SetValue<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key, TValue value)
        {
            Core.UdonDictionary.SetValue(dic.AsObjectArrays(), key, value);
        }

        public static int Count<TKey, TValue>(this UdonDictionary<TKey, TValue> dic)
        {
            return Core.UdonDictionary.Count(dic.AsObjectArrays());
        }

        public static TKey[] Keys<TKey, TValue>(this UdonDictionary<TKey, TValue> dic)
        {
            return Core.UdonDictionary.Keys<TKey>(dic.AsObjectArrays());
        }

        public static TValue[] Values<TKey, TValue>(this UdonDictionary<TKey, TValue> dic)
        {
            return Core.UdonDictionary.Values<TValue>(dic.AsObjectArrays());
        }

        public static void Add<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key, TValue value)
        {
            Core.UdonDictionary.Add(dic.AsObjectArrays(), key, value);
        }

        public static void Clear<TKey, TValue>(this UdonDictionary<TKey, TValue> dic)
        {
            Core.UdonDictionary.Clear(dic.AsObjectArrays());
        }

        public static bool ContainsKey<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key)
        {
            return Core.UdonDictionary.ContainsKey(dic.AsObjectArrays(), key);
        }

        public static bool ContainsValue<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TValue value)
        {
            return Core.UdonDictionary.ContainsValue(dic.AsObjectArrays(), value);
        }

        public static bool Remove<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key)
        {
            return Core.UdonDictionary.Remove(dic.AsObjectArrays(), key);
        }

        public static bool TryGetValue<TKey, TValue>(this UdonDictionary<TKey, TValue> dic, TKey key, out TValue value)
        {
            return Core.UdonDictionary.TryGetValue(dic.AsObjectArrays(), key, out value);
        }

        private static object[][] AsObjectArrays<TKey, TValue>(this UdonDictionary<TKey, TValue> dic)
        {
            return (object[][])(object)dic;
        }
    }
}
