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
        private long binario;
        #endregion

        #region Builder
        public Methods()
        {
            binario = zero;
        }
        #endregion

        #region Public methods
        public long ConvertToTinary(int num)
        {
            for (int i = num % div, j = zero; num > zero; num /= div, i = num % div, j++)
            {
                long digito = i % div;
                binario += digito * (long)Math.Pow(ten, j);
            }
            return binario;
        }
        #endregion
    }
}
