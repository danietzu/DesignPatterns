namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // square
            group1.Add(new Shape()); // square

            var group2 = new Group();
            group2.Add(new Shape()); // circle
            group2.Add(new Shape()); // circle

            var group = new Group();
            group.Add(group1);
            group.Add(group2);

            group.Render();
            group.Move();
        }
    }
}