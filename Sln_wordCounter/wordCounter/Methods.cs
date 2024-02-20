namespace wordCounter
{
    public class Methods
    {
        #region Attributes
        private readonly string _str;
        private string[] words;
        private readonly Dictionary<string, int> keyValuePairs;
        #endregion

        #region Builder
        public Methods(string str)
        {
            _str = str;
            words = Array.Empty<string>();
            keyValuePairs = new Dictionary<string, int>();
            DeleteCharacters();
            WordCounter();
        }
        #endregion

        #region Public methods
        public void Print()
        {
            var sorted = keyValuePairs.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            foreach (var word in sorted)
            {
                if (word.Value > 1) Console.WriteLine($"{word.Key} se repite {word.Value} veces.");
                else Console.WriteLine($"{word.Key} se repite {word.Value} vez.");
            }
        }
        #endregion

        #region Private methods
        private void DeleteCharacters()
        {
            string cleanStr = _str.ToLower().Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("?", "").Replace("¿", "");
            words = cleanStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        private void WordCounter()
        {
            foreach (string word in words)
            {
                if (keyValuePairs.TryGetValue(word, out int value)) keyValuePairs[word] = value + 1;
                else keyValuePairs.Add(word, 1);
            }
        }
        #endregion
    }
}