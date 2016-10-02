namespace ConsoleApplication.Class.Composition
{
    class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrating()
        {
            _logger.Log("We are Migrating.......");
        }
    }

}
