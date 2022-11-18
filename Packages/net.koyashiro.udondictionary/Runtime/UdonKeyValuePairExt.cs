namespace Koyashiro.UdonDictionary
{
    public static class UdonKeyValuePairExt
    {
        public static object GetKey(this UdonKeyValuePair pair)
        {
            return ((object[])(object)pair)[0];
        }

        public static void SetKey(this UdonKeyValuePair pair, object value)
        {
            ((object[])(object)pair)[0] = value;
        }

        public static object GetValue(this UdonKeyValuePair pair)
        {
            return ((object[])(object)pair)[1];
        }

        public static void SetValue(this UdonKeyValuePair pair, object value)
        {
            ((object[])(object)pair)[1] = value;
        }
    }
}
