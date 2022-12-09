using System;

namespace Koyashiro.UdonDictionary.Core
{
    using Koyashiro.UdonException;
    using Koyashiro.UdonList.Core;

    public static class UdonDictionary
    {
        public static object[] New<TKey, TValue>()
        {
            var keys = UdonList.New<TKey>();
            var values = UdonList.New<TValue>();

            return new object[] { keys, values };
        }

        public static object[] New<TKey, TValue>(int capacity)
        {
            var keys = UdonList.New<TKey>(capacity);
            var values = UdonList.New<TValue>(capacity);

            return new object[] { keys, values };
        }

        //public static object[] GetKeyValuePair<TKey, TValue>(object[] dic, int index)
        //{
        //    var keys = (object[])dic[0];
        //    var values = (object[])dic[1];
        //
        //    var key = UdonList.GetItem<TKey>(keys, index);
        //    var item = UdonList.GetItem<TValue>(values, index);
        //
        //    return new object[] { key, item };
        //}

        //public static TKey GetKey<TKey>(object[] dic, int index)
        //{
        //    var keys = (object[])dic[0];
        //
        //    return UdonList.GetItem<TKey>(keys, index);
        //}

        public static TValue GetValue<TKey, TValue>(object[] dic, TKey key)
        {
            var keys = (object[])dic[0];

            var index = UdonList.IndexOf(keys, key);
            if (index == -1)
            {
                UdonException.ThrowKeyNotFoundException();
            }

            var values = (object[])dic[1];

            return UdonList.GetItem<TValue>(values, index);
        }

        public static void SetValue<TKey, TValue>(object[] dic, TKey key, TValue value)
        {
            var keys = (object[])dic[0];
            var values = (object[])dic[1];

            var index = UdonList.IndexOf(keys, key);
            if (index == -1)
            {
                UdonList.Add(keys, key);
                UdonList.Add(values, value);
            }
            else
            {
                UdonList.SetItem(values, index, value);
            }
        }

        public static int Count(object[] dic)
        {
            var keys = (object[])dic[0];

            return UdonList.Count(keys);
        }

        public static TKey[] Keys<TKey>(object[] dic)
        {
            var keys = (object[])dic[0];

            return UdonList.ToArray<TKey>(keys);
        }

        public static TValue[] Values<TValue>(object[] dic)
        {
            var values = (object[])dic[1];

            return UdonList.ToArray<TValue>(values);
        }

        public static void Add<TKey, TValue>(object[] dic, TKey key, TValue value)
        {
            var keys = (object[])dic[0];
            var values = (object[])dic[1];

            var index = UdonList.IndexOf(keys, key);
            if (index == -1)
            {
                UdonList.Add(keys, key);
                UdonList.Add(values, value);
            }
            else
            {
                UdonException.ThrowArgumentException("An item with the same key has already been added.");
            }
        }

        public static void Clear(object[] dic)
        {
            var keys = (object[])dic[0];
            var values = (object[])dic[1];

            UdonList.Clear(keys);
            UdonList.Clear(values);
        }

        public static bool ContainsKey<TKey>(object[] dic, TKey key)
        {
            var keys = (object[])dic[0];

            return UdonList.IndexOf(keys, key) != -1;
        }

        public static bool ContainsValue<TValue>(object[] dic, TValue value)
        {
            var values = (object[])dic[1];

            return UdonList.IndexOf(values, value) != -1;
        }

        public static bool Remove<TKey>(object[] dic, TKey key)
        {
            var keys = (object[])dic[0];
            var values = (object[])dic[1];

            var index = UdonList.IndexOf(keys, key);
            if (index == -1)
            {
                return false;
            }

            UdonList.RemoveAt(keys, index);
            UdonList.RemoveAt(values, index);

            return true;
        }

        public static bool TryGetValue<TKey, TValue>(object[] dic, TKey key, out TValue value)
        {
            var keys = (object[])dic[0];
            var values = (object[])dic[1];

            var index = UdonList.IndexOf(keys, key);
            if (index == -1)
            {
                value = default;
                return false;
            }

            value = UdonList.GetItem<TValue>(values, index);

            return true;
        }
    }
}
