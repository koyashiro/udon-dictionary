namespace Koyashiro.UdonDictionary
{
    using Koyashiro.UdonList;

    public static class UdonDictionaryExt
    {
        public static object GetValue(this UdonDictionary dic, object key)
        {
            var index = dic.IndexOfKey(key);
            if (index == -1)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return dic.GetKeyValuePair(index).GetValue();
        }

        public static void SetValue(this UdonDictionary dic, object key, object value)
        {
            var index = dic.IndexOfKey(key);
            if (index == -1)
            {
                dic.Add(key, value);
            }
            else
            {
                dic.GetKeyValuePair(index).SetValue(value);
            }
        }

        public static int GetCount(this UdonDictionary dic)
        {
            return dic.AsList().GetCount();
        }

        public static object[] Values(this UdonDictionary dic)
        {
            var values = new object[dic.AsList().GetCount()];
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = dic.GetKeyValuePair(i).GetValue();
            }
            return values;
        }

        public static object[] Keys(this UdonDictionary dic)
        {
            var keys = new object[dic.AsList().GetCount()];
            for (var i = 0; i < keys.Length; i++)
            {
                keys[i] = dic.GetKeyValuePair(i).GetKey();
            }
            return keys;
        }

        public static void Add(this UdonDictionary dic, object key, object value)
        {
            var index = dic.IndexOfKey(key);
            if (index == -1)
            {
                dic.AsList().Add(UdonKeyValuePair.New(key, value));
            }
            else
            {
                UdonException.ThrowArgumentException("An item with the same key has already been added.");
            }
        }

        public static void Clear(this UdonDictionary dic)
        {
            dic.AsList().Clear();
        }

        public static bool ContainsKey(this UdonDictionary dic, object key)
        {
            return dic.IndexOfKey(key) != -1;
        }

        public static bool ContainsValue(this UdonDictionary dic, object value)
        {
            return dic.IndexOfKey(value) != -1;
        }

        public static bool Remove(this UdonDictionary dic, object key)
        {
            var index = dic.IndexOfKey(key);
            if (index == -1)
            {
                return false;
            }

            dic.AsList().RemoveAt(index);
            return true;
        }

        public static bool TryGetValue(this UdonDictionary dic, object key, out object value)
        {
            var index = dic.IndexOfKey(key);
            if (index == -1)
            {
                value = default;
                return false;
            }

            value = dic.GetKeyValuePair(index).GetValue();
            return true;
        }

        private static int IndexOfKey(this UdonDictionary dic, object key)
        {
            for (var i = 0; i < dic.GetCount(); i++)
            {
                var kv = (object[])dic.AsList().GetItem(i);
                var k = kv[0];

                if (object.Equals(key, k))
                {
                    return i;
                }
            }

            return -1;
        }

        private static int IndexOfValue(this UdonDictionary dic, object value)
        {
            for (var i = 0; i < dic.GetCount(); i++)
            {
                var kv = (object[])dic.AsList().GetItem(i);
                var v = kv[1];

                if (object.Equals(value, v))
                {
                    return i;
                }
            }

            return -1;
        }

        private static UdonKeyValuePair GetKeyValuePair(this UdonDictionary dic, int index)
        {
            return (UdonKeyValuePair)dic.AsList().GetItem(index);
        }

        private static object GetKey(this UdonDictionary dic, int index)
        {
            return dic.GetKeyValuePair(index).GetKey();
        }

        private static object GetValue(this UdonDictionary dic, int index)
        {
            return dic.GetKeyValuePair(index).GetValue();
        }

        private static UdonList AsList(this UdonDictionary dic)
        {
            return (UdonList)(object)dic;
        }
    }
}
