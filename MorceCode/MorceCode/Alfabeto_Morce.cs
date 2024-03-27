using System.Text;

namespace MorceCode
{
    public class Alfabeto_Morce
    {
        #region Attributes
        private static Dictionary<char, string>? morseAD;
        #endregion

        #region Private methods
        private static void MorseAlphabetDictionary()
        {
            morseAD = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'.', ".—.—.—"},
                {',', "——..——"},
                {'?', "..——.."},
                {'\"' , ".—..—."},
                {'/', "—..—."}
            };
            
        }

        private static string VerifyText(string str)
        {
            if (!string.IsNullOrEmpty(str)) str = str.ToLower();
            return str;
        }

        private string Encode(string str)
        {
            StringBuilder sb = new();
            foreach (char c in str)
            {
                if (morseAD.ContainsKey(c)) sb.Append(morseAD[c] + " ");
                else if (c == ' ') sb.Append("/ ");
                else sb.Append(c + " ");
            }
            return sb.ToString();
        }
        #endregion
    }
}
