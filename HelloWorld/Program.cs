namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namesList = new List<string>();
            

            var input = " ";
            while (input != "")
            {
                Console.Write("Enter different names: ");
                input = Console.ReadLine();
                if (input != "")
                    namesList.Add(input);

            }
            if (namesList.Count == 0)
                Console.WriteLine("");
            else if (namesList.Count == 1) 
                Console.WriteLine(namesList[0] + " " + "likes your post");
            else if (namesList.Count == 2)
                Console.WriteLine(namesList[0] + " and " + namesList[1] + " likes your post");
            else
                Console.WriteLine(namesList[0] + " and " + namesList[1] + " and " + (namesList.Count - 2) + " others likes your post");

        }
    }
}
