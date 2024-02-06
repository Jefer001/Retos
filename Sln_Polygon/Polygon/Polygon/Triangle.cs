using Polygon.Helpers;

namespace Polygon.Polygon
{
    public class Triangle : IPolygon
    {
        #region Constants
        private const int DOS = 2;
        #endregion

        #region Attributes
        private double _height, _base;
        #endregion

        #region Builder
        public Triangle(double b, double height)
        {
            _base = b;
            _height = height;
        }
        #endregion

        #region Methods public
        public double Area()
        {
            return (_base * _height) / DOS;
        }

        public string PrintArea()
        {
            return $"El área del triángulo es {Area()}";
        }
        #endregion
    }
}
