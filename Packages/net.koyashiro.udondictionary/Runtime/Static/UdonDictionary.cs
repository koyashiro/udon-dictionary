
namespace Koyashiro.UdonDictionary.Static
{
    using Koyashiro.UdonException;
    using Koyashiro.UdonList.Core;

    public static class UdonDictionary
    {
        public static object[] New()
        {
            return UdonList.New();
        }

        public static object[] New(int capacity)
        {
            return UdonList.New(2 * capacity);
        }

        public static object[] GetKeyValuePair<TKey, TValue>(object[] dic, int index)
        {
            var key = UdonList.GetItem<TKey>(dic, 2 * index);
            var item = UdonList.GetItem<TValue>(dic, 2 * index + 1);

            return new object[] { key, item };
        }

        public static TKey GetKey<TKey>(object[] dic, int index)
        {
            return UdonList.GetItem<TKey>(dic, 2 * index);
        }

        public static TValue GetValue<TKey, TValue>(object[] dic, TKey key)
        {
            var index = IndexOfKey(dic, key);
            if (index == -1)
            {
                UdonException.ThrowKeyNotFoundException();
            }

            return UdonList.GetItem<TValue>(dic, index + 1);
        }

        public static void SetValue<TKey, TValue>(object[] dic, TKey key, TValue value)
        {
            var index = IndexOfKey(dic, key);
            if (index == -1)
            {
                UdonList.Add(dic, key);
                UdonList.Add(dic, value);
            }
            else
            {
                UdonList.SetItem<TValue>(dic, index + 1, value);
            }
        }

        public static int Count(object[] dic)
        {
            return UdonList.Count(dic) / 2;
        }

        public static TValue[] Values<TValue>(object[] dic)
        {
            var count = UdonList.Count(dic) / 2;
            var values = new TValue[count];
            for (var i = 0; i < count; i++)
            {
                values[i] = UdonList.GetItem<TValue>(dic, 2 * i + 1);
            }
            return values;
        }

        public static TKey[] Keys<TKey>(object[] dic)
        {
            var count = UdonList.Count(dic) / 2;
            var keys = new TKey[count];
            for (var i = 0; i < count; i++)
            {
                keys[i] = UdonList.GetItem<TKey>(dic, 2 * i);
            }
            return keys;
        }

        public static void Add<TKey, TValue>(object[] dic, TKey key, TValue value)
        {
            var index = IndexOfKey(dic, key);
            if (index == -1)
            {
                UdonList.Add(dic, key);
                UdonList.Add(dic, value);
            }
            else
            {
                UdonException.ThrowArgumentException("An item with the same key has already been added.");
            }
        }

        public static void Clear(object[] dic)
        {
            UdonList.Clear(dic);
        }

        public static bool ContainsKey<TKey>(object[] dic, TKey key)
        {
            return IndexOfKey(dic, key) != -1;
        }

        public static bool ContainsValue<TValue>(object[] dic, TValue value)
        {
            return IndexOfValue(dic, value) != -1;
        }

        public static bool Remove<TKey>(object[] dic, TKey key)
        {
            var index = IndexOfKey(dic, key);
            if (index == -1)
            {
                return false;
            }

            UdonList.RemoveAt(dic, index);
            UdonList.RemoveAt(dic, index + 1);

            return true;
        }

        public static bool TryGetValue<TKey, TValue>(object[] dic, TKey key, out TValue value)
        {
            var index = IndexOfKey(dic, key);
            if (index == -1)
            {
                value = default;
                return false;
            }

            value = UdonList.GetItem<TValue>(dic, index);
            return true;
        }

        private static int IndexOfKey<TKey>(object[] dic, TKey key)
        {
            var count = UdonList.Count(dic) / 2;
            for (var i = 0; i < count; i++)
            {
                var k = UdonList.GetItem<TKey>(dic, 2 * i);

                if (object.Equals(key, k))
                {
                    return 2 * i;
                }
            }


            return -1;
        }

        private static int IndexOfValue<TValue>(object[] dic, TValue value)
        {
            var count = UdonList.Count(dic) / 2;
            for (var i = 0; i < count; i++)
            {
                var v = UdonList.GetItem<TValue>(dic, 2 * i + 1);

                if (object.Equals(value, v))
                {
                    return 2 * i + 1;
                }
            }

            return -1;
        }
    }
}
