namespace HelloWorld
{
    public class DbMigrator1
    {
        private readonly ILogger _logger;

        public DbMigrator1(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // details of migrating the db

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}
