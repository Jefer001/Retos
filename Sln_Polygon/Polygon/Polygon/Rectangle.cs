using Polygon.Helpers;

namespace Polygon.Polygon
{
    public class Rectangle : IPolygon
    {
        #region Attributes
        private double _length, _width;
        #endregion

        #region Builder
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        #endregion

        #region Methods public
        public double Area()
        {
            return _length * _width;
        }

        public string PrintArea()
        {
            return $"El área del rectángulo es {Area()}";
        }
        #endregion
    }
}
