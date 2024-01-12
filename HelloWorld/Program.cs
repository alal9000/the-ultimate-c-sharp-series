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


                // mosh solution
                //var names = new List<string>();

                //while (true)
                //{
                //    Console.Write("Type a name (or hit ENTER to quit): ");

                //    var input = Console.ReadLine();
                //    if (String.IsNullOrWhiteSpace(input))
                //        break;
                //    names.Add(input);
                //}

                //if (names.Count > 2)
                //    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                //else if (names.Count == 2)
                //    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                //else if (names.Count == 1)
                //    Console.WriteLine("{0} likes your post.", names[0]);
                //else
                //    Console.WriteLine();
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

                //mosh solution
                //Console.Write("What's your name? ");
                //var name = Console.ReadLine();

                //var array = new char[name.Length];
                //for (var i = name.Length; i > 0; i--)
                //    array[name.Length - i] = name[i - 1];

                //var reversed = new string(array);
                //Console.WriteLine("Reversed name: " + reversed);
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

                // mosh solution
                //var numbers = new List<int>();

                //while (numbers.Count < 5)
                //{
                //    Console.Write("Enter a number: ");
                //    var number = Convert.ToInt32(Console.ReadLine());
                //    if (numbers.Contains(number))
                //    {
                //        Console.WriteLine("You've previously entered " + number);
                //        continue;
                //    }

                //    numbers.Add(number);
                //}

                //numbers.Sort();

                //foreach (var number in numbers)
                //    Console.WriteLine(number);
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

                // mosh solution
                //var numbers = new List<int>();

                //while (true)
                //{
                //    Console.Write("Enter a number (or 'Quit' to exit): ");
                //    var input = Console.ReadLine();

                //    if (input.ToLower() == "quit")
                //        break;

                //    numbers.Add(Convert.ToInt32(input));
                //}

                //var uniques = new List<int>();
                //foreach (var number in numbers)
                //{
                //    if (!uniques.Contains(number))
                //        uniques.Add(number);
                //}

                //Console.WriteLine("Unique numbers:");
                //foreach (var number in uniques)
                //    Console.WriteLine(number);

            }

            void ex5()
            {


                while (true)
                {
                    var numbers = new List<int>();

                    Console.WriteLine("supply list of comma seperated numbers");
                    var input = Console.ReadLine();
                    var inputArray = input.Split(",");

                    foreach (var item in inputArray)
                    {
                        numbers.Add(Convert.ToInt32(item));
                    }

                    if (numbers.Count < 5)
                        Console.WriteLine("Invalid List, retry");
                    continue;


                }


                // mosh solution

                //string[] elements;
                //while (true)
                //{
                //    Console.Write("Enter a list of comma-separated numbers: ");
                //    var input = Console.ReadLine();

                //    if (!String.IsNullOrWhiteSpace(input))
                //    {
                //        elements = input.Split(',');
                //        if (elements.Length >= 5)
                //            break;
                //    }

                //    Console.WriteLine("Invalid List");
                //}

                //var numbers = new List<int>();
                //foreach (var number in elements)
                //    numbers.Add(Convert.ToInt32(number));

                //var smallests = new List<int>();
                //while (smallests.Count < 3)
                //{
                //    // Assume the first number is the smallest
                //    var min = numbers[0];
                //    foreach (var number in numbers)
                //    {
                //        if (number < min)
                //            min = number;
                //    }
                //    smallests.Add(min);

                //    numbers.Remove(min);
                //}

                //Console.WriteLine("The 3 smallest numbers are: ");
                //foreach (var number in smallests)
                //    Console.WriteLine(number);

            }
            ex5();




        }
    }
}
