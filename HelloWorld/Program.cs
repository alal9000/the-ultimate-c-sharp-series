namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex2();
        }

        public static void ex1()
        {
            var path = @"c:\users\aaron\words.txt";
            var content = File.ReadAllText(path);

            var charCount = 0;
            foreach (var ch in content)
            {
                if (ch == ' ')
                    charCount++;

            }
            Console.WriteLine(charCount + 1);
        }

        public static void ex2()
        {
            var path = @"c:\users\aaron\words.txt";
            var content = File.ReadAllText(path);

            var wordArray = content.Split(" ");

            
            var longest = "";
            foreach (var word in wordArray)
            {
                if (word.Length > longest.Length)
                    longest = word;

            }
            Console.WriteLine(longest);
        }

    }
}
