namespace wordCounter
{
    public class Methods
    {
        #region Attributes
        private string[] words;
        private readonly Dictionary<string, int> keyValuePairs;
        #endregion

        #region Builder
        public Methods()
        {
            words = Array.Empty<string>();
            keyValuePairs = new Dictionary<string, int>();
        }
        #endregion

        #region Public methods
        public void ReceiveMsg(string str)
        {
            string cleanStr = str.ToLower().Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("?", "").Replace("¿", "");
            words = cleanStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        public void Print()
        {
            WordCounter();
            var sorted = keyValuePairs.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            foreach (var word in sorted)
            {
                Console.WriteLine($"{word.Key} tiene {word.Value}");
            }
        }
        #endregion

        #region Private methods
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