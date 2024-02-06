using Polygon.Helpers;

namespace Polygon.Polygon
{
    public class Square : IPolygon
    {
        #region Constants
        private const int DOS = 2;
        #endregion

        #region Attributes
        private double _side;
        #endregion

        #region Builder
        public Square(double side)
        {
            _side = side;
        }
        #endregion

        #region Methods public
        public double Area()
        {
            return Math.Pow(_side, DOS);
        }

        public string PrintArea()
        {
            return $"El área del cuadrado es {Area()}";
        }
        #endregion
    }
}
