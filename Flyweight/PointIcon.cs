namespace Flyweight
{
    public class PointIcon
    {
        private readonly PointType _type;
        private readonly byte[] _icon;

        public PointIcon(PointType type, byte[] icon)
        {
            _type = type;
            _icon = icon;
        }

        public PointType Type => _type;
    }
}