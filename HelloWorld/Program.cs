using System.Text;

namespace HelloWorld
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            ex5();
        }

        // mosh solution i didnt try
        public static void ex1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        // my solution I was able to use the above solution without looking at the answer
        public static void ex2()
        {
            //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();

            //if (input == "")
            //    return;

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //numbers.Sort();

            //var isDuplicate = false;
            //for (var i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == numbers[i - 1])
            //    {
            //        isDuplicate = true;
            //        break;
            //    }
            //}

            //var message = isDuplicate ? "duplicate" : "Not duplicate";
            //Console.WriteLine(message);

            // mosh solution
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        // mosh solution I didnt try
        public static void ex3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        // mosh solution I didnt try
        public static void ex4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);

        }

        // my implementation
        public static void ex5()
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var vowels = 0;
            foreach (var ch in input)
            {
                if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
                    vowels++;
            }

            Console.WriteLine(vowels);

            // mosh solution
            //Console.Write("Enter a word: ");
            //// Note the ToLower() here. This is used to count for both A and a. 
            //var input = Console.ReadLine().ToLower();

            //var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            //var vowelsCount = 0;
            //foreach (var character in input)
            //{
            //    if (vowels.Contains(character))
            //        vowelsCount++;
            //}

            //Console.WriteLine(vowelsCount);


        }

    }
}
