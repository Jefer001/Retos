namespace Anagrama
{
    public class Methods
    {
        #region Public methods
        public static bool IsAnagrama(string w, string w2)
        {
            if (w.Length != w2.Length) return false;
            else 
                for (int i = 0; i < w.Length; i++)
                {
                    if (w2.Contains(w[1])) return true;
                }
            return false;
        }
        #endregion
    }
}
