namespace wordCounter
{
    public class Methods
    {
        public static void WordCounter(string str)
        {
            string cleanStr = str.ToLower().Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("?", "").Replace("¿", "");
            string[] words = cleanStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyValuePairs = new();

            foreach (string word in words)
            {
                if (keyValuePairs.TryGetValue(word, out int value)) keyValuePairs[word] = value + 1;
                else keyValuePairs.Add(word, 1);
            }

            var sorted = keyValuePairs.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            foreach (var word in sorted)
            {
                Console.WriteLine($"{word.Key} tiene {word.Value}");
            }
        }
    }
}