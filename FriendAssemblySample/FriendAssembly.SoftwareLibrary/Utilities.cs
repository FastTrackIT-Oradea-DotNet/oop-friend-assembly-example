namespace FriendAssembly.SoftwareLibrary
{
    public static class Utilities
    {
        public static int[] ConvertToIntArray(string[] stringArray)
        {
            int[] result = new int[stringArray?.Length ?? 0];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ConvertStringToInt(stringArray?[i]);
            }

            return result;
        }

        internal static int ConvertStringToInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return 0;
        }
    }
}
