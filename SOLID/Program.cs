using SOLID.OCP;
using System;

namespace SOLID
{
    public class Program
    {
        public static void Main()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var kiwi = new Product("Kiwi", Color.Green, Size.Small);
            var blueberry = new Product("Blueberry", Color.Blue, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Huge);

            Product[] products = { apple, kiwi, blueberry, tree, house };

            var filter = new ProductFilter();

            Console.WriteLine("Green products: ");
            foreach (var product in filter.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine(" - " + product.Name);

            Console.WriteLine("Small products: ");
            foreach (var product in filter.Filter(products, new SizeSpecification(Size.Small)))
                Console.WriteLine(" - " + product.Name);

            Console.WriteLine("Small green products: ");
            foreach (var product in filter.Filter(products, new AndSpecification<Product>(
                                                                new SizeSpecification(Size.Small),
                                                                new ColorSpecification(Color.Green))))
                Console.WriteLine(" - " + product.Name);
        }
    }
}