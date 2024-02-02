namespace FizzBuzz
{
    public class Methods
    {
        #region Constants
            private readonly int start = 1;
            private readonly int end = 100;
            private readonly int zero = 0;
            private readonly int three = 3;
            private readonly int five = 5;
        #endregion

        #region Public methods
        public void Print()
        {
            for (int i = start; i <= end; i++)
            {
                if (i % three == zero && i % five == zero) Console.Write("Fiiz Buzz");
                else if (i % three == zero) Console.Write("Fizz");
                else if (i % five == zero) Console.Write("Buzz");
                else Console.Write(i);
                Console.WriteLine();
            }
        }
        #endregion
    }
}
