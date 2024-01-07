namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ex1()
            {
                var namesList = new List<string>();

                while (true)
                {
                    Console.Write("Enter different names: ");
                    var number = Console.ReadLine();
                    if (number != "")
                        namesList.Add(number);
                    else
                        break;

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

            void ex2()
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();
                var array = new char[input.Length];

                for (var i = input.Length; i > 0; i--)
                    array[i - 1] = input[i - 1];

                Array.Reverse(array);
                var newString = new String(array);
                Console.WriteLine(newString);
            }

            void ex3()
            {
               var numbers = new List<int>();

                var count = 0;
                while (count < 5) 
                {
                    
                    Console.Write("Enter a number: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("already there, retry");
                        continue;
                    }

                    numbers.Add(number);
                    count++;
                }

                var array = new int[5];
                for (var i = 0; i < 5; i++)
                {
                    array[i] = numbers[i];
                }

                Array.Sort(array);
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }

            void ex4()
            {
                var numbers = new List<int>();
                
                while (true)
                {
                    Console.Write("enter a number or type Quit to exit");
                    var input = Console.ReadLine();

                    if (input == "Quit")
                        break;

                    var number = Convert.ToInt32(input);
                    numbers.Add(number);
                }

                var set = numbers.Distinct();

                foreach (var item in set)
                    Console.WriteLine(item);

            }

            ex4();
            


        
        }
    }
}
