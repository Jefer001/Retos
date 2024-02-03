
namespace NumPrimos
{
    public class Methods
    {
        #region Constants
        private const int zero = 0;
        private const int start = 1;
        private const int two = 2;
        private const int end = 100;
        #endregion

        #region Public methods
        public static void Print()
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) {
                    Console.Write(i);
                    Console.WriteLine();
                    }
                }
        }
        #endregion

        #region Private methods
        private static bool IsPrime(int i)
        {
            if (i < two) return false;
            for (int j = two; j < i; j++)
            {
                if (i % j == zero) return false;
            }
            return true;
        }
        #endregion
    }
}
