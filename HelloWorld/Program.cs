namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be converted into a byte");
            }



            
        }
    }
}
