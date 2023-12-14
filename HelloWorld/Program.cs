namespace HelloWorld
{
    public enum shippingMethod
    {
        REGULARAIRMAIL = 1,
        REGISTEREDAIRMAIL = 2,
        EXPRESS = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var method = shippingMethod.EXPRESS;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((shippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var ship = (shippingMethod)Enum.Parse(typeof(shippingMethod), methodName);
        }
    }
}
