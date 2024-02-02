namespace HelloWorld
{


    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator1(new FileLogger("C:\\Projects\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
