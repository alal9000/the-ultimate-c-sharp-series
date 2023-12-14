namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
