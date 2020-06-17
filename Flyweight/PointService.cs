using System.Collections.Generic;

namespace Flyweight
{
    public class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            var point = new Point(1, 2, _iconFactory.GetPointIcon(PointType.Cafe));

            points.Add(point);

            return points;
        }
    }
}