using System.Text;

namespace MorceCode
{
    public class Alfabeto_Morce
    {
        #region Attributes
        private readonly Dictionary<char, string>? morseAD;
        #endregion

        #region Builder
        public Alfabeto_Morce()
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
                {'.', ".-.-.-"},
                {',', "--..--"},
                {'?', "..--.."},
                {'\'', ".----."},
                {'!', "-.-.--"},
                {'/', "-..-."},
                {'(', "-.--."},
                {')', "-.--.-"},
                {'&', ".-..."},
                {':', "---..."},
                {';', "-.-.-."},
                {'=', "-...-"},
                {'+', ".-.-."},
                {'-', "-....-"},
                {'_', "..--.-"},
                {'\"', ".-..-."},
                {'$', "...-..-"},
                {'@', ".--.-."},
                {' ', "/"}
            };
        }
        #endregion

        #region Public methods
        public static string VerifyText(string str)
        {
            if (!string.IsNullOrEmpty(str)) str = str.ToLower();
            return str;
        }

        public string Encode(string str)
        {
            string encodeText = string.Empty;

            foreach (char c in str)
            {
                if (morseAD.ContainsKey(c)) encodeText += morseAD[c] + " ";
                else encodeText += c + " ";
            }
            return encodeText.Trim();
        }

        public string Decode(string str)
        {
            string[] words = str.Split('/');
            string decodeText = string.Empty;

            foreach(string word in words)
            {
                string[] letters = word.Split(' ');

                foreach(string letter in letters)
                {
                    foreach (KeyValuePair<char, string> valuePair in morseAD)
                    {
                        if (letter.Equals(valuePair.Value))
                        {
                            decodeText += valuePair.Key;
                            break;
                        }
                    }
                }
                decodeText += " ";
            }
            return decodeText.Trim();
        }
        #endregion
    }
}
