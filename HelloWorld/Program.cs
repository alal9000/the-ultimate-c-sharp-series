namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title;

            // LINQ Extention Methods
            var totalPrices = books.Sum(b => b.Price);

            Console.WriteLine(totalPrices);

            //books.Where();
            //books.Single();
            //books.SingleOrDefault();

            //books.First();
            //books.FirstOrDefault();

            //books.Last();
            //books.LastOrDefault();

            //books.Min();
            //books.Max();
            //books.Count();
            //books.Sum();
            //books.Average(b => b.Price);

            //books.Skip(5).Take(3);







            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title);



            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book);

            //Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}
