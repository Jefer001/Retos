namespace ConvertToBinary
{
    public class Methods
    {
        #region Constants
        private readonly int zero = 0;
        private readonly int div = 2;
        private readonly int ten = 10;
        #endregion

        #region Attributes
        private long binary;
        #endregion

        #region Builder
        public Methods()
        {
            binary = zero;
        }
        #endregion

        #region Public methods
        public long ConvertToBinary(int num)
        {
            for (int i = num % div, j = zero; num > zero; num /= div, i = num % div, j++)
            {
                long digito = i % div;
                binary += digito * (long)Math.Pow(ten, j);
            }
            return binary;
        }
        #endregion
    }
}
