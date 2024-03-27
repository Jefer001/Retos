namespace MorceCode
{
    public class Alfabeto_Morce
    {
        #region Attributes
        private static Dictionary<char, string>? morseAD;
        private string txt;
        #endregion

        #region Builder
        public Alfabeto_Morce()
        {
            txt = string.Empty;
        }
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
        #endregion
    }
}
