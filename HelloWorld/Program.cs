namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else 
            //    date2 = DateTime.Today;

            //Console.WriteLine(date2);

            //DateTime? date3 = date2;

            //Console.WriteLine(date3.GetValueOrDefault());

            //Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);
        }
    }
}
