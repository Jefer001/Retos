namespace Fibonacci
{
    public class Methods
    {
        #region Constants
        private const int one = 1;
        #endregion

        #region Public methods
        public static void Fibonacci(int f, int s, int c, int n)
        {
            Console.WriteLine(f + "");
            if (c < n) Fibonacci (s, f+s, c+one, n);
        }
        #endregion
    }
}
