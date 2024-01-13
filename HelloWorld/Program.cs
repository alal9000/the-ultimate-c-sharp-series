namespace HelloWorld
{
    internal class Program
    {
        public class Person
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public DateTime Birthdate;
        }

        public static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Mosh",
                LastName = "Hamedani"
            };
        }
    }
}
