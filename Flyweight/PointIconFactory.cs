using System.Collections.Generic;

namespace Flyweight
{
    public class PointIconFactory
    {
        private readonly Dictionary<PointType, PointIcon> _icons =
            new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if (_icons.ContainsKey(type) == false)
            {
                var icon = new PointIcon(type, new byte[10]);
                _icons.Add(type, icon);
            }

            return _icons[type];
        }
    }
}