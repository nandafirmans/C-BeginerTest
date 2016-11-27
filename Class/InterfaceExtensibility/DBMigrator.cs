using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.InterfaceExtensibility
{
    public class DBMigrator
    {
        private readonly ILogger _logger; 

        public DBMigrator(ILogger logger) // passing an instance for the interface on constructor, its called depedency injection
        {
            _logger = logger;
        }


        public void Migrate()
        {
            _logger.LogInfo("Migration Start " + DateTime.Now);

            _logger.LogError("Migration Start " + DateTime.Now);
        }
    }
}
