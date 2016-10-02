namespace ConsoleApplication.Class.Composition
{
    class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public  void Installing()
        {
            _logger.Log("We are Installing..........");
        }
    }
}
