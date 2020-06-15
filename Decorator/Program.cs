namespace Decorator
{
    internal class Program
    {
        private static void Main()
        {
            StoreCreditCard(
                new EncryptedCloudStream(
                    new CompressedCloudStream(
                        new CloudStream())));
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}