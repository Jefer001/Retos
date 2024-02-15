namespace Reverse
{
    public class Methods
    {
        public static string Reverse(string str)
        {
            Char[] chars = str.ToCharArray();
            string res = string.Empty;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                res += chars[i];
            }
            return res;
        }
    }
}
